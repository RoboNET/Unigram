// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputPrivacyKeyStatusTimestamp : TLInputPrivacyKeyBase 
	{
		public TLInputPrivacyKeyStatusTimestamp() { }
		public TLInputPrivacyKeyStatusTimestamp(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputPrivacyKeyStatusTimestamp; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x4F96CB18);
		}
	}
}