// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLFoundGif : TLFoundGifBase 
	{
		public String ThumbUrl { get; set; }
		public String ContentUrl { get; set; }
		public String ContentType { get; set; }
		public Int32 W { get; set; }
		public Int32 H { get; set; }

		public TLFoundGif() { }
		public TLFoundGif(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.FoundGif; } }

		public override void Read(TLBinaryReader from)
		{
			Url = from.ReadString();
			ThumbUrl = from.ReadString();
			ContentUrl = from.ReadString();
			ContentType = from.ReadString();
			W = from.ReadInt32();
			H = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x162ECC1F);
			to.Write(Url);
			to.Write(ThumbUrl);
			to.Write(ContentUrl);
			to.Write(ContentType);
			to.Write(W);
			to.Write(H);
		}
	}
}