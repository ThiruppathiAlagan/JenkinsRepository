﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATTPOCAPIService.Mock
{
    public class AtollData
    {
        public List<SearchRing> getSearchRings()
        {
            var list = new List<SearchRing>();

            list.Add(new SearchRing() { projectId = 0, projectIdSpecified = false, paceJobNumber = "MRVWV000390", projectNumber = "NER-RVWV-11-00994", 
                searchRingId=null, searchRingName=null, usid = new int[1],faLocationCode =new FaLocationCode(){ faLocationCode="10068630", faType="CELL" }});              
            
            list.Add(new SearchRing() { projectId = 0, projectIdSpecified = false, paceJobNumber = "MRVWV000391", projectNumber = "NER-RVWV-11-00994", 
                searchRingId=null, searchRingName=null, usid = new int[1],faLocationCode =new FaLocationCode(){ faLocationCode="10068630", faType="CELL" }});              
       
            
            list.Add(new SearchRing() { projectId = 0, projectIdSpecified = false, paceJobNumber = "MRVWV000392", projectNumber = "NER-RVWV-11-00994", 
                searchRingId=null, searchRingName=null, usid=new int[1],faLocationCode =new FaLocationCode(){ faLocationCode="10068630", faType="CELL" }});              
       
            return list;
        }
        public SearchRing getSearchRings(string projectNumber)
        {
            var list = new List<SearchRing>();

            list.Add(new SearchRing()
            {
                projectId = 0,
                projectIdSpecified = false,
                paceJobNumber = "MRVWV000390",
                projectNumber = "NER-RVWV-11-00994",
                searchRingId = null,
                searchRingName = null,
                usid = new int[1],
                faLocationCode = new FaLocationCode() { faLocationCode = "10068630", faType = "CELL" }
            });

            list.Add(new SearchRing()
            {
                projectId = 0,
                projectIdSpecified = false,
                paceJobNumber = "MRVWV000390",
                projectNumber = "NER-RVWV-11-00995",
                searchRingId = null,
                searchRingName = null,
                usid = new int[1],
                faLocationCode = new FaLocationCode() { faLocationCode = "10068630", faType = "CELL" }
            });


            list.Add(new SearchRing()
            {
                projectId = 0,
                projectIdSpecified = false,
                paceJobNumber = "MRVWV000390",
                projectNumber = "NER-RVWV-11-00996",
                searchRingId = null,
                searchRingName = null,
                usid = new int[1],
                faLocationCode = new FaLocationCode() { faLocationCode = "10068630", faType = "CELL" }
            });

           return list.FirstOrDefault(x => x.projectNumber == projectNumber);
           
        }
        public atollInfoType getAtollInfo(string atollName)
        {
            var atoll = new List<atollInfoType>();
            atoll.Add(new atollInfoType()
            {
                iplanJobNumber = "",
                schema = "MWR_IND_GSM",
                groundElevation = "",
                city = "TBD",
                county = "",
                e911Phase = null,
                frequencyBand = null,
                latitude = "38.340819",
                longitude = "-85.655539",
                market = "TBD",
                maxAGL = "999",
                commonID = "1",
                siteID = null,
                technology = null,
                latDms = "38 20\u0027 26.9484\u0027\u0027 ",
                longDms = "-85 39\u0027 19.9404\u0027\u0027 ",
                nad = "NAD83"
            });

            atoll.Add(new atollInfoType()
            {
                iplanJobNumber = "",
                schema = "MWR_IND_GSM",
                groundElevation = "",
                city = "TBD",
                county = "",
                e911Phase = null,
                frequencyBand = null,
                latitude = "38.340819",
                longitude = "-85.655539",
                market = "TBD",
                maxAGL = "999",
                commonID = "2",
                siteID = null,
                technology = null,
                latDms = "38 20\u0027 26.9484\u0027\u0027 ",
                longDms = "-85 39\u0027 19.9404\u0027\u0027 ",
                nad = "NAD83"
            });

            return atoll.FirstOrDefault(x => x.commonID == atollName); ;
        }    
    }

    public class SearchRing
    {
        public int projectId { get; set; }
        public bool projectIdSpecified { get; set; }
        public string paceJobNumber { get; set; }
        public string projectNumber { get; set; }
        public string searchRingId { get; set; }
        public string searchRingName { get; set; }
        public int[] usid { get; set; }
        public FaLocationCode faLocationCode;
    }
    public partial class FaLocationCode
    {
        public string faLocationCode { get; set; }
        public string faType { get; set; }
    }
    public partial class atollInfoType
    {
        public string groundElevation { get; set; }
        public string city { get; set; }
        public string county { get; set; }
        public string e911Phase { get; set; }
        public string frequencyBand { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string market { get; set; }
        public string maxAGL { get; set; }
        public string commonID { get; set; }
        public string siteID { get; set; }
        public string technology { get; set; }
        public string latDms { get; set; }
        public string longDms { get; set; }
        public string nad { get; set; }
        public string iplanJobNumber { get; set; }
        public string schema { get; set; }
    }  
}