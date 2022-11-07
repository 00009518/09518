using cw1_9518_view.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace cw1_9518_view.Services
{
    public class RoomService
    {
        private string host;
        public RoomService(string apiUrl)
        {
            host = apiUrl;
        }

        public async Task<int> Update(Room rom, int id)
        {
            try
            {
                var client = new HttpClient();

                var json = JsonConvert.SerializeObject(rom);

                var data = new StringContent(json, Encoding.UTF8, "application/json");

                await client.PutAsync(host + "/api/Rooms/" + id, data);
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public async Task<int> Create(Room rom)
        {
            try
            {

                var client = new HttpClient();

                var json = JsonConvert.SerializeObject(rom);

                var data = new StringContent(json, Encoding.UTF8, "application/json");
                await client.PostAsync(host + "/api/Rooms", data);
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public async Task<List<Room>> FindAll()
        {

            var client = new HttpClient();
            var response = await client.GetAsync(host + "/api/Rooms");


            var content = await response.Content.ReadAsStringAsync();
            var rooms = JsonConvert.DeserializeObject<List<Room>>(content);

            return rooms;
        }

        public async Task<Room> FindOne(int id)
        {
            Room room = new Room();

            var client = new HttpClient();
            var response = await client.GetAsync(host + "/api/Rooms/" + id);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                room = JsonConvert.DeserializeObject<Room>(content);
            }
            return room;
        }

        public async Task<int> Delete(int id)
        {
            try
            {
                var client = new HttpClient();
                await client.DeleteAsync(host + "/api/Rooms/" + id);
                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
