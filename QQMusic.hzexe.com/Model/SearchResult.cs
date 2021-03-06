﻿//Copyright by hzexe https://github.com/hzexe
//All rights reserved
//See the LICENSE file in the project root for more information.
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using QQMusic.hzexe.com.Utils;

namespace Hzexe.QQMusic.Model
{

    public class Semantic
    {
        public int? curnum { get; set; }
        public int? curpage { get; set; }
        //public List<object> list { get; set; }
        public int? totalnum { get; set; }
    }

    public class Action1
    {
        public int? alert { get; set; }
        public int? icons { get; set; }
        public int? msg { get; set; }
        [JsonProperty("switch")]
        public int Switch { get; set; }
    }

    public class Album : IAlbum
    {
        public int id { get; set; }
        public string mid { get; set; }
        public string name { get; set; }
        public string subtitle { get; set; }
        public string title { get; set; }
        public string title_hilight { get; set; }
    }

    public partial class File : IFile
    {
        public string media_mid { get; set; }
        public int? size_128 { get; set; }
        public int? size_320 { get; set; }
        public int? size_aac { get; set; }
        public int? size_ape { get; set; }
        public int? size_dts { get; set; }
        public int? size_flac { get; set; }
        public int? size_ogg { get; set; }
        public int? size_try { get; set; }
        public string strMediaMid { get; set; }
        public int? try_begin { get; set; }
        public int? try_end { get; set; }
        /// <summary>
        /// 获取当前歌曲可用的格式并按大小降序排列
        /// </summary>
        /// <returns></returns>
        public EnumFileType GetAvailableFileType()
        {
            EnumFileType tp = 0;
            List<IFiletype> list = new List<IFiletype>(5);
            if ((size_128 ?? 0) > 0)
                tp |= EnumFileType.Mp3_128k;
            if ((size_320 ?? 0) > 0)
                tp |= EnumFileType.Mp3_320k;
            if ((size_aac ?? 0) > 0)
            {
                //
            }
            if ((size_ogg ?? 0) > 0)
            {
                //
            }
            if ((size_dts ?? 0) > 0)
            {
                //
            }
            if ((size_ape ?? 0) > 0)
                tp |= EnumFileType.Ape;
            if ((size_flac ?? 0) > 0)
                tp |= EnumFileType.Flac;
            //System.Linq.Expresions.ExpressionCreator < System.Action < System.Object,System.Object >>
            return tp;
        }
    }

    public class Action2
    {
        public int alert { get; set; }
        public int icons { get; set; }
        public int msg { get; set; }
        [JsonProperty("switch")]
        public int Switch { get; set; }
    }

    public class Album2
    {
        public int id { get; set; }
        public string mid { get; set; }
        public string name { get; set; }
        public string subtitle { get; set; }
        public string title { get; set; }
        public string title_hilight { get; set; }
    }

    public class File2
    {
        public string media_mid { get; set; }
        public int size_128 { get; set; }
        public int size_320 { get; set; }
        public int size_aac { get; set; }
        public int size_ape { get; set; }
        public int size_dts { get; set; }
        public int size_flac { get; set; }
        public int size_ogg { get; set; }
        public int size_try { get; set; }
        public string strMediaMid { get; set; }
        public int try_begin { get; set; }
        public int try_end { get; set; }
    }

    public class Ksong
    {
        public int id { get; set; }
        public string mid { get; set; }
    }

    public class Mv
    {
        public int id { get; set; }
        public string vid { get; set; }
    }

    public class Pay
    {
        public int? pay_down { get; set; }
        public int? pay_month { get; set; }
        public int? pay_play { get; set; }
        public int? pay_status { get; set; }
        public int? price_album { get; set; }
        public int? price_track { get; set; }
        public int? time_free { get; set; }
    }

    public class Singer
    {
        public int? id { get; set; }
        public string mid { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string title_hilight { get; set; }
        public int? type { get; set; }
        public Int64? uin { get; set; }
    }

    public class Volume
    {
        public double gain { get; set; }
        public double lra { get; set; }
        public double peak { get; set; }
    }

