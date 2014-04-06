using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using wunderNET.Models;

namespace wunderNET
{
    public class wunderNETClient
    {
        private const string ApiBaseUrl = "https://api.wunderlist.com/";
        private RestClient restClient;
        private UserLogin userLogin;

        public wunderNETClient()
        {
            restClient = new RestClient(ApiBaseUrl);
        }

        public wunderNETClient(string userName, string password)
        {
            restClient = new RestClient(ApiBaseUrl);
            GetAccessToken(userName, password);
        }

        public AccountInfo GetAccessToken(string userName, string password){

            var request = new RestRequest("login", Method.POST);
            request.AddParameter("email", userName);
            request.AddParameter("password", password);

            var response = restClient.Execute<AccountInfo>(request);

            userLogin = new UserLogin();

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                userLogin.Token = response.Data.Token;
            }

            return response.Data;
        }

        public List<TaskInfo> GetTasks()
        {
            var request = new RestRequest("me/tasks", Method.GET);
            request.AddHeader("Authorization", "Bearer " + userLogin.Token);

            var response = restClient.Execute<List<TaskInfo>>(request);

            return response.Data;
        }

        public List<ListInfo> GetLists()
        {
            var request = new RestRequest("me/lists", Method.GET);
            request.AddHeader("Authorization", "Bearer " + userLogin.Token);

            var response = restClient.Execute<List<ListInfo>>(request);

            return response.Data;
        }

        public TaskInfo ModifyTask(TaskInfo task)
        {
            var request = new RestRequest("me/{taskid}", Method.POST);
            request.AddHeader("Authorization", "Bearer " + userLogin.Token);
            request.AddUrlSegment("taskid", task.ID);
            request.AddParameter("note", task.Note);
            request.AddParameter("due_date", task.DueDate);
            request.AddParameter("recurrence_count", 0);

            var response = restClient.Execute<TaskInfo>(request);

            return response.Data;
        }

        public TaskInfo DeleteTask(TaskInfo task)
        {
            var request = new RestRequest("me/{taskid}", Method.POST);
            request.AddHeader("Authorization", "Bearer " + userLogin.Token);
            request.AddUrlSegment("taskid", task.ID);

            restClient.Execute(request);

            return task;
        }

        public ListInfo DeleteList(ListInfo list)
        {
            var request = new RestRequest("me/{listid}", Method.POST);
            request.AddHeader("Authorization", "Bearer " + userLogin.Token);
            request.AddUrlSegment("listid", list.ID);

            restClient.Execute(request);

            return list;
        }

    }
}
