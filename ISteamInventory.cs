internal class ISteamInventory : SteamInterface // TypeDefIndex: 5118
{	// Methods

	// RVA: 0x1286830 Offset: 0x1284E30 VA: 0x181286830
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0x1288B00 Offset: 0x1287100 VA: 0x181288B00
	internal static extern IntPtr SteamAPI_SteamInventory_v003() { }

	// RVA: 0x1288B00 Offset: 0x1287100 VA: 0x181288B00 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0x1288A90 Offset: 0x1287090 VA: 0x181288A90
	internal static extern IntPtr SteamAPI_SteamGameServerInventory_v003() { }

	// RVA: 0x1288A90 Offset: 0x1287090 VA: 0x181288A90 Slot: 5
	public override IntPtr GetServerInterfacePointer() { }

	// RVA: 0x1289920 Offset: 0x1287F20 VA: 0x181289920
	private static extern Result _GetResultStatus(IntPtr self, SteamInventoryResult_t resultHandle) { }

	// RVA: 0x1288A00 Offset: 0x1287000 VA: 0x181288A00
	internal Result GetResultStatus(SteamInventoryResult_t resultHandle) { }

	// RVA: 0x1289870 Offset: 0x1287E70 VA: 0x181289870
	private static extern bool _GetResultItems(IntPtr self, SteamInventoryResult_t resultHandle, [In] [Out] SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize) { }

	// RVA: 0x1288950 Offset: 0x1286F50 VA: 0x181288950
	internal bool GetResultItems(SteamInventoryResult_t resultHandle, [In] [Out] SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize) { }

	// RVA: 0x1289790 Offset: 0x1287D90 VA: 0x181289790
	private static extern bool _GetResultItemProperty(IntPtr self, SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSizeOut) { }

	// RVA: 0x1288720 Offset: 0x1286D20 VA: 0x181288720
	internal bool GetResultItemProperty(SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut) { }

	// RVA: 0x1289080 Offset: 0x1287680 VA: 0x181289080
	private static extern bool _CheckResultSteamID(IntPtr self, SteamInventoryResult_t resultHandle, SteamId steamIDExpected) { }

	// RVA: 0x1287EA0 Offset: 0x12864A0 VA: 0x181287EA0
	internal bool CheckResultSteamID(SteamInventoryResult_t resultHandle, SteamId steamIDExpected) { }

	// RVA: 0x12891D0 Offset: 0x12877D0 VA: 0x1812891D0
	private static extern void _DestroyResult(IntPtr self, SteamInventoryResult_t resultHandle) { }

	// RVA: 0x1287FF0 Offset: 0x12865F0 VA: 0x181287FF0
	internal void DestroyResult(SteamInventoryResult_t resultHandle) { }

	// RVA: 0x1289370 Offset: 0x1287970 VA: 0x181289370
	private static extern bool _GetAllItems(IntPtr self, ref SteamInventoryResult_t pResultHandle) { }

	// RVA: 0x1288190 Offset: 0x1286790 VA: 0x181288190
	internal bool GetAllItems(ref SteamInventoryResult_t pResultHandle) { }

	// RVA: 0x1289B40 Offset: 0x1288140 VA: 0x181289B40
	private static extern bool _SerializeResult(IntPtr self, SteamInventoryResult_t resultHandle, IntPtr pOutBuffer, ref uint punOutBufferSize) { }

	// RVA: 0x1288D60 Offset: 0x1287360 VA: 0x181288D60
	internal bool SerializeResult(SteamInventoryResult_t resultHandle, IntPtr pOutBuffer, ref uint punOutBufferSize) { }

	// RVA: 0x12899B0 Offset: 0x1287FB0 VA: 0x1812899B0
	private static extern bool _GrantPromoItems(IntPtr self, ref SteamInventoryResult_t pResultHandle) { }

	// RVA: 0x1288B70 Offset: 0x1287170 VA: 0x181288B70
	internal bool GrantPromoItems(ref SteamInventoryResult_t pResultHandle) { }

	// RVA: 0x1289120 Offset: 0x1287720 VA: 0x181289120
	private static extern bool _ConsumeItem(IntPtr self, ref SteamInventoryResult_t pResultHandle, InventoryItemId itemConsume, uint unQuantity) { }

	// RVA: 0x1287F40 Offset: 0x1286540 VA: 0x181287F40
	internal bool ConsumeItem(ref SteamInventoryResult_t pResultHandle, InventoryItemId itemConsume, uint unQuantity) { }

	// RVA: 0x1289260 Offset: 0x1287860 VA: 0x181289260
	private static extern bool _ExchangeItems(IntPtr self, ref SteamInventoryResult_t pResultHandle, [In] [Out] InventoryDefId[] pArrayGenerate, [In] [Out] uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, [In] [Out] InventoryItemId[] pArrayDestroy, [In] [Out] uint[] punArrayDestroyQuantity, uint unArrayDestroyLength) { }

	// RVA: 0x1288080 Offset: 0x1286680 VA: 0x181288080
	internal bool ExchangeItems(ref SteamInventoryResult_t pResultHandle, [In] [Out] InventoryDefId[] pArrayGenerate, [In] [Out] uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, [In] [Out] InventoryItemId[] pArrayDestroy, [In] [Out] uint[] punArrayDestroyQuantity, uint unArrayDestroyLength) { }

	// RVA: 0x1289CB0 Offset: 0x12882B0 VA: 0x181289CB0
	private static extern bool _TransferItemQuantity(IntPtr self, ref SteamInventoryResult_t pResultHandle, InventoryItemId itemIdSource, uint unQuantity, InventoryItemId itemIdDest) { }

	// RVA: 0x1288F20 Offset: 0x1287520 VA: 0x181288F20
	internal bool TransferItemQuantity(ref SteamInventoryResult_t pResultHandle, InventoryItemId itemIdSource, uint unQuantity, InventoryItemId itemIdDest) { }

	// RVA: 0x1289D70 Offset: 0x1288370 VA: 0x181289D70
	private static extern bool _TriggerItemDrop(IntPtr self, ref SteamInventoryResult_t pResultHandle, InventoryDefId dropListDefinition) { }

	// RVA: 0x1288FE0 Offset: 0x12875E0 VA: 0x181288FE0
	internal bool TriggerItemDrop(ref SteamInventoryResult_t pResultHandle, InventoryDefId dropListDefinition) { }

	// RVA: 0x1289A40 Offset: 0x1288040 VA: 0x181289A40
	private static extern bool _LoadItemDefinitions(IntPtr self) { }

	// RVA: 0x1288C00 Offset: 0x1287200 VA: 0x181288C00
	internal bool LoadItemDefinitions() { }

	// RVA: 0x1289400 Offset: 0x1287A00 VA: 0x181289400
	private static extern bool _GetItemDefinitionIDs(IntPtr self, [In] [Out] InventoryDefId[] pItemDefIDs, ref uint punItemDefIDsArraySize) { }

	// RVA: 0x1288220 Offset: 0x1286820 VA: 0x181288220
	internal bool GetItemDefinitionIDs([In] [Out] InventoryDefId[] pItemDefIDs, ref uint punItemDefIDsArraySize) { }

	// RVA: 0x12894B0 Offset: 0x1287AB0 VA: 0x1812894B0
	private static extern bool _GetItemDefinitionProperty(IntPtr self, InventoryDefId iDefinition, string pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSizeOut) { }

	// RVA: 0x12882D0 Offset: 0x12868D0 VA: 0x1812882D0
	internal bool GetItemDefinitionProperty(InventoryDefId iDefinition, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut) { }

	// RVA: 0x1289BF0 Offset: 0x12881F0 VA: 0x181289BF0
	private static extern SteamAPICall_t _StartPurchase(IntPtr self, [In] [Out] InventoryDefId[] pArrayItemDefs, [In] [Out] uint[] punArrayQuantity, uint unArrayLength) { }

	// RVA: 0x1288E10 Offset: 0x1287410 VA: 0x181288E10
	internal CallResult<SteamInventoryStartPurchaseResult_t> StartPurchase([In] [Out] InventoryDefId[] pArrayItemDefs, [In] [Out] uint[] punArrayQuantity, uint unArrayLength) { }

	// RVA: 0x1289AC0 Offset: 0x12880C0 VA: 0x181289AC0
	private static extern SteamAPICall_t _RequestPrices(IntPtr self) { }

	// RVA: 0x1288C80 Offset: 0x1287280 VA: 0x181288C80
	internal CallResult<SteamInventoryRequestPricesResult_t> RequestPrices() { }

	// RVA: 0x1289710 Offset: 0x1287D10 VA: 0x181289710
	private static extern uint _GetNumItemsWithPrices(IntPtr self) { }

	// RVA: 0x12886A0 Offset: 0x1286CA0 VA: 0x1812886A0
	internal uint GetNumItemsWithPrices() { }

	// RVA: 0x1289630 Offset: 0x1287C30 VA: 0x181289630
	private static extern bool _GetItemsWithPrices(IntPtr self, [In] [Out] InventoryDefId[] pArrayItemDefs, [In] [Out] ulong[] pCurrentPrices, [In] [Out] ulong[] pBasePrices, uint unArrayLength) { }

	// RVA: 0x12885C0 Offset: 0x1286BC0 VA: 0x1812885C0
	internal bool GetItemsWithPrices([In] [Out] InventoryDefId[] pArrayItemDefs, [In] [Out] ulong[] pCurrentPrices, [In] [Out] ulong[] pBasePrices, uint unArrayLength) { }

	// RVA: 0x1289580 Offset: 0x1287B80 VA: 0x181289580
	private static extern bool _GetItemPrice(IntPtr self, InventoryDefId iDefinition, ref ulong pCurrentPrice, ref ulong pBasePrice) { }

	// RVA: 0x1288510 Offset: 0x1286B10 VA: 0x181288510
	internal bool GetItemPrice(InventoryDefId iDefinition, ref ulong pCurrentPrice, ref ulong pBasePrice) { }

}

