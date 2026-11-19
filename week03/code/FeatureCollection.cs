using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Net.Http;
using System.Text.Json;

/// <summary>
/// It maps the root object of the GeoJSON response, which contains the collection of earthquakes.
/// </summary>
public class FeatureCollection
{
    public List<Feature> Features { get; set; }
}

/// <summary>
/// It maps each individual element of the earthquake list.
/// </summary>
public class Feature
{
    public FeatureProperties Properties { get; set; }
}

/// <summary>
/// It maps the specific attributes of each earthquake (magnitude and location).
/// </summary>
public class FeatureProperties
{
    public double Mag { get; set; }
    public string Place { get; set; }
}