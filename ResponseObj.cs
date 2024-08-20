using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class coordinates
{
    [JsonProperty("latitude")]
    public double latitude { get; set; }

    [JsonProperty("longitude")]
    public double longitude { get; set; }

}

public class data
{
    [JsonProperty("coordinates")]
    public coordinates coordinates { get; set; }

    [JsonProperty("phase")]
    public string phase { get; set; }

    [JsonProperty("moonrise")]
    public DateTime moonrise { get; set; }

    [JsonProperty("moonset")]
    public DateTime moonset { get; set; }

    [JsonProperty("moonAlwaysUp")]
    public bool moonAlwaysUp { get; set; }

    [JsonProperty("moonAlwaysDown")]
    public bool moonAlwaysDown { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