    public class Grp
    {
        public Action2 action { get; set; }
        public Album2 album { get; set; }
        public int? chinesesinger { get; set; }
        public string desc { get; set; }
        public string desc_hilight { get; set; }
        public string docid { get; set; }
        public File2 file { get; set; }
        public int? fnote { get; set; }
        public int? genre { get; set; }
        public int? id { get; set; }
        public int? index_album { get; set; }
        public int? index_cd { get; set; }
        public int? interval { get; set; }
        public int? isonly { get; set; }
        public Ksong ksong { get; set; }
        public int? language { get; set; }
        public string lyric { get; set; }
        public string lyric_hilight { get; set; }
        public string mid { get; set; }
        public Mv mv { get; set; }
        public string name { get; set; }
        public int? newStatus { get; set; }
        public long? nt { get; set; }
        public Pay pay { get; set; }
        public long pure { get; set; }
        public Singer[] singer { get; set; }
        public int? status { get; set; }
        public string subtitle { get; set; }
        public long? t { get; set; }
        public int? tag { get; set; }
        public string time_public { get; set; }
        public string title { get; set; }
        public string title_hilight { get; set; }
        public int? type { get; set; }
        public string url { get; set; }
        public int? ver { get; set; }
        public Volume volume { get; set; }
    }

    public class Ksong2
    {
        public int id { get; set; }
        public string mid { get; set; }
    }

    public class Mv2
    {
        public int id { get; set; }
        public string vid { get; set; }
    }

    public class Pay2
    {
        public int pay_down { get; set; }
        public int pay_month { get; set; }
        public int pay_play { get; set; }
        public int pay_status { get; set; }
        public int price_album { get; set; }
        public int price_track { get; set; }
        public int time_free { get; set; }
    }

    public class Singer2
    {
        public int id { get; set; }
        public string mid { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string title_hilight { get; set; }
        public int? type { get; set; }
        public Int64? uin { get; set; }
    }

    public class Volume2
    {
        public double gain { get; set; }
        public double lra { get; set; }
        public double peak { get; set; }
    }

    public class SongItem : ISongItem
    {
        public Action1 action { get; set; }
        [JsonConverter(typeof(ConcreteTypeConverter<Album>))]
        public IAlbum album { get; set; }
        public int chinesesinger { get; set; }
        public string desc { get; set; }
        public string desc_hilight { get; set; }
        public string docid { get; set; }
        [JsonConverter(typeof(ConcreteTypeConverter<File>))]
        public IFile file { get; set; }
        public int fnote { get; set; }
        public int genre { get; set; }
        public List<Grp> grp { get; set; }
        public int id { get; set; }
        public int index_album { get; set; }
        public int index_cd { get; set; }
        public int interval { get; set; }
        public int isonly { get; set; }
        public Ksong2 ksong { get; set; }
        public int language { get; set; }
        public string lyric { get; set; }
        public string lyric_hilight { get; set; }
        public string mid { get; set; }
        public Mv2 mv { get; set; }
        public string name { get; set; }
        public int newStatus { get; set; }
        //public object nt { get; set; }
        public Pay2 pay { get; set; }
        public int pure { get; set; }
        public Singer2[] singer { get; set; }
        public int status { get; set; }
        public string subtitle { get; set; }
        public int t { get; set; }
        public int tag { get; set; }
        public string time_public { get; set; }
        public string title { get; set; }
        public string title_hilight { get; set; }
        public int? type { get; set; }
        public string url { get; set; }
        public int ver { get; set; }
        public Volume2 volume { get; set; }
        public string format { get; set; }
    }

    public class Song
    {
        public int curnum { get; set; }
        public int curpage { get; set; }
        public List<SongItem> list { get; set; }
        public int totalnum { get; set; }
    }

    public class ZhidaMv
    {
        public string desc { get; set; }
        public int id { get; set; }
        public string pic { get; set; }
        public string publish_date { get; set; }
        public string title { get; set; }
        public string vid { get; set; }
    }

    public class Zhida
    {
        public int? type { get; set; }
        public ZhidaMv zhida_mv { get; set; }
    }

    public class SearchResult
    {
        public string keyword { get; set; }
        public int priority { get; set; }
        //public List<object> qc { get; set; }
        public Semantic semantic { get; set; }
        public Song song { get; set; }
        public int tab { get; set; }
        //public List<object> taglist { get; set; }
        public int totaltime { get; set; }
        public Zhida zhida { get; set; }
    }
}
