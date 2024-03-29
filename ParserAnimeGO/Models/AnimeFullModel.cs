﻿using ParserAnimeGO.Models.ParserModels;

namespace ParserAnimeGO.Models
{
    public class AnimeFullModel
    {
        public long AnimeId { get; set; }
        public string? TitleEn { get; set; }
        public string? TitleRu { get; set; }
        public string? Type { get; set; }
        public int? Year { get; set; }
        public string? Description { get; set; }
        public double? Rate { get; set; }
        public string? Status { get; set; }
        public int? CountEpisode { get; set; }
        public string? MpaaRate { get; set; }
        public int? Planned { get; set; }
        public int? Completed { get; set; }
        public int? Watching { get; set; }
        public int? Dropped { get; set; }
        public int? OnHold { get; set; }
        public string? Href { get; set; }
        public string? ImgIdFromAnimeGo { get; set; }
        public string? NextEpisode { get; set; }
        public string? Duration { get; set; }
        public long? IdForComments { get; set; }
        public List<string> Studios { get; set; } = new List<string>();
        public List<string> Genres { get; set; } = new List<string>();
        public List<string> Dubbing { get; set; } = new List<string>();

        public void UpdateWithPartialAnimeData(PartialAnimeData partialAnimeData)
        {
            TitleEn = partialAnimeData.TitleEn;
            TitleRu = partialAnimeData.TitleRu;
            Type = partialAnimeData.Type;
            Year = partialAnimeData.Year;
            Description = partialAnimeData.Description;
            Href = partialAnimeData.Href;
        }
        public void UpdateWithMainAnimeData(MainAnimeData mainAnimeData)
        {
            Rate = mainAnimeData.Rate;
            Status = mainAnimeData.Status;
            CountEpisode = mainAnimeData.CountEpisode;
            MpaaRate = mainAnimeData.MpaaRate;
            ImgIdFromAnimeGo = mainAnimeData.ImgIdFromAnimeGo;
            NextEpisode = mainAnimeData.NextEpisode;
            Studios = mainAnimeData.Studios;
            Duration = mainAnimeData.Duration;
            Genres = mainAnimeData.Genres;
            Dubbing = mainAnimeData.Dubbing.ToList();
            IdForComments = mainAnimeData.IdForComments;

        }
        public void UpdateWithShowAnimeData(ShowAnimeData showAnimeData)
        {
            Planned = showAnimeData.Planned;
            Completed = showAnimeData.Completed;
            Watching = showAnimeData.Watching;
            Dropped = showAnimeData.Dropped;
            OnHold = showAnimeData.OnHold;
        }
    }
}
