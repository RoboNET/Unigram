// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLWallPaper : TLWallPaperBase 
	{
		public TLVector<TLPhotoSizeBase> Sizes { get; set; }

		public TLWallPaper() { }
		public TLWallPaper(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.WallPaper; } }

		public override void Read(TLBinaryReader from)
		{
			Id = from.ReadInt32();
			Title = from.ReadString();
			Sizes = TLFactory.Read<TLVector<TLPhotoSizeBase>>(from);
			Color = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xCCB03657);
			to.Write(Id);
			to.Write(Title);
			to.WriteObject(Sizes);
			to.Write(Color);
		}
	}
}