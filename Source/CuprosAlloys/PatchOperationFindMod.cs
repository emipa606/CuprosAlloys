using System;
using System.Linq;
using System.Xml;
using Verse;

namespace CuprosAlloys
{
	// Token: 0x02000002 RID: 2
	internal class PatchOperationFindMod : PatchOperation
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		protected override bool ApplyWorker(XmlDocument xml)
		{
			bool flag = this.modName.NullOrEmpty();
			return !flag && ModsConfig.ActiveModsInLoadOrder.Any((ModMetaData m) => m.Name == this.modName);
		}

		// Token: 0x04000001 RID: 1
		private string modName;
	}
}
