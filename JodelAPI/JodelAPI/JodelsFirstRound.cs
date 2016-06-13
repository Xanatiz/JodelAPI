﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JodelAPI
{
    class JodelsFirstRound
    {
        public class LocCoordinates
        {
            public int lat { get; set; }
            public int lng { get; set; }
        }

        public class Location
        {
            public string name { get; set; }
            public LocCoordinates loc_coordinates { get; set; }
        }

        public class ImageHeaders
        {
            public string Host { get; set; }
            public string xAmzDate { get; set; }
            public string xAmzContentSha256 { get; set; }
            public string Authorization { get; set; }
        }

        public class Recent
        {
            public string post_id { get; set; }
            public string created_at { get; set; }
            public string message { get; set; }
            public int discovered_by { get; set; }
            public string updated_at { get; set; }
            public string post_own { get; set; }
            public int discovered { get; set; }
            public int distance { get; set; }
            public int vote_count { get; set; }
            public string color { get; set; }
            public Location location { get; set; }
            public List<object> ptp_location { get; set; }
            public List<object> tags { get; set; }
            public string user_handle { get; set; }
            public int? child_count { get; set; }
            public List<object> children { get; set; }
            public string image_url { get; set; }
            public ImageHeaders image_headers { get; set; }
            public string thumbnail_url { get; set; }
        }

        public class LocCoordinates2
        {
            public int lat { get; set; }
            public int lng { get; set; }
        }

        public class Location2
        {
            public string name { get; set; }
            public LocCoordinates2 loc_coordinates { get; set; }
        }

        public class Replied
        {
            public string post_id { get; set; }
            public string created_at { get; set; }
            public string message { get; set; }
            public int discovered_by { get; set; }
            public string updated_at { get; set; }
            public string post_own { get; set; }
            public int discovered { get; set; }
            public int distance { get; set; }
            public int child_count { get; set; }
            public List<object> children { get; set; }
            public int vote_count { get; set; }
            public string color { get; set; }
            public Location2 location { get; set; }
            public List<object> ptp_location { get; set; }
            public List<object> tags { get; set; }
            public string user_handle { get; set; }
        }

        public class LocCoordinates3
        {
            public int lat { get; set; }
            public int lng { get; set; }
        }

        public class Location3
        {
            public string name { get; set; }
            public LocCoordinates3 loc_coordinates { get; set; }
        }

        public class Voted
        {
            public string post_id { get; set; }
            public string created_at { get; set; }
            public string message { get; set; }
            public int discovered_by { get; set; }
            public string updated_at { get; set; }
            public string post_own { get; set; }
            public int discovered { get; set; }
            public int distance { get; set; }
            public int child_count { get; set; }
            public List<object> children { get; set; }
            public int vote_count { get; set; }
            public string color { get; set; }
            public Location3 location { get; set; }
            public List<object> ptp_location { get; set; }
            public List<object> tags { get; set; }
            public string user_handle { get; set; }
        }

        public class RootObject
        {
            public List<Recent> recent { get; set; }
            public List<Replied> replied { get; set; }
            public List<Voted> voted { get; set; }
            public int max { get; set; }
        }
    }
}