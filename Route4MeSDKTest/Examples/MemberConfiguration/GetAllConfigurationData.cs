﻿using Route4MeSDK.DataTypes;
using Route4MeSDK.QueryTypes;
using System;

namespace Route4MeSDK.Examples
{
    public sealed partial class Route4MeExamples
    {
        /// <summary>
        /// Get All Configuration Data
        /// </summary>
        public void GetAllConfigurationData()
        {
            // Create the manager with the api key
            Route4MeManager route4Me = new Route4MeManager(c_ApiKey);

            MemberConfigurationParameters @params = new MemberConfigurationParameters();

            // Run the query
            string errorString = "";
            MemberConfigurationDataResponse result = route4Me.GetConfigurationData(@params, out errorString);

            Console.WriteLine("");

            if (result != null)
            {
                Console.WriteLine("GetAllConfigurationData executed successfully");
                Console.WriteLine("Result: " + result.Result);
                foreach (MemberConfigurationData mc_data in result.data)
                {
                    Console.WriteLine("MemberId= " + mc_data.MemberId);
                    Console.WriteLine("ConfigKey= " + mc_data.ConfigKey);
                    Console.WriteLine("ConfigValue= " + mc_data.ConfigValue);
                    Console.WriteLine("---------------------------");
                }
            }
            else
            {
                Console.WriteLine("GetAllConfigurationData error: {0}", errorString);
            }
        }
    }
}