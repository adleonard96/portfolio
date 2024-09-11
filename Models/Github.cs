using System.Collections;

namespace Github{
    class GithubStats 
    {
        public string id {get; set;}
        public string type {get; set;}
        public Actor actor {get; set;}
        public Repo  repo {get; set;}
        public Payload payload {get; set;}
        public bool publicRepo {get; set;}
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
        public int push_id {get; set;}
        public int size {get; set;}
        public int distinct_size {get; set;}
        public string ref_ {get; set;}
        public string head {get; set;}
        public string before {get; set;}

        public ArrayList commits {get; set;}
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
    