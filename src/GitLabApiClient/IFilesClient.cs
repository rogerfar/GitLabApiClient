using System.Threading.Tasks;
using GitLabApiClient.Internal.Paths;
using GitLabApiClient.Models.Files.Responses;

namespace GitLabApiClient
{
    public interface IFilesClient
    {
        Task<File> GetAsync(ProjectId projectId, string filePath, string reference = "master");
        Task<string> GetRawAsync(ProjectId projectId, string filePath, string reference = "master");
        Task<byte[]> GetArchiveAsync(ProjectId projectId, string extension = "tar.gz", string sha = null);
    }
}
