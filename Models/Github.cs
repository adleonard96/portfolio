using System.Text.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Github{
    class GithubStatRetriever
    {
        public static async Task<List<GithubStats>> GetStats()
        {
            const string USERNAME = "adleonard96";
            List<GithubStats> stats = [];
            var json = await GithubStatRetriever._GetDataFromGh(USERNAME);
            stats.AddRange(JsonSerializer.Deserialize<List<GithubStats>>(json));
            return stats;
        }

        private static async Task<string> _GetDataFromGh(string username)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(
                HttpMethod.Get,
                string.Format("https://api.github.com/users/{0}/events/public", username)
            );
            request.Headers.Add("User-Agent", "Request");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }

    class GithubStats 
    {
        public string id {get; set;}
        public string type {get; set;}
        public Actor actor {get; set;}
        public Repo  repo {get; set;}
        public Payload payload {get; set;}
        [JsonPropertyName("public")]
        public bool publicRepo {get; set;}
        public DateTime created_at {get; set;}
    }

    class Actor
    {
        public int id {get; set;}
        
        public string login {get; set;}

        public string display_login {get; set;}

        public string gravatar_id {get; set;}

        public string url {get; set;}

        public string avatar_url {get; set;}
    }

    class Repo 
    {
        public int id {get; set;}

        public string name {get; set;}

        public string url { get; set;}
    }

    class Payload
    {
        public int repository_id {get; set;}
        public long push_id {get; set;}
        public int size {get; set;}
        public int distinct_size {get; set;}

        [JsonPropertyName("ref")]
        public string payloadRef {get; set;}
        public string head {get; set;}
        public string before {get; set;}

        public List<Commit> commits {get; set;}
        public string ref_type {get; set;}
        public string master_branch {get; set;}
        public string description { get; set; }
        public string pusher_type { get; set; }
        public string action { get; set; }
    }

    class Commit
    {
        public string sha {get; set;}
        public Author author{get; set;}
        public string message {get; set;}
        public bool distinct {get; set;}
        public string url {get; set;}
    }

    class Author
    {
        public string email {get; set;}
        public string name {get; set;}
    }
}    
    