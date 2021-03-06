﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Yandex.Alice.Sdk.Models
{
    public class AliceImageResponseModel : AliceResponseModel
    {
        [JsonPropertyName("card")]
        public AliceImageCardModel Card { get; set; }
    }
}
