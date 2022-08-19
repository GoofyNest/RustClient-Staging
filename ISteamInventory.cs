internal class ISteamInventory : SteamInterface // TypeDefIndex: 5118
{	// Methods

	// RVA: 0x1285ED0 Offset: 0x12844D0 VA: 0x181285ED0
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0x12881A0 Offset: 0x12867A0 VA: 0x1812881A0
	internal static extern IntPtr SteamAPI_SteamInventory_v003() { }

	// RVA: 0x12881A0 Offset: 0x12867A0 VA: 0x1812881A0 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0x1288130 Offset: 0x1286730 VA: 0x181288130
	internal static extern IntPtr SteamAPI_SteamGameServerInventory_v003() { }

	// RVA: 0x1288130 Offset: 0x1286730 VA: 0x181288130 Slot: 5
	public override IntPtr GetServerInterfacePointer() { }

	// RVA: 0x1288FC0 Offset: 0x12875C0 VA: 0x181288FC0
	private static extern Result _GetResultStatus(IntPtr self, SteamInventoryResult_t resultHandle) { }

	// RVA: 0x12880A0 Offset: 0x12866A0 VA: 0x1812880A0
	internal Result GetResultStatus(SteamInventoryResult_t resultHandle) { }

	// RVA: 0x1288F10 Offset: 0x1287510 VA: 0x181288F10
	private static extern bool _GetResultItems(IntPtr self, SteamInventoryResult_t resultHandle, [In] [Out] SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize) { }

	// RVA: 0x1287FF0 Offset: 0x12865F0 VA: 0x181287FF0
	internal bool GetResultItems(SteamInventoryResult_t resultHandle, [In] [Out] SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize) { }

	// RVA: 0x1288E30 Offset: 0x1287430 VA: 0x181288E30
	private static extern bool _GetResultItemProperty(IntPtr self, SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSizeOut) { }

	// RVA: 0x1287DC0 Offset: 0x12863C0 VA: 0x181287DC0
	internal bool GetResultItemProperty(SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut) { }

	// RVA: 0x1288720 Offset: 0x1286D20 VA: 0x181288720
	private static extern bool _CheckResultSteamID(IntPtr self, SteamInventoryResult_t resultHandle, SteamId steamIDExpected) { }

	// RVA: 0x1287540 Offset: 0x1285B40 VA: 0x181287540
	internal bool CheckResultSteamID(SteamInventoryResult_t resultHandle, SteamId steamIDExpected) { }

	// RVA: 0x1288870 Offset: 0x1286E70 VA: 0x181288870
	private static extern void _DestroyResult(IntPtr self, SteamInventoryResult_t resultHandle) { }

	// RVA: 0x1287690 Offset: 0x1285C90 VA: 0x181287690
	internal void DestroyResult(SteamInventoryResult_t resultHandle) { }

	// RVA: 0x1288A10 Offset: 0x1287010 VA: 0x181288A10
	private static extern bool _GetAllItems(IntPtr self, ref SteamInventoryResult_t pResultHandle) { }

	// RVA: 0x1287830 Offset: 0x1285E30 VA: 0x181287830
	internal bool GetAllItems(ref SteamInventoryResult_t pResultHandle) { }

	// RVA: 0x12891E0 Offset: 0x12877E0 VA: 0x1812891E0
	private static extern bool _SerializeResult(IntPtr self, SteamInventoryResult_t resultHandle, IntPtr pOutBuffer, ref uint punOutBufferSize) { }

	// RVA: 0x1288400 Offset: 0x1286A00 VA: 0x181288400
	internal bool SerializeResult(SteamInventoryResult_t resultHandle, IntPtr pOutBuffer, ref uint punOutBufferSize) { }

	// RVA: 0x1289050 Offset: 0x1287650 VA: 0x181289050
	private static extern bool _GrantPromoItems(IntPtr self, ref SteamInventoryResult_t pResultHandle) { }

	// RVA: 0x1288210 Offset: 0x1286810 VA: 0x181288210
	internal bool GrantPromoItems(ref SteamInventoryResult_t pResultHandle) { }

	// RVA: 0x12887C0 Offset: 0x1286DC0 VA: 0x1812887C0
	private static extern bool _ConsumeItem(IntPtr self, ref SteamInventoryResult_t pResultHandle, InventoryItemId itemConsume, uint unQuantity) { }

	// RVA: 0x12875E0 Offset: 0x1285BE0 VA: 0x1812875E0
	internal bool ConsumeItem(ref SteamInventoryResult_t pResultHandle, InventoryItemId itemConsume, uint unQuantity) { }

	// RVA: 0x1288900 Offset: 0x1286F00 VA: 0x181288900
	private static extern bool _ExchangeItems(IntPtr self, ref SteamInventoryResult_t pResultHandle, [In] [Out] InventoryDefId[] pArrayGenerate, [In] [Out] uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, [In] [Out] InventoryItemId[] pArrayDestroy, [In] [Out] uint[] punArrayDestroyQuantity, uint unArrayDestroyLength) { }

	// RVA: 0x1287720 Offset: 0x1285D20 VA: 0x181287720
	internal bool ExchangeItems(ref SteamInventoryResult_t pResultHandle, [In] [Out] InventoryDefId[] pArrayGenerate, [In] [Out] uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, [In] [Out] InventoryItemId[] pArrayDestroy, [In] [Out] uint[] punArrayDestroyQuantity, uint unArrayDestroyLength) { }

	// RVA: 0x1289350 Offset: 0x1287950 VA: 0x181289350
	private static extern bool _TransferItemQuantity(IntPtr self, ref SteamInventoryResult_t pResultHandle, InventoryItemId itemIdSource, uint unQuantity, InventoryItemId itemIdDest) { }

	// RVA: 0x12885C0 Offset: 0x1286BC0 VA: 0x1812885C0
	internal bool TransferItemQuantity(ref SteamInventoryResult_t pResultHandle, InventoryItemId itemIdSource, uint unQuantity, InventoryItemId itemIdDest) { }

	// RVA: 0x1289410 Offset: 0x1287A10 VA: 0x181289410
	private static extern bool _TriggerItemDrop(IntPtr self, ref SteamInventoryResult_t pResultHandle, InventoryDefId dropListDefinition) { }

	// RVA: 0x1288680 Offset: 0x1286C80 VA: 0x181288680
	internal bool TriggerItemDrop(ref SteamInventoryResult_t pResultHandle, InventoryDefId dropListDefinition) { }

	// RVA: 0x12890E0 Offset: 0x12876E0 VA: 0x1812890E0
	private static extern bool _LoadItemDefinitions(IntPtr self) { }

	// RVA: 0x12882A0 Offset: 0x12868A0 VA: 0x1812882A0
	internal bool LoadItemDefinitions() { }

	// RVA: 0x1288AA0 Offset: 0x12870A0 VA: 0x181288AA0
	private static extern bool _GetItemDefinitionIDs(IntPtr self, [In] [Out] InventoryDefId[] pItemDefIDs, ref uint punItemDefIDsArraySize) { }

	// RVA: 0x12878C0 Offset: 0x1285EC0 VA: 0x1812878C0
	internal bool GetItemDefinitionIDs([In] [Out] InventoryDefId[] pItemDefIDs, ref uint punItemDefIDsArraySize) { }

	// RVA: 0x1288B50 Offset: 0x1287150 VA: 0x181288B50
	private static extern bool _GetItemDefinitionProperty(IntPtr self, InventoryDefId iDefinition, string pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSizeOut) { }

	// RVA: 0x1287970 Offset: 0x1285F70 VA: 0x181287970
	internal bool GetItemDefinitionProperty(InventoryDefId iDefinition, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut) { }

	// RVA: 0x1289290 Offset: 0x1287890 VA: 0x181289290
	private static extern SteamAPICall_t _StartPurchase(IntPtr self, [In] [Out] InventoryDefId[] pArrayItemDefs, [In] [Out] uint[] punArrayQuantity, uint unArrayLength) { }

	// RVA: 0x12884B0 Offset: 0x1286AB0 VA: 0x1812884B0
	internal CallResult<SteamInventoryStartPurchaseResult_t> StartPurchase([In] [Out] InventoryDefId[] pArrayItemDefs, [In] [Out] uint[] punArrayQuantity, uint unArrayLength) { }

	// RVA: 0x1289160 Offset: 0x1287760 VA: 0x181289160
	private static extern SteamAPICall_t _RequestPrices(IntPtr self) { }

	// RVA: 0x1288320 Offset: 0x1286920 VA: 0x181288320
	internal CallResult<SteamInventoryRequestPricesResult_t> RequestPrices() { }

	// RVA: 0x1288DB0 Offset: 0x12873B0 VA: 0x181288DB0
	private static extern uint _GetNumItemsWithPrices(IntPtr self) { }

	// RVA: 0x1287D40 Offset: 0x1286340 VA: 0x181287D40
	internal uint GetNumItemsWithPrices() { }

	// RVA: 0x1288CD0 Offset: 0x12872D0 VA: 0x181288CD0
	private static extern bool _GetItemsWithPrices(IntPtr self, [In] [Out] InventoryDefId[] pArrayItemDefs, [In] [Out] ulong[] pCurrentPrices, [In] [Out] ulong[] pBasePrices, uint unArrayLength) { }

	// RVA: 0x1287C60 Offset: 0x1286260 VA: 0x181287C60
	internal bool GetItemsWithPrices([In] [Out] InventoryDefId[] pArrayItemDefs, [In] [Out] ulong[] pCurrentPrices, [In] [Out] ulong[] pBasePrices, uint unArrayLength) { }

	// RVA: 0x1288C20 Offset: 0x1287220 VA: 0x181288C20
	private static extern bool _GetItemPrice(IntPtr self, InventoryDefId iDefinition, ref ulong pCurrentPrice, ref ulong pBasePrice) { }

	// RVA: 0x1287BB0 Offset: 0x12861B0 VA: 0x181287BB0
	internal bool GetItemPrice(InventoryDefId iDefinition, ref ulong pCurrentPrice, ref ulong pBasePrice) { }

}

