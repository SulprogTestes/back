﻿using Microsoft.OpenApi.Models;

internal class NonBodyParameter : OpenApiParameter
{
    public string Name { get; set; }

    public string In { get; set; }

    public string Description { get; set; }

    public bool Required { get; set; }

    public string Type { get; set; }
}
