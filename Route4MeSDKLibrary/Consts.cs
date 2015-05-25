﻿
namespace Route4MeSDK
{
  /// <summary>
  /// Route4Me infrastructure settings
  /// Api version 4 hosts constants
  /// </summary>
  public static class R4MEInfrastructureSettings
  {
    #region Api V4

    public const string ApiVersion = "4";

    public const string MainHost      = "https://www.route4me.com";
    public const string ApiHost       = MainHost + "/api.v4/optimization_problem.php";
    public const string ShowRouteHost = MainHost + "/route4me.php";
    public const string RouteHost     = MainHost + "/api.v4/route.php";
    public const string SetGpsHost    = MainHost + "/track/set.php";

    #endregion
  }
}