using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine.Networking;
using System;
using System.IO;

namespace JsonBridge{

  public class JsonSerDes
  {
    private string url;

    public JsonSerDes(string url){
      this.url = url;
    }

    public string serialization(DataSerialized data, string map){

      string json = JsonConvert.SerializeObject(data, Formatting.Indented);
      File.WriteAllText(map,json);
      Debug.Log("Serialization done");

      string resp = new JsonRequestHandler(url)
      .Feed(JsonConvert.SerializeObject(data))
      .Fetch()
      .get();

      return resp;
    }

    public ResponseModel webDeserialization(string resp){

      ResponseModel answers = JsonConvert.DeserializeObject<ResponseModel>(resp);

      Debug.Log("Deserialization done");

      return answers;

    }

    public DataSerialized deserialization(string jsonFilePath){

      string mapJson = System.IO.File.ReadAllText(jsonFilePath);
      return JsonConvert.DeserializeObject<DataSerialized>(mapJson);
    }

  }
}