using System;
using System.IO;
using System.Threading;
using Google.Apis.Services;
using Google.Apis.Drive.v3;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Collections.Generic;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Upload;

namespace ConsoleApp1
{
    class Program
    {
        private const string PathToServiceAccountKeyFile = @"C:\Users\Administrator\Downloads\tenacious-cocoa-418704-870e90b50468.json";
        private const string ServiceAccountEmail = "project-service-name@tenacious-cocoa-418704.iam.gserviceaccount.com";
        private const string UploadFileName = @"dd.csv";
        private const string DirectoryId = "1D1fDJHGPUI1DGZcOzPfwJpk6PaynPBJG";

        static void Main(string[] args)
        {
            // 드라이브 계정에 대한 쓰기 액세스 권한
            var credential = GoogleCredential.FromFile(PathToServiceAccountKeyFile)
                            .CreateScoped(DriveService.Scope.Drive);

            // Google 드라이브 API에 대한 모든 호출은 드라이브 서비스 개체를 통해 실행
            var service = new DriveService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                //ApplicationName = "Drive API Snippets"
            });

            // 파일 메타데이터 업로드 
            var fileMetadata = new Google.Apis.Drive.v3.Data.File()
            {
                Name = "upload.csv", //업로드 파일명(드라이브 상에서 보여지는 이름)
                Parents = new List<String>() { "1D1fDJHGPUI1DGZcOzPfwJpk6PaynPBJG" }
            };



            string uploadedFileId;
            // Create a new file on Google Drive
            await using (var fsSource = new FileStream(UploadFileName, FileMode.Open, FileAccess.Read))
            {
                // Create a new file, with metadata and stream.
                var request = service.Files.Create(fileMetadata, fsSource, "text/plain");
                request.Fields = "*";
                var results = await request.UploadAsync(CancellationToken.None);

                if (results.Status == UploadStatus.Failed)
                {
                    Console.WriteLine($"Error uploading file: {results.Exception.Message}");
                }

                // the file id of the new file we created
                uploadedFileId = request.ResponseBody?.Id;
            }
        }
    }
}