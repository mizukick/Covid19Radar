﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Cosmos;

namespace Covid19Radar.DataStore
{
    public interface ICosmos
    {
        Container User { get; }
        Container Beacon { get; }

    }
}