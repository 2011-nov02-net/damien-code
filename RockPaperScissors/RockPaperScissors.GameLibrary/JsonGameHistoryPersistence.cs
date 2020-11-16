using RockPaperScissors.Library;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace RockPaperScissors.GameLibrary
{
    public class JsonGameHistoryPersistence
    {
        private string _filepath;

        public JsonGameHistoryPersistence(string filepath)
        {
            _filepath = filepath;
        }

        public List<GameHistory> Read()
        {
            List<GameHistory> gameHistories = null;
            try
            {
                string json = File.ReadAllText(_filepath);
                gameHistories = JsonSerializer.Deserialize<List<GameHistory>>(json);
            }
            catch { }
            finally { }

            return gameHistories ?? new List<GameHistory>();
        }

        public void Write(List<GameHistory> gameHistories)
        {
            /* ways to work with JSON in .NET
             * - DataContractSerializer (built-in, semi-old)
             * - System.Text.Json (built-in, new, fast)
             * - Newtonsoft.Json (aka JSON.NET, very popular 3rd party)
             */

            /* ways to work with XML in .NET
             *  - DataContractSerializer (supports JSON)
             *  - XmlSerializer (quite old, doesn't support generics)
             */

            string json = JsonSerializer.Serialize(gameHistories);
            // File.WriteAllText(_filepath, json);

            using var fileWriter = new StreamWriter(_filepath);
            fileWriter.Write(json);

            // StreamWriter writer = null;
            // 
            // try
            // {
            //     writer = new StreamWriter(_filepath);
            //     writer.Write(json);
            // }
            // // throw; just throws the exception again
            // // catch(Exception)
            // // {
            // //     throw;
            // // }
            // finally
            // {
            //     writer?.Close();
            // }
        }
    }         
}
