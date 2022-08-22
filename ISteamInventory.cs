internal class ISteamInventory : SteamInterface // TypeDefIndex: 5118
{	// Methods

	// RVA: 0x1286190 Offset: 0x1284790 VA: 0x181286190
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0x1288460 Offset: 0x1286A60 VA: 0x181288460
	internal static extern IntPtr SteamAPI_SteamInventory_v003() { }

	// RVA: 0x1288460 Offset: 0x1286A60 VA: 0x181288460 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0x12883F0 Offset: 0x12869F0 VA: 0x1812883F0
	internal static extern IntPtr SteamAPI_SteamGameServerInventory_v003() { }

	// RVA: 0x12883F0 Offset: 0x12869F0 VA: 0x1812883F0 Slot: 5
	public override IntPtr GetServerInterfacePointer() { }

	// RVA: 0x1289280 Offset: 0x1287880 VA: 0x181289280
	private static extern Result _GetResultStatus(IntPtr self, SteamInventoryResult_t resultHandle) { }

	// RVA: 0x1288360 Offset: 0x1286960 VA: 0x181288360
	internal Result GetResultStatus(SteamInventoryResult_t resultHandle) { }

	// RVA: 0x12891D0 Offset: 0x12877D0 VA: 0x1812891D0
	private static extern bool _GetResultItems(IntPtr self, SteamInventoryResult_t resultHandle, [In] [Out] SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize) { }

	// RVA: 0x12882B0 Offset: 0x12868B0 VA: 0x1812882B0
	internal bool GetResultItems(SteamInventoryResult_t resultHandle, [In] [Out] SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize) { }

	// RVA: 0x12890F0 Offset: 0x12876F0 VA: 0x1812890F0
	private static extern bool _GetResultItemProperty(IntPtr self, SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSizeOut) { }

	// RVA: 0x1288080 Offset: 0x1286680 VA: 0x181288080
	internal bool GetResultItemProperty(SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut) { }

	// RVA: 0x12889E0 Offset: 0x1286FE0 VA: 0x1812889E0
	private static extern bool _CheckResultSteamID(IntPtr self, SteamInventoryResult_t resultHandle, SteamId steamIDExpected) { }

	// RVA: 0x1287800 Offset: 0x1285E00 VA: 0x181287800
	internal bool CheckResultSteamID(SteamInventoryResult_t resultHandle, SteamId steamIDExpected) { }

	// RVA: 0x1288B30 Offset: 0x1287130 VA: 0x181288B30
	private static extern void _DestroyResult(IntPtr self, SteamInventoryResult_t resultHandle) { }

	// RVA: 0x1287950 Offset: 0x1285F50 VA: 0x181287950
	internal void DestroyResult(SteamInventoryResult_t resultHandle) { }

	// RVA: 0x1288CD0 Offset: 0x12872D0 VA: 0x181288CD0
	private static extern bool _GetAllItems(IntPtr self, ref SteamInventoryResult_t pResultHandle) { }

	// RVA: 0x1287AF0 Offset: 0x12860F0 VA: 0x181287AF0
	internal bool GetAllItems(ref SteamInventoryResult_t pResultHandle) { }

	// RVA: 0x12894A0 Offset: 0x1287AA0 VA: 0x1812894A0
	private static extern bool _SerializeResult(IntPtr self, SteamInventoryResult_t resultHandle, IntPtr pOutBuffer, ref uint punOutBufferSize) { }

	// RVA: 0x12886C0 Offset: 0x1286CC0 VA: 0x1812886C0
	internal bool SerializeResult(SteamInventoryResult_t resultHandle, IntPtr pOutBuffer, ref uint punOutBufferSize) { }

	// RVA: 0x1289310 Offset: 0x1287910 VA: 0x181289310
	private static extern bool _GrantPromoItems(IntPtr self, ref SteamInventoryResult_t pResultHandle) { }

	// RVA: 0x12884D0 Offset: 0x1286AD0 VA: 0x1812884D0
	internal bool GrantPromoItems(ref SteamInventoryResult_t pResultHandle) { }

	// RVA: 0x1288A80 Offset: 0x1287080 VA: 0x181288A80
	private static extern bool _ConsumeItem(IntPtr self, ref SteamInventoryResult_t pResultHandle, InventoryItemId itemConsume, uint unQuantity) { }

	// RVA: 0x12878A0 Offset: 0x1285EA0 VA: 0x1812878A0
	internal bool ConsumeItem(ref SteamInventoryResult_t pResultHandle, InventoryItemId itemConsume, uint unQuantity) { }

	// RVA: 0x1288BC0 Offset: 0x12871C0 VA: 0x181288BC0
	private static extern bool _ExchangeItems(IntPtr self, ref SteamInventoryResult_t pResultHandle, [In] [Out] InventoryDefId[] pArrayGenerate, [In] [Out] uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, [In] [Out] InventoryItemId[] pArrayDestroy, [In] [Out] uint[] punArrayDestroyQuantity, uint unArrayDestroyLength) { }

	// RVA: 0x12879E0 Offset: 0x1285FE0 VA: 0x1812879E0
	internal bool ExchangeItems(ref SteamInventoryResult_t pResultHandle, [In] [Out] InventoryDefId[] pArrayGenerate, [In] [Out] uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, [In] [Out] InventoryItemId[] pArrayDestroy, [In] [Out] uint[] punArrayDestroyQuantity, uint unArrayDestroyLength) { }

	// RVA: 0x1289610 Offset: 0x1287C10 VA: 0x181289610
	private static extern bool _TransferItemQuantity(IntPtr self, ref SteamInventoryResult_t pResultHandle, InventoryItemId itemIdSource, uint unQuantity, InventoryItemId itemIdDest) { }

	// RVA: 0x1288880 Offset: 0x1286E80 VA: 0x181288880
	internal bool TransferItemQuantity(ref SteamInventoryResult_t pResultHandle, InventoryItemId itemIdSource, uint unQuantity, InventoryItemId itemIdDest) { }

	// RVA: 0x12896D0 Offset: 0x1287CD0 VA: 0x1812896D0
	private static extern bool _TriggerItemDrop(IntPtr self, ref SteamInventoryResult_t pResultHandle, InventoryDefId dropListDefinition) { }

	// RVA: 0x1288940 Offset: 0x1286F40 VA: 0x181288940
	internal bool TriggerItemDrop(ref SteamInventoryResult_t pResultHandle, InventoryDefId dropListDefinition) { }

	// RVA: 0x12893A0 Offset: 0x12879A0 VA: 0x1812893A0
	private static extern bool _LoadItemDefinitions(IntPtr self) { }

	// RVA: 0x1288560 Offset: 0x1286B60 VA: 0x181288560
	internal bool LoadItemDefinitions() { }

	// RVA: 0x1288D60 Offset: 0x1287360 VA: 0x181288D60
	private static extern bool _GetItemDefinitionIDs(IntPtr self, [In] [Out] InventoryDefId[] pItemDefIDs, ref uint punItemDefIDsArraySize) { }

	// RVA: 0x1287B80 Offset: 0x1286180 VA: 0x181287B80
	internal bool GetItemDefinitionIDs([In] [Out] InventoryDefId[] pItemDefIDs, ref uint punItemDefIDsArraySize) { }

	// RVA: 0x1288E10 Offset: 0x1287410 VA: 0x181288E10
	private static extern bool _GetItemDefinitionProperty(IntPtr self, InventoryDefId iDefinition, string pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSizeOut) { }

	// RVA: 0x1287C30 Offset: 0x1286230 VA: 0x181287C30
	internal bool GetItemDefinitionProperty(InventoryDefId iDefinition, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut) { }

	// RVA: 0x1289550 Offset: 0x1287B50 VA: 0x181289550
	private static extern SteamAPICall_t _StartPurchase(IntPtr self, [In] [Out] InventoryDefId[] pArrayItemDefs, [In] [Out] uint[] punArrayQuantity, uint unArrayLength) { }

	// RVA: 0x1288770 Offset: 0x1286D70 VA: 0x181288770
	internal CallResult<SteamInventoryStartPurchaseResult_t> StartPurchase([In] [Out] InventoryDefId[] pArrayItemDefs, [In] [Out] uint[] punArrayQuantity, uint unArrayLength) { }

	// RVA: 0x1289420 Offset: 0x1287A20 VA: 0x181289420
	private static extern SteamAPICall_t _RequestPrices(IntPtr self) { }

	// RVA: 0x12885E0 Offset: 0x1286BE0 VA: 0x1812885E0
	internal CallResult<SteamInventoryRequestPricesResult_t> RequestPrices() { }

	// RVA: 0x1289070 Offset: 0x1287670 VA: 0x181289070
	private static extern uint _GetNumItemsWithPrices(IntPtr self) { }

	// RVA: 0x1288000 Offset: 0x1286600 VA: 0x181288000
	internal uint GetNumItemsWithPrices() { }

	// RVA: 0x1288F90 Offset: 0x1287590 VA: 0x181288F90
	private static extern bool _GetItemsWithPrices(IntPtr self, [In] [Out] InventoryDefId[] pArrayItemDefs, [In] [Out] ulong[] pCurrentPrices, [In] [Out] ulong[] pBasePrices, uint unArrayLength) { }

	// RVA: 0x1287F20 Offset: 0x1286520 VA: 0x181287F20
	internal bool GetItemsWithPrices([In] [Out] InventoryDefId[] pArrayItemDefs, [In] [Out] ulong[] pCurrentPrices, [In] [Out] ulong[] pBasePrices, uint unArrayLength) { }

	// RVA: 0x1288EE0 Offset: 0x12874E0 VA: 0x181288EE0
	private static extern bool _GetItemPrice(IntPtr self, InventoryDefId iDefinition, ref ulong pCurrentPrice, ref ulong pBasePrice) { }

	// RVA: 0x1287E70 Offset: 0x1286470 VA: 0x181287E70
	internal bool GetItemPrice(InventoryDefId iDefinition, ref ulong pCurrentPrice, ref ulong pBasePrice) { }

}

