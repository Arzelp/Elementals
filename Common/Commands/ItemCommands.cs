using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace Elementals.Common.Commands
{
	public class ItemCommands : ModCommand
	{
		public override CommandType Type
			=> CommandType.Chat;

		public override string Command
			=> "item";

		public override string Usage
			=> "/item <type|name> [stack]" +
			"\n type — ItemID of item." +
			"\n name — name of Item in current localization." +
			"\n Replace spaces in item name with underscores.";

		public override string Description
			=> "Spawn an item by name or by typeId";

		public override void Action(CommandCaller caller, string input, string[] args) {
			if (args.Length == 0)
				throw new UsageException("At least one argument was expected.");

			if (!int.TryParse(args[0], out int type)) {
				string name = args[0].Replace("_", " ");
				for (int k = 1; k < ItemLoader.ItemCount; k++) {
					if (name.ToLower() == Lang.GetItemNameValue(k).ToLower()) {
						type = k;
						break;
					}
				}
			}

			if (type <= 0 || type >= ItemLoader.ItemCount)
				throw new UsageException(string.Format("Unknown item — Must be valid name or 0 < type < {0}", ItemLoader.ItemCount));

			int stack = 1;
			if (args.Length >= 2) {
				if (!int.TryParse(args[1], out stack))
					throw new UsageException("Stack value must be integer, but met: " + args[1]);
			}

			caller.Player.QuickSpawnItem(new EntitySource_DebugCommand($"{nameof(Elementals)}_{nameof(ItemCommands)}"), type, stack);
		}
	}
}