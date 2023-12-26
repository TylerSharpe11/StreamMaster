﻿using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

using StreamMaster.Domain.Services;

using System.Collections.Concurrent;
using System.Xml.Serialization;

namespace StreamMaster.SchedulesDirect.Data;

public partial class SchedulesDirectData(ILogger<SchedulesDirectData> logger, ISettingsService settingsService, IMemoryCache memoryCache, int EPGId) : ISchedulesDirectData
{
    public int EPGId { get; set; } = EPGId;

    [XmlArrayItem("Provider")]
    public ConcurrentBag<MxfProvider> Providers { get; set; } = [];

    [XmlAttribute("provider")]
    public string Provider { get; set; } = string.Empty;

    public void ResetLists()
    {
        Affiliates.Clear();

        GuideImages.Clear();

        Keywords.Clear();

        KeywordGroups.Clear();

        Lineups.Clear();

        People.Clear();

        Programs.Clear();
        ProgramsToProcess.Clear();

        Providers.Clear();

        Seasons.Clear();
        SeasonsToProcess.Clear();

        SeriesInfos.Clear();
        SeriesInfosToProcess.Clear();
        ScheduleEntries.Clear();

        Services.Clear();
        ServicesToProcess.Clear();
    }

}