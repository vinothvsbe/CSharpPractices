using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Text.Json;

namespace BOMGenerator
{
    class BOMData
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Value { get; set; }
    }
    public class BOMStructure
    {
        public string PartNumber { get; set; }
        public string PartDescription { get; set; }
        public int Level { get; set; }

        public List<BOMStructure> ChildPart {get;set;}
        public BOMStructure(){
            ChildPart = new List<BOMStructure>();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int totalBOMCount = 2; // Number of total record
            List<BOMData> bomDataList = new List<BOMData>();
            List<BOMStructure> bomStructureList = new List<BOMStructure>();
            // var client = new MongoClient($@"mongodb://localhost:27017");
            // var database = client.GetDatabase("SampleDb");
            // var collection = database.GetCollection<Sample>("SampleDb");

            // collection.InsertOne(new Sample
            // {
            //     Value = "SampleValue1"
            // });
            int levelCounter=1;
            BOMStructure bomStructure=new BOMStructure();
            bomStructure.PartNumber="0000-000000";
            bomStructure.PartDescription="0000-000000 Part Description";
            bomStructure.Level = levelCounter;
            
            if(totalBOMCount>0){
                levelCounter=2;
                for(int i=0;i<totalBOMCount;i++){
                    bomStructure.ChildPart.Add(BOMCreator(i, i-1, ref levelCounter));
                    levelCounter=2;
                }
            }
            
            Console.WriteLine(JsonSerializer.Serialize(bomStructure));
            Console.WriteLine("Done");
        }

        public static BOMStructure BOMCreator(int firstSegmentCounter, int secondSegmentCounter,ref int levelCounter){
            int secondSegmentCounterR = secondSegmentCounter+1;

            BOMStructure bomStructure = new BOMStructure();
            bomStructure.PartNumber = "000"+firstSegmentCounter.ToString()+"-"+secondSegmentCounterR.ToString().PadLeft(8,'0');
            bomStructure.PartDescription = bomStructure.PartNumber+ " Part Description";
            bomStructure.Level = levelCounter;
            bool isChildAvailable = new Random().Next(1,4)%2==0;
            levelCounter++;
            int currentLevelCounter = levelCounter;
            if(isChildAvailable && levelCounter<17){
                
                int noOfChild = new Random().Next(1,5);
                for(int i=0;i<noOfChild;i++){
                    bomStructure.ChildPart.Add(BOMCreator(i, int.Parse((secondSegmentCounter+1).ToString()+i.ToString()), ref levelCounter));
                    levelCounter = currentLevelCounter;
                }
                
            }
            return bomStructure;
        }
    }
}
