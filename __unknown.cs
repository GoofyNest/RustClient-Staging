internal sealed class <>f__AnonymousType0<<message>j__TPar> // TypeDefIndex: 1
{
// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
internal sealed class <>f__AnonymousType0<<message>j__TPar> // TypeDefIndex: 1
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x9E940 Offset: 0x9DD40 VA: 0x18009E940
	private readonly <message>j__TPar <message>i__Field; // 0x0

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public void .ctor(<message>j__TPar message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1359F10 Offset: 0x1358510 VA: 0x181359F10
	|-<>f__AnonymousType0<object>..ctor
	|-<>f__AnonymousType0<string>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E94C0 Offset: 0x15E7AC0 VA: 0x1815E94C0
	|-<>f__AnonymousType0<object>.Equals
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E9570 Offset: 0x15E7B70 VA: 0x1815E9570
	|-<>f__AnonymousType0<object>.GetHashCode
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E95C0 Offset: 0x15E7BC0 VA: 0x1815E95C0
	|-<>f__AnonymousType0<object>.ToString
	*/

}

internal class __Filters // TypeDefIndex: 143
{	// Fields
	internal static readonly __Filters Instance; // 0x2B11178

	// Methods

	// RVA: 0x214C3F0 Offset: 0x214A9F0 VA: 0x18214C3F0 Slot: 4
	internal virtual bool FilterAttribute(MemberInfo m, object filterCriteria) { }

	// RVA: 0x214C9E0 Offset: 0x214AFE0 VA: 0x18214C9E0 Slot: 5
	internal virtual bool FilterName(MemberInfo m, object filterCriteria) { }

	// RVA: 0x214C820 Offset: 0x214AE20 VA: 0x18214C820 Slot: 6
	internal virtual bool FilterIgnoreCase(MemberInfo m, object filterCriteria) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x214CB90 Offset: 0x214B190 VA: 0x18214CB90
	private static void .cctor() { }

}

public sealed class Func<TResult> : MulticastDelegate // TypeDefIndex: 155
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-Func<MP3Stream>..ctor
	|-Func<JsonSerializerSettings>..ctor
	|-Func<PublishResult>..ctor
	|-Func<bool>..ctor
	|-Func<byte>..ctor
	|-Func<Stream>..ctor
	|-Func<int>..ctor
	|-Func<UdpReceiveResult>..ctor
	|-Func<Nullable<ServerInfo>>..ctor
	|-Func<Nullable<Image>>..ctor
	|-Func<Nullable<InventoryPurchaseResult>>..ctor
	|-Func<Nullable<InventoryResult>>..ctor
	|-Func<Nullable<Item>>..ctor
	|-Func<Nullable<ResultPage>>..ctor
	|-Func<Nullable<int>>..ctor
	|-Func<Nullable<Int32Enum>>..ctor
	|-Func<object>..ctor
	|-Func<string>..ctor
	|-Func<StringBuilder>..ctor
	|-Func<ManualResetEvent>..ctor
	|-Func<SemaphoreSlim>..ctor
	|-Func<Task.ContingentProperties>..ctor
	|-Func<Task<Stream>>..ctor
	|-Func<Task<WebResponse>>..ctor
	|-Func<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual TResult Invoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B88C00 Offset: 0x1B87200 VA: 0x181B88C00
	|-Func<JsonSerializerSettings>.Invoke
	|-Func<IReferenceResolver>.Invoke
	|-Func<string>.Invoke
	|-Func<object>.Invoke
	|
	|-RVA: 0x1B89600 Offset: 0x1B87C00 VA: 0x181B89600
	|-Func<bool>.Invoke
	|-Func<byte>.Invoke
	|-Func<VoidTaskResult>.Invoke
	|
	|-RVA: 0x1B89390 Offset: 0x1B87990 VA: 0x181B89390
	|-Func<int>.Invoke
	|
	|-RVA: 0x1B890E0 Offset: 0x1B876E0 VA: 0x181B890E0
	|-Func<PublishResult>.Invoke
	|-Func<Nullable<Image>>.Invoke
	|
	|-RVA: 0x1220AC0 Offset: 0x121F0C0 VA: 0x181220AC0
	|-Func<UdpReceiveResult>.Invoke
	|
	|-RVA: 0x1B89E00 Offset: 0x1B88400 VA: 0x181B89E00
	|-Func<Nullable<ServerInfo>>.Invoke
	|
	|-RVA: 0x1B88950 Offset: 0x1B86F50 VA: 0x181B88950
	|-Func<Nullable<InventoryPurchaseResult>>.Invoke
	|-Func<Nullable<ResultPage>>.Invoke
	|
	|-RVA: 0x198A790 Offset: 0x1988D90 VA: 0x18198A790
	|-Func<Nullable<InventoryResult>>.Invoke
	|
	|-RVA: 0x1B89870 Offset: 0x1B87E70 VA: 0x181B89870
	|-Func<Nullable<Item>>.Invoke
	|
	|-RVA: 0x1B88E70 Offset: 0x1B87470 VA: 0x181B88E70
	|-Func<Nullable<int>>.Invoke
	|-Func<Nullable<Int32Enum>>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190
	|-Func<PublishResult>.BeginInvoke
	|-Func<bool>.BeginInvoke
	|-Func<byte>.BeginInvoke
	|-Func<int>.BeginInvoke
	|-Func<UdpReceiveResult>.BeginInvoke
	|-Func<Nullable<ServerInfo>>.BeginInvoke
	|-Func<Nullable<Image>>.BeginInvoke
	|-Func<Nullable<InventoryPurchaseResult>>.BeginInvoke
	|-Func<Nullable<InventoryResult>>.BeginInvoke
	|-Func<Nullable<Item>>.BeginInvoke
	|-Func<Nullable<ResultPage>>.BeginInvoke
	|-Func<Nullable<int>>.BeginInvoke
	|-Func<Nullable<Int32Enum>>.BeginInvoke
	|-Func<object>.BeginInvoke
	|-Func<VoidTaskResult>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19F91A0 Offset: 0x19F77A0 VA: 0x1819F91A0
	|-Func<PublishResult>.EndInvoke
	|-Func<Nullable<Image>>.EndInvoke
	|
	|-RVA: 0xFF6250 Offset: 0xFF4850 VA: 0x180FF6250
	|-Func<bool>.EndInvoke
	|-Func<byte>.EndInvoke
	|-Func<VoidTaskResult>.EndInvoke
	|
	|-RVA: 0xB9A710 Offset: 0xB98D10 VA: 0x180B9A710
	|-Func<int>.EndInvoke
	|
	|-RVA: 0x1220A80 Offset: 0x121F080 VA: 0x181220A80
	|-Func<UdpReceiveResult>.EndInvoke
	|
	|-RVA: 0x19F9010 Offset: 0x19F7610 VA: 0x1819F9010
	|-Func<Nullable<ServerInfo>>.EndInvoke
	|
	|-RVA: 0x19F9080 Offset: 0x19F7680 VA: 0x1819F9080
	|-Func<Nullable<InventoryPurchaseResult>>.EndInvoke
	|-Func<Nullable<ResultPage>>.EndInvoke
	|
	|-RVA: 0x198A750 Offset: 0x1988D50 VA: 0x18198A750
	|-Func<Nullable<InventoryResult>>.EndInvoke
	|
	|-RVA: 0x19F90F0 Offset: 0x19F76F0 VA: 0x1819F90F0
	|-Func<Nullable<Item>>.EndInvoke
	|
	|-RVA: 0x12213D0 Offset: 0x121F9D0 VA: 0x1812213D0
	|-Func<Nullable<int>>.EndInvoke
	|-Func<Nullable<Int32Enum>>.EndInvoke
	|
	|-RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0
	|-Func<object>.EndInvoke
	*/

}

public sealed class Func<T, TResult> : MulticastDelegate // TypeDefIndex: 156
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-Func<AchievementGroup.AchievementItem, bool>..ctor
	|-Func<BaseEntity, bool>..ctor
	|-Func<BaseNetworkable, Debugging.EntityInfo>..ctor
	|-Func<BaseNetworkable, bool>..ctor
	|-Func<BaseNetworkable, uint>..ctor
	|-Func<BaseViewModel, string>..ctor
	|-Func<Admin.PlayerInfo, GameObjectRef>..ctor
	|-Func<Admin.PlayerInfo, object>..ctor
	|-Func<Admin.ServerConvarInfo, GameObjectRef>..ctor
	|-Func<Admin.ServerConvarInfo, object>..ctor
	|-Func<Debugging.EntityInfo, Debugging.EntityInfo>..ctor
	|-Func<Debugging.EntityInfo, bool>..ctor
	|-Func<Entity.EntityInfo, bool>..ctor
	|-Func<ConsoleSystem.Command, bool>..ctor
	|-Func<ConstructionGrade, BuildingGrade.Enum>..ctor
	|-Func<ConstructionGrade, bool>..ctor
	|-Func<CraftingQueueIcon, bool>..ctor
	|-Func<Demos.DemoInfo, DateTime>..ctor
	|-Func<Demos.DemoInfo, object>..ctor
	|-Func<Demos.DemoInfo, string>..ctor
	|-Func<Demos.DemoInfo, TimeSpan>..ctor
	|-Func<DungeonBaseInfo, int>..ctor
	|-Func<EZSoftBone.BoneChain, int>..ctor
	|-Func<AccountNotice, bool>..ctor
	|-Func<AccountNotice, DateTime>..ctor
	|-Func<BurstCloth.Chain, FourBitNumber>..ctor
	|-Func<BurstCloth.Chain, SevenBitNumber>..ctor
	|-Func<BurstCloth.Chain, bool>..ctor
	|-Func<BurstCloth.Chain, int>..ctor
	|-Func<CardPlayerData, bool>..ctor
	|-Func<Hero, Guid>..ctor
	|-Func<Input.Button, bool>..ctor
	|-Func<Input.Button, string>..ctor
	|-Func<Manifest.Administrator, bool>..ctor
	|-Func<Manifest.NewsInfo.BlogInfo, string>..ctor
	|-Func<Manifest.ServerDesc, string>..ctor
	|-Func<RCon.BannedAddresses, bool>..ctor
	|-Func<SkeletonDefinition.Bone, Debugging.EntityInfo>..ctor
	|-Func<SkeletonDefinition.Bone, PathFinder.Point>..ctor
	|-Func<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>..ctor
	|-Func<SkeletonDefinition.Bone, Option>..ctor
	|-Func<SkeletonDefinition.Bone, InventoryItem>..ctor
	|-Func<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>..ctor
	|-Func<SkeletonDefinition.Bone, InventoryRecipe>..ctor
	|-Func<SkeletonDefinition.Bone, bool>..ctor
	|-Func<SkeletonDefinition.Bone, KeyValuePair<object, int>>..ctor
	|-Func<SkeletonDefinition.Bone, int>..ctor
	|-Func<SkeletonDefinition.Bone, Int32Enum>..ctor
	|-Func<SkeletonDefinition.Bone, long>..ctor
	|-Func<SkeletonDefinition.Bone, object>..ctor
	|-Func<SkeletonDefinition.Bone, float>..ctor
	|-Func<SkeletonDefinition.Bone, GameObject>..ctor
	|-Func<SkeletonDefinition.Bone, Resolution>..ctor
	|-Func<SkeletonDefinition.Bone, Transform>..ctor
	|-Func<WeightedStringList.Container, bool>..ctor
	|-Func<WeightedStringList.Container, float>..ctor
	|-Func<GameManifest.PrefabProperties, bool>..ctor
	|-Func<GameManifest.PrefabProperties, string>..ctor
	|-Func<GameStat.Stat, bool>..ctor
	|-Func<GenerateDungeonBase.DungeonSegment, float>..ctor
	|-Func<GenerateDungeonGrid.PathNode, PathFinder.Point>..ctor
	|-Func<GenerateDungeonGrid.PathNode, bool>..ctor
	|-Func<GeneratePowerlineLayout.PathNode, PathFinder.Point>..ctor
	|-Func<GeneratePowerlineLayout.PathNode, bool>..ctor
	|-Func<GenerateRoadLayout.PathNode, PathFinder.Point>..ctor
	|-Func<GenerateRoadLayout.PathNode, bool>..ctor
	|-Func<HitboxDefinition, int>..ctor
	|-Func<IPlayerInfo, bool>..ctor
	|-Func<IPlayerInfo, int>..ctor
	|-Func<IPlayerInfo, string>..ctor
	|-Func<IPlayerItem, bool>..ctor
	|-Func<IPlayerItem, DateTimeOffset>..ctor
	|-Func<IPlayerItem, int>..ctor
	|-Func<IPlayerItemDefinition, bool>..ctor
	|-Func<IPlayerItemDefinition, int>..ctor
	|-Func<ImageStorageEntity.ImageRequest, IImageReceiver>..ctor
	|-Func<ImageStorageEntity.ImageRequest, object>..ctor
	|-Func<Item, bool>..ctor
	|-Func<Item, int>..ctor
	|-Func<ItemBlueprint, Rarity>..ctor
	|-Func<ItemBlueprint, bool>..ctor
	|-Func<ItemBlueprint, int>..ctor
	|-Func<ItemDefinition, ItemCategory>..ctor
	|-Func<ItemDefinition, ItemModWearable>..ctor
	|-Func<ItemDefinition, bool>..ctor
	|-Func<ItemDefinition, float>..ctor
	|-Func<ItemDefinition, string>..ctor
	|-Func<ItemIcon, int>..ctor
	|-Func<ItemModWearable, bool>..ctor
	|-Func<ItemModWearable, Guid>..ctor
	|-Func<ItemSkinDirectory.Skin, bool>..ctor
	|-Func<LoadAssetsResult, bool>..ctor
	|-Func<LoadAssetsResult, int>..ctor
	|-Func<FourBitNumber, FourBitNumber>..ctor
	|-Func<FourBitNumber, bool>..ctor
	|-Func<SevenBitNumber, SevenBitNumber>..ctor
	|-Func<SevenBitNumber, bool>..ctor
	|-Func<SevenBitNumber, object>..ctor
	|-Func<EventsCollection, int>..ctor
	|-Func<TrackChunk, EventsCollection>..ctor
	|-Func<TrackChunk, bool>..ctor
	|-Func<ITempoMapValuesCache, bool>..ctor
	|-Func<MetricTempoMapValuesCache.AccumulatedMicroseconds, bool>..ctor
	|-Func<MetricTempoMapValuesCache.AccumulatedMicroseconds, long>..ctor
	|-Func<ValueChange<TimeSignature>, bool>..ctor
	|-Func<MusicTheme, float>..ctor
	|-Func<DefaultSerializationBinder.TypeNameKey, object>..ctor
	|-Func<DefaultSerializationBinder.TypeNameKey, Type>..ctor
	|-Func<JsonProperty, JsonProperty>..ctor
	|-Func<JsonProperty, JsonSerializerInternalReader.PropertyPresence>..ctor
	|-Func<JsonProperty, int>..ctor
	|-Func<JsonProperty, string>..ctor
	|-Func<JsonSerializerInternalReader.CreatorPropertyContext, bool>..ctor
	|-Func<ConvertUtils.TypeConvertKey, Func<object, object>>..ctor
	|-Func<ConvertUtils.TypeConvertKey, object>..ctor
	|-Func<PathFinder.Point, PathFinder.Point>..ctor
	|-Func<PathFinder.Point, bool>..ctor
	|-Func<PetCommandList.PetCommandDesc, bool>..ctor
	|-Func<PieMenu.MenuOption, bool>..ctor
	|-Func<PieMenu.MenuOption, int>..ctor
	|-Func<PlayerItemRecipe, Debugging.EntityInfo>..ctor
	|-Func<PlayerItemRecipe, IPlayerItemDefinition>..ctor
	|-Func<PlayerItemRecipe, PathFinder.Point>..ctor
	|-Func<PlayerItemRecipe, PlayerItemRecipe>..ctor
	|-Func<PlayerItemRecipe, ProjectileWeaponMod.Modifier>..ctor
	|-Func<PlayerItemRecipe, Option>..ctor
	|-Func<PlayerItemRecipe, InventoryItem>..ctor
	|-Func<PlayerItemRecipe, InventoryRecipe.Ingredient>..ctor
	|-Func<PlayerItemRecipe, InventoryRecipe>..ctor
	|-Func<PlayerItemRecipe, bool>..ctor
	|-Func<PlayerItemRecipe, KeyValuePair<object, int>>..ctor
	|-Func<PlayerItemRecipe, int>..ctor
	|-Func<PlayerItemRecipe, Int32Enum>..ctor
	|-Func<PlayerItemRecipe, long>..ctor
	|-Func<PlayerItemRecipe, object>..ctor
	|-Func<PlayerItemRecipe, float>..ctor
	|-Func<PlayerItemRecipe, Resolution>..ctor
	|-Func<PlayerItemRecipe.Ingredient, FourBitNumber>..ctor
	|-Func<PlayerItemRecipe.Ingredient, SevenBitNumber>..ctor
	|-Func<PlayerItemRecipe.Ingredient, PlayerItemRecipe.Ingredient>..ctor
	|-Func<PlayerItemRecipe.Ingredient, bool>..ctor
	|-Func<PlayerItemRecipe.Ingredient, int>..ctor
	|-Func<Prefab, bool>..ctor
	|-Func<Prefab<DungeonGridLink>, int>..ctor
	|-Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier>..ctor
	|-Func<ProjectileWeaponMod, bool>..ctor
	|-Func<ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>..ctor
	|-Func<ProjectileWeaponMod.Modifier, bool>..ctor
	|-Func<ProjectileWeaponMod.Modifier, float>..ctor
	|-Func<MarketTerminal.PendingOrder, uint>..ctor
	|-Func<PathData, PathList>..ctor
	|-Func<PathData, bool>..ctor
	|-Func<PlayerNameID, bool>..ctor
	|-Func<PlayerTeam.TeamMember, ulong>..ctor
	|-Func<PrefabData, bool>..ctor
	|-Func<PrefabData, string>..ctor
	|-Func<RelationshipManager.PlayerRelationshipInfo, ulong>..ctor
	|-Func<Indexer.Entity, Indexer.Entity>..ctor
	|-Func<Indexer.Entity, uint>..ctor
	|-Func<SteamItem, InventoryItem>..ctor
	|-Func<SteamItemDefinition, InventoryDef>..ctor
	|-Func<Option, Option>..ctor
	|-Func<Option, bool>..ctor
	|-Func<OptionAttribute, Option>..ctor
	|-Func<SteamInventoryItem, bool>..ctor
	|-Func<SteamInventoryItem, IEnumerable<PlayerItemRecipe>>..ctor
	|-Func<SteamInventoryItem, Task<IPlayerInventory>>..ctor
	|-Func<ServerBrowserTag, bool>..ctor
	|-Func<ServerInfo, Debugging.EntityInfo>..ctor
	|-Func<ServerInfo, FourBitNumber>..ctor
	|-Func<ServerInfo, SevenBitNumber>..ctor
	|-Func<ServerInfo, PathFinder.Point>..ctor
	|-Func<ServerInfo, ProjectileWeaponMod.Modifier>..ctor
	|-Func<ServerInfo, Option>..ctor
	|-Func<ServerInfo, InventoryItem>..ctor
	|-Func<ServerInfo, InventoryRecipe.Ingredient>..ctor
	|-Func<ServerInfo, InventoryRecipe>..ctor
	|-Func<ServerInfo, bool>..ctor
	|-Func<ServerInfo, KeyValuePair<object, int>>..ctor
	|-Func<ServerInfo, int>..ctor
	|-Func<ServerInfo, Int32Enum>..ctor
	|-Func<ServerInfo, long>..ctor
	|-Func<ServerInfo, object>..ctor
	|-Func<ServerInfo, float>..ctor
	|-Func<ServerInfo, string>..ctor
	|-Func<ServerInfo, uint>..ctor
	|-Func<ServerInfo, Resolution>..ctor
	|-Func<SkeletonProperties.BoneProperty, bool>..ctor
	|-Func<Skinnable, bool>..ctor
	|-Func<Skinnable, string>..ctor
	|-Func<SkinnedMultiMesh.Part, bool>..ctor
	|-Func<SkinnedMultiMesh.Part, long>..ctor
	|-Func<Achievement, <>f__AnonymousType0<string, string, bool>>..ctor
	|-Func<Achievement, Debugging.EntityInfo>..ctor
	|-Func<Achievement, PathFinder.Point>..ctor
	|-Func<Achievement, ProjectileWeaponMod.Modifier>..ctor
	|-Func<Achievement, Option>..ctor
	|-Func<Achievement, InventoryItem>..ctor
	|-Func<Achievement, InventoryRecipe.Ingredient>..ctor
	|-Func<Achievement, InventoryRecipe>..ctor
	|-Func<Achievement, bool>..ctor
	|-Func<Achievement, KeyValuePair<object, int>>..ctor
	|-Func<Achievement, int>..ctor
	|-Func<Achievement, Int32Enum>..ctor
	|-Func<Achievement, long>..ctor
	|-Func<Achievement, object>..ctor
	|-Func<Achievement, float>..ctor
	|-Func<Achievement, Resolution>..ctor
	|-Func<InventoryDefId, Debugging.EntityInfo>..ctor
	|-Func<InventoryDefId, PathFinder.Point>..ctor
	|-Func<InventoryDefId, ProjectileWeaponMod.Modifier>..ctor
	|-Func<InventoryDefId, Option>..ctor
	|-Func<InventoryDefId, InventoryDef>..ctor
	|-Func<InventoryDefId, InventoryItem>..ctor
	|-Func<InventoryDefId, InventoryRecipe.Ingredient>..ctor
	|-Func<InventoryDefId, InventoryRecipe>..ctor
	|-Func<InventoryDefId, bool>..ctor
	|-Func<InventoryDefId, KeyValuePair<object, int>>..ctor
	|-Func<InventoryDefId, int>..ctor
	|-Func<InventoryDefId, Int32Enum>..ctor
	|-Func<InventoryDefId, long>..ctor
	|-Func<InventoryDefId, object>..ctor
	|-Func<InventoryDefId, float>..ctor
	|-Func<InventoryDefId, Resolution>..ctor
	|-Func<InventoryItemId, InventoryItemId>..ctor
	|-Func<InventoryItemId, bool>..ctor
	|-Func<ServerInfo, ServerInfo>..ctor
	|-Func<ServerInfo, bool>..ctor
	|-Func<ServerInfo, int>..ctor
	|-Func<ServerInfo, object>..ctor
	|-Func<Friend, Debugging.EntityInfo>..ctor
	|-Func<Friend, PathFinder.Point>..ctor
	|-Func<Friend, ProjectileWeaponMod.Modifier>..ctor
	|-Func<Friend, SteamPlayer>..ctor
	|-Func<Friend, Option>..ctor
	|-Func<Friend, InventoryItem>..ctor
	|-Func<Friend, InventoryRecipe.Ingredient>..ctor
	|-Func<Friend, InventoryRecipe>..ctor
	|-Func<Friend, bool>..ctor
	|-Func<Friend, KeyValuePair<object, int>>..ctor
	|-Func<Friend, int>..ctor
	|-Func<Friend, Int32Enum>..ctor
	|-Func<Friend, long>..ctor
	|-Func<Friend, object>..ctor
	|-Func<Friend, float>..ctor
	|-Func<Friend, Resolution>..ctor
	|-Func<InventoryDef, IPlayerItemDefinition>..ctor
	|-Func<InventoryDef, SteamItemDefinition>..ctor
	|-Func<InventoryDef, InventoryDefId>..ctor
	|-Func<InventoryDef, InventoryRecipe[]>..ctor
	|-Func<InventoryDef, string>..ctor
	|-Func<InventoryItem, Debugging.EntityInfo>..ctor
	|-Func<InventoryItem, FourBitNumber>..ctor
	|-Func<InventoryItem, SevenBitNumber>..ctor
	|-Func<InventoryItem, PathFinder.Point>..ctor
	|-Func<InventoryItem, ProjectileWeaponMod.Modifier>..ctor
	|-Func<InventoryItem, SteamItem>..ctor
	|-Func<InventoryItem, Option>..ctor
	|-Func<InventoryItem, InventoryDefId>..ctor
	|-Func<InventoryItem, InventoryItemId>..ctor
	|-Func<InventoryItem, InventoryItem>..ctor
	|-Func<InventoryItem, InventoryRecipe.Ingredient>..ctor
	|-Func<InventoryItem, InventoryRecipe>..ctor
	|-Func<InventoryItem, bool>..ctor
	|-Func<InventoryItem, KeyValuePair<object, int>>..ctor
	|-Func<InventoryItem, int>..ctor
	|-Func<InventoryItem, Int32Enum>..ctor
	|-Func<InventoryItem, long>..ctor
	|-Func<InventoryItem, object>..ctor
	|-Func<InventoryItem, float>..ctor
	|-Func<InventoryItem, uint>..ctor
	|-Func<InventoryItem, Resolution>..ctor
	|-Func<InventoryItem.Amount, InventoryItemId>..ctor
	|-Func<InventoryItem.Amount, bool>..ctor
	|-Func<InventoryItem.Amount, uint>..ctor
	|-Func<InventoryRecipe, PlayerItemRecipe>..ctor
	|-Func<InventoryRecipe, InventoryRecipe>..ctor
	|-Func<InventoryRecipe, bool>..ctor
	|-Func<InventoryRecipe, object>..ctor
	|-Func<InventoryRecipe.Ingredient, Debugging.EntityInfo>..ctor
	|-Func<InventoryRecipe.Ingredient, PathFinder.Point>..ctor
	|-Func<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>..ctor
	|-Func<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>..ctor
	|-Func<InventoryRecipe.Ingredient, Option>..ctor
	|-Func<InventoryRecipe.Ingredient, InventoryItem>..ctor
	|-Func<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>..ctor
	|-Func<InventoryRecipe.Ingredient, InventoryRecipe>..ctor
	|-Func<InventoryRecipe.Ingredient, bool>..ctor
	|-Func<InventoryRecipe.Ingredient, KeyValuePair<object, int>>..ctor
	|-Func<InventoryRecipe.Ingredient, int>..ctor
	|-Func<InventoryRecipe.Ingredient, Int32Enum>..ctor
	|-Func<InventoryRecipe.Ingredient, long>..ctor
	|-Func<InventoryRecipe.Ingredient, object>..ctor
	|-Func<InventoryRecipe.Ingredient, float>..ctor
	|-Func<InventoryRecipe.Ingredient, string>..ctor
	|-Func<InventoryRecipe.Ingredient, Resolution>..ctor
	|-Func<InventoryRecipe[], bool>..ctor
	|-Func<InventoryRecipe[], IEnumerable<InventoryRecipe>>..ctor
	|-Func<Item, DateTime>..ctor
	|-Func<ArraySegment<byte>, WebSocketHttpRequest>..ctor
	|-Func<ArraySegment<byte>, object>..ctor
	|-Func<bool, bool>..ctor
	|-Func<byte[], bool>..ctor
	|-Func<byte[], IEnumerable<byte>>..ctor
	|-Func<byte[], int>..ctor
	|-Func<char, bool>..ctor
	|-Func<DictionaryEntry, bool>..ctor
	|-Func<DictionaryEntry, KeyValuePair<object, object>>..ctor
	|-Func<DictionaryEntry, object>..ctor
	|-Func<KeyValuePair<IPAddress, int>, int>..ctor
	|-Func<KeyValuePair<object, int>, bool>..ctor
	|-Func<KeyValuePair<object, int>, KeyValuePair<object, int>>..ctor
	|-Func<KeyValuePair<object, int>, int>..ctor
	|-Func<KeyValuePair<object, long>, long>..ctor
	|-Func<KeyValuePair<object, object>, Debugging.EntityInfo>..ctor
	|-Func<KeyValuePair<object, object>, PathFinder.Point>..ctor
	|-Func<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>..ctor
	|-Func<KeyValuePair<object, object>, Option>..ctor
	|-Func<KeyValuePair<object, object>, InventoryItem>..ctor
	|-Func<KeyValuePair<object, object>, InventoryRecipe.Ingredient>..ctor
	|-Func<KeyValuePair<object, object>, InventoryRecipe>..ctor
	|-Func<KeyValuePair<object, object>, bool>..ctor
	|-Func<KeyValuePair<object, object>, KeyValuePair<object, int>>..ctor
	|-Func<KeyValuePair<object, object>, int>..ctor
	|-Func<KeyValuePair<object, object>, Int32Enum>..ctor
	|-Func<KeyValuePair<object, object>, long>..ctor
	|-Func<KeyValuePair<object, object>, object>..ctor
	|-Func<KeyValuePair<object, object>, float>..ctor
	|-Func<KeyValuePair<object, object>, Resolution>..ctor
	|-Func<KeyValuePair<string, Stats.Node>, long>..ctor
	|-Func<KeyValuePair<string, AssetBundle>, bool>..ctor
	|-Func<KeyValuePair<Type, Pool.ICollection>, long>..ctor
	|-Func<KeyValuePair<Type, long>, long>..ctor
	|-Func<KeyValuePair<Type, PostProcessBundle>, bool>..ctor
	|-Func<KeyValuePair<Type, PostProcessBundle>, PostProcessBundle>..ctor
	|-Func<KeyValuePair<uint, FileStorage.CacheData>, bool>..ctor
	|-Func<KeyValuePair<uint, FileStorage.CacheData>, uint>..ctor
	|-Func<KeyValuePair<uint, Indexer.Entity>, Indexer.Entity>..ctor
	|-Func<KeyValuePair<uint, object>, Debugging.EntityInfo>..ctor
	|-Func<KeyValuePair<uint, object>, PathFinder.Point>..ctor
	|-Func<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>..ctor
	|-Func<KeyValuePair<uint, object>, Option>..ctor
	|-Func<KeyValuePair<uint, object>, InventoryItem>..ctor
	|-Func<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>..ctor
	|-Func<KeyValuePair<uint, object>, InventoryRecipe>..ctor
	|-Func<KeyValuePair<uint, object>, bool>..ctor
	|-Func<KeyValuePair<uint, object>, KeyValuePair<object, int>>..ctor
	|-Func<KeyValuePair<uint, object>, int>..ctor
	|-Func<KeyValuePair<uint, object>, Int32Enum>..ctor
	|-Func<KeyValuePair<uint, object>, long>..ctor
	|-Func<KeyValuePair<uint, object>, object>..ctor
	|-Func<KeyValuePair<uint, object>, float>..ctor
	|-Func<KeyValuePair<uint, object>, uint>..ctor
	|-Func<KeyValuePair<uint, object>, Resolution>..ctor
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, Dispatch.ResultCallback>..ctor
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, bool>..ctor
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, ulong>..ctor
	|-Func<KeyValuePair<Transform, int>, int>..ctor
	|-Func<StackFrame, Report.StackTrace.StackFrame>..ctor
	|-Func<double, double>..ctor
	|-Func<Exception, bool>..ctor
	|-Func<Guid, int>..ctor
	|-Func<Guid, object>..ctor
	|-Func<IAsyncResult, ISocket>..ctor
	|-Func<IAsyncResult, Stream>..ctor
	|-Func<IAsyncResult, int>..ctor
	|-Func<IAsyncResult, UdpReceiveResult>..ctor
	|-Func<IAsyncResult, WebResponse>..ctor
	|-Func<FileInfo, bool>..ctor
	|-Func<int, FourBitNumber>..ctor
	|-Func<int, SevenBitNumber>..ctor
	|-Func<int, bool>..ctor
	|-Func<int, int>..ctor
	|-Func<int, object>..ctor
	|-Func<int, float>..ctor
	|-Func<int, Material[]>..ctor
	|-Func<Int32Enum, Debugging.EntityInfo>..ctor
	|-Func<Int32Enum, PathFinder.Point>..ctor
	|-Func<Int32Enum, ProjectileWeaponMod.Modifier>..ctor
	|-Func<Int32Enum, Option>..ctor
	|-Func<Int32Enum, InventoryItem>..ctor
	|-Func<Int32Enum, InventoryRecipe.Ingredient>..ctor
	|-Func<Int32Enum, InventoryRecipe>..ctor
	|-Func<Int32Enum, bool>..ctor
	|-Func<Int32Enum, KeyValuePair<object, int>>..ctor
	|-Func<Int32Enum, int>..ctor
	|-Func<Int32Enum, Int32Enum>..ctor
	|-Func<Int32Enum, long>..ctor
	|-Func<Int32Enum, object>..ctor
	|-Func<Int32Enum, float>..ctor
	|-Func<Int32Enum, Resolution>..ctor
	|-Func<long, bool>..ctor
	|-Func<long, long>..ctor
	|-Func<IntPtr, object>..ctor
	|-Func<IGrouping<ItemCategory, ItemDefinition>, ItemCategory>..ctor
	|-Func<IGrouping<InventoryDefId, InventoryDef>, InventoryDefId>..ctor
	|-Func<IGrouping<InventoryDefId, InventoryDef>, uint>..ctor
	|-Func<IGrouping<string, IPlayerInfo>, string>..ctor
	|-Func<IGrouping<string, PrefabData>, List<PrefabData>>..ctor
	|-Func<IGrouping<string, PrefabData>, string>..ctor
	|-Func<IGrouping<string, Animator>, int>..ctor
	|-Func<IGrouping<string, Collider>, int>..ctor
	|-Func<IGrouping<string, LODGroup>, int>..ctor
	|-Func<IGrouping<string, Rigidbody>, int>..ctor
	|-Func<IGrouping<string, Transform>, KeyValuePair<Transform, int>>..ctor
	|-Func<IGrouping<string, Transform>, int>..ctor
	|-Func<IGrouping<Type, Object>, int>..ctor
	|-Func<IGrouping<uint, BaseNetworkable>, BaseNetworkable>..ctor
	|-Func<IGrouping<uint, BaseNetworkable>, int>..ctor
	|-Func<IGrouping<AssetBundle, string>, LoadAssetsResult>..ctor
	|-Func<IGrouping<Vector2Int, Resolution>, Resolution>..ctor
	|-Func<SimpleAsyncResult, bool>..ctor
	|-Func<object, Debugging.EntityInfo>..ctor
	|-Func<object, FourBitNumber>..ctor
	|-Func<object, SevenBitNumber>..ctor
	|-Func<object, PathFinder.Point>..ctor
	|-Func<object, PlayerItemRecipe.Ingredient>..ctor
	|-Func<object, PlayerItemRecipe>..ctor
	|-Func<object, ProjectileWeaponMod.Modifier>..ctor
	|-Func<object, Option>..ctor
	|-Func<object, InventoryDefId>..ctor
	|-Func<object, InventoryItemId>..ctor
	|-Func<object, InventoryItem>..ctor
	|-Func<object, InventoryRecipe.Ingredient>..ctor
	|-Func<object, InventoryRecipe>..ctor
	|-Func<object, PublishResult>..ctor
	|-Func<object, bool>..ctor
	|-Func<object, KeyValuePair<object, int>>..ctor
	|-Func<object, DateTime>..ctor
	|-Func<object, DateTimeOffset>..ctor
	|-Func<object, Guid>..ctor
	|-Func<object, int>..ctor
	|-Func<object, Int32Enum>..ctor
	|-Func<object, long>..ctor
	|-Func<object, UdpReceiveResult>..ctor
	|-Func<object, Nullable<ServerInfo>>..ctor
	|-Func<object, Nullable<Image>>..ctor
	|-Func<object, Nullable<InventoryPurchaseResult>>..ctor
	|-Func<object, Nullable<InventoryResult>>..ctor
	|-Func<object, Nullable<Item>>..ctor
	|-Func<object, Nullable<ResultPage>>..ctor
	|-Func<object, Nullable<int>>..ctor
	|-Func<object, Nullable<Int32Enum>>..ctor
	|-Func<object, object>..ctor
	|-Func<object, float>..ctor
	|-Func<object, string>..ctor
	|-Func<object, VoidTaskResult>..ctor
	|-Func<object, Type>..ctor
	|-Func<object, uint>..ctor
	|-Func<object, ulong>..ctor
	|-Func<object, Resolution>..ctor
	|-Func<object[], JsonConverter>..ctor
	|-Func<Assembly, IEnumerable<Type>>..ctor
	|-Func<AssemblyName, Assembly>..ctor
	|-Func<ConstructorInfo, bool>..ctor
	|-Func<FieldInfo, bool>..ctor
	|-Func<FieldInfo, int>..ctor
	|-Func<FieldInfo, ParameterOverride>..ctor
	|-Func<MemberInfo, bool>..ctor
	|-Func<MemberInfo, string>..ctor
	|-Func<ParameterInfo, Type>..ctor
	|-Func<PropertyInfo, bool>..ctor
	|-Func<EnumMemberAttribute, string>..ctor
	|-Func<MemberHolder, MemberInfo[]>..ctor
	|-Func<float, bool>..ctor
	|-Func<float, float>..ctor
	|-Func<string, Report.StackTrace.StackFrame>..ctor
	|-Func<string, InventoryRecipe.Ingredient>..ctor
	|-Func<string, InventoryRecipe>..ctor
	|-Func<string, bool>..ctor
	|-Func<string, Guid>..ctor
	|-Func<string, string>..ctor
	|-Func<string, Match>..ctor
	|-Func<string, AssetBundle>..ctor
	|-Func<string, GameObject>..ctor
	|-Func<string, KeyCode>..ctor
	|-Func<Match, bool>..ctor
	|-Func<Match, string>..ctor
	|-Func<Task<Dictionary<string, string>>, Task<Dictionary<string, string>>>..ctor
	|-Func<Type, BidirectionalDictionary<string, string>>..ctor
	|-Func<Type, ReflectionObject>..ctor
	|-Func<Type, bool>..ctor
	|-Func<Type, IEnumerable<MemberInfo>>..ctor
	|-Func<Type, Func<object[], JsonConverter>>..ctor
	|-Func<Type, Tuple<bool, bool, bool, bool>>..ctor
	|-Func<Type, Type>..ctor
	|-Func<uint, bool>..ctor
	|-Func<uint, uint>..ctor
	|-Func<ulong, bool>..ctor
	|-Func<ulong, ulong>..ctor
	|-Func<ValueTuple<ItemDefinition.AmountType, int>, string>..ctor
	|-Func<ValueTuple<Int32Enum, int>, object>..ctor
	|-Func<KerningPair, uint>..ctor
	|-Func<TMP_Character, uint>..ctor
	|-Func<TMP_GlyphPairAdjustmentRecord, uint>..ctor
	|-Func<TechTreeData.NodeInstance, int>..ctor
	|-Func<TechTreeData.NodeInstance, TechTreeData.NodeInstance>..ctor
	|-Func<Animator, string>..ctor
	|-Func<Collider, bool>..ctor
	|-Func<Collider, string>..ctor
	|-Func<GameObject, ItemBlueprint>..ctor
	|-Func<GameObject, ItemDefinition>..ctor
	|-Func<KeyCode, bool>..ctor
	|-Func<KeyCode, string>..ctor
	|-Func<LODGroup, string>..ctor
	|-Func<PlayerEditorConnectionEvents.MessageTypeSubscribers, bool>..ctor
	|-Func<Object, bool>..ctor
	|-Func<Object, Type>..ctor
	|-Func<Renderer, bool>..ctor
	|-Func<Resolution, bool>..ctor
	|-Func<Resolution, int>..ctor
	|-Func<Resolution, Resolution>..ctor
	|-Func<Resolution, Vector2Int>..ctor
	|-Func<Rigidbody, bool>..ctor
	|-Func<Rigidbody, string>..ctor
	|-Func<Glyph, uint>..ctor
	|-Func<Transform, bool>..ctor
	|-Func<Transform, int>..ctor
	|-Func<Transform, object>..ctor
	|-Func<Transform, string>..ctor
	|-Func<Dropdown.OptionData, bool>..ctor
	|-Func<ILayoutElement, float>..ctor
	|-Func<Toggle, SteamInventoryItem>..ctor
	|-Func<Toggle, bool>..ctor
	|-Func<Wearable, bool>..ctor
	|-Func<WeatherPreset, bool>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual TResult Invoke(T arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16D2B30 Offset: 0x16D1130 VA: 0x1816D2B30
	|-Func<Entity.EntityInfo, bool>.Invoke
	|-Func<ItemSkinDirectory.Skin, bool>.Invoke
	|-Func<Option, bool>.Invoke
	|-Func<SkinnedMultiMesh.Part, bool>.Invoke
	|-Func<InventoryItem, FourBitNumber>.Invoke
	|-Func<InventoryItem, SevenBitNumber>.Invoke
	|-Func<InventoryItem, bool>.Invoke
	|
	|-RVA: 0x1B15A40 Offset: 0x1B14040 VA: 0x181B15A40
	|-Func<ArraySegment<byte>, WebSocketHttpRequest>.Invoke
	|-Func<ImageStorageEntity.ImageRequest, object>.Invoke
	|-Func<DefaultSerializationBinder.TypeNameKey, object>.Invoke
	|-Func<ConvertUtils.TypeConvertKey, object>.Invoke
	|-Func<PlayerItemRecipe, long>.Invoke
	|-Func<PlayerItemRecipe, object>.Invoke
	|-Func<ArraySegment<byte>, object>.Invoke
	|-Func<DictionaryEntry, object>.Invoke
	|-Func<KeyValuePair<object, long>, long>.Invoke
	|-Func<KeyValuePair<object, object>, long>.Invoke
	|-Func<KeyValuePair<object, object>, object>.Invoke
	|-Func<KeyValuePair<uint, object>, long>.Invoke
	|-Func<KeyValuePair<uint, object>, object>.Invoke
	|-Func<Guid, object>.Invoke
	|
	|-RVA: 0x19FDF10 Offset: 0x19FC510 VA: 0x1819FDF10
	|-Func<Exception, bool>.Invoke
	|-Func<SimpleAsyncResult, bool>.Invoke
	|-Func<string, bool>.Invoke
	|-Func<object, bool>.Invoke
	|
	|-RVA: 0x212B9C0 Offset: 0x2129FC0 VA: 0x18212B9C0
	|-Func<int, int>.Invoke
	|-Func<Int32Enum, int>.Invoke
	|-Func<Int32Enum, Int32Enum>.Invoke
	|
	|-RVA: 0x212FEE0 Offset: 0x212E4E0 VA: 0x18212FEE0
	|-Func<int, float>.Invoke
	|-Func<Int32Enum, float>.Invoke
	|
	|-RVA: 0x19FB240 Offset: 0x19F9840 VA: 0x1819FB240
	|-Func<object, string>.Invoke
	|-Func<object[], JsonConverter>.Invoke
	|-Func<string, string>.Invoke
	|-Func<string, GameObject>.Invoke
	|-Func<object, object>.Invoke
	|-Func<AssemblyName, Assembly>.Invoke
	|
	|-RVA: 0x18A4B00 Offset: 0x18A3100 VA: 0x1818A4B00
	|-Func<ulong, bool>.Invoke
	|-Func<long, bool>.Invoke
	|
	|-RVA: 0x19FC0C0 Offset: 0x19FA6C0 VA: 0x1819FC0C0
	|-Func<ILayoutElement, float>.Invoke
	|-Func<object, float>.Invoke
	|
	|-RVA: 0x18A4610 Offset: 0x18A2C10 VA: 0x1818A4610
	|-Func<NativeInputUpdateType, bool>.Invoke
	|-Func<int, bool>.Invoke
	|-Func<Int32Enum, bool>.Invoke
	|
	|-RVA: 0x1B95FE0 Offset: 0x1B945E0 VA: 0x181B95FE0
	|-Func<Admin.PlayerInfo, object>.Invoke
	|
	|-RVA: 0x1B94EC0 Offset: 0x1B934C0 VA: 0x181B94EC0
	|-Func<Admin.ServerConvarInfo, object>.Invoke
	|-Func<InventoryRecipe, object>.Invoke
	|-Func<InventoryRecipe.Ingredient, long>.Invoke
	|-Func<InventoryRecipe.Ingredient, object>.Invoke
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, ulong>.Invoke
	|
	|-RVA: 0x1B8DDA0 Offset: 0x1B8C3A0 VA: 0x181B8DDA0
	|-Func<Debugging.EntityInfo, Debugging.EntityInfo>.Invoke
	|-Func<PlayerItemRecipe, Debugging.EntityInfo>.Invoke
	|-Func<PlayerItemRecipe, PlayerItemRecipe>.Invoke
	|-Func<PlayerItemRecipe, KeyValuePair<object, int>>.Invoke
	|-Func<DictionaryEntry, KeyValuePair<object, object>>.Invoke
	|-Func<KeyValuePair<object, int>, KeyValuePair<object, int>>.Invoke
	|-Func<KeyValuePair<object, object>, Debugging.EntityInfo>.Invoke
	|-Func<KeyValuePair<object, object>, KeyValuePair<object, int>>.Invoke
	|-Func<KeyValuePair<uint, object>, Debugging.EntityInfo>.Invoke
	|-Func<KeyValuePair<uint, object>, KeyValuePair<object, int>>.Invoke
	|
	|-RVA: 0x16D24F0 Offset: 0x16D0AF0 VA: 0x1816D24F0
	|-Func<Debugging.EntityInfo, bool>.Invoke
	|-Func<RCon.BannedAddresses, bool>.Invoke
	|-Func<WeightedStringList.Container, bool>.Invoke
	|-Func<GameStat.Stat, bool>.Invoke
	|-Func<PlayerItemRecipe, bool>.Invoke
	|-Func<DictionaryEntry, bool>.Invoke
	|-Func<KeyValuePair<object, int>, bool>.Invoke
	|-Func<KeyValuePair<object, object>, bool>.Invoke
	|-Func<KeyValuePair<uint, object>, bool>.Invoke
	|
	|-RVA: 0x1B92850 Offset: 0x1B90E50 VA: 0x181B92850
	|-Func<Demos.DemoInfo, DateTime>.Invoke
	|-Func<Demos.DemoInfo, TimeSpan>.Invoke
	|-Func<InventoryItem, PathFinder.Point>.Invoke
	|-Func<InventoryItem, InventoryItemId>.Invoke
	|
	|-RVA: 0x1B8EC60 Offset: 0x1B8D260 VA: 0x181B8EC60
	|-Func<Demos.DemoInfo, object>.Invoke
	|-Func<SkinnedMultiMesh.Part, long>.Invoke
	|-Func<InventoryItem, long>.Invoke
	|-Func<InventoryItem, object>.Invoke
	|
	|-RVA: 0x16D2830 Offset: 0x16D0E30 VA: 0x1816D2830
	|-Func<BurstCloth.Chain, FourBitNumber>.Invoke
	|-Func<BurstCloth.Chain, SevenBitNumber>.Invoke
	|-Func<BurstCloth.Chain, bool>.Invoke
	|-Func<PathFinder.Point, bool>.Invoke
	|-Func<PlayerItemRecipe.Ingredient, FourBitNumber>.Invoke
	|-Func<PlayerItemRecipe.Ingredient, SevenBitNumber>.Invoke
	|-Func<PlayerItemRecipe.Ingredient, bool>.Invoke
	|-Func<Achievement, bool>.Invoke
	|-Func<InventoryItemId, bool>.Invoke
	|-Func<Friend, bool>.Invoke
	|
	|-RVA: 0x1B18B10 Offset: 0x1B17110 VA: 0x181B18B10
	|-Func<BurstCloth.Chain, int>.Invoke
	|-Func<PlayerItemRecipe.Ingredient, int>.Invoke
	|
	|-RVA: 0x1B93D50 Offset: 0x1B92350 VA: 0x181B93D50
	|-Func<SkeletonDefinition.Bone, Debugging.EntityInfo>.Invoke
	|-Func<SkeletonDefinition.Bone, KeyValuePair<object, int>>.Invoke
	|
	|-RVA: 0x1B96F10 Offset: 0x1B95510 VA: 0x181B96F10
	|-Func<SkeletonDefinition.Bone, PathFinder.Point>.Invoke
	|-Func<InventoryItem.Amount, InventoryItemId>.Invoke
	|
	|-RVA: 0x1B941F0 Offset: 0x1B927F0 VA: 0x181B941F0
	|-Func<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<SkeletonDefinition.Bone, Resolution>.Invoke
	|
	|-RVA: 0x1B8D510 Offset: 0x1B8BB10 VA: 0x181B8D510
	|-Func<SkeletonDefinition.Bone, Option>.Invoke
	|-Func<SkeletonDefinition.Bone, InventoryItem>.Invoke
	|
	|-RVA: 0x1B93590 Offset: 0x1B91B90 VA: 0x181B93590
	|-Func<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.Invoke
	|-Func<SkeletonDefinition.Bone, InventoryRecipe>.Invoke
	|
	|-RVA: 0x16D34A0 Offset: 0x16D1AA0 VA: 0x1816D34A0
	|-Func<SkeletonDefinition.Bone, bool>.Invoke
	|-Func<InventoryItem.Amount, bool>.Invoke
	|
	|-RVA: 0x1B93A20 Offset: 0x1B92020 VA: 0x181B93A20
	|-Func<SkeletonDefinition.Bone, int>.Invoke
	|-Func<SkeletonDefinition.Bone, Int32Enum>.Invoke
	|
	|-RVA: 0x1B8E120 Offset: 0x1B8C720 VA: 0x181B8E120
	|-Func<SkeletonDefinition.Bone, long>.Invoke
	|-Func<SkeletonDefinition.Bone, object>.Invoke
	|
	|-RVA: 0x1B8D990 Offset: 0x1B8BF90 VA: 0x181B8D990
	|-Func<SkeletonDefinition.Bone, float>.Invoke
	|
	|-RVA: 0x1B91E10 Offset: 0x1B90410 VA: 0x181B91E10
	|-Func<WeightedStringList.Container, float>.Invoke
	|-Func<PlayerItemRecipe, float>.Invoke
	|-Func<KeyValuePair<object, object>, float>.Invoke
	|-Func<KeyValuePair<uint, object>, float>.Invoke
	|
	|-RVA: 0x18A8110 Offset: 0x18A6710 VA: 0x1818A8110
	|-Func<FourBitNumber, FourBitNumber>.Invoke
	|-Func<FourBitNumber, bool>.Invoke
	|-Func<SevenBitNumber, SevenBitNumber>.Invoke
	|-Func<SevenBitNumber, bool>.Invoke
	|
	|-RVA: 0x1B95970 Offset: 0x1B93F70 VA: 0x181B95970
	|-Func<SevenBitNumber, object>.Invoke
	|
	|-RVA: 0x1B94BC0 Offset: 0x1B931C0 VA: 0x181B94BC0
	|-Func<PathFinder.Point, PathFinder.Point>.Invoke
	|-Func<PlayerItemRecipe.Ingredient, PlayerItemRecipe.Ingredient>.Invoke
	|-Func<Achievement, PathFinder.Point>.Invoke
	|-Func<InventoryItemId, InventoryItemId>.Invoke
	|-Func<Friend, PathFinder.Point>.Invoke
	|
	|-RVA: 0x16D4470 Offset: 0x16D2A70 VA: 0x1816D4470
	|-Func<PetCommandList.PetCommandDesc, bool>.Invoke
	|
	|-RVA: 0x1B8F8E0 Offset: 0x1B8DEE0 VA: 0x181B8F8E0
	|-Func<PlayerItemRecipe, PathFinder.Point>.Invoke
	|-Func<KeyValuePair<object, object>, PathFinder.Point>.Invoke
	|-Func<KeyValuePair<uint, object>, PathFinder.Point>.Invoke
	|
	|-RVA: 0x1B90CC0 Offset: 0x1B8F2C0 VA: 0x181B90CC0
	|-Func<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<PlayerItemRecipe, Resolution>.Invoke
	|-Func<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<KeyValuePair<object, object>, Resolution>.Invoke
	|-Func<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<KeyValuePair<uint, object>, Resolution>.Invoke
	|
	|-RVA: 0x1B90640 Offset: 0x1B8EC40 VA: 0x181B90640
	|-Func<PlayerItemRecipe, Option>.Invoke
	|-Func<PlayerItemRecipe, InventoryItem>.Invoke
	|-Func<KeyValuePair<object, object>, Option>.Invoke
	|-Func<KeyValuePair<object, object>, InventoryItem>.Invoke
	|-Func<KeyValuePair<uint, object>, Option>.Invoke
	|-Func<KeyValuePair<uint, object>, InventoryItem>.Invoke
	|
	|-RVA: 0x1B90980 Offset: 0x1B8EF80 VA: 0x181B90980
	|-Func<PlayerItemRecipe, InventoryRecipe.Ingredient>.Invoke
	|-Func<PlayerItemRecipe, InventoryRecipe>.Invoke
	|-Func<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.Invoke
	|-Func<KeyValuePair<object, object>, InventoryRecipe>.Invoke
	|-Func<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.Invoke
	|-Func<KeyValuePair<uint, object>, InventoryRecipe>.Invoke
	|
	|-RVA: 0x1B932D0 Offset: 0x1B918D0 VA: 0x181B932D0
	|-Func<PlayerItemRecipe, int>.Invoke
	|-Func<PlayerItemRecipe, Int32Enum>.Invoke
	|-Func<KeyValuePair<object, object>, int>.Invoke
	|-Func<KeyValuePair<object, object>, Int32Enum>.Invoke
	|-Func<KeyValuePair<uint, object>, int>.Invoke
	|-Func<KeyValuePair<uint, object>, Int32Enum>.Invoke
	|
	|-RVA: 0x19FB9F0 Offset: 0x19F9FF0 VA: 0x1819FB9F0
	|-Func<ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<Resolution, Resolution>.Invoke
	|
	|-RVA: 0x16D4DC0 Offset: 0x16D33C0 VA: 0x1816D4DC0
	|-Func<ProjectileWeaponMod.Modifier, bool>.Invoke
	|-Func<Resolution, bool>.Invoke
	|
	|-RVA: 0x1B955C0 Offset: 0x1B93BC0 VA: 0x181B955C0
	|-Func<ProjectileWeaponMod.Modifier, float>.Invoke
	|
	|-RVA: 0x1B96490 Offset: 0x1B94A90 VA: 0x181B96490
	|-Func<Option, Option>.Invoke
	|-Func<InventoryItem, Option>.Invoke
	|-Func<InventoryItem, InventoryItem>.Invoke
	|
	|-RVA: 0x1B92150 Offset: 0x1B90750 VA: 0x181B92150
	|-Func<ServerInfo, Debugging.EntityInfo>.Invoke
	|-Func<ServerInfo, KeyValuePair<object, int>>.Invoke
	|
	|-RVA: 0x18A3F50 Offset: 0x18A2550 VA: 0x1818A3F50
	|-Func<ServerInfo, FourBitNumber>.Invoke
	|-Func<ServerInfo, SevenBitNumber>.Invoke
	|-Func<ServerInfo, bool>.Invoke
	|-Func<ServerInfo, bool>.Invoke
	|
	|-RVA: 0x1B92C20 Offset: 0x1B91220 VA: 0x181B92C20
	|-Func<ServerInfo, PathFinder.Point>.Invoke
	|
	|-RVA: 0x1B91040 Offset: 0x1B8F640 VA: 0x181B91040
	|-Func<ServerInfo, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<ServerInfo, Resolution>.Invoke
	|
	|-RVA: 0x1B8E570 Offset: 0x1B8CB70 VA: 0x181B8E570
	|-Func<ServerInfo, Option>.Invoke
	|-Func<ServerInfo, InventoryItem>.Invoke
	|
	|-RVA: 0x1B8FF50 Offset: 0x1B8E550 VA: 0x181B8FF50
	|-Func<ServerInfo, InventoryRecipe.Ingredient>.Invoke
	|-Func<ServerInfo, InventoryRecipe>.Invoke
	|
	|-RVA: 0x1B94690 Offset: 0x1B92C90 VA: 0x181B94690
	|-Func<ServerInfo, int>.Invoke
	|-Func<ServerInfo, Int32Enum>.Invoke
	|
	|-RVA: 0x1B8F020 Offset: 0x1B8D620 VA: 0x181B8F020
	|-Func<ServerInfo, long>.Invoke
	|-Func<ServerInfo, object>.Invoke
	|-Func<ServerInfo, object>.Invoke
	|
	|-RVA: 0x1B97350 Offset: 0x1B95950 VA: 0x181B97350
	|-Func<ServerInfo, float>.Invoke
	|
	|-RVA: 0x1B91750 Offset: 0x1B8FD50 VA: 0x181B91750
	|-Func<ServerInfo, uint>.Invoke
	|-Func<ServerInfo, int>.Invoke
	|
	|-RVA: 0x1B968A0 Offset: 0x1B94EA0 VA: 0x181B968A0
	|-Func<Achievement, Debugging.EntityInfo>.Invoke
	|-Func<Achievement, KeyValuePair<object, int>>.Invoke
	|-Func<Friend, Debugging.EntityInfo>.Invoke
	|-Func<Friend, KeyValuePair<object, int>>.Invoke
	|
	|-RVA: 0x1B95C70 Offset: 0x1B94270 VA: 0x181B95C70
	|-Func<Achievement, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<Achievement, Resolution>.Invoke
	|-Func<Friend, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<Friend, Resolution>.Invoke
	|
	|-RVA: 0x1B8FC20 Offset: 0x1B8E220 VA: 0x181B8FC20
	|-Func<Achievement, Option>.Invoke
	|-Func<Achievement, InventoryItem>.Invoke
	|-Func<Friend, Option>.Invoke
	|-Func<Friend, InventoryItem>.Invoke
	|
	|-RVA: 0x1B95290 Offset: 0x1B93890 VA: 0x181B95290
	|-Func<Achievement, InventoryRecipe.Ingredient>.Invoke
	|-Func<Achievement, InventoryRecipe>.Invoke
	|-Func<Friend, InventoryRecipe.Ingredient>.Invoke
	|-Func<Friend, InventoryRecipe>.Invoke
	|
	|-RVA: 0x1B8F6E0 Offset: 0x1B8DCE0 VA: 0x181B8F6E0
	|-Func<Achievement, int>.Invoke
	|-Func<Achievement, Int32Enum>.Invoke
	|-Func<Friend, int>.Invoke
	|-Func<Friend, Int32Enum>.Invoke
	|
	|-RVA: 0x19FD190 Offset: 0x19FB790 VA: 0x1819FD190
	|-Func<Achievement, long>.Invoke
	|-Func<Achievement, object>.Invoke
	|-Func<Friend, long>.Invoke
	|-Func<Friend, object>.Invoke
	|-Func<ValueTuple<Int32Enum, int>, object>.Invoke
	|
	|-RVA: 0x1B96C10 Offset: 0x1B95210 VA: 0x181B96C10
	|-Func<Achievement, float>.Invoke
	|-Func<Friend, float>.Invoke
	|
	|-RVA: 0x212E650 Offset: 0x212CC50 VA: 0x18212E650
	|-Func<InventoryDefId, Debugging.EntityInfo>.Invoke
	|-Func<InventoryDefId, KeyValuePair<object, int>>.Invoke
	|
	|-RVA: 0x212CA70 Offset: 0x212B070 VA: 0x18212CA70
	|-Func<InventoryDefId, PathFinder.Point>.Invoke
	|
	|-RVA: 0x212BBC0 Offset: 0x212A1C0 VA: 0x18212BBC0
	|-Func<InventoryDefId, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<InventoryDefId, Resolution>.Invoke
	|
	|-RVA: 0x212FBB0 Offset: 0x212E1B0 VA: 0x18212FBB0
	|-Func<InventoryDefId, Option>.Invoke
	|-Func<InventoryDefId, InventoryItem>.Invoke
	|
	|-RVA: 0x212D410 Offset: 0x212BA10 VA: 0x18212D410
	|-Func<InventoryDefId, InventoryRecipe.Ingredient>.Invoke
	|-Func<InventoryDefId, InventoryRecipe>.Invoke
	|
	|-RVA: 0x18A69E0 Offset: 0x18A4FE0 VA: 0x1818A69E0
	|-Func<InventoryDefId, bool>.Invoke
	|
	|-RVA: 0x2130800 Offset: 0x212EE00 VA: 0x182130800
	|-Func<InventoryDefId, int>.Invoke
	|-Func<InventoryDefId, Int32Enum>.Invoke
	|
	|-RVA: 0x212F500 Offset: 0x212DB00 VA: 0x18212F500
	|-Func<InventoryDefId, long>.Invoke
	|-Func<InventoryDefId, object>.Invoke
	|
	|-RVA: 0x2132A80 Offset: 0x2131080 VA: 0x182132A80
	|-Func<InventoryDefId, float>.Invoke
	|
	|-RVA: 0x212BF30 Offset: 0x212A530 VA: 0x18212BF30
	|-Func<ServerInfo, ServerInfo>.Invoke
	|
	|-RVA: 0x2131C10 Offset: 0x2130210 VA: 0x182131C10
	|-Func<InventoryItem, Debugging.EntityInfo>.Invoke
	|-Func<InventoryItem, KeyValuePair<object, int>>.Invoke
	|
	|-RVA: 0x212E240 Offset: 0x212C840 VA: 0x18212E240
	|-Func<InventoryItem, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<InventoryItem, Resolution>.Invoke
	|
	|-RVA: 0x212F7F0 Offset: 0x212DDF0 VA: 0x18212F7F0
	|-Func<InventoryItem, InventoryDefId>.Invoke
	|-Func<InventoryItem, uint>.Invoke
	|
	|-RVA: 0x212DAE0 Offset: 0x212C0E0 VA: 0x18212DAE0
	|-Func<InventoryItem, InventoryRecipe.Ingredient>.Invoke
	|-Func<InventoryItem, InventoryRecipe>.Invoke
	|
	|-RVA: 0x212D0E0 Offset: 0x212B6E0 VA: 0x18212D0E0
	|-Func<InventoryItem, int>.Invoke
	|-Func<InventoryItem, Int32Enum>.Invoke
	|
	|-RVA: 0x212D740 Offset: 0x212BD40 VA: 0x18212D740
	|-Func<InventoryItem, float>.Invoke
	|
	|-RVA: 0x2132630 Offset: 0x2130C30 VA: 0x182132630
	|-Func<InventoryItem.Amount, uint>.Invoke
	|
	|-RVA: 0x212B5C0 Offset: 0x2129BC0 VA: 0x18212B5C0
	|-Func<InventoryRecipe, PlayerItemRecipe>.Invoke
	|-Func<InventoryRecipe.Ingredient, Debugging.EntityInfo>.Invoke
	|-Func<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.Invoke
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, Dispatch.ResultCallback>.Invoke
	|
	|-RVA: 0x212C670 Offset: 0x212AC70 VA: 0x18212C670
	|-Func<InventoryRecipe, InventoryRecipe>.Invoke
	|-Func<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.Invoke
	|-Func<InventoryRecipe.Ingredient, InventoryRecipe>.Invoke
	|
	|-RVA: 0x16D40B0 Offset: 0x16D26B0 VA: 0x1816D40B0
	|-Func<InventoryRecipe, bool>.Invoke
	|-Func<InventoryRecipe.Ingredient, bool>.Invoke
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, bool>.Invoke
	|
	|-RVA: 0x2130C00 Offset: 0x212F200 VA: 0x182130C00
	|-Func<InventoryRecipe.Ingredient, PathFinder.Point>.Invoke
	|-Func<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.Invoke
	|
	|-RVA: 0x212ECF0 Offset: 0x212D2F0 VA: 0x18212ECF0
	|-Func<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<InventoryRecipe.Ingredient, Resolution>.Invoke
	|
	|-RVA: 0x212F100 Offset: 0x212D700 VA: 0x18212F100
	|-Func<InventoryRecipe.Ingredient, Option>.Invoke
	|-Func<InventoryRecipe.Ingredient, InventoryItem>.Invoke
	|
	|-RVA: 0x212DEF0 Offset: 0x212C4F0 VA: 0x18212DEF0
	|-Func<InventoryRecipe.Ingredient, int>.Invoke
	|-Func<InventoryRecipe.Ingredient, Int32Enum>.Invoke
	|
	|-RVA: 0x21300E0 Offset: 0x212E6E0 VA: 0x1821300E0
	|-Func<InventoryRecipe.Ingredient, float>.Invoke
	|
	|-RVA: 0x2131300 Offset: 0x212F900 VA: 0x182131300
	|-Func<Item, DateTime>.Invoke
	|
	|-RVA: 0x18A3850 Offset: 0x18A1E50 VA: 0x1818A3850
	|-Func<bool, bool>.Invoke
	|
	|-RVA: 0x18A6190 Offset: 0x18A4790 VA: 0x1818A6190
	|-Func<char, bool>.Invoke
	|
	|-RVA: 0x1B17200 Offset: 0x1B15800 VA: 0x181B17200
	|-Func<KeyValuePair<object, int>, int>.Invoke
	|-Func<KeyValuePair<uint, object>, uint>.Invoke
	|-Func<Guid, int>.Invoke
	|
	|-RVA: 0x2132020 Offset: 0x2130620 VA: 0x182132020
	|-Func<double, double>.Invoke
	|
	|-RVA: 0x146DE40 Offset: 0x146C440 VA: 0x18146DE40
	|-Func<int, FourBitNumber>.Invoke
	|-Func<int, SevenBitNumber>.Invoke
	|-Func<uint, bool>.Invoke
	|
	|-RVA: 0x2130A00 Offset: 0x212F000 VA: 0x182130A00
	|-Func<int, object>.Invoke
	|-Func<Int32Enum, object>.Invoke
	|
	|-RVA: 0x2130490 Offset: 0x212EA90 VA: 0x182130490
	|-Func<Int32Enum, Debugging.EntityInfo>.Invoke
	|-Func<Int32Enum, KeyValuePair<object, int>>.Invoke
	|
	|-RVA: 0x2132330 Offset: 0x2130930 VA: 0x182132330
	|-Func<Int32Enum, PathFinder.Point>.Invoke
	|
	|-RVA: 0x212CD70 Offset: 0x212B370 VA: 0x18212CD70
	|-Func<Int32Enum, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<Int32Enum, Resolution>.Invoke
	|
	|-RVA: 0x2130FD0 Offset: 0x212F5D0 VA: 0x182130FD0
	|-Func<Int32Enum, Option>.Invoke
	|-Func<Int32Enum, InventoryItem>.Invoke
	|
	|-RVA: 0x212E9C0 Offset: 0x212CFC0 VA: 0x18212E9C0
	|-Func<Int32Enum, InventoryRecipe.Ingredient>.Invoke
	|-Func<Int32Enum, InventoryRecipe>.Invoke
	|
	|-RVA: 0x20C7840 Offset: 0x20C5E40 VA: 0x1820C7840
	|-Func<Int32Enum, long>.Invoke
	|
	|-RVA: 0x19FAAB0 Offset: 0x19F90B0 VA: 0x1819FAAB0
	|-Func<long, long>.Invoke
	|-Func<IntPtr, object>.Invoke
	|-Func<ulong, ulong>.Invoke
	|
	|-RVA: 0x19F9670 Offset: 0x19F7C70 VA: 0x1819F9670
	|-Func<object, Debugging.EntityInfo>.Invoke
	|-Func<object, PlayerItemRecipe>.Invoke
	|-Func<object, KeyValuePair<object, int>>.Invoke
	|-Func<object, DateTimeOffset>.Invoke
	|-Func<object, Guid>.Invoke
	|-Func<object, UdpReceiveResult>.Invoke
	|
	|-RVA: 0x1786050 Offset: 0x1784650 VA: 0x181786050
	|-Func<object, FourBitNumber>.Invoke
	|-Func<object, SevenBitNumber>.Invoke
	|
	|-RVA: 0x19FB570 Offset: 0x19F9B70 VA: 0x1819FB570
	|-Func<object, PathFinder.Point>.Invoke
	|-Func<object, PlayerItemRecipe.Ingredient>.Invoke
	|-Func<object, DateTime>.Invoke
	|-Func<object, Nullable<int>>.Invoke
	|-Func<object, Nullable<Int32Enum>>.Invoke
	|
	|-RVA: 0x19F9BB0 Offset: 0x19F81B0 VA: 0x1819F9BB0
	|-Func<object, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<object, Nullable<InventoryResult>>.Invoke
	|-Func<object, Resolution>.Invoke
	|
	|-RVA: 0x19F91E0 Offset: 0x19F77E0 VA: 0x1819F91E0
	|-Func<object, Option>.Invoke
	|-Func<object, InventoryItem>.Invoke
	|-Func<object, Nullable<InventoryPurchaseResult>>.Invoke
	|-Func<object, Nullable<ResultPage>>.Invoke
	|
	|-RVA: 0x19FA0F0 Offset: 0x19F86F0 VA: 0x1819FA0F0
	|-Func<object, InventoryDefId>.Invoke
	|-Func<object, uint>.Invoke
	|
	|-RVA: 0x148C340 Offset: 0x148A940 VA: 0x18148C340
	|-Func<object, InventoryItemId>.Invoke
	|
	|-RVA: 0x19FADB0 Offset: 0x19F93B0 VA: 0x1819FADB0
	|-Func<object, InventoryRecipe.Ingredient>.Invoke
	|-Func<object, InventoryRecipe>.Invoke
	|-Func<object, PublishResult>.Invoke
	|-Func<object, Nullable<Image>>.Invoke
	|
	|-RVA: 0x19FA500 Offset: 0x19F8B00 VA: 0x1819FA500
	|-Func<object, int>.Invoke
	|-Func<object, Int32Enum>.Invoke
	|
	|-RVA: 0x1477A60 Offset: 0x1476060 VA: 0x181477A60
	|-Func<object, long>.Invoke
	|
	|-RVA: 0x19FC550 Offset: 0x19FAB50 VA: 0x1819FC550
	|-Func<object, Nullable<ServerInfo>>.Invoke
	|
	|-RVA: 0x19FD490 Offset: 0x19FBA90 VA: 0x1819FD490
	|-Func<object, Nullable<Item>>.Invoke
	|
	|-RVA: 0x19FE310 Offset: 0x19FC910 VA: 0x1819FE310
	|-Func<object, VoidTaskResult>.Invoke
	|
	|-RVA: 0x133B5E0 Offset: 0x1339BE0 VA: 0x18133B5E0
	|-Func<object, ulong>.Invoke
	|
	|-RVA: 0x18A4810 Offset: 0x18A2E10 VA: 0x1818A4810
	|-Func<float, bool>.Invoke
	|
	|-RVA: 0x19FBDD0 Offset: 0x19FA3D0 VA: 0x1819FBDD0
	|-Func<float, float>.Invoke
	|
	|-RVA: 0x19FA7C0 Offset: 0x19F8DC0 VA: 0x1819FA7C0
	|-Func<uint, uint>.Invoke
	|
	|-RVA: 0x19FCDF0 Offset: 0x19FB3F0 VA: 0x1819FCDF0
	|-Func<Resolution, int>.Invoke
	|
	|-RVA: 0x19FCA50 Offset: 0x19FB050 VA: 0x1819FCA50
	|-Func<Resolution, Vector2Int>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(T arg, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B8CA90 Offset: 0x1B8B090 VA: 0x181B8CA90
	|-Func<Admin.PlayerInfo, object>.BeginInvoke
	|
	|-RVA: 0x1B8B110 Offset: 0x1B89710 VA: 0x181B8B110
	|-Func<Admin.ServerConvarInfo, object>.BeginInvoke
	|
	|-RVA: 0x1B8B810 Offset: 0x1B89E10 VA: 0x181B8B810
	|-Func<Debugging.EntityInfo, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x1B8D090 Offset: 0x1B8B690 VA: 0x181B8D090
	|-Func<Debugging.EntityInfo, bool>.BeginInvoke
	|
	|-RVA: 0x1B8C190 Offset: 0x1B8A790 VA: 0x181B8C190
	|-Func<Entity.EntityInfo, bool>.BeginInvoke
	|
	|-RVA: 0x1B8C090 Offset: 0x1B8A690 VA: 0x181B8C090
	|-Func<Demos.DemoInfo, DateTime>.BeginInvoke
	|
	|-RVA: 0x1B8BC10 Offset: 0x1B8A210 VA: 0x181B8BC10
	|-Func<Demos.DemoInfo, object>.BeginInvoke
	|
	|-RVA: 0x1B8C110 Offset: 0x1B8A710 VA: 0x181B8C110
	|-Func<Demos.DemoInfo, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x1B8BE90 Offset: 0x1B8A490 VA: 0x181B8BE90
	|-Func<BurstCloth.Chain, FourBitNumber>.BeginInvoke
	|
	|-RVA: 0x1B8D490 Offset: 0x1B8BA90 VA: 0x181B8D490
	|-Func<BurstCloth.Chain, SevenBitNumber>.BeginInvoke
	|
	|-RVA: 0x1B8AE90 Offset: 0x1B89490 VA: 0x181B8AE90
	|-Func<BurstCloth.Chain, bool>.BeginInvoke
	|
	|-RVA: 0x1B8AC90 Offset: 0x1B89290 VA: 0x181B8AC90
	|-Func<BurstCloth.Chain, int>.BeginInvoke
	|
	|-RVA: 0x1B8B210 Offset: 0x1B89810 VA: 0x181B8B210
	|-Func<RCon.BannedAddresses, bool>.BeginInvoke
	|
	|-RVA: 0x1B8B790 Offset: 0x1B89D90 VA: 0x181B8B790
	|-Func<SkeletonDefinition.Bone, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x1B8BA90 Offset: 0x1B8A090 VA: 0x181B8BA90
	|-Func<SkeletonDefinition.Bone, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x1B8AC10 Offset: 0x1B89210 VA: 0x181B8AC10
	|-Func<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x1B8C810 Offset: 0x1B8AE10 VA: 0x181B8C810
	|-Func<SkeletonDefinition.Bone, Option>.BeginInvoke
	|
	|-RVA: 0x1B8C690 Offset: 0x1B8AC90 VA: 0x181B8C690
	|-Func<SkeletonDefinition.Bone, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x1B8CA10 Offset: 0x1B8B010 VA: 0x181B8CA10
	|-Func<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x1B8AA90 Offset: 0x1B89090 VA: 0x181B8AA90
	|-Func<SkeletonDefinition.Bone, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x1B8C910 Offset: 0x1B8AF10 VA: 0x181B8C910
	|-Func<SkeletonDefinition.Bone, bool>.BeginInvoke
	|
	|-RVA: 0x1B8BF90 Offset: 0x1B8A590 VA: 0x181B8BF90
	|-Func<SkeletonDefinition.Bone, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x1B8B890 Offset: 0x1B89E90 VA: 0x181B8B890
	|-Func<SkeletonDefinition.Bone, int>.BeginInvoke
	|
	|-RVA: 0x1B8C610 Offset: 0x1B8AC10 VA: 0x181B8C610
	|-Func<SkeletonDefinition.Bone, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x1B8CF10 Offset: 0x1B8B510 VA: 0x181B8CF10
	|-Func<SkeletonDefinition.Bone, long>.BeginInvoke
	|
	|-RVA: 0x1B8BC90 Offset: 0x1B8A290 VA: 0x181B8BC90
	|-Func<SkeletonDefinition.Bone, object>.BeginInvoke
	|
	|-RVA: 0x1B8CD10 Offset: 0x1B8B310 VA: 0x181B8CD10
	|-Func<SkeletonDefinition.Bone, float>.BeginInvoke
	|
	|-RVA: 0x1B8BD90 Offset: 0x1B8A390 VA: 0x181B8BD90
	|-Func<SkeletonDefinition.Bone, Resolution>.BeginInvoke
	|
	|-RVA: 0x1B8A810 Offset: 0x1B88E10 VA: 0x181B8A810
	|-Func<WeightedStringList.Container, bool>.BeginInvoke
	|
	|-RVA: 0x1B8D310 Offset: 0x1B8B910 VA: 0x181B8D310
	|-Func<WeightedStringList.Container, float>.BeginInvoke
	|
	|-RVA: 0x1B8A210 Offset: 0x1B88810 VA: 0x181B8A210
	|-Func<GameStat.Stat, bool>.BeginInvoke
	|
	|-RVA: 0x1B8A190 Offset: 0x1B88790 VA: 0x181B8A190
	|-Func<ImageStorageEntity.ImageRequest, object>.BeginInvoke
	|
	|-RVA: 0x1B8D110 Offset: 0x1B8B710 VA: 0x181B8D110
	|-Func<ItemSkinDirectory.Skin, bool>.BeginInvoke
	|
	|-RVA: 0x1B8B190 Offset: 0x1B89790 VA: 0x181B8B190
	|-Func<FourBitNumber, FourBitNumber>.BeginInvoke
	|
	|-RVA: 0x1B8AF90 Offset: 0x1B89590 VA: 0x181B8AF90
	|-Func<FourBitNumber, bool>.BeginInvoke
	|
	|-RVA: 0x1B8C710 Offset: 0x1B8AD10 VA: 0x181B8C710
	|-Func<SevenBitNumber, SevenBitNumber>.BeginInvoke
	|
	|-RVA: 0x1B8C490 Offset: 0x1B8AA90 VA: 0x181B8C490
	|-Func<SevenBitNumber, bool>.BeginInvoke
	|
	|-RVA: 0x1B8A790 Offset: 0x1B88D90 VA: 0x181B8A790
	|-Func<SevenBitNumber, object>.BeginInvoke
	|
	|-RVA: 0x1B8CD90 Offset: 0x1B8B390 VA: 0x181B8CD90
	|-Func<DefaultSerializationBinder.TypeNameKey, object>.BeginInvoke
	|
	|-RVA: 0x1B8A990 Offset: 0x1B88F90 VA: 0x181B8A990
	|-Func<ConvertUtils.TypeConvertKey, object>.BeginInvoke
	|
	|-RVA: 0x1B8CE90 Offset: 0x1B8B490 VA: 0x181B8CE90
	|-Func<PathFinder.Point, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x1B8B310 Offset: 0x1B89910 VA: 0x181B8B310
	|-Func<PathFinder.Point, bool>.BeginInvoke
	|
	|-RVA: 0x1B8B590 Offset: 0x1B89B90 VA: 0x181B8B590
	|-Func<PetCommandList.PetCommandDesc, bool>.BeginInvoke
	|
	|-RVA: 0x1B8A410 Offset: 0x1B88A10 VA: 0x181B8A410
	|-Func<PlayerItemRecipe, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x1B8A710 Offset: 0x1B88D10 VA: 0x181B8A710
	|-Func<PlayerItemRecipe, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x1B8B290 Offset: 0x1B89890 VA: 0x181B8B290
	|-Func<PlayerItemRecipe, PlayerItemRecipe>.BeginInvoke
	|
	|-RVA: 0x1B8A610 Offset: 0x1B88C10 VA: 0x181B8A610
	|-Func<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x1B8B990 Offset: 0x1B89F90 VA: 0x181B8B990
	|-Func<PlayerItemRecipe, Option>.BeginInvoke
	|
	|-RVA: 0x1B8CB90 Offset: 0x1B8B190 VA: 0x181B8CB90
	|-Func<PlayerItemRecipe, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x1B8AB90 Offset: 0x1B89190 VA: 0x181B8AB90
	|-Func<PlayerItemRecipe, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x1B8A910 Offset: 0x1B88F10 VA: 0x181B8A910
	|-Func<PlayerItemRecipe, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x1B8B690 Offset: 0x1B89C90 VA: 0x181B8B690
	|-Func<PlayerItemRecipe, bool>.BeginInvoke
	|
	|-RVA: 0x1B8AA10 Offset: 0x1B89010 VA: 0x181B8AA10
	|-Func<PlayerItemRecipe, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x1B8C310 Offset: 0x1B8A910 VA: 0x181B8C310
	|-Func<PlayerItemRecipe, int>.BeginInvoke
	|
	|-RVA: 0x1B8A690 Offset: 0x1B88C90 VA: 0x181B8A690
	|-Func<PlayerItemRecipe, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x1B8C010 Offset: 0x1B8A610 VA: 0x181B8C010
	|-Func<PlayerItemRecipe, long>.BeginInvoke
	|
	|-RVA: 0x1B8B410 Offset: 0x1B89A10 VA: 0x181B8B410
	|-Func<PlayerItemRecipe, object>.BeginInvoke
	|
	|-RVA: 0x1B8C390 Offset: 0x1B8A990 VA: 0x181B8C390
	|-Func<PlayerItemRecipe, float>.BeginInvoke
	|
	|-RVA: 0x1B8A390 Offset: 0x1B88990 VA: 0x181B8A390
	|-Func<PlayerItemRecipe, Resolution>.BeginInvoke
	|
	|-RVA: 0x1B8BB90 Offset: 0x1B8A190 VA: 0x181B8BB90
	|-Func<PlayerItemRecipe.Ingredient, FourBitNumber>.BeginInvoke
	|
	|-RVA: 0x1B8B910 Offset: 0x1B89F10 VA: 0x181B8B910
	|-Func<PlayerItemRecipe.Ingredient, SevenBitNumber>.BeginInvoke
	|
	|-RVA: 0x1B8AB10 Offset: 0x1B89110 VA: 0x181B8AB10
	|-Func<PlayerItemRecipe.Ingredient, PlayerItemRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x1B8CC90 Offset: 0x1B8B290 VA: 0x181B8CC90
	|-Func<PlayerItemRecipe.Ingredient, bool>.BeginInvoke
	|
	|-RVA: 0x1B8B090 Offset: 0x1B89690 VA: 0x181B8B090
	|-Func<PlayerItemRecipe.Ingredient, int>.BeginInvoke
	|
	|-RVA: 0x1B8BD10 Offset: 0x1B8A310 VA: 0x181B8BD10
	|-Func<ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x1B8A490 Offset: 0x1B88A90 VA: 0x181B8A490
	|-Func<ProjectileWeaponMod.Modifier, bool>.BeginInvoke
	|
	|-RVA: 0x1B8CF90 Offset: 0x1B8B590 VA: 0x181B8CF90
	|-Func<ProjectileWeaponMod.Modifier, float>.BeginInvoke
	|
	|-RVA: 0x1B8D010 Offset: 0x1B8B610 VA: 0x181B8D010
	|-Func<Option, Option>.BeginInvoke
	|
	|-RVA: 0x1B8D410 Offset: 0x1B8BA10 VA: 0x181B8D410
	|-Func<Option, bool>.BeginInvoke
	|
	|-RVA: 0x1B8B610 Offset: 0x1B89C10 VA: 0x181B8B610
	|-Func<ServerInfo, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x1B8AD90 Offset: 0x1B89390 VA: 0x181B8AD90
	|-Func<ServerInfo, FourBitNumber>.BeginInvoke
	|
	|-RVA: 0x1B8BA10 Offset: 0x1B8A010 VA: 0x181B8BA10
	|-Func<ServerInfo, SevenBitNumber>.BeginInvoke
	|
	|-RVA: 0x1B8AF10 Offset: 0x1B89510 VA: 0x181B8AF10
	|-Func<ServerInfo, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x1B8AD10 Offset: 0x1B89310 VA: 0x181B8AD10
	|-Func<ServerInfo, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x1B8A310 Offset: 0x1B88910 VA: 0x181B8A310
	|-Func<ServerInfo, Option>.BeginInvoke
	|
	|-RVA: 0x1B8C510 Offset: 0x1B8AB10 VA: 0x181B8C510
	|-Func<ServerInfo, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x1B8B390 Offset: 0x1B89990 VA: 0x181B8B390
	|-Func<ServerInfo, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x1B8A290 Offset: 0x1B88890 VA: 0x181B8A290
	|-Func<ServerInfo, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x1B8CE10 Offset: 0x1B8B410 VA: 0x181B8CE10
	|-Func<ServerInfo, bool>.BeginInvoke
	|
	|-RVA: 0x1B8BF10 Offset: 0x1B8A510 VA: 0x181B8BF10
	|-Func<ServerInfo, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x1B8CC10 Offset: 0x1B8B210 VA: 0x181B8CC10
	|-Func<ServerInfo, int>.BeginInvoke
	|
	|-RVA: 0x1B8C590 Offset: 0x1B8AB90 VA: 0x181B8C590
	|-Func<ServerInfo, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x1B8BE10 Offset: 0x1B8A410 VA: 0x181B8BE10
	|-Func<ServerInfo, long>.BeginInvoke
	|
	|-RVA: 0x1B8C790 Offset: 0x1B8AD90 VA: 0x181B8C790
	|-Func<ServerInfo, object>.BeginInvoke
	|
	|-RVA: 0x1B8AE10 Offset: 0x1B89410 VA: 0x181B8AE10
	|-Func<ServerInfo, float>.BeginInvoke
	|
	|-RVA: 0x1B8BB10 Offset: 0x1B8A110 VA: 0x181B8BB10
	|-Func<ServerInfo, uint>.BeginInvoke
	|
	|-RVA: 0x1B8A590 Offset: 0x1B88B90 VA: 0x181B8A590
	|-Func<ServerInfo, Resolution>.BeginInvoke
	|
	|-RVA: 0x1B8C890 Offset: 0x1B8AE90 VA: 0x181B8C890
	|-Func<SkinnedMultiMesh.Part, bool>.BeginInvoke
	|
	|-RVA: 0x1B8C290 Offset: 0x1B8A890 VA: 0x181B8C290
	|-Func<SkinnedMultiMesh.Part, long>.BeginInvoke
	|
	|-RVA: 0x1B8D390 Offset: 0x1B8B990 VA: 0x181B8D390
	|-Func<Achievement, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x1B8CB10 Offset: 0x1B8B110 VA: 0x181B8CB10
	|-Func<Achievement, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x1B8B490 Offset: 0x1B89A90 VA: 0x181B8B490
	|-Func<Achievement, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x1B8A890 Offset: 0x1B88E90 VA: 0x181B8A890
	|-Func<Achievement, Option>.BeginInvoke
	|
	|-RVA: 0x1B8C410 Offset: 0x1B8AA10 VA: 0x181B8C410
	|-Func<Achievement, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x1B8B510 Offset: 0x1B89B10 VA: 0x181B8B510
	|-Func<Achievement, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x1B8D190 Offset: 0x1B8B790 VA: 0x181B8D190
	|-Func<Achievement, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x1B8A510 Offset: 0x1B88B10 VA: 0x181B8A510
	|-Func<Achievement, bool>.BeginInvoke
	|
	|-RVA: 0x1B8D210 Offset: 0x1B8B810 VA: 0x181B8D210
	|-Func<Achievement, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x1B8B710 Offset: 0x1B89D10 VA: 0x181B8B710
	|-Func<Achievement, int>.BeginInvoke
	|
	|-RVA: 0x1B8C210 Offset: 0x1B8A810 VA: 0x181B8C210
	|-Func<Achievement, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x1B8C990 Offset: 0x1B8AF90 VA: 0x181B8C990
	|-Func<Achievement, long>.BeginInvoke
	|
	|-RVA: 0x1B8A110 Offset: 0x1B88710 VA: 0x181B8A110
	|-Func<Achievement, object>.BeginInvoke
	|
	|-RVA: 0x1B8B010 Offset: 0x1B89610 VA: 0x181B8B010
	|-Func<Achievement, float>.BeginInvoke
	|
	|-RVA: 0x1B8D290 Offset: 0x1B8B890 VA: 0x181B8D290
	|-Func<Achievement, Resolution>.BeginInvoke
	|
	|-RVA: 0x21276A0 Offset: 0x2125CA0 VA: 0x1821276A0
	|-Func<InventoryDefId, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x2129220 Offset: 0x2127820 VA: 0x182129220
	|-Func<InventoryDefId, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x2126BA0 Offset: 0x21251A0 VA: 0x182126BA0
	|-Func<InventoryDefId, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x2128DA0 Offset: 0x21273A0 VA: 0x182128DA0
	|-Func<InventoryDefId, Option>.BeginInvoke
	|
	|-RVA: 0x2128A20 Offset: 0x2127020 VA: 0x182128A20
	|-Func<InventoryDefId, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x212AD20 Offset: 0x2129320 VA: 0x18212AD20
	|-Func<InventoryDefId, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x2126B20 Offset: 0x2125120 VA: 0x182126B20
	|-Func<InventoryDefId, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x2129BA0 Offset: 0x21281A0 VA: 0x182129BA0
	|-Func<InventoryDefId, bool>.BeginInvoke
	|
	|-RVA: 0x212A420 Offset: 0x2128A20 VA: 0x18212A420
	|-Func<InventoryDefId, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x21269A0 Offset: 0x2124FA0 VA: 0x1821269A0
	|-Func<InventoryDefId, int>.BeginInvoke
	|
	|-RVA: 0x212A020 Offset: 0x2128620 VA: 0x18212A020
	|-Func<InventoryDefId, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x2128320 Offset: 0x2126920 VA: 0x182128320
	|-Func<InventoryDefId, long>.BeginInvoke
	|
	|-RVA: 0x212AC20 Offset: 0x2129220 VA: 0x18212AC20
	|-Func<InventoryDefId, object>.BeginInvoke
	|
	|-RVA: 0x21273A0 Offset: 0x21259A0 VA: 0x1821273A0
	|-Func<InventoryDefId, float>.BeginInvoke
	|
	|-RVA: 0x2128B20 Offset: 0x2127120 VA: 0x182128B20
	|-Func<InventoryDefId, Resolution>.BeginInvoke
	|
	|-RVA: 0x2128120 Offset: 0x2126720 VA: 0x182128120
	|-Func<InventoryItemId, InventoryItemId>.BeginInvoke
	|
	|-RVA: 0x2127620 Offset: 0x2125C20 VA: 0x182127620
	|-Func<InventoryItemId, bool>.BeginInvoke
	|
	|-RVA: 0x2129FA0 Offset: 0x21285A0 VA: 0x182129FA0
	|-Func<ServerInfo, ServerInfo>.BeginInvoke
	|
	|-RVA: 0x212B2A0 Offset: 0x21298A0 VA: 0x18212B2A0
	|-Func<ServerInfo, bool>.BeginInvoke
	|
	|-RVA: 0x21288A0 Offset: 0x2126EA0 VA: 0x1821288A0
	|-Func<ServerInfo, int>.BeginInvoke
	|
	|-RVA: 0x2127020 Offset: 0x2125620 VA: 0x182127020
	|-Func<ServerInfo, object>.BeginInvoke
	|
	|-RVA: 0x212B420 Offset: 0x2129A20 VA: 0x18212B420
	|-Func<Friend, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x2128FA0 Offset: 0x21275A0 VA: 0x182128FA0
	|-Func<Friend, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x2127FA0 Offset: 0x21265A0 VA: 0x182127FA0
	|-Func<Friend, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x212AA20 Offset: 0x2129020 VA: 0x18212AA20
	|-Func<Friend, Option>.BeginInvoke
	|
	|-RVA: 0x212A5A0 Offset: 0x2128BA0 VA: 0x18212A5A0
	|-Func<Friend, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x2126FA0 Offset: 0x21255A0 VA: 0x182126FA0
	|-Func<Friend, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x21277A0 Offset: 0x2125DA0 VA: 0x1821277A0
	|-Func<Friend, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x212ABA0 Offset: 0x21291A0 VA: 0x18212ABA0
	|-Func<Friend, bool>.BeginInvoke
	|
	|-RVA: 0x212A4A0 Offset: 0x2128AA0 VA: 0x18212A4A0
	|-Func<Friend, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x2129820 Offset: 0x2127E20 VA: 0x182129820
	|-Func<Friend, int>.BeginInvoke
	|
	|-RVA: 0x212A120 Offset: 0x2128720 VA: 0x18212A120
	|-Func<Friend, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x212AAA0 Offset: 0x21290A0 VA: 0x18212AAA0
	|-Func<Friend, long>.BeginInvoke
	|
	|-RVA: 0x21293A0 Offset: 0x21279A0 VA: 0x1821293A0
	|-Func<Friend, object>.BeginInvoke
	|
	|-RVA: 0x2129120 Offset: 0x2127720 VA: 0x182129120
	|-Func<Friend, float>.BeginInvoke
	|
	|-RVA: 0x2128EA0 Offset: 0x21274A0 VA: 0x182128EA0
	|-Func<Friend, Resolution>.BeginInvoke
	|
	|-RVA: 0x2127AA0 Offset: 0x21260A0 VA: 0x182127AA0
	|-Func<InventoryItem, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x212AFA0 Offset: 0x21295A0 VA: 0x18212AFA0
	|-Func<InventoryItem, FourBitNumber>.BeginInvoke
	|
	|-RVA: 0x212ACA0 Offset: 0x21292A0 VA: 0x18212ACA0
	|-Func<InventoryItem, SevenBitNumber>.BeginInvoke
	|
	|-RVA: 0x21282A0 Offset: 0x21268A0 VA: 0x1821282A0
	|-Func<InventoryItem, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x2129F20 Offset: 0x2128520 VA: 0x182129F20
	|-Func<InventoryItem, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x2129020 Offset: 0x2127620 VA: 0x182129020
	|-Func<InventoryItem, Option>.BeginInvoke
	|
	|-RVA: 0x2129AA0 Offset: 0x21280A0 VA: 0x182129AA0
	|-Func<InventoryItem, InventoryDefId>.BeginInvoke
	|
	|-RVA: 0x2126F20 Offset: 0x2125520 VA: 0x182126F20
	|-Func<InventoryItem, InventoryItemId>.BeginInvoke
	|
	|-RVA: 0x212AF20 Offset: 0x2129520 VA: 0x18212AF20
	|-Func<InventoryItem, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x212A2A0 Offset: 0x21288A0 VA: 0x18212A2A0
	|-Func<InventoryItem, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x2127720 Offset: 0x2125D20 VA: 0x182127720
	|-Func<InventoryItem, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x2128620 Offset: 0x2126C20 VA: 0x182128620
	|-Func<InventoryItem, bool>.BeginInvoke
	|
	|-RVA: 0x2128020 Offset: 0x2126620 VA: 0x182128020
	|-Func<InventoryItem, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x21291A0 Offset: 0x21277A0 VA: 0x1821291A0
	|-Func<InventoryItem, int>.BeginInvoke
	|
	|-RVA: 0x212A0A0 Offset: 0x21286A0 VA: 0x18212A0A0
	|-Func<InventoryItem, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x2127CA0 Offset: 0x21262A0 VA: 0x182127CA0
	|-Func<InventoryItem, long>.BeginInvoke
	|
	|-RVA: 0x2128E20 Offset: 0x2127420 VA: 0x182128E20
	|-Func<InventoryItem, object>.BeginInvoke
	|
	|-RVA: 0x2127420 Offset: 0x2125A20 VA: 0x182127420
	|-Func<InventoryItem, float>.BeginInvoke
	|
	|-RVA: 0x212A7A0 Offset: 0x2128DA0 VA: 0x18212A7A0
	|-Func<InventoryItem, uint>.BeginInvoke
	|
	|-RVA: 0x21296A0 Offset: 0x2127CA0 VA: 0x1821296A0
	|-Func<InventoryItem, Resolution>.BeginInvoke
	|
	|-RVA: 0x2129E20 Offset: 0x2128420 VA: 0x182129E20
	|-Func<InventoryItem.Amount, InventoryItemId>.BeginInvoke
	|
	|-RVA: 0x21284A0 Offset: 0x2126AA0 VA: 0x1821284A0
	|-Func<InventoryItem.Amount, bool>.BeginInvoke
	|
	|-RVA: 0x212A9A0 Offset: 0x2128FA0 VA: 0x18212A9A0
	|-Func<InventoryItem.Amount, uint>.BeginInvoke
	|
	|-RVA: 0x2128220 Offset: 0x2126820 VA: 0x182128220
	|-Func<InventoryRecipe, PlayerItemRecipe>.BeginInvoke
	|
	|-RVA: 0x2126DA0 Offset: 0x21253A0 VA: 0x182126DA0
	|-Func<InventoryRecipe, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x2127BA0 Offset: 0x21261A0 VA: 0x182127BA0
	|-Func<InventoryRecipe, bool>.BeginInvoke
	|
	|-RVA: 0x2127C20 Offset: 0x2126220 VA: 0x182127C20
	|-Func<InventoryRecipe, object>.BeginInvoke
	|
	|-RVA: 0x2128520 Offset: 0x2126B20 VA: 0x182128520
	|-Func<InventoryRecipe.Ingredient, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x21278A0 Offset: 0x2125EA0 VA: 0x1821278A0
	|-Func<InventoryRecipe.Ingredient, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x2128C20 Offset: 0x2127220 VA: 0x182128C20
	|-Func<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x2127E20 Offset: 0x2126420 VA: 0x182127E20
	|-Func<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x2126E20 Offset: 0x2125420 VA: 0x182126E20
	|-Func<InventoryRecipe.Ingredient, Option>.BeginInvoke
	|
	|-RVA: 0x2129420 Offset: 0x2127A20 VA: 0x182129420
	|-Func<InventoryRecipe.Ingredient, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x212A6A0 Offset: 0x2128CA0 VA: 0x18212A6A0
	|-Func<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x21270A0 Offset: 0x21256A0 VA: 0x1821270A0
	|-Func<InventoryRecipe.Ingredient, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x2127320 Offset: 0x2125920 VA: 0x182127320
	|-Func<InventoryRecipe.Ingredient, bool>.BeginInvoke
	|
	|-RVA: 0x2128F20 Offset: 0x2127520 VA: 0x182128F20
	|-Func<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x2126EA0 Offset: 0x21254A0 VA: 0x182126EA0
	|-Func<InventoryRecipe.Ingredient, int>.BeginInvoke
	|
	|-RVA: 0x21292A0 Offset: 0x21278A0 VA: 0x1821292A0
	|-Func<InventoryRecipe.Ingredient, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x2129A20 Offset: 0x2128020 VA: 0x182129A20
	|-Func<InventoryRecipe.Ingredient, long>.BeginInvoke
	|
	|-RVA: 0x2129C20 Offset: 0x2128220 VA: 0x182129C20
	|-Func<InventoryRecipe.Ingredient, object>.BeginInvoke
	|
	|-RVA: 0x2129520 Offset: 0x2127B20 VA: 0x182129520
	|-Func<InventoryRecipe.Ingredient, float>.BeginInvoke
	|
	|-RVA: 0x2126CA0 Offset: 0x21252A0 VA: 0x182126CA0
	|-Func<InventoryRecipe.Ingredient, Resolution>.BeginInvoke
	|
	|-RVA: 0x2127D20 Offset: 0x2126320 VA: 0x182127D20
	|-Func<Item, DateTime>.BeginInvoke
	|
	|-RVA: 0x212ADA0 Offset: 0x21293A0 VA: 0x18212ADA0
	|-Func<ArraySegment<byte>, object>.BeginInvoke
	|
	|-RVA: 0x2129620 Offset: 0x2127C20 VA: 0x182129620
	|-Func<bool, bool>.BeginInvoke
	|
	|-RVA: 0x21297A0 Offset: 0x2127DA0 VA: 0x1821297A0
	|-Func<char, bool>.BeginInvoke
	|
	|-RVA: 0x21286A0 Offset: 0x2126CA0 VA: 0x1821286A0
	|-Func<DictionaryEntry, bool>.BeginInvoke
	|
	|-RVA: 0x212A1A0 Offset: 0x21287A0 VA: 0x18212A1A0
	|-Func<DictionaryEntry, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x2129720 Offset: 0x2127D20 VA: 0x182129720
	|-Func<DictionaryEntry, object>.BeginInvoke
	|
	|-RVA: 0x212B220 Offset: 0x2129820 VA: 0x18212B220
	|-Func<KeyValuePair<object, int>, bool>.BeginInvoke
	|
	|-RVA: 0x2129DA0 Offset: 0x21283A0 VA: 0x182129DA0
	|-Func<KeyValuePair<object, int>, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x21289A0 Offset: 0x2126FA0 VA: 0x1821289A0
	|-Func<KeyValuePair<object, int>, int>.BeginInvoke
	|
	|-RVA: 0x2128BA0 Offset: 0x21271A0 VA: 0x182128BA0
	|-Func<KeyValuePair<object, long>, long>.BeginInvoke
	|
	|-RVA: 0x2126C20 Offset: 0x2125220 VA: 0x182126C20
	|-Func<KeyValuePair<object, object>, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x2128AA0 Offset: 0x21270A0 VA: 0x182128AA0
	|-Func<KeyValuePair<object, object>, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x21281A0 Offset: 0x21267A0 VA: 0x1821281A0
	|-Func<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x21274A0 Offset: 0x2125AA0 VA: 0x1821274A0
	|-Func<KeyValuePair<object, object>, Option>.BeginInvoke
	|
	|-RVA: 0x212A8A0 Offset: 0x2128EA0 VA: 0x18212A8A0
	|-Func<KeyValuePair<object, object>, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x21295A0 Offset: 0x2127BA0 VA: 0x1821295A0
	|-Func<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x212A720 Offset: 0x2128D20 VA: 0x18212A720
	|-Func<KeyValuePair<object, object>, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x2129CA0 Offset: 0x21282A0 VA: 0x182129CA0
	|-Func<KeyValuePair<object, object>, bool>.BeginInvoke
	|
	|-RVA: 0x2128420 Offset: 0x2126A20 VA: 0x182128420
	|-Func<KeyValuePair<object, object>, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x21271A0 Offset: 0x21257A0 VA: 0x1821271A0
	|-Func<KeyValuePair<object, object>, int>.BeginInvoke
	|
	|-RVA: 0x212B020 Offset: 0x2129620 VA: 0x18212B020
	|-Func<KeyValuePair<object, object>, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x2128720 Offset: 0x2126D20 VA: 0x182128720
	|-Func<KeyValuePair<object, object>, long>.BeginInvoke
	|
	|-RVA: 0x2126A20 Offset: 0x2125020 VA: 0x182126A20
	|-Func<KeyValuePair<object, object>, object>.BeginInvoke
	|
	|-RVA: 0x212B120 Offset: 0x2129720 VA: 0x18212B120
	|-Func<KeyValuePair<object, object>, float>.BeginInvoke
	|
	|-RVA: 0x2127120 Offset: 0x2125720 VA: 0x182127120
	|-Func<KeyValuePair<object, object>, Resolution>.BeginInvoke
	|
	|-RVA: 0x212A620 Offset: 0x2128C20 VA: 0x18212A620
	|-Func<KeyValuePair<uint, object>, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x2127DA0 Offset: 0x21263A0 VA: 0x182127DA0
	|-Func<KeyValuePair<uint, object>, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x212B0A0 Offset: 0x21296A0 VA: 0x18212B0A0
	|-Func<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x212A220 Offset: 0x2128820 VA: 0x18212A220
	|-Func<KeyValuePair<uint, object>, Option>.BeginInvoke
	|
	|-RVA: 0x2128920 Offset: 0x2126F20 VA: 0x182128920
	|-Func<KeyValuePair<uint, object>, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x212B4A0 Offset: 0x2129AA0 VA: 0x18212B4A0
	|-Func<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x2129320 Offset: 0x2127920 VA: 0x182129320
	|-Func<KeyValuePair<uint, object>, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x212B1A0 Offset: 0x21297A0 VA: 0x18212B1A0
	|-Func<KeyValuePair<uint, object>, bool>.BeginInvoke
	|
	|-RVA: 0x212AEA0 Offset: 0x21294A0 VA: 0x18212AEA0
	|-Func<KeyValuePair<uint, object>, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x212A520 Offset: 0x2128B20 VA: 0x18212A520
	|-Func<KeyValuePair<uint, object>, int>.BeginInvoke
	|
	|-RVA: 0x2127220 Offset: 0x2125820 VA: 0x182127220
	|-Func<KeyValuePair<uint, object>, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x21298A0 Offset: 0x2127EA0 VA: 0x1821298A0
	|-Func<KeyValuePair<uint, object>, long>.BeginInvoke
	|
	|-RVA: 0x2129920 Offset: 0x2127F20 VA: 0x182129920
	|-Func<KeyValuePair<uint, object>, object>.BeginInvoke
	|
	|-RVA: 0x2127920 Offset: 0x2125F20 VA: 0x182127920
	|-Func<KeyValuePair<uint, object>, float>.BeginInvoke
	|
	|-RVA: 0x21280A0 Offset: 0x21266A0 VA: 0x1821280A0
	|-Func<KeyValuePair<uint, object>, uint>.BeginInvoke
	|
	|-RVA: 0x212AB20 Offset: 0x2129120 VA: 0x18212AB20
	|-Func<KeyValuePair<uint, object>, Resolution>.BeginInvoke
	|
	|-RVA: 0x2126AA0 Offset: 0x21250A0 VA: 0x182126AA0
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, Dispatch.ResultCallback>.BeginInvoke
	|
	|-RVA: 0x212A820 Offset: 0x2128E20 VA: 0x18212A820
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, bool>.BeginInvoke
	|
	|-RVA: 0x2126D20 Offset: 0x2125320 VA: 0x182126D20
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, ulong>.BeginInvoke
	|
	|-RVA: 0x2128D20 Offset: 0x2127320 VA: 0x182128D20
	|-Func<double, double>.BeginInvoke
	|
	|-RVA: 0x2127520 Offset: 0x2125B20 VA: 0x182127520
	|-Func<Guid, int>.BeginInvoke
	|
	|-RVA: 0x2128CA0 Offset: 0x21272A0 VA: 0x182128CA0
	|-Func<Guid, object>.BeginInvoke
	|
	|-RVA: 0x21272A0 Offset: 0x21258A0 VA: 0x1821272A0
	|-Func<int, FourBitNumber>.BeginInvoke
	|
	|-RVA: 0x21279A0 Offset: 0x2125FA0 VA: 0x1821279A0
	|-Func<int, SevenBitNumber>.BeginInvoke
	|
	|-RVA: 0x2127820 Offset: 0x2125E20 VA: 0x182127820
	|-Func<int, bool>.BeginInvoke
	|
	|-RVA: 0x21299A0 Offset: 0x2127FA0 VA: 0x1821299A0
	|-Func<int, int>.BeginInvoke
	|
	|-RVA: 0x21283A0 Offset: 0x21269A0 VA: 0x1821283A0
	|-Func<int, object>.BeginInvoke
	|
	|-RVA: 0x212AE20 Offset: 0x2129420 VA: 0x18212AE20
	|-Func<int, float>.BeginInvoke
	|
	|-RVA: 0x2127B20 Offset: 0x2126120 VA: 0x182127B20
	|-Func<Int32Enum, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x2127A20 Offset: 0x2126020 VA: 0x182127A20
	|-Func<Int32Enum, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x212A320 Offset: 0x2128920 VA: 0x18212A320
	|-Func<Int32Enum, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x212A920 Offset: 0x2128F20 VA: 0x18212A920
	|-Func<Int32Enum, Option>.BeginInvoke
	|
	|-RVA: 0x2128820 Offset: 0x2126E20 VA: 0x182128820
	|-Func<Int32Enum, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x21275A0 Offset: 0x2125BA0 VA: 0x1821275A0
	|-Func<Int32Enum, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x21285A0 Offset: 0x2126BA0 VA: 0x1821285A0
	|-Func<Int32Enum, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x21294A0 Offset: 0x2127AA0 VA: 0x1821294A0
	|-Func<Int32Enum, bool>.BeginInvoke
	|
	|-RVA: 0x2127EA0 Offset: 0x21264A0 VA: 0x182127EA0
	|-Func<Int32Enum, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x2129B20 Offset: 0x2128120 VA: 0x182129B20
	|-Func<Int32Enum, int>.BeginInvoke
	|
	|-RVA: 0x2129D20 Offset: 0x2128320 VA: 0x182129D20
	|-Func<Int32Enum, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x212A3A0 Offset: 0x21289A0 VA: 0x18212A3A0
	|-Func<Int32Enum, long>.BeginInvoke
	|
	|-RVA: 0x2127F20 Offset: 0x2126520 VA: 0x182127F20
	|-Func<Int32Enum, object>.BeginInvoke
	|
	|-RVA: 0x212B3A0 Offset: 0x21299A0 VA: 0x18212B3A0
	|-Func<Int32Enum, float>.BeginInvoke
	|
	|-RVA: 0x21290A0 Offset: 0x21276A0 VA: 0x1821290A0
	|-Func<Int32Enum, Resolution>.BeginInvoke
	|
	|-RVA: 0x2129EA0 Offset: 0x21284A0 VA: 0x182129EA0
	|-Func<long, bool>.BeginInvoke
	|
	|-RVA: 0x21287A0 Offset: 0x2126DA0 VA: 0x1821287A0
	|-Func<long, long>.BeginInvoke
	|
	|-RVA: 0x212B320 Offset: 0x2129920 VA: 0x18212B320
	|-Func<IntPtr, object>.BeginInvoke
	|
	|-RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380
	|-Func<object, Debugging.EntityInfo>.BeginInvoke
	|-Func<object, FourBitNumber>.BeginInvoke
	|-Func<object, SevenBitNumber>.BeginInvoke
	|-Func<object, PathFinder.Point>.BeginInvoke
	|-Func<object, PlayerItemRecipe.Ingredient>.BeginInvoke
	|-Func<object, PlayerItemRecipe>.BeginInvoke
	|-Func<object, ProjectileWeaponMod.Modifier>.BeginInvoke
	|-Func<object, Option>.BeginInvoke
	|-Func<object, InventoryDefId>.BeginInvoke
	|-Func<object, InventoryItemId>.BeginInvoke
	|-Func<object, InventoryItem>.BeginInvoke
	|-Func<object, InventoryRecipe.Ingredient>.BeginInvoke
	|-Func<object, InventoryRecipe>.BeginInvoke
	|-Func<object, PublishResult>.BeginInvoke
	|-Func<object, bool>.BeginInvoke
	|-Func<object, KeyValuePair<object, int>>.BeginInvoke
	|-Func<object, DateTime>.BeginInvoke
	|-Func<object, DateTimeOffset>.BeginInvoke
	|-Func<object, Guid>.BeginInvoke
	|-Func<object, int>.BeginInvoke
	|-Func<object, Int32Enum>.BeginInvoke
	|-Func<object, long>.BeginInvoke
	|-Func<object, UdpReceiveResult>.BeginInvoke
	|-Func<object, Nullable<ServerInfo>>.BeginInvoke
	|-Func<object, Nullable<Image>>.BeginInvoke
	|-Func<object, Nullable<InventoryPurchaseResult>>.BeginInvoke
	|-Func<object, Nullable<InventoryResult>>.BeginInvoke
	|-Func<object, Nullable<Item>>.BeginInvoke
	|-Func<object, Nullable<ResultPage>>.BeginInvoke
	|-Func<object, Nullable<int>>.BeginInvoke
	|-Func<object, Nullable<Int32Enum>>.BeginInvoke
	|-Func<object, object>.BeginInvoke
	|-Func<object, float>.BeginInvoke
	|-Func<object, VoidTaskResult>.BeginInvoke
	|-Func<object, uint>.BeginInvoke
	|-Func<object, ulong>.BeginInvoke
	|-Func<object, Resolution>.BeginInvoke
	|
	|-RVA: 0x19F8D90 Offset: 0x19F7390 VA: 0x1819F8D90
	|-Func<float, bool>.BeginInvoke
	|
	|-RVA: 0x19F8C90 Offset: 0x19F7290 VA: 0x1819F8C90
	|-Func<float, float>.BeginInvoke
	|
	|-RVA: 0x19F8A90 Offset: 0x19F7090 VA: 0x1819F8A90
	|-Func<uint, bool>.BeginInvoke
	|
	|-RVA: 0x19F8B10 Offset: 0x19F7110 VA: 0x1819F8B10
	|-Func<uint, uint>.BeginInvoke
	|
	|-RVA: 0x19F8F10 Offset: 0x19F7510 VA: 0x1819F8F10
	|-Func<ulong, bool>.BeginInvoke
	|
	|-RVA: 0x19F8D10 Offset: 0x19F7310 VA: 0x1819F8D10
	|-Func<ulong, ulong>.BeginInvoke
	|
	|-RVA: 0x19F8B90 Offset: 0x19F7190 VA: 0x1819F8B90
	|-Func<ValueTuple<Int32Enum, int>, object>.BeginInvoke
	|
	|-RVA: 0x19F8F90 Offset: 0x19F7590 VA: 0x1819F8F90
	|-Func<Resolution, bool>.BeginInvoke
	|
	|-RVA: 0x19F8E10 Offset: 0x19F7410 VA: 0x1819F8E10
	|-Func<Resolution, int>.BeginInvoke
	|
	|-RVA: 0x19F8E90 Offset: 0x19F7490 VA: 0x1819F8E90
	|-Func<Resolution, Resolution>.BeginInvoke
	|
	|-RVA: 0x19F8C10 Offset: 0x19F7210 VA: 0x1819F8C10
	|-Func<Resolution, Vector2Int>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0
	|-Func<Admin.PlayerInfo, object>.EndInvoke
	|-Func<Admin.ServerConvarInfo, object>.EndInvoke
	|-Func<Demos.DemoInfo, object>.EndInvoke
	|-Func<SkeletonDefinition.Bone, object>.EndInvoke
	|-Func<ImageStorageEntity.ImageRequest, object>.EndInvoke
	|-Func<SevenBitNumber, object>.EndInvoke
	|-Func<DefaultSerializationBinder.TypeNameKey, object>.EndInvoke
	|-Func<ConvertUtils.TypeConvertKey, object>.EndInvoke
	|-Func<PlayerItemRecipe, object>.EndInvoke
	|-Func<ServerInfo, object>.EndInvoke
	|-Func<Achievement, object>.EndInvoke
	|-Func<InventoryDefId, object>.EndInvoke
	|-Func<ServerInfo, object>.EndInvoke
	|-Func<Friend, object>.EndInvoke
	|-Func<InventoryItem, object>.EndInvoke
	|-Func<InventoryRecipe, object>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, object>.EndInvoke
	|-Func<ArraySegment<byte>, object>.EndInvoke
	|-Func<DictionaryEntry, object>.EndInvoke
	|-Func<KeyValuePair<object, object>, object>.EndInvoke
	|-Func<KeyValuePair<uint, object>, object>.EndInvoke
	|-Func<Guid, object>.EndInvoke
	|-Func<int, object>.EndInvoke
	|-Func<Int32Enum, object>.EndInvoke
	|-Func<IntPtr, object>.EndInvoke
	|-Func<object, object>.EndInvoke
	|-Func<ValueTuple<Int32Enum, int>, object>.EndInvoke
	|
	|-RVA: 0x1220A80 Offset: 0x121F080 VA: 0x181220A80
	|-Func<Debugging.EntityInfo, Debugging.EntityInfo>.EndInvoke
	|-Func<SkeletonDefinition.Bone, Debugging.EntityInfo>.EndInvoke
	|-Func<SkeletonDefinition.Bone, KeyValuePair<object, int>>.EndInvoke
	|-Func<PlayerItemRecipe, Debugging.EntityInfo>.EndInvoke
	|-Func<PlayerItemRecipe, PlayerItemRecipe>.EndInvoke
	|-Func<PlayerItemRecipe, KeyValuePair<object, int>>.EndInvoke
	|-Func<ServerInfo, Debugging.EntityInfo>.EndInvoke
	|-Func<ServerInfo, KeyValuePair<object, int>>.EndInvoke
	|-Func<Achievement, Debugging.EntityInfo>.EndInvoke
	|-Func<Achievement, KeyValuePair<object, int>>.EndInvoke
	|-Func<InventoryDefId, Debugging.EntityInfo>.EndInvoke
	|-Func<InventoryDefId, KeyValuePair<object, int>>.EndInvoke
	|-Func<Friend, Debugging.EntityInfo>.EndInvoke
	|-Func<Friend, KeyValuePair<object, int>>.EndInvoke
	|-Func<InventoryItem, Debugging.EntityInfo>.EndInvoke
	|-Func<InventoryItem, KeyValuePair<object, int>>.EndInvoke
	|-Func<InventoryRecipe, PlayerItemRecipe>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, Debugging.EntityInfo>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.EndInvoke
	|-Func<DictionaryEntry, KeyValuePair<object, object>>.EndInvoke
	|-Func<KeyValuePair<object, int>, KeyValuePair<object, int>>.EndInvoke
	|-Func<KeyValuePair<object, object>, Debugging.EntityInfo>.EndInvoke
	|-Func<KeyValuePair<object, object>, KeyValuePair<object, int>>.EndInvoke
	|-Func<KeyValuePair<uint, object>, Debugging.EntityInfo>.EndInvoke
	|-Func<KeyValuePair<uint, object>, KeyValuePair<object, int>>.EndInvoke
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, Dispatch.ResultCallback>.EndInvoke
	|-Func<Int32Enum, Debugging.EntityInfo>.EndInvoke
	|-Func<Int32Enum, KeyValuePair<object, int>>.EndInvoke
	|-Func<object, Debugging.EntityInfo>.EndInvoke
	|-Func<object, PlayerItemRecipe>.EndInvoke
	|-Func<object, KeyValuePair<object, int>>.EndInvoke
	|-Func<object, DateTimeOffset>.EndInvoke
	|-Func<object, Guid>.EndInvoke
	|-Func<object, UdpReceiveResult>.EndInvoke
	|
	|-RVA: 0xFF6250 Offset: 0xFF4850 VA: 0x180FF6250
	|-Func<Debugging.EntityInfo, bool>.EndInvoke
	|-Func<Entity.EntityInfo, bool>.EndInvoke
	|-Func<BurstCloth.Chain, FourBitNumber>.EndInvoke
	|-Func<BurstCloth.Chain, SevenBitNumber>.EndInvoke
	|-Func<BurstCloth.Chain, bool>.EndInvoke
	|-Func<RCon.BannedAddresses, bool>.EndInvoke
	|-Func<SkeletonDefinition.Bone, bool>.EndInvoke
	|-Func<WeightedStringList.Container, bool>.EndInvoke
	|-Func<GameStat.Stat, bool>.EndInvoke
	|-Func<ItemSkinDirectory.Skin, bool>.EndInvoke
	|-Func<FourBitNumber, FourBitNumber>.EndInvoke
	|-Func<FourBitNumber, bool>.EndInvoke
	|-Func<SevenBitNumber, SevenBitNumber>.EndInvoke
	|-Func<SevenBitNumber, bool>.EndInvoke
	|-Func<PathFinder.Point, bool>.EndInvoke
	|-Func<PetCommandList.PetCommandDesc, bool>.EndInvoke
	|-Func<PlayerItemRecipe, bool>.EndInvoke
	|-Func<PlayerItemRecipe.Ingredient, FourBitNumber>.EndInvoke
	|-Func<PlayerItemRecipe.Ingredient, SevenBitNumber>.EndInvoke
	|-Func<PlayerItemRecipe.Ingredient, bool>.EndInvoke
	|-Func<ProjectileWeaponMod.Modifier, bool>.EndInvoke
	|-Func<Option, bool>.EndInvoke
	|-Func<ServerInfo, FourBitNumber>.EndInvoke
	|-Func<ServerInfo, SevenBitNumber>.EndInvoke
	|-Func<ServerInfo, bool>.EndInvoke
	|-Func<SkinnedMultiMesh.Part, bool>.EndInvoke
	|-Func<Achievement, bool>.EndInvoke
	|-Func<InventoryDefId, bool>.EndInvoke
	|-Func<InventoryItemId, bool>.EndInvoke
	|-Func<ServerInfo, bool>.EndInvoke
	|-Func<Friend, bool>.EndInvoke
	|-Func<InventoryItem, FourBitNumber>.EndInvoke
	|-Func<InventoryItem, SevenBitNumber>.EndInvoke
	|-Func<InventoryItem, bool>.EndInvoke
	|-Func<InventoryItem.Amount, bool>.EndInvoke
	|-Func<InventoryRecipe, bool>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, bool>.EndInvoke
	|-Func<bool, bool>.EndInvoke
	|-Func<char, bool>.EndInvoke
	|-Func<DictionaryEntry, bool>.EndInvoke
	|-Func<KeyValuePair<object, int>, bool>.EndInvoke
	|-Func<KeyValuePair<object, object>, bool>.EndInvoke
	|-Func<KeyValuePair<uint, object>, bool>.EndInvoke
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, bool>.EndInvoke
	|-Func<int, FourBitNumber>.EndInvoke
	|-Func<int, SevenBitNumber>.EndInvoke
	|-Func<int, bool>.EndInvoke
	|-Func<Int32Enum, bool>.EndInvoke
	|-Func<long, bool>.EndInvoke
	|-Func<object, FourBitNumber>.EndInvoke
	|-Func<object, SevenBitNumber>.EndInvoke
	|-Func<object, bool>.EndInvoke
	|-Func<object, VoidTaskResult>.EndInvoke
	|-Func<float, bool>.EndInvoke
	|-Func<uint, bool>.EndInvoke
	|-Func<ulong, bool>.EndInvoke
	|-Func<Resolution, bool>.EndInvoke
	|
	|-RVA: 0x12213D0 Offset: 0x121F9D0 VA: 0x1812213D0
	|-Func<Demos.DemoInfo, DateTime>.EndInvoke
	|-Func<Demos.DemoInfo, TimeSpan>.EndInvoke
	|-Func<SkeletonDefinition.Bone, PathFinder.Point>.EndInvoke
	|-Func<SkeletonDefinition.Bone, long>.EndInvoke
	|-Func<PathFinder.Point, PathFinder.Point>.EndInvoke
	|-Func<PlayerItemRecipe, PathFinder.Point>.EndInvoke
	|-Func<PlayerItemRecipe, long>.EndInvoke
	|-Func<PlayerItemRecipe.Ingredient, PlayerItemRecipe.Ingredient>.EndInvoke
	|-Func<ServerInfo, PathFinder.Point>.EndInvoke
	|-Func<ServerInfo, long>.EndInvoke
	|-Func<SkinnedMultiMesh.Part, long>.EndInvoke
	|-Func<Achievement, PathFinder.Point>.EndInvoke
	|-Func<Achievement, long>.EndInvoke
	|-Func<InventoryDefId, PathFinder.Point>.EndInvoke
	|-Func<InventoryDefId, long>.EndInvoke
	|-Func<InventoryItemId, InventoryItemId>.EndInvoke
	|-Func<Friend, PathFinder.Point>.EndInvoke
	|-Func<Friend, long>.EndInvoke
	|-Func<InventoryItem, PathFinder.Point>.EndInvoke
	|-Func<InventoryItem, InventoryItemId>.EndInvoke
	|-Func<InventoryItem, long>.EndInvoke
	|-Func<InventoryItem.Amount, InventoryItemId>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, PathFinder.Point>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, long>.EndInvoke
	|-Func<Item, DateTime>.EndInvoke
	|-Func<KeyValuePair<object, long>, long>.EndInvoke
	|-Func<KeyValuePair<object, object>, PathFinder.Point>.EndInvoke
	|-Func<KeyValuePair<object, object>, long>.EndInvoke
	|-Func<KeyValuePair<uint, object>, PathFinder.Point>.EndInvoke
	|-Func<KeyValuePair<uint, object>, long>.EndInvoke
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, ulong>.EndInvoke
	|-Func<Int32Enum, PathFinder.Point>.EndInvoke
	|-Func<Int32Enum, long>.EndInvoke
	|-Func<long, long>.EndInvoke
	|-Func<object, PathFinder.Point>.EndInvoke
	|-Func<object, PlayerItemRecipe.Ingredient>.EndInvoke
	|-Func<object, InventoryItemId>.EndInvoke
	|-Func<object, DateTime>.EndInvoke
	|-Func<object, long>.EndInvoke
	|-Func<object, Nullable<int>>.EndInvoke
	|-Func<object, Nullable<Int32Enum>>.EndInvoke
	|-Func<object, ulong>.EndInvoke
	|-Func<ulong, ulong>.EndInvoke
	|-Func<Resolution, Vector2Int>.EndInvoke
	|
	|-RVA: 0xB9A710 Offset: 0xB98D10 VA: 0x180B9A710
	|-Func<BurstCloth.Chain, int>.EndInvoke
	|-Func<SkeletonDefinition.Bone, int>.EndInvoke
	|-Func<SkeletonDefinition.Bone, Int32Enum>.EndInvoke
	|-Func<PlayerItemRecipe, int>.EndInvoke
	|-Func<PlayerItemRecipe, Int32Enum>.EndInvoke
	|-Func<PlayerItemRecipe.Ingredient, int>.EndInvoke
	|-Func<ServerInfo, int>.EndInvoke
	|-Func<ServerInfo, Int32Enum>.EndInvoke
	|-Func<ServerInfo, uint>.EndInvoke
	|-Func<Achievement, int>.EndInvoke
	|-Func<Achievement, Int32Enum>.EndInvoke
	|-Func<InventoryDefId, int>.EndInvoke
	|-Func<InventoryDefId, Int32Enum>.EndInvoke
	|-Func<ServerInfo, int>.EndInvoke
	|-Func<Friend, int>.EndInvoke
	|-Func<Friend, Int32Enum>.EndInvoke
	|-Func<InventoryItem, InventoryDefId>.EndInvoke
	|-Func<InventoryItem, int>.EndInvoke
	|-Func<InventoryItem, Int32Enum>.EndInvoke
	|-Func<InventoryItem, uint>.EndInvoke
	|-Func<InventoryItem.Amount, uint>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, int>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, Int32Enum>.EndInvoke
	|-Func<KeyValuePair<object, int>, int>.EndInvoke
	|-Func<KeyValuePair<object, object>, int>.EndInvoke
	|-Func<KeyValuePair<object, object>, Int32Enum>.EndInvoke
	|-Func<KeyValuePair<uint, object>, int>.EndInvoke
	|-Func<KeyValuePair<uint, object>, Int32Enum>.EndInvoke
	|-Func<KeyValuePair<uint, object>, uint>.EndInvoke
	|-Func<Guid, int>.EndInvoke
	|-Func<int, int>.EndInvoke
	|-Func<Int32Enum, int>.EndInvoke
	|-Func<Int32Enum, Int32Enum>.EndInvoke
	|-Func<object, InventoryDefId>.EndInvoke
	|-Func<object, int>.EndInvoke
	|-Func<object, Int32Enum>.EndInvoke
	|-Func<object, uint>.EndInvoke
	|-Func<uint, uint>.EndInvoke
	|-Func<Resolution, int>.EndInvoke
	|
	|-RVA: 0x198A750 Offset: 0x1988D50 VA: 0x18198A750
	|-Func<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<SkeletonDefinition.Bone, Resolution>.EndInvoke
	|-Func<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<PlayerItemRecipe, Resolution>.EndInvoke
	|-Func<ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<ServerInfo, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<ServerInfo, Resolution>.EndInvoke
	|-Func<Achievement, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<Achievement, Resolution>.EndInvoke
	|-Func<InventoryDefId, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<InventoryDefId, Resolution>.EndInvoke
	|-Func<Friend, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<Friend, Resolution>.EndInvoke
	|-Func<InventoryItem, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<InventoryItem, Resolution>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, Resolution>.EndInvoke
	|-Func<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<KeyValuePair<object, object>, Resolution>.EndInvoke
	|-Func<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<KeyValuePair<uint, object>, Resolution>.EndInvoke
	|-Func<Int32Enum, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<Int32Enum, Resolution>.EndInvoke
	|-Func<object, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<object, Nullable<InventoryResult>>.EndInvoke
	|-Func<object, Resolution>.EndInvoke
	|-Func<Resolution, Resolution>.EndInvoke
	|
	|-RVA: 0x19F9080 Offset: 0x19F7680 VA: 0x1819F9080
	|-Func<SkeletonDefinition.Bone, Option>.EndInvoke
	|-Func<SkeletonDefinition.Bone, InventoryItem>.EndInvoke
	|-Func<PlayerItemRecipe, Option>.EndInvoke
	|-Func<PlayerItemRecipe, InventoryItem>.EndInvoke
	|-Func<Option, Option>.EndInvoke
	|-Func<ServerInfo, Option>.EndInvoke
	|-Func<ServerInfo, InventoryItem>.EndInvoke
	|-Func<Achievement, Option>.EndInvoke
	|-Func<Achievement, InventoryItem>.EndInvoke
	|-Func<InventoryDefId, Option>.EndInvoke
	|-Func<InventoryDefId, InventoryItem>.EndInvoke
	|-Func<Friend, Option>.EndInvoke
	|-Func<Friend, InventoryItem>.EndInvoke
	|-Func<InventoryItem, Option>.EndInvoke
	|-Func<InventoryItem, InventoryItem>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, Option>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, InventoryItem>.EndInvoke
	|-Func<KeyValuePair<object, object>, Option>.EndInvoke
	|-Func<KeyValuePair<object, object>, InventoryItem>.EndInvoke
	|-Func<KeyValuePair<uint, object>, Option>.EndInvoke
	|-Func<KeyValuePair<uint, object>, InventoryItem>.EndInvoke
	|-Func<Int32Enum, Option>.EndInvoke
	|-Func<Int32Enum, InventoryItem>.EndInvoke
	|-Func<object, Option>.EndInvoke
	|-Func<object, InventoryItem>.EndInvoke
	|-Func<object, Nullable<InventoryPurchaseResult>>.EndInvoke
	|-Func<object, Nullable<ResultPage>>.EndInvoke
	|
	|-RVA: 0x19F91A0 Offset: 0x19F77A0 VA: 0x1819F91A0
	|-Func<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<SkeletonDefinition.Bone, InventoryRecipe>.EndInvoke
	|-Func<PlayerItemRecipe, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<PlayerItemRecipe, InventoryRecipe>.EndInvoke
	|-Func<ServerInfo, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<ServerInfo, InventoryRecipe>.EndInvoke
	|-Func<Achievement, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<Achievement, InventoryRecipe>.EndInvoke
	|-Func<InventoryDefId, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<InventoryDefId, InventoryRecipe>.EndInvoke
	|-Func<Friend, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<Friend, InventoryRecipe>.EndInvoke
	|-Func<InventoryItem, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<InventoryItem, InventoryRecipe>.EndInvoke
	|-Func<InventoryRecipe, InventoryRecipe>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, InventoryRecipe>.EndInvoke
	|-Func<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<KeyValuePair<object, object>, InventoryRecipe>.EndInvoke
	|-Func<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<KeyValuePair<uint, object>, InventoryRecipe>.EndInvoke
	|-Func<Int32Enum, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<Int32Enum, InventoryRecipe>.EndInvoke
	|-Func<object, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<object, InventoryRecipe>.EndInvoke
	|-Func<object, PublishResult>.EndInvoke
	|-Func<object, Nullable<Image>>.EndInvoke
	|
	|-RVA: 0x19F90C0 Offset: 0x19F76C0 VA: 0x1819F90C0
	|-Func<SkeletonDefinition.Bone, float>.EndInvoke
	|-Func<WeightedStringList.Container, float>.EndInvoke
	|-Func<PlayerItemRecipe, float>.EndInvoke
	|-Func<ProjectileWeaponMod.Modifier, float>.EndInvoke
	|-Func<ServerInfo, float>.EndInvoke
	|-Func<Achievement, float>.EndInvoke
	|-Func<InventoryDefId, float>.EndInvoke
	|-Func<Friend, float>.EndInvoke
	|-Func<InventoryItem, float>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, float>.EndInvoke
	|-Func<KeyValuePair<object, object>, float>.EndInvoke
	|-Func<KeyValuePair<uint, object>, float>.EndInvoke
	|-Func<int, float>.EndInvoke
	|-Func<Int32Enum, float>.EndInvoke
	|-Func<object, float>.EndInvoke
	|-Func<float, float>.EndInvoke
	|
	|-RVA: 0x212B520 Offset: 0x2129B20 VA: 0x18212B520
	|-Func<ServerInfo, ServerInfo>.EndInvoke
	|
	|-RVA: 0x212B590 Offset: 0x2129B90 VA: 0x18212B590
	|-Func<double, double>.EndInvoke
	|
	|-RVA: 0x19F9010 Offset: 0x19F7610 VA: 0x1819F9010
	|-Func<object, Nullable<ServerInfo>>.EndInvoke
	|
	|-RVA: 0x19F90F0 Offset: 0x19F76F0 VA: 0x1819F90F0
	|-Func<object, Nullable<Item>>.EndInvoke
	*/

}

public sealed class Converter<TInput, TOutput> : MulticastDelegate // TypeDefIndex: 161
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-Converter<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual TOutput Invoke(TInput input) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD59790 Offset: 0xD57D90 VA: 0x180D59790
	|-Converter<Type, string>.Invoke
	|-Converter<object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(TInput input, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380
	|-Converter<object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual TOutput EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0
	|-Converter<object, object>.EndInvoke
	*/

}

internal struct __DTString // TypeDefIndex: 231
{	// Fields
	internal string Value; // 0x0
	internal int Index; // 0x8
	internal int len; // 0xC
	internal char m_current; // 0x10
	private CompareInfo m_info; // 0x18
	private bool m_checkDigitToken; // 0x20
	private static char[] WhiteSpaceChecks; // 0x0

	// Properties
	internal CompareInfo CompareInfo { get; }

	// Methods

	// RVA: 0x235430 Offset: 0x234830 VA: 0x180235430
	internal void .ctor(string str, DateTimeFormatInfo dtfi, bool checkDigitToken) { }

	// RVA: 0x235510 Offset: 0x234910 VA: 0x180235510
	internal void .ctor(string str, DateTimeFormatInfo dtfi) { }

	// RVA: 0xF3F70 Offset: 0xF3370 VA: 0x1800F3F70
	internal CompareInfo get_CompareInfo() { }

	// RVA: 0x2349E0 Offset: 0x233DE0 VA: 0x1802349E0
	internal bool GetNext() { }

	// RVA: 0x234890 Offset: 0x233C90 VA: 0x180234890
	internal bool AtEnd() { }

	// RVA: 0x234850 Offset: 0x233C50 VA: 0x180234850
	internal bool Advance(int count) { }

	// RVA: 0x234A20 Offset: 0x233E20 VA: 0x180234A20
	internal void GetRegularToken(out TokenType tokenType, out int tokenValue, DateTimeFormatInfo dtfi) { }

	// RVA: 0x234AB0 Offset: 0x233EB0 VA: 0x180234AB0
	internal TokenType GetSeparatorToken(DateTimeFormatInfo dtfi, out int indexBeforeSeparator, out char charBeforeSeparator) { }

	// RVA: 0x234E70 Offset: 0x234270 VA: 0x180234E70
	internal bool MatchSpecifiedWord(string target) { }

	// RVA: 0x234DF0 Offset: 0x2341F0 VA: 0x180234DF0
	internal bool MatchSpecifiedWord(string target, int endIndex) { }

	// RVA: 0x234EF0 Offset: 0x2342F0 VA: 0x180234EF0
	internal bool MatchSpecifiedWords(string target, bool checkWordBoundary, ref int matchLength) { }

	// RVA: 0x234F00 Offset: 0x234300 VA: 0x180234F00
	internal bool Match(string str) { }

	// RVA: 0x234FB0 Offset: 0x2343B0 VA: 0x180234FB0
	internal bool Match(char ch) { }

	// RVA: 0x234D40 Offset: 0x234140 VA: 0x180234D40
	internal int MatchLongestWords(string[] words, ref int maxMatchStrLen) { }

	// RVA: 0x234A30 Offset: 0x233E30 VA: 0x180234A30
	internal int GetRepeatCount() { }

	// RVA: 0x234960 Offset: 0x233D60 VA: 0x180234960
	internal bool GetNextDigit() { }

	// RVA: 0x234900 Offset: 0x233D00 VA: 0x180234900
	internal char GetChar() { }

	// RVA: 0x234930 Offset: 0x233D30 VA: 0x180234930
	internal int GetDigit() { }

	// RVA: 0x2352B0 Offset: 0x2346B0 VA: 0x1802352B0
	internal void SkipWhiteSpaces() { }

	// RVA: 0x2352A0 Offset: 0x2346A0 VA: 0x1802352A0
	internal bool SkipWhiteSpaceCurrent() { }

	// RVA: 0x235350 Offset: 0x234750 VA: 0x180235350
	internal void TrimTail() { }

	// RVA: 0x235130 Offset: 0x234530 VA: 0x180235130
	internal void RemoveTrailingInQuoteSpaces() { }

	// RVA: 0x235010 Offset: 0x234410 VA: 0x180235010
	internal void RemoveLeadingInQuoteSpaces() { }

	// RVA: 0x234BC0 Offset: 0x233FC0 VA: 0x180234BC0
	internal DTSubString GetSubString() { }

	// RVA: 0x2348A0 Offset: 0x233CA0 VA: 0x1802348A0
	internal void ConsumeSubString(DTSubString sub) { }

	// RVA: 0x214C1B0 Offset: 0x214A7B0 VA: 0x18214C1B0
	private static void .cctor() { }

}

internal class __ComObject // TypeDefIndex: 429
{	// Methods

	// RVA: 0x214AF50 Offset: 0x2149550 VA: 0x18214AF50
	private void .ctor() { }

}

internal static class __Error // TypeDefIndex: 615
{	// Methods

	// RVA: 0x1687130 Offset: 0x1685730 VA: 0x181687130
	internal static void EndOfFile() { }

	// RVA: 0x1687280 Offset: 0x1685880 VA: 0x181687280
	internal static void FileNotOpen() { }

	// RVA: 0x16875A0 Offset: 0x1685BA0 VA: 0x1816875A0
	internal static void StreamIsClosed() { }

	// RVA: 0x1687450 Offset: 0x1685A50 VA: 0x181687450
	internal static void MemoryStreamNotExpandable() { }

	// RVA: 0x1687530 Offset: 0x1685B30 VA: 0x181687530
	internal static void ReaderClosed() { }

	// RVA: 0x16874C0 Offset: 0x1685AC0 VA: 0x1816874C0
	internal static void ReadNotSupported() { }

	// RVA: 0x1687DC0 Offset: 0x16863C0 VA: 0x181687DC0
	internal static void WrongAsyncResult() { }

	// RVA: 0x16871A0 Offset: 0x16857A0 VA: 0x1816871A0
	internal static void EndReadCalledTwice() { }

	// RVA: 0x1687210 Offset: 0x1685810 VA: 0x181687210
	internal static void EndWriteCalledTwice() { }

	// RVA: 0x16872F0 Offset: 0x16858F0 VA: 0x1816872F0
	internal static string GetDisplayablePath(string path, bool isInvalidPath) { }

	// RVA: 0x1687610 Offset: 0x1685C10 VA: 0x181687610
	internal static void WinIOError(int errorCode, string maybeFullPath) { }

	// RVA: 0x1687CE0 Offset: 0x16862E0 VA: 0x181687CE0
	internal static void WriteNotSupported() { }

	// RVA: 0x1687D50 Offset: 0x1686350 VA: 0x181687D50
	internal static void WriterClosed() { }

}

internal abstract class Iterator<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 627
{	// Fields
	private int threadId; // 0x0
	internal int state; // 0x0
	internal TSource current; // 0x0

	// Properties
	public TSource Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E3470 Offset: 0x19E1A70 VA: 0x1819E3470
	|-Iterator<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public TSource get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Iterator<object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract Iterator<TSource> Clone();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Iterator<object>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A02620 Offset: 0x1A00C20 VA: 0x181A02620
	|-Iterator<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected virtual void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E2230 Offset: 0x19E0830 VA: 0x1819E2230
	|-Iterator<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<TSource> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E22F0 Offset: 0x19E08F0 VA: 0x1819E22F0
	|-Iterator<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool MoveNext();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Iterator<object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1355EA0 Offset: 0x13544A0 VA: 0x181355EA0
	|-Iterator<object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F20D0 Offset: 0x17F06D0 VA: 0x1817F20D0
	|-Iterator<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A026A0 Offset: 0x1A00CA0 VA: 0x181A026A0
	|-Iterator<object>.System.Collections.IEnumerator.Reset
	*/

}

internal abstract class SearchResultHandler<TSource> // TypeDefIndex: 629
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract bool IsResultIncluded(SearchResult result);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SearchResultHandler<object>.IsResultIncluded
	*/

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract TSource CreateObject(SearchResult result);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SearchResultHandler<object>.CreateObject
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5AD60 Offset: 0xD59360 VA: 0x180D5AD60
	|-SearchResultHandler<object>..ctor
	|-SearchResultHandler<string>..ctor
	*/

}

internal static class _ThreadPoolWaitCallback // TypeDefIndex: 814
{	// Methods

	// RVA: 0x161E810 Offset: 0x161CE10 VA: 0x18161E810
	internal static bool PerformWaitCallback() { }

}

public class Task<TResult> : Task // TypeDefIndex: 842
{	// Fields
	internal TResult m_result; // 0x0
	private static readonly TaskFactory<TResult> s_Factory; // 0x0
	internal static readonly Func<Task<Task>, Task<TResult>> TaskWhenAnyCast; // 0x0

	// Properties
	[DebuggerBrowsableAttribute] // RVA: 0x9E940 Offset: 0x9DD40 VA: 0x18009E940
	public TResult Result { get; }
	internal TResult ResultOnSuccess { get; }
	public static TaskFactory<TResult> Factory { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A9CCE0 Offset: 0x1A9B2E0 VA: 0x181A9CCE0
	|-Task<PublishResult>..ctor
	|
	|-RVA: 0x1A9AF00 Offset: 0x1A99500 VA: 0x181A9AF00
	|-Task<bool>..ctor
	|
	|-RVA: 0x1A9B660 Offset: 0x1A99C60 VA: 0x181A9B660
	|-Task<int>..ctor
	|
	|-RVA: 0x1A9B200 Offset: 0x1A99800 VA: 0x181A9B200
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0x1A9B9E0 Offset: 0x1A99FE0 VA: 0x181A9B9E0
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x1A9AB90 Offset: 0x1A99190 VA: 0x181A9AB90
	|-Task<Nullable<Image>>..ctor
	|
	|-RVA: 0x1A9C070 Offset: 0x1A9A670 VA: 0x181A9C070
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1A9C9B0 Offset: 0x1A9AFB0 VA: 0x181A9C9B0
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1A9AF60 Offset: 0x1A99560 VA: 0x181A9AF60
	|-Task<Nullable<Item>>..ctor
	|
	|-RVA: 0x1A9AEA0 Offset: 0x1A994A0 VA: 0x181A9AEA0
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1A57280 Offset: 0x1A55880 VA: 0x181A57280
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x1A56A60 Offset: 0x1A55060 VA: 0x181A56A60
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x1A565C0 Offset: 0x1A54BC0 VA: 0x181A565C0
	|-Task<object>..ctor
	|-Task<Task>..ctor
	|
	|-RVA: 0x1A56AC0 Offset: 0x1A550C0 VA: 0x181A56AC0
	|-Task<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(object state, TaskCreationOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A9BA40 Offset: 0x1A9A040 VA: 0x181A9BA40
	|-Task<PublishResult>..ctor
	|
	|-RVA: 0x1A9BBB0 Offset: 0x1A9A1B0 VA: 0x181A9BBB0
	|-Task<bool>..ctor
	|
	|-RVA: 0x1A9CAA0 Offset: 0x1A9B0A0 VA: 0x181A9CAA0
	|-Task<int>..ctor
	|
	|-RVA: 0x1A9CC50 Offset: 0x1A9B250 VA: 0x181A9CC50
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0x1A9A8B0 Offset: 0x1A98EB0 VA: 0x181A9A8B0
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x1A9B170 Offset: 0x1A99770 VA: 0x181A9B170
	|-Task<Nullable<Image>>..ctor
	|
	|-RVA: 0x1A9AD80 Offset: 0x1A99380 VA: 0x181A9AD80
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1A9AE10 Offset: 0x1A99410 VA: 0x181A9AE10
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1A997F0 Offset: 0x1A97DF0 VA: 0x181A997F0
	|-Task<Nullable<Item>>..ctor
	|
	|-RVA: 0x1A99CC0 Offset: 0x1A982C0 VA: 0x181A99CC0
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1A569D0 Offset: 0x1A54FD0 VA: 0x181A569D0
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x1A56C40 Offset: 0x1A55240 VA: 0x181A56C40
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x1A570D0 Offset: 0x1A556D0 VA: 0x181A570D0
	|-Task<object>..ctor
	|
	|-RVA: 0x1A57380 Offset: 0x1A55980 VA: 0x181A57380
	|-Task<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A9A650 Offset: 0x1A98C50 VA: 0x181A9A650
	|-Task<PublishResult>..ctor
	|
	|-RVA: 0x1A990D0 Offset: 0x1A976D0 VA: 0x181A990D0
	|-Task<bool>..ctor
	|
	|-RVA: 0x1A99880 Offset: 0x1A97E80 VA: 0x181A99880
	|-Task<int>..ctor
	|
	|-RVA: 0x1A9CA10 Offset: 0x1A9B010 VA: 0x181A9CA10
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0x1A9C0D0 Offset: 0x1A9A6D0 VA: 0x181A9C0D0
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x1A9BFD0 Offset: 0x1A9A5D0 VA: 0x181A9BFD0
	|-Task<Nullable<Image>>..ctor
	|
	|-RVA: 0x1A9AFC0 Offset: 0x1A995C0 VA: 0x181A9AFC0
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1A9AB00 Offset: 0x1A99100 VA: 0x181A9AB00
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1A9C1B0 Offset: 0x1A9A7B0 VA: 0x181A9C1B0
	|-Task<Nullable<Item>>..ctor
	|
	|-RVA: 0x1A99C30 Offset: 0x1A98230 VA: 0x181A99C30
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1A56DF0 Offset: 0x1A553F0 VA: 0x181A56DF0
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x1A55CD0 Offset: 0x1A542D0 VA: 0x181A55CD0
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x1A56740 Offset: 0x1A54D40 VA: 0x181A56740
	|-Task<object>..ctor
	|
	|-RVA: 0x1A56540 Offset: 0x1A54B40 VA: 0x181A56540
	|-Task<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(bool canceled, TResult result, TaskCreationOptions creationOptions, CancellationToken ct) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A9CD40 Offset: 0x1A9B340 VA: 0x181A9CD40
	|-Task<PublishResult>..ctor
	|
	|-RVA: 0x1A99D50 Offset: 0x1A98350 VA: 0x181A99D50
	|-Task<bool>..ctor
	|
	|-RVA: 0x1A99150 Offset: 0x1A97750 VA: 0x181A99150
	|-Task<int>..ctor
	|
	|-RVA: 0x1A9BF20 Offset: 0x1A9A520 VA: 0x181A9BF20
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0x1A99FF0 Offset: 0x1A985F0 VA: 0x181A99FF0
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x1A9A470 Offset: 0x1A98A70 VA: 0x181A9A470
	|-Task<Nullable<Image>>..ctor
	|
	|-RVA: 0x1A9ACD0 Offset: 0x1A992D0 VA: 0x181A9ACD0
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1A9C900 Offset: 0x1A9AF00 VA: 0x181A9C900
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1A99900 Offset: 0x1A97F00 VA: 0x181A99900
	|-Task<Nullable<Item>>..ctor
	|
	|-RVA: 0x1A9A800 Offset: 0x1A98E00 VA: 0x181A9A800
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1A56E70 Offset: 0x1A55470 VA: 0x181A56E70
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x1A55D50 Offset: 0x1A54350 VA: 0x181A55D50
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x1A561F0 Offset: 0x1A547F0 VA: 0x181A561F0
	|-Task<object>..ctor
	|
	|-RVA: 0x1A572E0 Offset: 0x1A558E0 VA: 0x181A572E0
	|-Task<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A9BD60 Offset: 0x1A9A360 VA: 0x181A9BD60
	|-Task<PublishResult>..ctor
	|
	|-RVA: 0x1A9BE40 Offset: 0x1A9A440 VA: 0x181A9BE40
	|-Task<bool>..ctor
	|
	|-RVA: 0x1A99550 Offset: 0x1A97B50 VA: 0x181A99550
	|-Task<int>..ctor
	|
	|-RVA: 0x1A99630 Offset: 0x1A97C30 VA: 0x181A99630
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0x1A99710 Offset: 0x1A97D10 VA: 0x181A99710
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x1A9A1D0 Offset: 0x1A987D0 VA: 0x181A9A1D0
	|-Task<Nullable<Image>>..ctor
	|
	|-RVA: 0x1A9B580 Offset: 0x1A99B80 VA: 0x181A9B580
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1A99DF0 Offset: 0x1A983F0 VA: 0x181A99DF0
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1A99A30 Offset: 0x1A98030 VA: 0x181A99A30
	|-Task<Nullable<Item>>..ctor
	|
	|-RVA: 0x1A9BAD0 Offset: 0x1A9A0D0 VA: 0x181A9BAD0
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1A568F0 Offset: 0x1A54EF0 VA: 0x181A568F0
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x1A55F10 Offset: 0x1A54510 VA: 0x181A55F10
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x1A562A0 Offset: 0x1A548A0 VA: 0x181A562A0
	|-Task<object>..ctor
	|
	|-RVA: 0x1A55FF0 Offset: 0x1A545F0 VA: 0x181A55FF0
	|-Task<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A9AA20 Offset: 0x1A99020 VA: 0x181A9AA20
	|-Task<PublishResult>..ctor
	|
	|-RVA: 0x1A9C820 Offset: 0x1A9AE20 VA: 0x181A9C820
	|-Task<bool>..ctor
	|
	|-RVA: 0x1A9B7E0 Offset: 0x1A99DE0 VA: 0x181A9B7E0
	|-Task<int>..ctor
	|
	|-RVA: 0x1A9B380 Offset: 0x1A99980 VA: 0x181A9B380
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0x1A9A940 Offset: 0x1A98F40 VA: 0x181A9A940
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x1A9ABF0 Offset: 0x1A991F0 VA: 0x181A9ABF0
	|-Task<Nullable<Image>>..ctor
	|
	|-RVA: 0x1A9A0F0 Offset: 0x1A986F0 VA: 0x181A9A0F0
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1A9A2B0 Offset: 0x1A988B0 VA: 0x181A9A2B0
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1A9C740 Offset: 0x1A9AD40 VA: 0x181A9C740
	|-Task<Nullable<Item>>..ctor
	|
	|-RVA: 0x1A9A390 Offset: 0x1A98990 VA: 0x181A9A390
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1A56460 Offset: 0x1A54A60 VA: 0x181A56460
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x1A56F10 Offset: 0x1A55510 VA: 0x181A56F10
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x1A56FF0 Offset: 0x1A555F0 VA: 0x181A56FF0
	|-Task<object>..ctor
	|
	|-RVA: 0x1A56380 Offset: 0x1A54980 VA: 0x181A56380
	|-Task<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A9CB30 Offset: 0x1A9B130 VA: 0x181A9CB30
	|-Task<PublishResult>..ctor
	|
	|-RVA: 0x1A9C2C0 Offset: 0x1A9A8C0 VA: 0x181A9C2C0
	|-Task<bool>..ctor
	|
	|-RVA: 0x1A991F0 Offset: 0x1A977F0 VA: 0x181A991F0
	|-Task<int>..ctor
	|
	|-RVA: 0x1A9C620 Offset: 0x1A9AC20 VA: 0x181A9C620
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0x1A99ED0 Offset: 0x1A984D0 VA: 0x181A99ED0
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x1A99310 Offset: 0x1A97910 VA: 0x181A99310
	|-Task<Nullable<Image>>..ctor
	|
	|-RVA: 0x1A9B460 Offset: 0x1A99A60 VA: 0x181A9B460
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1A98FB0 Offset: 0x1A975B0 VA: 0x181A98FB0
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1A99430 Offset: 0x1A97A30 VA: 0x181A99430
	|-Task<Nullable<Item>>..ctor
	|
	|-RVA: 0x1A9CDF0 Offset: 0x1A9B3F0 VA: 0x181A9CDF0
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1A567D0 Offset: 0x1A54DD0 VA: 0x181A567D0
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x1A57410 Offset: 0x1A55A10 VA: 0x181A57410
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x1A57160 Offset: 0x1A55760 VA: 0x181A57160
	|-Task<object>..ctor
	|
	|-RVA: 0x1A56CD0 Offset: 0x1A552D0 VA: 0x181A56CD0
	|-Task<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Delegate valueSelector, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A9A530 Offset: 0x1A98B30 VA: 0x181A9A530
	|-Task<PublishResult>..ctor
	|
	|-RVA: 0x1A9B050 Offset: 0x1A99650 VA: 0x181A9B050
	|-Task<bool>..ctor
	|
	|-RVA: 0x1A9A6E0 Offset: 0x1A98CE0 VA: 0x181A9A6E0
	|-Task<int>..ctor
	|
	|-RVA: 0x1A9C3E0 Offset: 0x1A9A9E0 VA: 0x181A9C3E0
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0x1A99B10 Offset: 0x1A98110 VA: 0x181A99B10
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x1A9C500 Offset: 0x1A9AB00 VA: 0x181A9C500
	|-Task<Nullable<Image>>..ctor
	|
	|-RVA: 0x1A9B6C0 Offset: 0x1A99CC0 VA: 0x181A9B6C0
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1A9B8C0 Offset: 0x1A99EC0 VA: 0x181A9B8C0
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1A9BC40 Offset: 0x1A9A240 VA: 0x181A9BC40
	|-Task<Nullable<Item>>..ctor
	|
	|-RVA: 0x1A9B260 Offset: 0x1A99860 VA: 0x181A9B260
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1A55DF0 Offset: 0x1A543F0 VA: 0x181A55DF0
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x1A56620 Offset: 0x1A54C20 VA: 0x181A56620
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x1A560D0 Offset: 0x1A546D0 VA: 0x181A560D0
	|-Task<object>..ctor
	|
	|-RVA: 0x1A56B20 Offset: 0x1A55120 VA: 0x181A56B20
	|-Task<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> StartNew(Task parent, Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A98690 Offset: 0x1A96C90 VA: 0x181A98690
	|-Task<PublishResult>.StartNew
	|
	|-RVA: 0x1A97910 Offset: 0x1A95F10 VA: 0x181A97910
	|-Task<bool>.StartNew
	|
	|-RVA: 0x1A976D0 Offset: 0x1A95CD0 VA: 0x181A976D0
	|-Task<int>.StartNew
	|
	|-RVA: 0x1A97D90 Offset: 0x1A96390 VA: 0x181A97D90
	|-Task<UdpReceiveResult>.StartNew
	|
	|-RVA: 0x1A97B50 Offset: 0x1A96150 VA: 0x181A97B50
	|-Task<Nullable<ServerInfo>>.StartNew
	|
	|-RVA: 0x1A98450 Offset: 0x1A96A50 VA: 0x181A98450
	|-Task<Nullable<Image>>.StartNew
	|
	|-RVA: 0x1A97490 Offset: 0x1A95A90 VA: 0x181A97490
	|-Task<Nullable<InventoryPurchaseResult>>.StartNew
	|
	|-RVA: 0x1A97250 Offset: 0x1A95850 VA: 0x181A97250
	|-Task<Nullable<InventoryResult>>.StartNew
	|
	|-RVA: 0x1A98210 Offset: 0x1A96810 VA: 0x181A98210
	|-Task<Nullable<Item>>.StartNew
	|
	|-RVA: 0x1A97FD0 Offset: 0x1A965D0 VA: 0x181A97FD0
	|-Task<Nullable<ResultPage>>.StartNew
	|
	|-RVA: 0x1A55440 Offset: 0x1A53A40 VA: 0x181A55440
	|-Task<Nullable<int>>.StartNew
	|
	|-RVA: 0x1A54D80 Offset: 0x1A53380 VA: 0x181A54D80
	|-Task<Nullable<Int32Enum>>.StartNew
	|
	|-RVA: 0x1A54FC0 Offset: 0x1A535C0 VA: 0x181A54FC0
	|-Task<object>.StartNew
	|
	|-RVA: 0x1A55200 Offset: 0x1A53800 VA: 0x181A55200
	|-Task<VoidTaskResult>.StartNew
	*/

	// RVA: -1 Offset: -1
	internal bool TrySetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A98EF0 Offset: 0x1A974F0 VA: 0x181A98EF0
	|-Task<PublishResult>.TrySetResult
	|
	|-RVA: 0x1A55920 Offset: 0x1A53F20 VA: 0x181A55920
	|-Task<bool>.TrySetResult
	|-Task<VoidTaskResult>.TrySetResult
	|
	|-RVA: 0x1A988D0 Offset: 0x1A96ED0 VA: 0x181A988D0
	|-Task<int>.TrySetResult
	|
	|-RVA: 0x1A98A40 Offset: 0x1A97040 VA: 0x181A98A40
	|-Task<UdpReceiveResult>.TrySetResult
	|
	|-RVA: 0x1A98C50 Offset: 0x1A97250 VA: 0x181A98C50
	|-Task<Nullable<ServerInfo>>.TrySetResult
	|
	|-RVA: 0x1A98D60 Offset: 0x1A97360 VA: 0x181A98D60
	|-Task<Nullable<Image>>.TrySetResult
	|
	|-RVA: 0x1A98980 Offset: 0x1A96F80 VA: 0x181A98980
	|-Task<Nullable<InventoryPurchaseResult>>.TrySetResult
	|-Task<Nullable<ResultPage>>.TrySetResult
	|
	|-RVA: 0x1A98E30 Offset: 0x1A97430 VA: 0x181A98E30
	|-Task<Nullable<InventoryResult>>.TrySetResult
	|
	|-RVA: 0x1A98B00 Offset: 0x1A97100 VA: 0x181A98B00
	|-Task<Nullable<Item>>.TrySetResult
	|
	|-RVA: 0x1A557B0 Offset: 0x1A53DB0 VA: 0x181A557B0
	|-Task<Nullable<int>>.TrySetResult
	|-Task<Nullable<Int32Enum>>.TrySetResult
	|
	|-RVA: 0x1A55860 Offset: 0x1A53E60 VA: 0x181A55860
	|-Task<object>.TrySetResult
	|-Task<Task>.TrySetResult
	*/

	// RVA: -1 Offset: -1
	internal void DangerousSetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A96410 Offset: 0x1A94A10 VA: 0x181A96410
	|-Task<PublishResult>.DangerousSetResult
	|
	|-RVA: 0x1A548B0 Offset: 0x1A52EB0 VA: 0x181A548B0
	|-Task<bool>.DangerousSetResult
	|-Task<VoidTaskResult>.DangerousSetResult
	|
	|-RVA: 0x1A961C0 Offset: 0x1A947C0 VA: 0x181A961C0
	|-Task<int>.DangerousSetResult
	|
	|-RVA: 0x1A96220 Offset: 0x1A94820 VA: 0x181A96220
	|-Task<UdpReceiveResult>.DangerousSetResult
	|
	|-RVA: 0x1A96300 Offset: 0x1A94900 VA: 0x181A96300
	|-Task<Nullable<ServerInfo>>.DangerousSetResult
	|
	|-RVA: 0x1A96490 Offset: 0x1A94A90 VA: 0x181A96490
	|-Task<Nullable<Image>>.DangerousSetResult
	|
	|-RVA: 0x1A96290 Offset: 0x1A94890 VA: 0x181A96290
	|-Task<Nullable<InventoryPurchaseResult>>.DangerousSetResult
	|-Task<Nullable<ResultPage>>.DangerousSetResult
	|
	|-RVA: 0x1A96150 Offset: 0x1A94750 VA: 0x181A96150
	|-Task<Nullable<InventoryResult>>.DangerousSetResult
	|
	|-RVA: 0x1A95FD0 Offset: 0x1A945D0 VA: 0x181A95FD0
	|-Task<Nullable<Item>>.DangerousSetResult
	|
	|-RVA: 0x1A54910 Offset: 0x1A52F10 VA: 0x181A54910
	|-Task<Nullable<int>>.DangerousSetResult
	|-Task<Nullable<Int32Enum>>.DangerousSetResult
	|
	|-RVA: 0x1A54970 Offset: 0x1A52F70 VA: 0x181A54970
	|-Task<object>.DangerousSetResult
	*/

	// RVA: -1 Offset: -1
	public TResult get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A57530 Offset: 0x1A55B30 VA: 0x181A57530
	|-Task<ISocket>.get_Result
	|-Task<SteamInventoryCrafting.MarketPrice>.get_Result
	|-Task<Nullable<int>>.get_Result
	|-Task<Nullable<Int32Enum>>.get_Result
	|-Task<object>.get_Result
	|-Task<Task>.get_Result
	|
	|-RVA: 0x1A9D410 Offset: 0x1A9BA10 VA: 0x181A9D410
	|-Task<PublishResult>.get_Result
	|-Task<Nullable<Image>>.get_Result
	|
	|-RVA: 0x1A575A0 Offset: 0x1A55BA0 VA: 0x181A575A0
	|-Task<bool>.get_Result
	|-Task<VoidTaskResult>.get_Result
	|
	|-RVA: 0x1A9D3A0 Offset: 0x1A9B9A0 VA: 0x181A9D3A0
	|-Task<int>.get_Result
	|
	|-RVA: 0x1A9D280 Offset: 0x1A9B880 VA: 0x181A9D280
	|-Task<UdpReceiveResult>.get_Result
	|
	|-RVA: 0x1A9D4B0 Offset: 0x1A9BAB0 VA: 0x181A9D4B0
	|-Task<Nullable<ServerInfo>>.get_Result
	|
	|-RVA: 0x1A9D310 Offset: 0x1A9B910 VA: 0x181A9D310
	|-Task<Nullable<InventoryPurchaseResult>>.get_Result
	|-Task<Nullable<ResultPage>>.get_Result
	|
	|-RVA: 0x1A9D070 Offset: 0x1A9B670 VA: 0x181A9D070
	|-Task<Nullable<InventoryResult>>.get_Result
	|
	|-RVA: 0x1A9D110 Offset: 0x1A9B710 VA: 0x181A9D110
	|-Task<Nullable<Item>>.get_Result
	*/

	// RVA: -1 Offset: -1
	internal TResult get_ResultOnSuccess() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A9CF30 Offset: 0x1A9B530 VA: 0x181A9CF30
	|-Task<PublishResult>.get_ResultOnSuccess
	|-Task<Nullable<Image>>.get_ResultOnSuccess
	|
	|-RVA: 0x77B0E0 Offset: 0x7796E0 VA: 0x18077B0E0
	|-Task<bool>.get_ResultOnSuccess
	|-Task<VoidTaskResult>.get_ResultOnSuccess
	|
	|-RVA: 0x8D8F00 Offset: 0x8D7500 VA: 0x1808D8F00
	|-Task<int>.get_ResultOnSuccess
	|
	|-RVA: 0x105DDA0 Offset: 0x105C3A0 VA: 0x18105DDA0
	|-Task<UdpReceiveResult>.get_ResultOnSuccess
	|
	|-RVA: 0x1A9D010 Offset: 0x1A9B610 VA: 0x181A9D010
	|-Task<Nullable<ServerInfo>>.get_ResultOnSuccess
	|
	|-RVA: 0x1A9CFF0 Offset: 0x1A9B5F0 VA: 0x181A9CFF0
	|-Task<Nullable<InventoryPurchaseResult>>.get_ResultOnSuccess
	|-Task<Nullable<ResultPage>>.get_ResultOnSuccess
	|
	|-RVA: 0x1A9CF10 Offset: 0x1A9B510 VA: 0x181A9CF10
	|-Task<Nullable<InventoryResult>>.get_ResultOnSuccess
	|
	|-RVA: 0x1A9CF50 Offset: 0x1A9B550 VA: 0x181A9CF50
	|-Task<Nullable<Item>>.get_ResultOnSuccess
	|
	|-RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	|-Task<Nullable<int>>.get_ResultOnSuccess
	|-Task<Nullable<Int32Enum>>.get_ResultOnSuccess
	|-Task<object>.get_ResultOnSuccess
	*/

	// RVA: -1 Offset: -1
	internal TResult GetResultCore(bool waitCompletionNotification) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A96510 Offset: 0x1A94B10 VA: 0x181A96510
	|-Task<PublishResult>.GetResultCore
	|-Task<Nullable<Image>>.GetResultCore
	|
	|-RVA: 0x1A54A00 Offset: 0x1A53000 VA: 0x181A54A00
	|-Task<bool>.GetResultCore
	|-Task<VoidTaskResult>.GetResultCore
	|
	|-RVA: 0x1A96840 Offset: 0x1A94E40 VA: 0x181A96840
	|-Task<int>.GetResultCore
	|
	|-RVA: 0x1A967B0 Offset: 0x1A94DB0 VA: 0x181A967B0
	|-Task<UdpReceiveResult>.GetResultCore
	|
	|-RVA: 0x1A966D0 Offset: 0x1A94CD0 VA: 0x181A966D0
	|-Task<Nullable<ServerInfo>>.GetResultCore
	|
	|-RVA: 0x1A965B0 Offset: 0x1A94BB0 VA: 0x181A965B0
	|-Task<Nullable<InventoryPurchaseResult>>.GetResultCore
	|-Task<Nullable<ResultPage>>.GetResultCore
	|
	|-RVA: 0x1A96640 Offset: 0x1A94C40 VA: 0x181A96640
	|-Task<Nullable<InventoryResult>>.GetResultCore
	|
	|-RVA: 0x1A968B0 Offset: 0x1A94EB0 VA: 0x181A968B0
	|-Task<Nullable<Item>>.GetResultCore
	|
	|-RVA: 0x1A54A80 Offset: 0x1A53080 VA: 0x181A54A80
	|-Task<Nullable<int>>.GetResultCore
	|-Task<Nullable<Int32Enum>>.GetResultCore
	|-Task<object>.GetResultCore
	*/

	// RVA: -1 Offset: -1
	internal bool TrySetException(object exceptionObject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A55730 Offset: 0x1A53D30 VA: 0x181A55730
	|-Task<PublishResult>.TrySetException
	|-Task<bool>.TrySetException
	|-Task<int>.TrySetException
	|-Task<UdpReceiveResult>.TrySetException
	|-Task<Nullable<ServerInfo>>.TrySetException
	|-Task<Nullable<Image>>.TrySetException
	|-Task<Nullable<InventoryPurchaseResult>>.TrySetException
	|-Task<Nullable<InventoryResult>>.TrySetException
	|-Task<Nullable<Item>>.TrySetException
	|-Task<Nullable<ResultPage>>.TrySetException
	|-Task<Nullable<int>>.TrySetException
	|-Task<Nullable<Int32Enum>>.TrySetException
	|-Task<object>.TrySetException
	|-Task<VoidTaskResult>.TrySetException
	*/

	// RVA: -1 Offset: -1
	internal bool TrySetCanceled(CancellationToken tokenToRecord) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A55680 Offset: 0x1A53C80 VA: 0x181A55680
	|-Task<PublishResult>.TrySetCanceled
	|-Task<bool>.TrySetCanceled
	|-Task<int>.TrySetCanceled
	|-Task<UdpReceiveResult>.TrySetCanceled
	|-Task<Nullable<ServerInfo>>.TrySetCanceled
	|-Task<Nullable<Image>>.TrySetCanceled
	|-Task<Nullable<InventoryPurchaseResult>>.TrySetCanceled
	|-Task<Nullable<InventoryResult>>.TrySetCanceled
	|-Task<Nullable<Item>>.TrySetCanceled
	|-Task<Nullable<ResultPage>>.TrySetCanceled
	|-Task<Nullable<int>>.TrySetCanceled
	|-Task<Nullable<Int32Enum>>.TrySetCanceled
	|-Task<object>.TrySetCanceled
	|-Task<VoidTaskResult>.TrySetCanceled
	*/

	// RVA: -1 Offset: -1
	internal bool TrySetCanceled(CancellationToken tokenToRecord, object cancellationException) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A556B0 Offset: 0x1A53CB0 VA: 0x181A556B0
	|-Task<PublishResult>.TrySetCanceled
	|-Task<bool>.TrySetCanceled
	|-Task<int>.TrySetCanceled
	|-Task<UdpReceiveResult>.TrySetCanceled
	|-Task<Nullable<ServerInfo>>.TrySetCanceled
	|-Task<Nullable<Image>>.TrySetCanceled
	|-Task<Nullable<InventoryPurchaseResult>>.TrySetCanceled
	|-Task<Nullable<InventoryResult>>.TrySetCanceled
	|-Task<Nullable<Item>>.TrySetCanceled
	|-Task<Nullable<ResultPage>>.TrySetCanceled
	|-Task<Nullable<int>>.TrySetCanceled
	|-Task<Nullable<Int32Enum>>.TrySetCanceled
	|-Task<object>.TrySetCanceled
	|-Task<VoidTaskResult>.TrySetCanceled
	*/

	// RVA: -1 Offset: -1
	public static TaskFactory<TResult> get_Factory() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x117DAB0 Offset: 0x117C0B0 VA: 0x18117DAB0
	|-Task<Stream>.get_Factory
	|-Task<int>.get_Factory
	|-Task<UdpReceiveResult>.get_Factory
	|-Task<WebResponse>.get_Factory
	|-Task<PublishResult>.get_Factory
	|-Task<bool>.get_Factory
	|-Task<Nullable<ServerInfo>>.get_Factory
	|-Task<Nullable<Image>>.get_Factory
	|-Task<Nullable<InventoryPurchaseResult>>.get_Factory
	|-Task<Nullable<InventoryResult>>.get_Factory
	|-Task<Nullable<Item>>.get_Factory
	|-Task<Nullable<ResultPage>>.get_Factory
	|-Task<Nullable<int>>.get_Factory
	|-Task<Nullable<Int32Enum>>.get_Factory
	|-Task<object>.get_Factory
	|-Task<VoidTaskResult>.get_Factory
	*/

	// RVA: -1 Offset: -1 Slot: 19
	internal override void InnerInvoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A97160 Offset: 0x1A95760 VA: 0x181A97160
	|-Task<PublishResult>.InnerInvoke
	|
	|-RVA: 0x1A54CB0 Offset: 0x1A532B0 VA: 0x181A54CB0
	|-Task<bool>.InnerInvoke
	|-Task<VoidTaskResult>.InnerInvoke
	|
	|-RVA: 0x1A96C80 Offset: 0x1A95280 VA: 0x181A96C80
	|-Task<int>.InnerInvoke
	|
	|-RVA: 0x1A97070 Offset: 0x1A95670 VA: 0x181A97070
	|-Task<UdpReceiveResult>.InnerInvoke
	|
	|-RVA: 0x1A96E40 Offset: 0x1A95440 VA: 0x181A96E40
	|-Task<Nullable<ServerInfo>>.InnerInvoke
	|
	|-RVA: 0x1A969C0 Offset: 0x1A94FC0 VA: 0x181A969C0
	|-Task<Nullable<Image>>.InnerInvoke
	|
	|-RVA: 0x1A96D50 Offset: 0x1A95350 VA: 0x181A96D50
	|-Task<Nullable<InventoryPurchaseResult>>.InnerInvoke
	|-Task<Nullable<ResultPage>>.InnerInvoke
	|
	|-RVA: 0x1A96F80 Offset: 0x1A95580 VA: 0x181A96F80
	|-Task<Nullable<InventoryResult>>.InnerInvoke
	|
	|-RVA: 0x1A96AB0 Offset: 0x1A950B0 VA: 0x181A96AB0
	|-Task<Nullable<Item>>.InnerInvoke
	|
	|-RVA: 0x1A54B00 Offset: 0x1A53100 VA: 0x181A54B00
	|-Task<Nullable<int>>.InnerInvoke
	|-Task<Nullable<Int32Enum>>.InnerInvoke
	|
	|-RVA: 0x1A54BD0 Offset: 0x1A531D0 VA: 0x181A54BD0
	|-Task<object>.InnerInvoke
	|-Task<Task>.InnerInvoke
	*/

	// RVA: -1 Offset: -1
	public TaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A549D0 Offset: 0x1A52FD0 VA: 0x181A549D0
	|-Task<CompanionSubscription.Status>.GetAwaiter
	|-Task<IAuthTicket>.GetAwaiter
	|-Task<IPlayerInfo>.GetAwaiter
	|-Task<IPlayerInventory>.GetAwaiter
	|-Task<IPlayerInventory[]>.GetAwaiter
	|-Task<MP3Stream>.GetAwaiter
	|-Task<SteamInventoryCrafting.MarketPrice>.GetAwaiter
	|-Task<AuthTicket>.GetAwaiter
	|-Task<InventoryDef[]>.GetAwaiter
	|-Task<PublishResult>.GetAwaiter
	|-Task<byte[]>.GetAwaiter
	|-Task<Dictionary<string, string>>.GetAwaiter
	|-Task<List<IPlayerItemDefinition>>.GetAwaiter
	|-Task<Stream>.GetAwaiter
	|-Task<HttpResponseMessage>.GetAwaiter
	|-Task<UdpReceiveResult>.GetAwaiter
	|-Task<Nullable<ServerInfo>>.GetAwaiter
	|-Task<Nullable<Image>>.GetAwaiter
	|-Task<Nullable<InventoryPurchaseResult>>.GetAwaiter
	|-Task<Nullable<InventoryResult>>.GetAwaiter
	|-Task<Nullable<Item>>.GetAwaiter
	|-Task<Nullable<ResultPage>>.GetAwaiter
	|-Task<string>.GetAwaiter
	|-Task<bool>.GetAwaiter
	|-Task<int>.GetAwaiter
	|-Task<Nullable<int>>.GetAwaiter
	|-Task<Nullable<Int32Enum>>.GetAwaiter
	|-Task<object>.GetAwaiter
	|-Task<VoidTaskResult>.GetAwaiter
	*/

	// RVA: -1 Offset: -1
	public ConfiguredTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A53DC0 Offset: 0x1A523C0 VA: 0x181A53DC0
	|-Task<AsyncProtocolResult>.ConfigureAwait
	|-Task<Stream>.ConfigureAwait
	|-Task<HttpResponseMessage>.ConfigureAwait
	|-Task<WebResponse>.ConfigureAwait
	|-Task<Nullable<int>>.ConfigureAwait
	|-Task<string>.ConfigureAwait
	|-Task<PublishResult>.ConfigureAwait
	|-Task<bool>.ConfigureAwait
	|-Task<int>.ConfigureAwait
	|-Task<UdpReceiveResult>.ConfigureAwait
	|-Task<Nullable<ServerInfo>>.ConfigureAwait
	|-Task<Nullable<Image>>.ConfigureAwait
	|-Task<Nullable<InventoryPurchaseResult>>.ConfigureAwait
	|-Task<Nullable<InventoryResult>>.ConfigureAwait
	|-Task<Nullable<Item>>.ConfigureAwait
	|-Task<Nullable<ResultPage>>.ConfigureAwait
	|-Task<Nullable<Int32Enum>>.ConfigureAwait
	|-Task<object>.ConfigureAwait
	|-Task<Task>.ConfigureAwait
	|-Task<VoidTaskResult>.ConfigureAwait
	*/

	// RVA: -1 Offset: -1
	public Task ContinueWith(Action<Task<TResult>> continuationAction, TaskContinuationOptions continuationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A54480 Offset: 0x1A52A80 VA: 0x181A54480
	|-Task<ISocket>.ContinueWith
	|-Task<object>.ContinueWith
	|
	|-RVA: 0x1A94C40 Offset: 0x1A93240 VA: 0x181A94C40
	|-Task<PublishResult>.ContinueWith
	|
	|-RVA: 0x1A95320 Offset: 0x1A93920 VA: 0x181A95320
	|-Task<bool>.ContinueWith
	|
	|-RVA: 0x1A95260 Offset: 0x1A93860 VA: 0x181A95260
	|-Task<int>.ContinueWith
	|
	|-RVA: 0x1A94D00 Offset: 0x1A93300 VA: 0x181A94D00
	|-Task<UdpReceiveResult>.ContinueWith
	|
	|-RVA: 0x1A951A0 Offset: 0x1A937A0 VA: 0x181A951A0
	|-Task<Nullable<ServerInfo>>.ContinueWith
	|
	|-RVA: 0x1A945B0 Offset: 0x1A92BB0 VA: 0x181A945B0
	|-Task<Nullable<Image>>.ContinueWith
	|
	|-RVA: 0x1A95C60 Offset: 0x1A94260 VA: 0x181A95C60
	|-Task<Nullable<InventoryPurchaseResult>>.ContinueWith
	|
	|-RVA: 0x1A959B0 Offset: 0x1A93FB0 VA: 0x181A959B0
	|-Task<Nullable<InventoryResult>>.ContinueWith
	|
	|-RVA: 0x1A95F10 Offset: 0x1A94510 VA: 0x181A95F10
	|-Task<Nullable<Item>>.ContinueWith
	|
	|-RVA: 0x1A944F0 Offset: 0x1A92AF0 VA: 0x181A944F0
	|-Task<Nullable<ResultPage>>.ContinueWith
	|
	|-RVA: 0x1A54730 Offset: 0x1A52D30 VA: 0x181A54730
	|-Task<Nullable<int>>.ContinueWith
	|
	|-RVA: 0x1A541D0 Offset: 0x1A527D0 VA: 0x181A541D0
	|-Task<Nullable<Int32Enum>>.ContinueWith
	|
	|-RVA: 0x1A547F0 Offset: 0x1A52DF0 VA: 0x181A547F0
	|-Task<VoidTaskResult>.ContinueWith
	*/

	// RVA: -1 Offset: -1
	internal Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A953E0 Offset: 0x1A939E0 VA: 0x181A953E0
	|-Task<PublishResult>.ContinueWith
	|
	|-RVA: 0x1A95D20 Offset: 0x1A94320 VA: 0x181A95D20
	|-Task<bool>.ContinueWith
	|
	|-RVA: 0x1A94A50 Offset: 0x1A93050 VA: 0x181A94A50
	|-Task<int>.ContinueWith
	|
	|-RVA: 0x1A94860 Offset: 0x1A92E60 VA: 0x181A94860
	|-Task<UdpReceiveResult>.ContinueWith
	|
	|-RVA: 0x1A94DC0 Offset: 0x1A933C0 VA: 0x181A94DC0
	|-Task<Nullable<ServerInfo>>.ContinueWith
	|
	|-RVA: 0x1A94670 Offset: 0x1A92C70 VA: 0x181A94670
	|-Task<Nullable<Image>>.ContinueWith
	|
	|-RVA: 0x1A94FB0 Offset: 0x1A935B0 VA: 0x181A94FB0
	|-Task<Nullable<InventoryPurchaseResult>>.ContinueWith
	|
	|-RVA: 0x1A957C0 Offset: 0x1A93DC0 VA: 0x181A957C0
	|-Task<Nullable<InventoryResult>>.ContinueWith
	|
	|-RVA: 0x1A95A70 Offset: 0x1A94070 VA: 0x181A95A70
	|-Task<Nullable<Item>>.ContinueWith
	|
	|-RVA: 0x1A955D0 Offset: 0x1A93BD0 VA: 0x181A955D0
	|-Task<Nullable<ResultPage>>.ContinueWith
	|
	|-RVA: 0x1A54290 Offset: 0x1A52890 VA: 0x181A54290
	|-Task<Nullable<int>>.ContinueWith
	|
	|-RVA: 0x1A53DF0 Offset: 0x1A523F0 VA: 0x181A53DF0
	|-Task<Nullable<Int32Enum>>.ContinueWith
	|
	|-RVA: 0x1A53FE0 Offset: 0x1A525E0 VA: 0x181A53FE0
	|-Task<object>.ContinueWith
	|
	|-RVA: 0x1A54540 Offset: 0x1A52B40 VA: 0x181A54540
	|-Task<VoidTaskResult>.ContinueWith
	*/

	// RVA: -1 Offset: -1
	public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED8F80 Offset: 0xED7580 VA: 0x180ED8F80
	|-Task<Dictionary<string, string>>.ContinueWith<Task<Dictionary<string, string>>>
	|-Task<object>.ContinueWith<object>
	*/

	// RVA: -1 Offset: -1
	internal Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED9030 Offset: 0xED7630 VA: 0x180ED9030
	|-Task<object>.ContinueWith<object>
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A559D0 Offset: 0x1A53FD0 VA: 0x181A559D0
	|-Task<PublishResult>..cctor
	|-Task<bool>..cctor
	|-Task<int>..cctor
	|-Task<UdpReceiveResult>..cctor
	|-Task<Nullable<ServerInfo>>..cctor
	|-Task<Nullable<Image>>..cctor
	|-Task<Nullable<InventoryPurchaseResult>>..cctor
	|-Task<Nullable<InventoryResult>>..cctor
	|-Task<Nullable<Item>>..cctor
	|-Task<Nullable<ResultPage>>..cctor
	|-Task<Nullable<int>>..cctor
	|-Task<Nullable<Int32Enum>>..cctor
	|-Task<object>..cctor
	|-Task<VoidTaskResult>..cctor
	*/

}

public class TaskFactory<TResult> // TypeDefIndex: 845
{
// Namespace: System.Threading.Tasks
public class TaskFactory<TResult> // TypeDefIndex: 845
	// Fields
	private CancellationToken m_defaultCancellationToken; // 0x0
	private TaskScheduler m_defaultScheduler; // 0x0
	private TaskCreationOptions m_defaultCreationOptions; // 0x0
	private TaskContinuationOptions m_defaultContinuationOptions; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A944B0 Offset: 0x1A92AB0 VA: 0x181A944B0
	|-TaskFactory<PublishResult>..ctor
	|-TaskFactory<bool>..ctor
	|-TaskFactory<int>..ctor
	|-TaskFactory<UdpReceiveResult>..ctor
	|-TaskFactory<Nullable<ServerInfo>>..ctor
	|-TaskFactory<Nullable<Image>>..ctor
	|-TaskFactory<Nullable<InventoryPurchaseResult>>..ctor
	|-TaskFactory<Nullable<InventoryResult>>..ctor
	|-TaskFactory<Nullable<Item>>..ctor
	|-TaskFactory<Nullable<ResultPage>>..ctor
	|-TaskFactory<Nullable<int>>..ctor
	|-TaskFactory<Nullable<Int32Enum>>..ctor
	|-TaskFactory<object>..ctor
	|-TaskFactory<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A94430 Offset: 0x1A92A30 VA: 0x181A94430
	|-TaskFactory<PublishResult>..ctor
	|-TaskFactory<bool>..ctor
	|-TaskFactory<int>..ctor
	|-TaskFactory<UdpReceiveResult>..ctor
	|-TaskFactory<Nullable<ServerInfo>>..ctor
	|-TaskFactory<Nullable<Image>>..ctor
	|-TaskFactory<Nullable<InventoryPurchaseResult>>..ctor
	|-TaskFactory<Nullable<InventoryResult>>..ctor
	|-TaskFactory<Nullable<Item>>..ctor
	|-TaskFactory<Nullable<ResultPage>>..ctor
	|-TaskFactory<Nullable<int>>..ctor
	|-TaskFactory<Nullable<Int32Enum>>..ctor
	|-TaskFactory<object>..ctor
	|-TaskFactory<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> StartNew(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A93EF0 Offset: 0x1A924F0 VA: 0x181A93EF0
	|-TaskFactory<PublishResult>.StartNew
	|
	|-RVA: 0x1A93860 Offset: 0x1A91E60 VA: 0x181A93860
	|-TaskFactory<bool>.StartNew
	|
	|-RVA: 0x1A93710 Offset: 0x1A91D10 VA: 0x181A93710
	|-TaskFactory<int>.StartNew
	|
	|-RVA: 0x1A93470 Offset: 0x1A91A70 VA: 0x181A93470
	|-TaskFactory<UdpReceiveResult>.StartNew
	|
	|-RVA: 0x1A94040 Offset: 0x1A92640 VA: 0x181A94040
	|-TaskFactory<Nullable<ServerInfo>>.StartNew
	|
	|-RVA: 0x1A94190 Offset: 0x1A92790 VA: 0x181A94190
	|-TaskFactory<Nullable<Image>>.StartNew
	|
	|-RVA: 0x1A93320 Offset: 0x1A91920 VA: 0x181A93320
	|-TaskFactory<Nullable<InventoryPurchaseResult>>.StartNew
	|
	|-RVA: 0x1A93DA0 Offset: 0x1A923A0 VA: 0x181A93DA0
	|-TaskFactory<Nullable<InventoryResult>>.StartNew
	|
	|-RVA: 0x1A93C50 Offset: 0x1A92250 VA: 0x181A93C50
	|-TaskFactory<Nullable<Item>>.StartNew
	|
	|-RVA: 0x1A935C0 Offset: 0x1A91BC0 VA: 0x181A935C0
	|-TaskFactory<Nullable<ResultPage>>.StartNew
	|
	|-RVA: 0x1A93B00 Offset: 0x1A92100 VA: 0x181A93B00
	|-TaskFactory<Nullable<int>>.StartNew
	|
	|-RVA: 0x1A939B0 Offset: 0x1A91FB0 VA: 0x181A939B0
	|-TaskFactory<Nullable<Int32Enum>>.StartNew
	|
	|-RVA: 0x1A931D0 Offset: 0x1A917D0 VA: 0x181A931D0
	|-TaskFactory<object>.StartNew
	|
	|-RVA: 0x1A942E0 Offset: 0x1A928E0 VA: 0x181A942E0
	|-TaskFactory<VoidTaskResult>.StartNew
	*/

	// RVA: -1 Offset: -1
	private static void FromAsyncCoreLogic(IAsyncResult iar, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, Task<TResult> promise, bool requiresSynchronization) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A89460 Offset: 0x1A87A60 VA: 0x181A89460
	|-TaskFactory<PublishResult>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A8A7D0 Offset: 0x1A88DD0 VA: 0x181A8A7D0
	|-TaskFactory<bool>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A89DE0 Offset: 0x1A883E0 VA: 0x181A89DE0
	|-TaskFactory<int>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A8AC60 Offset: 0x1A89260 VA: 0x181A8AC60
	|-TaskFactory<UdpReceiveResult>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A8A270 Offset: 0x1A88870 VA: 0x181A8A270
	|-TaskFactory<Nullable<ServerInfo>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A89920 Offset: 0x1A87F20 VA: 0x181A89920
	|-TaskFactory<Nullable<Image>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A8C940 Offset: 0x1A8AF40 VA: 0x181A8C940
	|-TaskFactory<Nullable<InventoryPurchaseResult>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A8BA20 Offset: 0x1A8A020 VA: 0x181A8BA20
	|-TaskFactory<Nullable<InventoryResult>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A8BEC0 Offset: 0x1A8A4C0 VA: 0x181A8BEC0
	|-TaskFactory<Nullable<Item>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A8B100 Offset: 0x1A89700 VA: 0x181A8B100
	|-TaskFactory<Nullable<ResultPage>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A8C4D0 Offset: 0x1A8AAD0 VA: 0x181A8C4D0
	|-TaskFactory<Nullable<int>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A8B5B0 Offset: 0x1A89BB0 VA: 0x181A8B5B0
	|-TaskFactory<Nullable<Int32Enum>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A88B60 Offset: 0x1A87160 VA: 0x181A88B60
	|-TaskFactory<object>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A88FF0 Offset: 0x1A875F0 VA: 0x181A88FF0
	|-TaskFactory<VoidTaskResult>.FromAsyncCoreLogic
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A93180 Offset: 0x1A91780 VA: 0x181A93180
	|-TaskFactory<Stream>.FromAsync
	|-TaskFactory<UdpReceiveResult>.FromAsync
	|-TaskFactory<WebResponse>.FromAsync
	|-TaskFactory<PublishResult>.FromAsync
	|-TaskFactory<bool>.FromAsync
	|-TaskFactory<int>.FromAsync
	|-TaskFactory<Nullable<ServerInfo>>.FromAsync
	|-TaskFactory<Nullable<Image>>.FromAsync
	|-TaskFactory<Nullable<InventoryPurchaseResult>>.FromAsync
	|-TaskFactory<Nullable<InventoryResult>>.FromAsync
	|-TaskFactory<Nullable<Item>>.FromAsync
	|-TaskFactory<Nullable<ResultPage>>.FromAsync
	|-TaskFactory<Nullable<int>>.FromAsync
	|-TaskFactory<Nullable<Int32Enum>>.FromAsync
	|-TaskFactory<object>.FromAsync
	|-TaskFactory<VoidTaskResult>.FromAsync
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromAsyncImpl(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A8E330 Offset: 0x1A8C930 VA: 0x181A8E330
	|-TaskFactory<PublishResult>.FromAsyncImpl
	|
	|-RVA: 0x1A92A90 Offset: 0x1A91090 VA: 0x181A92A90
	|-TaskFactory<bool>.FromAsyncImpl
	|
	|-RVA: 0x1A900B0 Offset: 0x1A8E6B0 VA: 0x181A900B0
	|-TaskFactory<int>.FromAsyncImpl
	|
	|-RVA: 0x1A92390 Offset: 0x1A90990 VA: 0x181A92390
	|-TaskFactory<UdpReceiveResult>.FromAsyncImpl
	|
	|-RVA: 0x1A8F930 Offset: 0x1A8DF30 VA: 0x181A8F930
	|-TaskFactory<Nullable<ServerInfo>>.FromAsyncImpl
	|
	|-RVA: 0x1A8CDF0 Offset: 0x1A8B3F0 VA: 0x181A8CDF0
	|-TaskFactory<Nullable<Image>>.FromAsyncImpl
	|
	|-RVA: 0x1A90E90 Offset: 0x1A8F490 VA: 0x181A90E90
	|-TaskFactory<Nullable<InventoryPurchaseResult>>.FromAsyncImpl
	|
	|-RVA: 0x1A8EA60 Offset: 0x1A8D060 VA: 0x181A8EA60
	|-TaskFactory<Nullable<InventoryResult>>.FromAsyncImpl
	|
	|-RVA: 0x1A8F180 Offset: 0x1A8D780 VA: 0x181A8F180
	|-TaskFactory<Nullable<Item>>.FromAsyncImpl
	|
	|-RVA: 0x1A8DC10 Offset: 0x1A8C210 VA: 0x181A8DC10
	|-TaskFactory<Nullable<ResultPage>>.FromAsyncImpl
	|
	|-RVA: 0x1A907A0 Offset: 0x1A8EDA0 VA: 0x181A907A0
	|-TaskFactory<Nullable<int>>.FromAsyncImpl
	|
	|-RVA: 0x1A915B0 Offset: 0x1A8FBB0 VA: 0x181A915B0
	|-TaskFactory<Nullable<Int32Enum>>.FromAsyncImpl
	|
	|-RVA: 0x1A8D520 Offset: 0x1A8BB20 VA: 0x181A8D520
	|-TaskFactory<object>.FromAsyncImpl
	|
	|-RVA: 0x1A91CA0 Offset: 0x1A902A0 VA: 0x181A91CA0
	|-TaskFactory<VoidTaskResult>.FromAsyncImpl
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157BFC0 Offset: 0x157A5C0 VA: 0x18157BFC0
	|-TaskFactory<int>.FromAsync<byte[], int>
	|-TaskFactory<int>.FromAsync<object, int>
	|
	|-RVA: 0x157C020 Offset: 0x157A620 VA: 0x18157C020
	|-TaskFactory<object>.FromAsync<object, object>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromAsyncImpl<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157AE30 Offset: 0x1579430 VA: 0x18157AE30
	|-TaskFactory<int>.FromAsyncImpl<object, int>
	|
	|-RVA: 0x157B470 Offset: 0x1579A70 VA: 0x18157B470
	|-TaskFactory<object>.FromAsyncImpl<object, object>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromAsyncTrim<TInstance, TArgs>(TInstance thisRef, TArgs args, Func<TInstance, TArgs, AsyncCallback, object, IAsyncResult> beginMethod, Func<TInstance, IAsyncResult, TResult> endMethod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157BAB0 Offset: 0x157A0B0 VA: 0x18157BAB0
	|-TaskFactory<int>.FromAsyncTrim<Stream, Stream.ReadWriteParameters>
	|-TaskFactory<int>.FromAsyncTrim<object, Stream.ReadWriteParameters>
	|
	|-RVA: 0x157BE10 Offset: 0x157A410 VA: 0x18157BE10
	|-TaskFactory<object>.FromAsyncTrim<object, object>
	|
	|-RVA: 0x157BC60 Offset: 0x157A260 VA: 0x18157BC60
	|-TaskFactory<VoidTaskResult>.FromAsyncTrim<Stream, Stream.ReadWriteParameters>
	|-TaskFactory<VoidTaskResult>.FromAsyncTrim<object, Stream.ReadWriteParameters>
	*/

}

internal sealed class UnwrapPromise<TResult> : Task<TResult>, ITaskCompletionAction // TypeDefIndex: 868
{	// Fields
	private byte _state; // 0x0
	private readonly bool _lookForOce; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Task outerTask, bool lookForOce) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A60A90 Offset: 0x1A5F090 VA: 0x181A60A90
	|-UnwrapPromise<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public void Invoke(Task completingTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A603F0 Offset: 0x1A5E9F0 VA: 0x181A603F0
	|-UnwrapPromise<object>.Invoke
	*/

	// RVA: -1 Offset: -1
	private void InvokeCore(Task completingTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A60390 Offset: 0x1A5E990 VA: 0x181A60390
	|-UnwrapPromise<object>.InvokeCore
	*/

	// RVA: -1 Offset: -1
	private void InvokeCoreAsync(Task completingTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A60150 Offset: 0x1A5E750 VA: 0x181A60150
	|-UnwrapPromise<object>.InvokeCoreAsync
	*/

	// RVA: -1 Offset: -1
	private void ProcessCompletedOuterTask(Task task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A60560 Offset: 0x1A5EB60 VA: 0x181A60560
	|-UnwrapPromise<object>.ProcessCompletedOuterTask
	*/

	// RVA: -1 Offset: -1
	private bool TrySetFromTask(Task task, bool lookForOce) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A607C0 Offset: 0x1A5EDC0 VA: 0x181A607C0
	|-UnwrapPromise<object>.TrySetFromTask
	*/

	// RVA: -1 Offset: -1
	private void ProcessInnerTask(Task task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A60710 Offset: 0x1A5ED10 VA: 0x181A60710
	|-UnwrapPromise<object>.ProcessInnerTask
	*/

}

public class TaskCompletionSource<TResult> // TypeDefIndex: 871
{	// Fields
	private readonly Task<TResult> m_task; // 0x0

	// Properties
	public Task<TResult> Task { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1369470 Offset: 0x1367A70 VA: 0x181369470
	|-TaskCompletionSource<HttpResponseMessage>..ctor
	|-TaskCompletionSource<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	|-TaskCompletionSource<HttpResponseMessage>.get_Task
	|-TaskCompletionSource<object>.get_Task
	*/

	// RVA: -1 Offset: -1
	private void SpinUntilCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1369360 Offset: 0x1367960 VA: 0x181369360
	|-TaskCompletionSource<object>.SpinUntilCompleted
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCanceled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1369440 Offset: 0x1367A40 VA: 0x181369440
	|-TaskCompletionSource<object>.TrySetCanceled
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCanceled(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13693C0 Offset: 0x13679C0 VA: 0x1813693C0
	|-TaskCompletionSource<object>.TrySetCanceled
	*/

	// RVA: -1 Offset: -1
	public void SetCanceled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13692C0 Offset: 0x13678C0 VA: 0x1813692C0
	|-TaskCompletionSource<HttpResponseMessage>.SetCanceled
	|-TaskCompletionSource<object>.SetCanceled
	*/

}

internal sealed class ContinuationTaskFromResultTask<TAntecedentResult> : Task // TypeDefIndex: 873
{	// Fields
	private Task<TAntecedentResult> m_antecedent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Task<TAntecedentResult> antecedent, Delegate action, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1364E60 Offset: 0x1363460 VA: 0x181364E60
	|-ContinuationTaskFromResultTask<PublishResult>..ctor
	|
	|-RVA: 0x1365400 Offset: 0x1363A00 VA: 0x181365400
	|-ContinuationTaskFromResultTask<bool>..ctor
	|
	|-RVA: 0x1365220 Offset: 0x1363820 VA: 0x181365220
	|-ContinuationTaskFromResultTask<int>..ctor
	|
	|-RVA: 0x1364F50 Offset: 0x1363550 VA: 0x181364F50
	|-ContinuationTaskFromResultTask<UdpReceiveResult>..ctor
	|
	|-RVA: 0x1365130 Offset: 0x1363730 VA: 0x181365130
	|-ContinuationTaskFromResultTask<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x1365310 Offset: 0x1363910 VA: 0x181365310
	|-ContinuationTaskFromResultTask<Nullable<Image>>..ctor
	|
	|-RVA: 0x1364D70 Offset: 0x1363370 VA: 0x181364D70
	|-ContinuationTaskFromResultTask<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1364AA0 Offset: 0x13630A0 VA: 0x181364AA0
	|-ContinuationTaskFromResultTask<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1364B90 Offset: 0x1363190 VA: 0x181364B90
	|-ContinuationTaskFromResultTask<Nullable<Item>>..ctor
	|
	|-RVA: 0x13654F0 Offset: 0x1363AF0 VA: 0x1813654F0
	|-ContinuationTaskFromResultTask<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1364C80 Offset: 0x1363280 VA: 0x181364C80
	|-ContinuationTaskFromResultTask<Nullable<int>>..ctor
	|
	|-RVA: 0x13648C0 Offset: 0x1362EC0 VA: 0x1813648C0
	|-ContinuationTaskFromResultTask<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x13649B0 Offset: 0x1362FB0 VA: 0x1813649B0
	|-ContinuationTaskFromResultTask<object>..ctor
	|
	|-RVA: 0x1365040 Offset: 0x1363640 VA: 0x181365040
	|-ContinuationTaskFromResultTask<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 19
	internal override void InnerInvoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13647B0 Offset: 0x1362DB0 VA: 0x1813647B0
	|-ContinuationTaskFromResultTask<PublishResult>.InnerInvoke
	|-ContinuationTaskFromResultTask<bool>.InnerInvoke
	|-ContinuationTaskFromResultTask<int>.InnerInvoke
	|-ContinuationTaskFromResultTask<UdpReceiveResult>.InnerInvoke
	|-ContinuationTaskFromResultTask<Nullable<ServerInfo>>.InnerInvoke
	|-ContinuationTaskFromResultTask<Nullable<Image>>.InnerInvoke
	|-ContinuationTaskFromResultTask<Nullable<InventoryPurchaseResult>>.InnerInvoke
	|-ContinuationTaskFromResultTask<Nullable<InventoryResult>>.InnerInvoke
	|-ContinuationTaskFromResultTask<Nullable<Item>>.InnerInvoke
	|-ContinuationTaskFromResultTask<Nullable<ResultPage>>.InnerInvoke
	|-ContinuationTaskFromResultTask<Nullable<int>>.InnerInvoke
	|-ContinuationTaskFromResultTask<Nullable<Int32Enum>>.InnerInvoke
	|-ContinuationTaskFromResultTask<object>.InnerInvoke
	|-ContinuationTaskFromResultTask<VoidTaskResult>.InnerInvoke
	*/

}

internal sealed class ContinuationResultTaskFromResultTask<TAntecedentResult, TResult> : Task<TResult> // TypeDefIndex: 874
{	// Fields
	private Task<TAntecedentResult> m_antecedent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Task<TAntecedentResult> antecedent, Delegate function, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1364620 Offset: 0x1362C20 VA: 0x181364620
	|-ContinuationResultTaskFromResultTask<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 19
	internal override void InnerInvoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1364500 Offset: 0x1362B00 VA: 0x181364500
	|-ContinuationResultTaskFromResultTask<object, object>.InnerInvoke
	*/

}

internal sealed class __BinaryWriter // TypeDefIndex: 1105
{	// Fields
	internal Stream sout; // 0x10
	internal FormatterTypeStyle formatterTypeStyle; // 0x18
	internal Hashtable objectMapTable; // 0x20
	internal ObjectWriter objectWriter; // 0x28
	internal BinaryWriter dataWriter; // 0x30
	internal int m_nestedObjectCount; // 0x38
	private int nullCount; // 0x3C
	internal BinaryMethodCall binaryMethodCall; // 0x40
	internal BinaryMethodReturn binaryMethodReturn; // 0x48
	internal BinaryObject binaryObject; // 0x50
	internal BinaryObjectWithMap binaryObjectWithMap; // 0x58
	internal BinaryObjectWithMapTyped binaryObjectWithMapTyped; // 0x60
	internal BinaryObjectString binaryObjectString; // 0x68
	internal BinaryArray binaryArray; // 0x70
	private byte[] byteBuffer; // 0x78
	private int chunkSize; // 0x80
	internal MemberPrimitiveUnTyped memberPrimitiveUnTyped; // 0x88
	internal MemberPrimitiveTyped memberPrimitiveTyped; // 0x90
	internal ObjectNull objectNull; // 0x98
	internal MemberReference memberReference; // 0xA0
	internal BinaryAssembly binaryAssembly; // 0xA8

	// Methods

	// RVA: 0x12ACC90 Offset: 0x12AB290 VA: 0x1812ACC90
	internal void .ctor(Stream sout, ObjectWriter objectWriter, FormatterTypeStyle formatterTypeStyle) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void WriteBegin() { }

	// RVA: 0x12AAB10 Offset: 0x12A9110 VA: 0x1812AAB10
	internal void WriteEnd() { }

	// RVA: 0x12AA8F0 Offset: 0x12A8EF0 VA: 0x1812AA8F0
	internal void WriteBoolean(bool value) { }

	// RVA: 0x12AA920 Offset: 0x12A8F20 VA: 0x1812AA920
	internal void WriteByte(byte value) { }

	// RVA: 0x12AA950 Offset: 0x12A8F50 VA: 0x1812AA950
	private void WriteBytes(byte[] value) { }

	// RVA: 0x12AA980 Offset: 0x12A8F80 VA: 0x1812AA980
	private void WriteBytes(byte[] byteA, int offset, int size) { }

	// RVA: 0x12AA9B0 Offset: 0x12A8FB0 VA: 0x1812AA9B0
	internal void WriteChar(char value) { }

	// RVA: 0x12AA9E0 Offset: 0x12A8FE0 VA: 0x1812AA9E0
	internal void WriteChars(char[] value) { }

	// RVA: 0x12AAA40 Offset: 0x12A9040 VA: 0x1812AAA40
	internal void WriteDecimal(Decimal value) { }

	// RVA: 0x12AC300 Offset: 0x12AA900 VA: 0x1812AC300
	internal void WriteSingle(float value) { }

	// RVA: 0x12AAAE0 Offset: 0x12A90E0 VA: 0x1812AAAE0
	internal void WriteDouble(double value) { }

	// RVA: 0x12AAB40 Offset: 0x12A9140 VA: 0x1812AAB40
	internal void WriteInt16(short value) { }

	// RVA: 0x12AAB70 Offset: 0x12A9170 VA: 0x1812AAB70
	internal void WriteInt32(int value) { }

	// RVA: 0x12AAA10 Offset: 0x12A9010 VA: 0x1812AAA10
	internal void WriteInt64(long value) { }

	// RVA: 0x12AA920 Offset: 0x12A8F20 VA: 0x1812AA920
	internal void WriteSByte(sbyte value) { }

	// RVA: 0x12AC330 Offset: 0x12AA930 VA: 0x1812AC330
	internal void WriteString(string value) { }

	// RVA: 0x12AAA10 Offset: 0x12A9010 VA: 0x1812AAA10
	internal void WriteTimeSpan(TimeSpan value) { }

	// RVA: 0x12AAA10 Offset: 0x12A9010 VA: 0x1812AAA10
	internal void WriteDateTime(DateTime value) { }

	// RVA: 0x12AC360 Offset: 0x12AA960 VA: 0x1812AC360
	internal void WriteUInt16(ushort value) { }

	// RVA: 0x12AC390 Offset: 0x12AA990 VA: 0x1812AC390
	internal void WriteUInt32(uint value) { }

	// RVA: 0x12AC3C0 Offset: 0x12AA9C0 VA: 0x1812AC3C0
	internal void WriteUInt64(ulong value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void WriteObjectEnd(NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x12ABE70 Offset: 0x12AA470 VA: 0x1812ABE70
	internal void WriteSerializationHeaderEnd() { }

	// RVA: 0x12ABEF0 Offset: 0x12AA4F0 VA: 0x1812ABEF0
	internal void WriteSerializationHeader(int topId, int headerId, int minorVersion, int majorVersion) { }

	// RVA: 0x12AB390 Offset: 0x12A9990 VA: 0x1812AB390
	internal void WriteMethodCall() { }

	// RVA: 0x12AB430 Offset: 0x12A9A30 VA: 0x1812AB430
	internal void WriteMethodReturn() { }

	// RVA: 0x12AB6F0 Offset: 0x12A9CF0 VA: 0x1812AB6F0
	internal void WriteObject(NameInfo nameInfo, NameInfo typeNameInfo, int numMembers, string[] memberNames, Type[] memberTypes, WriteObjectInfo[] memberObjectInfos) { }

	// RVA: 0x12AB620 Offset: 0x12A9C20 VA: 0x1812AB620
	internal void WriteObjectString(int objectId, string value) { }

	// RVA: 0x12ABFB0 Offset: 0x12AA5B0 VA: 0x1812ABFB0
	internal void WriteSingleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, Array array) { }

	// RVA: 0x12AA580 Offset: 0x12A8B80 VA: 0x1812AA580
	private void WriteArrayAsBytes(Array array, int typeLength) { }

	// RVA: 0x12AAE10 Offset: 0x12A9410 VA: 0x1812AAE10
	internal void WriteJaggedArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound) { }

	// RVA: 0x12ABCB0 Offset: 0x12AA2B0 VA: 0x1812ABCB0
	internal void WriteRectangleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int rank, int[] lengthA, int[] lowerBoundA) { }

	// RVA: 0x12AB5C0 Offset: 0x12A9BC0 VA: 0x1812AB5C0
	internal void WriteObjectByteArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, byte[] byteA) { }

	// RVA: 0x12AB210 Offset: 0x12A9810 VA: 0x1812AB210
	internal void WriteMember(NameInfo memberNameInfo, NameInfo typeNameInfo, object value) { }

	// RVA: 0x12AB4E0 Offset: 0x12A9AE0 VA: 0x1812AB4E0
	internal void WriteNullMember(NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x12AB050 Offset: 0x12A9650 VA: 0x1812AB050
	internal void WriteMemberObjectRef(NameInfo memberNameInfo, int idRef) { }

	// RVA: 0x12AB020 Offset: 0x12A9620 VA: 0x1812AB020
	internal void WriteMemberNested(NameInfo memberNameInfo) { }

	// RVA: 0x12AB120 Offset: 0x12A9720 VA: 0x1812AB120
	internal void WriteMemberString(NameInfo memberNameInfo, NameInfo typeNameInfo, string value) { }

	// RVA: 0x12AAC90 Offset: 0x12A9290 VA: 0x1812AAC90
	internal void WriteItem(NameInfo itemNameInfo, NameInfo typeNameInfo, object value) { }

	// RVA: 0x12AB4D0 Offset: 0x12A9AD0 VA: 0x1812AB4D0
	internal void WriteNullItem(NameInfo itemNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x12AAAD0 Offset: 0x12A90D0 VA: 0x1812AAAD0
	internal void WriteDelayedNullItem() { }

	// RVA: 0x12AABA0 Offset: 0x12A91A0 VA: 0x1812AABA0
	internal void WriteItemEnd() { }

	// RVA: 0x12AA4C0 Offset: 0x12A8AC0 VA: 0x1812AA4C0
	private void InternalWriteItemNull() { }

	// RVA: 0x12AABB0 Offset: 0x12A91B0 VA: 0x1812AABB0
	internal void WriteItemObjectRef(NameInfo nameInfo, int idRef) { }

	// RVA: 0x12AA7F0 Offset: 0x12A8DF0 VA: 0x1812AA7F0
	internal void WriteAssembly(Type type, string assemblyString, int assemId, bool isNew) { }

	// RVA: 0x12AC3F0 Offset: 0x12AA9F0 VA: 0x1812AC3F0
	internal void WriteValue(InternalPrimitiveTypeE code, object value) { }

}

internal sealed class __BinaryParser // TypeDefIndex: 1116
{	// Fields
	internal ObjectReader objectReader; // 0x10
	internal Stream input; // 0x18
	internal long topId; // 0x20
	internal long headerId; // 0x28
	internal SizedArray objectMapIdTable; // 0x30
	internal SizedArray assemIdToAssemblyTable; // 0x38
	internal SerStack stack; // 0x40
	internal BinaryTypeEnum expectedType; // 0x48
	internal object expectedTypeInformation; // 0x50
	internal ParseRecord PRS; // 0x58
	private BinaryAssemblyInfo systemAssemblyInfo; // 0x60
	private BinaryReader dataReader; // 0x68
	private static Encoding encoding; // 0x0
	private SerStack opPool; // 0x70
	private BinaryObject binaryObject; // 0x78
	private BinaryObjectWithMap bowm; // 0x80
	private BinaryObjectWithMapTyped bowmt; // 0x88
	internal BinaryObjectString objectString; // 0x90
	internal BinaryCrossAppDomainString crossAppDomainString; // 0x98
	internal MemberPrimitiveTyped memberPrimitiveTyped; // 0xA0
	private byte[] byteBuffer; // 0xA8
	internal MemberPrimitiveUnTyped memberPrimitiveUnTyped; // 0xB0
	internal MemberReference memberReference; // 0xB8
	internal ObjectNull objectNull; // 0xC0
	internal static MessageEnd messageEnd; // 0x8

	// Properties
	internal BinaryAssemblyInfo SystemAssemblyInfo { get; }
	internal SizedArray ObjectMapIdTable { get; }
	internal SizedArray AssemIdToAssemblyTable { get; }
	internal ParseRecord prs { get; }

	// Methods

	// RVA: 0x120F1A0 Offset: 0x120D7A0 VA: 0x18120F1A0
	internal void .ctor(Stream stream, ObjectReader objectReader) { }

	// RVA: 0x120F460 Offset: 0x120DA60 VA: 0x18120F460
	internal BinaryAssemblyInfo get_SystemAssemblyInfo() { }

	// RVA: 0x120F390 Offset: 0x120D990 VA: 0x18120F390
	internal SizedArray get_ObjectMapIdTable() { }

	// RVA: 0x120F2C0 Offset: 0x120D8C0 VA: 0x18120F2C0
	internal SizedArray get_AssemIdToAssemblyTable() { }

	// RVA: 0x120F540 Offset: 0x120DB40 VA: 0x18120F540
	internal ParseRecord get_prs() { }

	// RVA: 0x120EBB0 Offset: 0x120D1B0 VA: 0x18120EBB0
	internal void Run() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void ReadBegin() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void ReadEnd() { }

	// RVA: 0x120A320 Offset: 0x1208920 VA: 0x18120A320
	internal bool ReadBoolean() { }

	// RVA: 0x120A350 Offset: 0x1208950 VA: 0x18120A350
	internal byte ReadByte() { }

	// RVA: 0x120A410 Offset: 0x1208A10 VA: 0x18120A410
	internal byte[] ReadBytes(int length) { }

	// RVA: 0x120A380 Offset: 0x1208980 VA: 0x18120A380
	internal void ReadBytes(byte[] byteA, int offset, int size) { }

	// RVA: 0x120A440 Offset: 0x1208A40 VA: 0x18120A440
	internal char ReadChar() { }

	// RVA: 0x120A470 Offset: 0x1208A70 VA: 0x18120A470
	internal char[] ReadChars(int length) { }

	// RVA: 0x120B280 Offset: 0x1209880 VA: 0x18120B280
	internal Decimal ReadDecimal() { }

	// RVA: 0x120E5A0 Offset: 0x120CBA0 VA: 0x18120E5A0
	internal float ReadSingle() { }

	// RVA: 0x120B350 Offset: 0x1209950 VA: 0x18120B350
	internal double ReadDouble() { }

	// RVA: 0x120B380 Offset: 0x1209980 VA: 0x18120B380
	internal short ReadInt16() { }

	// RVA: 0x120B3B0 Offset: 0x12099B0 VA: 0x18120B3B0
	internal int ReadInt32() { }

	// RVA: 0x120B3E0 Offset: 0x12099E0 VA: 0x18120B3E0
	internal long ReadInt64() { }

	// RVA: 0x120A350 Offset: 0x1208950 VA: 0x18120A350
	internal sbyte ReadSByte() { }

	// RVA: 0x120E5D0 Offset: 0x120CBD0 VA: 0x18120E5D0
	internal string ReadString() { }

	// RVA: 0x120B3E0 Offset: 0x12099E0 VA: 0x18120B3E0
	internal TimeSpan ReadTimeSpan() { }

	// RVA: 0x120B200 Offset: 0x1209800 VA: 0x18120B200
	internal DateTime ReadDateTime() { }

	// RVA: 0x120E600 Offset: 0x120CC00 VA: 0x18120E600
	internal ushort ReadUInt16() { }

	// RVA: 0x120E630 Offset: 0x120CC30 VA: 0x18120E630
	internal uint ReadUInt32() { }

	// RVA: 0x120E660 Offset: 0x120CC60 VA: 0x18120E660
	internal ulong ReadUInt64() { }

	// RVA: 0x120E4F0 Offset: 0x120CAF0 VA: 0x18120E4F0
	internal void ReadSerializationHeaderRecord() { }

	// RVA: 0x120A050 Offset: 0x1208650 VA: 0x18120A050
	internal void ReadAssembly(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x120DFF0 Offset: 0x120C5F0 VA: 0x18120DFF0
	private void ReadObject() { }

	// RVA: 0x120A4A0 Offset: 0x1208AA0 VA: 0x18120A4A0
	internal void ReadCrossAppDomainMap() { }

	// RVA: 0x120D910 Offset: 0x120BF10 VA: 0x18120D910
	internal void ReadObjectWithMap(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x120D9D0 Offset: 0x120BFD0 VA: 0x18120D9D0
	private void ReadObjectWithMap(BinaryObjectWithMap record) { }

	// RVA: 0x120D850 Offset: 0x120BE50 VA: 0x18120D850
	internal void ReadObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x120D200 Offset: 0x120B800 VA: 0x18120D200
	private void ReadObjectWithMapTyped(BinaryObjectWithMapTyped record) { }

	// RVA: 0x120C860 Offset: 0x120AE60 VA: 0x18120C860
	private void ReadObjectString(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x120B410 Offset: 0x1209A10 VA: 0x18120B410
	private void ReadMemberPrimitiveTyped() { }

	// RVA: 0x1209960 Offset: 0x1207F60 VA: 0x181209960
	private void ReadArray(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x12093F0 Offset: 0x12079F0 VA: 0x1812093F0
	private void ReadArrayAsBytes(ParseRecord pr) { }

	// RVA: 0x120BA10 Offset: 0x120A010 VA: 0x18120BA10
	private void ReadMemberPrimitiveUnTyped() { }

	// RVA: 0x120BF50 Offset: 0x120A550 VA: 0x18120BF50
	private void ReadMemberReference() { }

	// RVA: 0x120C490 Offset: 0x120AA90 VA: 0x18120C490
	private void ReadObjectNull(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x120C310 Offset: 0x120A910 VA: 0x18120C310
	private void ReadMessageEnd() { }

	// RVA: 0x120E690 Offset: 0x120CC90 VA: 0x18120E690
	internal object ReadValue(InternalPrimitiveTypeE code) { }

	// RVA: 0x12091B0 Offset: 0x12077B0 VA: 0x1812091B0
	private ObjectProgress GetOp() { }

	// RVA: 0x1209350 Offset: 0x1207950 VA: 0x181209350
	private void PutOp(ObjectProgress op) { }

	// RVA: 0x120F140 Offset: 0x120D740 VA: 0x18120F140
	private static void .cctor() { }

}

public struct TaskAwaiter<TResult> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 1291
{	// Fields
	private readonly Task<TResult> m_task; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Task<TResult> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1510 Offset: 0xF0910 VA: 0x1800F1510
	|-TaskAwaiter<PublishResult>..ctor
	|-TaskAwaiter<bool>..ctor
	|-TaskAwaiter<int>..ctor
	|-TaskAwaiter<UdpReceiveResult>..ctor
	|-TaskAwaiter<Nullable<ServerInfo>>..ctor
	|-TaskAwaiter<Nullable<Image>>..ctor
	|-TaskAwaiter<Nullable<InventoryPurchaseResult>>..ctor
	|-TaskAwaiter<Nullable<InventoryResult>>..ctor
	|-TaskAwaiter<Nullable<Item>>..ctor
	|-TaskAwaiter<Nullable<ResultPage>>..ctor
	|-TaskAwaiter<Nullable<int>>..ctor
	|-TaskAwaiter<Nullable<Int32Enum>>..ctor
	|-TaskAwaiter<object>..ctor
	|-TaskAwaiter<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C140 Offset: 0x14B540 VA: 0x18014C140
	|-TaskAwaiter<CompanionSubscription.Status>.get_IsCompleted
	|-TaskAwaiter<IAuthTicket>.get_IsCompleted
	|-TaskAwaiter<IPlayerInfo>.get_IsCompleted
	|-TaskAwaiter<IPlayerInventory>.get_IsCompleted
	|-TaskAwaiter<IPlayerInventory[]>.get_IsCompleted
	|-TaskAwaiter<MP3Stream>.get_IsCompleted
	|-TaskAwaiter<SteamInventoryCrafting.MarketPrice>.get_IsCompleted
	|-TaskAwaiter<AuthTicket>.get_IsCompleted
	|-TaskAwaiter<InventoryDef[]>.get_IsCompleted
	|-TaskAwaiter<PublishResult>.get_IsCompleted
	|-TaskAwaiter<bool>.get_IsCompleted
	|-TaskAwaiter<byte[]>.get_IsCompleted
	|-TaskAwaiter<Dictionary<string, string>>.get_IsCompleted
	|-TaskAwaiter<List<IPlayerItemDefinition>>.get_IsCompleted
	|-TaskAwaiter<Stream>.get_IsCompleted
	|-TaskAwaiter<int>.get_IsCompleted
	|-TaskAwaiter<HttpResponseMessage>.get_IsCompleted
	|-TaskAwaiter<UdpReceiveResult>.get_IsCompleted
	|-TaskAwaiter<Nullable<ServerInfo>>.get_IsCompleted
	|-TaskAwaiter<Nullable<Image>>.get_IsCompleted
	|-TaskAwaiter<Nullable<InventoryPurchaseResult>>.get_IsCompleted
	|-TaskAwaiter<Nullable<InventoryResult>>.get_IsCompleted
	|-TaskAwaiter<Nullable<Item>>.get_IsCompleted
	|-TaskAwaiter<Nullable<ResultPage>>.get_IsCompleted
	|-TaskAwaiter<Nullable<int>>.get_IsCompleted
	|-TaskAwaiter<Nullable<Int32Enum>>.get_IsCompleted
	|-TaskAwaiter<object>.get_IsCompleted
	|-TaskAwaiter<string>.get_IsCompleted
	|-TaskAwaiter<VoidTaskResult>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14CA80 Offset: 0x14BE80 VA: 0x18014CA80
	|-TaskAwaiter<PublishResult>.OnCompleted
	|-TaskAwaiter<bool>.OnCompleted
	|-TaskAwaiter<int>.OnCompleted
	|-TaskAwaiter<UdpReceiveResult>.OnCompleted
	|-TaskAwaiter<Nullable<ServerInfo>>.OnCompleted
	|-TaskAwaiter<Nullable<Image>>.OnCompleted
	|-TaskAwaiter<Nullable<InventoryPurchaseResult>>.OnCompleted
	|-TaskAwaiter<Nullable<InventoryResult>>.OnCompleted
	|-TaskAwaiter<Nullable<Item>>.OnCompleted
	|-TaskAwaiter<Nullable<ResultPage>>.OnCompleted
	|-TaskAwaiter<Nullable<int>>.OnCompleted
	|-TaskAwaiter<Nullable<Int32Enum>>.OnCompleted
	|-TaskAwaiter<object>.OnCompleted
	|-TaskAwaiter<VoidTaskResult>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14CAB0 Offset: 0x14BEB0 VA: 0x18014CAB0
	|-TaskAwaiter<PublishResult>.UnsafeOnCompleted
	|-TaskAwaiter<bool>.UnsafeOnCompleted
	|-TaskAwaiter<int>.UnsafeOnCompleted
	|-TaskAwaiter<UdpReceiveResult>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<ServerInfo>>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<Image>>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<InventoryPurchaseResult>>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<InventoryResult>>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<Item>>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<ResultPage>>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<int>>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<Int32Enum>>.UnsafeOnCompleted
	|-TaskAwaiter<object>.UnsafeOnCompleted
	|-TaskAwaiter<VoidTaskResult>.UnsafeOnCompleted
	*/

	// RVA: -1 Offset: -1
	public TResult GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3CE0 Offset: 0x1E30E0 VA: 0x1801E3CE0
	|-TaskAwaiter<CompanionSubscription.Status>.GetResult
	|-TaskAwaiter<IAuthTicket>.GetResult
	|-TaskAwaiter<IPlayerInfo>.GetResult
	|-TaskAwaiter<IPlayerInventory>.GetResult
	|-TaskAwaiter<IPlayerInventory[]>.GetResult
	|-TaskAwaiter<MP3Stream>.GetResult
	|-TaskAwaiter<SteamInventoryCrafting.MarketPrice>.GetResult
	|-TaskAwaiter<AuthTicket>.GetResult
	|-TaskAwaiter<InventoryDef[]>.GetResult
	|-TaskAwaiter<byte[]>.GetResult
	|-TaskAwaiter<Dictionary<string, string>>.GetResult
	|-TaskAwaiter<List<IPlayerItemDefinition>>.GetResult
	|-TaskAwaiter<Stream>.GetResult
	|-TaskAwaiter<HttpResponseMessage>.GetResult
	|-TaskAwaiter<string>.GetResult
	|-TaskAwaiter<object>.GetResult
	|
	|-RVA: 0x1E2F90 Offset: 0x1E2390 VA: 0x1801E2F90
	|-TaskAwaiter<PublishResult>.GetResult
	|-TaskAwaiter<Nullable<Image>>.GetResult
	|
	|-RVA: 0x1E3110 Offset: 0x1E2510 VA: 0x1801E3110
	|-TaskAwaiter<UdpReceiveResult>.GetResult
	|
	|-RVA: 0x1E31C0 Offset: 0x1E25C0 VA: 0x1801E31C0
	|-TaskAwaiter<Nullable<ServerInfo>>.GetResult
	|
	|-RVA: 0x1E3050 Offset: 0x1E2450 VA: 0x1801E3050
	|-TaskAwaiter<Nullable<InventoryPurchaseResult>>.GetResult
	|-TaskAwaiter<Nullable<ResultPage>>.GetResult
	|
	|-RVA: 0x1E3400 Offset: 0x1E2800 VA: 0x1801E3400
	|-TaskAwaiter<Nullable<InventoryResult>>.GetResult
	|
	|-RVA: 0x1E32C0 Offset: 0x1E26C0 VA: 0x1801E32C0
	|-TaskAwaiter<Nullable<Item>>.GetResult
	|
	|-RVA: 0x1E3CD0 Offset: 0x1E30D0 VA: 0x1801E3CD0
	|-TaskAwaiter<bool>.GetResult
	|
	|-RVA: 0x1E2F00 Offset: 0x1E2300 VA: 0x1801E2F00
	|-TaskAwaiter<int>.GetResult
	|-TaskAwaiter<Nullable<int>>.GetResult
	|-TaskAwaiter<Nullable<Int32Enum>>.GetResult
	|-TaskAwaiter<VoidTaskResult>.GetResult
	*/

}

public struct ConfiguredTaskAwaitable<TResult> // TypeDefIndex: 1294
{	// Fields
	private readonly ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<TResult> m_configuredTaskAwaiter; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Task<TResult> task, bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E2E90 Offset: 0x1E2290 VA: 0x1801E2E90
	|-ConfiguredTaskAwaitable<PublishResult>..ctor
	|-ConfiguredTaskAwaitable<bool>..ctor
	|-ConfiguredTaskAwaitable<int>..ctor
	|-ConfiguredTaskAwaitable<UdpReceiveResult>..ctor
	|-ConfiguredTaskAwaitable<Nullable<ServerInfo>>..ctor
	|-ConfiguredTaskAwaitable<Nullable<Image>>..ctor
	|-ConfiguredTaskAwaitable<Nullable<InventoryPurchaseResult>>..ctor
	|-ConfiguredTaskAwaitable<Nullable<InventoryResult>>..ctor
	|-ConfiguredTaskAwaitable<Nullable<Item>>..ctor
	|-ConfiguredTaskAwaitable<Nullable<ResultPage>>..ctor
	|-ConfiguredTaskAwaitable<Nullable<int>>..ctor
	|-ConfiguredTaskAwaitable<Nullable<Int32Enum>>..ctor
	|-ConfiguredTaskAwaitable<object>..ctor
	|-ConfiguredTaskAwaitable<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14B7F0 Offset: 0x14ABF0 VA: 0x18014B7F0
	|-ConfiguredTaskAwaitable<AsyncProtocolResult>.GetAwaiter
	|-ConfiguredTaskAwaitable<Stream>.GetAwaiter
	|-ConfiguredTaskAwaitable<HttpResponseMessage>.GetAwaiter
	|-ConfiguredTaskAwaitable<WebResponse>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<int>>.GetAwaiter
	|-ConfiguredTaskAwaitable<string>.GetAwaiter
	|-ConfiguredTaskAwaitable<PublishResult>.GetAwaiter
	|-ConfiguredTaskAwaitable<bool>.GetAwaiter
	|-ConfiguredTaskAwaitable<int>.GetAwaiter
	|-ConfiguredTaskAwaitable<UdpReceiveResult>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<ServerInfo>>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<Image>>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<InventoryPurchaseResult>>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<InventoryResult>>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<Item>>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<ResultPage>>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<Int32Enum>>.GetAwaiter
	|-ConfiguredTaskAwaitable<object>.GetAwaiter
	|-ConfiguredTaskAwaitable<Task>.GetAwaiter
	|-ConfiguredTaskAwaitable<VoidTaskResult>.GetAwaiter
	*/

}

internal struct ConcurrentSet<KeyType, ItemType> // TypeDefIndex: 1507
{	// Fields
	private ItemType[] items; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public ItemType TryGet(KeyType key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B4F0 Offset: 0x22A8F0 VA: 0x18022B4F0
	|-ConcurrentSet<KeyValuePair<object, Int32Enum>, object>.TryGet
	|-ConcurrentSet<KeyValuePair<string, EventTags>, NameInfo>.TryGet
	|
	|-RVA: 0x22B5B0 Offset: 0x22A9B0 VA: 0x18022B5B0
	|-ConcurrentSet<object, object>.TryGet
	*/

	// RVA: -1 Offset: -1
	public ItemType GetOrAdd(ItemType newItem) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B4E0 Offset: 0x22A8E0 VA: 0x18022B4E0
	|-ConcurrentSet<KeyValuePair<object, Int32Enum>, object>.GetOrAdd
	|-ConcurrentSet<KeyValuePair<string, EventTags>, NameInfo>.GetOrAdd
	|-ConcurrentSet<object, object>.GetOrAdd
	*/

}

internal abstract class ConcurrentSetItem<KeyType, ItemType> // TypeDefIndex: 1508
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int Compare(ItemType other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ConcurrentSetItem<object, object>.Compare
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int Compare(KeyType key);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ConcurrentSetItem<object, object>.Compare
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5AD60 Offset: 0xD59360 VA: 0x180D5AD60
	|-ConcurrentSetItem<KeyValuePair<object, Int32Enum>, object>..ctor
	|-ConcurrentSetItem<KeyValuePair<string, EventTags>, NameInfo>..ctor
	|-ConcurrentSetItem<object, object>..ctor
	*/

}

internal sealed class InvokeTypeInfo<ContainerType> : TraceLoggingTypeInfo<ContainerType> // TypeDefIndex: 1524
{	// Fields
	private readonly PropertyAnalysis[] properties; // 0x0
	private readonly PropertyAccessor<ContainerType>[] accessors; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TypeAnalysis typeAnalysis) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B51ED0 Offset: 0x1B504D0 VA: 0x181B51ED0
	|-InvokeTypeInfo<bool>..ctor
	|-InvokeTypeInfo<byte>..ctor
	|-InvokeTypeInfo<char>..ctor
	|-InvokeTypeInfo<KeyValuePair<object, object>>..ctor
	|-InvokeTypeInfo<DateTime>..ctor
	|-InvokeTypeInfo<DateTimeOffset>..ctor
	|-InvokeTypeInfo<Decimal>..ctor
	|-InvokeTypeInfo<EmptyStruct>..ctor
	|-InvokeTypeInfo<double>..ctor
	|-InvokeTypeInfo<Guid>..ctor
	|-InvokeTypeInfo<short>..ctor
	|-InvokeTypeInfo<int>..ctor
	|-InvokeTypeInfo<long>..ctor
	|-InvokeTypeInfo<IntPtr>..ctor
	|-InvokeTypeInfo<object>..ctor
	|-InvokeTypeInfo<sbyte>..ctor
	|-InvokeTypeInfo<float>..ctor
	|-InvokeTypeInfo<TimeSpan>..ctor
	|-InvokeTypeInfo<ushort>..ctor
	|-InvokeTypeInfo<uint>..ctor
	|-InvokeTypeInfo<ulong>..ctor
	|-InvokeTypeInfo<UIntPtr>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B51890 Offset: 0x1B4FE90 VA: 0x181B51890
	|-InvokeTypeInfo<bool>.WriteMetadata
	|-InvokeTypeInfo<byte>.WriteMetadata
	|-InvokeTypeInfo<char>.WriteMetadata
	|-InvokeTypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|-InvokeTypeInfo<DateTime>.WriteMetadata
	|-InvokeTypeInfo<DateTimeOffset>.WriteMetadata
	|-InvokeTypeInfo<Decimal>.WriteMetadata
	|-InvokeTypeInfo<EmptyStruct>.WriteMetadata
	|-InvokeTypeInfo<double>.WriteMetadata
	|-InvokeTypeInfo<Guid>.WriteMetadata
	|-InvokeTypeInfo<short>.WriteMetadata
	|-InvokeTypeInfo<int>.WriteMetadata
	|-InvokeTypeInfo<long>.WriteMetadata
	|-InvokeTypeInfo<IntPtr>.WriteMetadata
	|-InvokeTypeInfo<object>.WriteMetadata
	|-InvokeTypeInfo<sbyte>.WriteMetadata
	|-InvokeTypeInfo<float>.WriteMetadata
	|-InvokeTypeInfo<TimeSpan>.WriteMetadata
	|-InvokeTypeInfo<ushort>.WriteMetadata
	|-InvokeTypeInfo<uint>.WriteMetadata
	|-InvokeTypeInfo<ulong>.WriteMetadata
	|-InvokeTypeInfo<UIntPtr>.WriteMetadata
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref ContainerType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B51800 Offset: 0x1B4FE00 VA: 0x181B51800
	|-InvokeTypeInfo<bool>.WriteData
	|-InvokeTypeInfo<byte>.WriteData
	|-InvokeTypeInfo<char>.WriteData
	|-InvokeTypeInfo<KeyValuePair<object, object>>.WriteData
	|-InvokeTypeInfo<DateTime>.WriteData
	|-InvokeTypeInfo<DateTimeOffset>.WriteData
	|-InvokeTypeInfo<Decimal>.WriteData
	|-InvokeTypeInfo<EmptyStruct>.WriteData
	|-InvokeTypeInfo<double>.WriteData
	|-InvokeTypeInfo<Guid>.WriteData
	|-InvokeTypeInfo<short>.WriteData
	|-InvokeTypeInfo<int>.WriteData
	|-InvokeTypeInfo<long>.WriteData
	|-InvokeTypeInfo<IntPtr>.WriteData
	|-InvokeTypeInfo<object>.WriteData
	|-InvokeTypeInfo<sbyte>.WriteData
	|-InvokeTypeInfo<float>.WriteData
	|-InvokeTypeInfo<TimeSpan>.WriteData
	|-InvokeTypeInfo<ushort>.WriteData
	|-InvokeTypeInfo<uint>.WriteData
	|-InvokeTypeInfo<ulong>.WriteData
	|-InvokeTypeInfo<UIntPtr>.WriteData
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override object GetData(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B4FA00 Offset: 0x1B4E000 VA: 0x181B4FA00
	|-InvokeTypeInfo<bool>.GetData
	|
	|-RVA: 0x1B50680 Offset: 0x1B4EC80 VA: 0x181B50680
	|-InvokeTypeInfo<byte>.GetData
	|
	|-RVA: 0x1B4E880 Offset: 0x1B4CE80 VA: 0x181B4E880
	|-InvokeTypeInfo<char>.GetData
	|
	|-RVA: 0x1B50400 Offset: 0x1B4EA00 VA: 0x181B50400
	|-InvokeTypeInfo<KeyValuePair<object, object>>.GetData
	|
	|-RVA: 0x1B4E380 Offset: 0x1B4C980 VA: 0x181B4E380
	|-InvokeTypeInfo<DateTime>.GetData
	|
	|-RVA: 0x1B4F500 Offset: 0x1B4DB00 VA: 0x181B4F500
	|-InvokeTypeInfo<DateTimeOffset>.GetData
	|
	|-RVA: 0x1B4E600 Offset: 0x1B4CC00 VA: 0x181B4E600
	|-InvokeTypeInfo<Decimal>.GetData
	|
	|-RVA: 0x1B4ED80 Offset: 0x1B4D380 VA: 0x181B4ED80
	|-InvokeTypeInfo<EmptyStruct>.GetData
	|
	|-RVA: 0x1B50900 Offset: 0x1B4EF00 VA: 0x181B50900
	|-InvokeTypeInfo<double>.GetData
	|
	|-RVA: 0x1B4F000 Offset: 0x1B4D600 VA: 0x181B4F000
	|-InvokeTypeInfo<Guid>.GetData
	|
	|-RVA: 0x1B50E00 Offset: 0x1B4F400 VA: 0x181B50E00
	|-InvokeTypeInfo<short>.GetData
	|
	|-RVA: 0x1B4EB00 Offset: 0x1B4D100 VA: 0x181B4EB00
	|-InvokeTypeInfo<int>.GetData
	|
	|-RVA: 0x1B4E100 Offset: 0x1B4C700 VA: 0x181B4E100
	|-InvokeTypeInfo<long>.GetData
	|
	|-RVA: 0x1B4FC80 Offset: 0x1B4E280 VA: 0x181B4FC80
	|-InvokeTypeInfo<IntPtr>.GetData
	|
	|-RVA: 0x1B51080 Offset: 0x1B4F680 VA: 0x181B51080
	|-InvokeTypeInfo<object>.GetData
	|
	|-RVA: 0x1B4F280 Offset: 0x1B4D880 VA: 0x181B4F280
	|-InvokeTypeInfo<sbyte>.GetData
	|
	|-RVA: 0x1B50180 Offset: 0x1B4E780 VA: 0x181B50180
	|-InvokeTypeInfo<float>.GetData
	|
	|-RVA: 0x1B51580 Offset: 0x1B4FB80 VA: 0x181B51580
	|-InvokeTypeInfo<TimeSpan>.GetData
	|
	|-RVA: 0x1B4F780 Offset: 0x1B4DD80 VA: 0x181B4F780
	|-InvokeTypeInfo<ushort>.GetData
	|
	|-RVA: 0x1B4FF00 Offset: 0x1B4E500 VA: 0x181B4FF00
	|-InvokeTypeInfo<uint>.GetData
	|
	|-RVA: 0x1B50B80 Offset: 0x1B4F180 VA: 0x181B50B80
	|-InvokeTypeInfo<ulong>.GetData
	|
	|-RVA: 0x1B51300 Offset: 0x1B4F900 VA: 0x181B51300
	|-InvokeTypeInfo<UIntPtr>.GetData
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override void WriteObjectData(TraceLoggingDataCollector collector, object valueObj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B51AC0 Offset: 0x1B500C0 VA: 0x181B51AC0
	|-InvokeTypeInfo<bool>.WriteObjectData
	|-InvokeTypeInfo<byte>.WriteObjectData
	|-InvokeTypeInfo<EmptyStruct>.WriteObjectData
	|-InvokeTypeInfo<sbyte>.WriteObjectData
	|
	|-RVA: 0x1B51CC0 Offset: 0x1B502C0 VA: 0x181B51CC0
	|-InvokeTypeInfo<char>.WriteObjectData
	|-InvokeTypeInfo<short>.WriteObjectData
	|-InvokeTypeInfo<ushort>.WriteObjectData
	|
	|-RVA: 0x1B51A10 Offset: 0x1B50010 VA: 0x181B51A10
	|-InvokeTypeInfo<KeyValuePair<object, object>>.WriteObjectData
	|-InvokeTypeInfo<DateTimeOffset>.WriteObjectData
	|-InvokeTypeInfo<Decimal>.WriteObjectData
	|-InvokeTypeInfo<Guid>.WriteObjectData
	|
	|-RVA: 0x1B51C10 Offset: 0x1B50210 VA: 0x181B51C10
	|-InvokeTypeInfo<DateTime>.WriteObjectData
	|-InvokeTypeInfo<long>.WriteObjectData
	|-InvokeTypeInfo<IntPtr>.WriteObjectData
	|-InvokeTypeInfo<TimeSpan>.WriteObjectData
	|-InvokeTypeInfo<ulong>.WriteObjectData
	|-InvokeTypeInfo<UIntPtr>.WriteObjectData
	|
	|-RVA: 0x1B51960 Offset: 0x1B4FF60 VA: 0x181B51960
	|-InvokeTypeInfo<double>.WriteObjectData
	|
	|-RVA: 0x1B51E20 Offset: 0x1B50420 VA: 0x181B51E20
	|-InvokeTypeInfo<int>.WriteObjectData
	|-InvokeTypeInfo<uint>.WriteObjectData
	|
	|-RVA: 0x1B51B70 Offset: 0x1B50170 VA: 0x181B51B70
	|-InvokeTypeInfo<object>.WriteObjectData
	|
	|-RVA: 0x1B51D70 Offset: 0x1B50370 VA: 0x181B51D70
	|-InvokeTypeInfo<float>.WriteObjectData
	*/

}

internal abstract class PropertyAccessor<ContainerType> // TypeDefIndex: 1526
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Write(TraceLoggingDataCollector collector, ref ContainerType value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-PropertyAccessor<object>.Write
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract object GetData(ContainerType value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-PropertyAccessor<object>.GetData
	*/

	// RVA: -1 Offset: -1
	public static PropertyAccessor<ContainerType> Create(PropertyAnalysis property) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B56210 Offset: 0x1B54810 VA: 0x181B56210
	|-PropertyAccessor<bool>.Create
	|
	|-RVA: 0x1B53EA0 Offset: 0x1B524A0 VA: 0x181B53EA0
	|-PropertyAccessor<byte>.Create
	|
	|-RVA: 0x1B54E60 Offset: 0x1B53460 VA: 0x181B54E60
	|-PropertyAccessor<char>.Create
	|
	|-RVA: 0x1B56600 Offset: 0x1B54C00 VA: 0x181B56600
	|-PropertyAccessor<KeyValuePair<object, object>>.Create
	|
	|-RVA: 0x1B57DA0 Offset: 0x1B563A0 VA: 0x181B57DA0
	|-PropertyAccessor<DateTime>.Create
	|
	|-RVA: 0x1B54680 Offset: 0x1B52C80 VA: 0x181B54680
	|-PropertyAccessor<DateTimeOffset>.Create
	|
	|-RVA: 0x1B536C0 Offset: 0x1B51CC0 VA: 0x181B536C0
	|-PropertyAccessor<Decimal>.Create
	|
	|-RVA: 0x1B54290 Offset: 0x1B52890 VA: 0x181B54290
	|-PropertyAccessor<EmptyStruct>.Create
	|
	|-RVA: 0x1B52AF0 Offset: 0x1B510F0 VA: 0x181B52AF0
	|-PropertyAccessor<double>.Create
	|
	|-RVA: 0x1B575C0 Offset: 0x1B55BC0 VA: 0x181B575C0
	|-PropertyAccessor<Guid>.Create
	|
	|-RVA: 0x1B571D0 Offset: 0x1B557D0 VA: 0x181B571D0
	|-PropertyAccessor<short>.Create
	|
	|-RVA: 0x1B55250 Offset: 0x1B53850 VA: 0x181B55250
	|-PropertyAccessor<int>.Create
	|
	|-RVA: 0x1B54A70 Offset: 0x1B53070 VA: 0x181B54A70
	|-PropertyAccessor<long>.Create
	|
	|-RVA: 0x1B569F0 Offset: 0x1B54FF0 VA: 0x181B569F0
	|-PropertyAccessor<IntPtr>.Create
	|
	|-RVA: 0x1B579B0 Offset: 0x1B55FB0 VA: 0x181B579B0
	|-PropertyAccessor<object>.Create
	|
	|-RVA: 0x1B53AB0 Offset: 0x1B520B0 VA: 0x181B53AB0
	|-PropertyAccessor<sbyte>.Create
	|
	|-RVA: 0x1B55640 Offset: 0x1B53C40 VA: 0x181B55640
	|-PropertyAccessor<float>.Create
	|
	|-RVA: 0x1B55E20 Offset: 0x1B54420 VA: 0x181B55E20
	|-PropertyAccessor<TimeSpan>.Create
	|
	|-RVA: 0x1B55A30 Offset: 0x1B54030 VA: 0x181B55A30
	|-PropertyAccessor<ushort>.Create
	|
	|-RVA: 0x1B532D0 Offset: 0x1B518D0 VA: 0x181B532D0
	|-PropertyAccessor<uint>.Create
	|
	|-RVA: 0x1B52EE0 Offset: 0x1B514E0 VA: 0x181B52EE0
	|-PropertyAccessor<ulong>.Create
	|
	|-RVA: 0x1B56DE0 Offset: 0x1B553E0 VA: 0x181B56DE0
	|-PropertyAccessor<UIntPtr>.Create
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5AD60 Offset: 0xD59360 VA: 0x180D5AD60
	|-PropertyAccessor<bool>..ctor
	|-PropertyAccessor<byte>..ctor
	|-PropertyAccessor<char>..ctor
	|-PropertyAccessor<KeyValuePair<object, object>>..ctor
	|-PropertyAccessor<DateTime>..ctor
	|-PropertyAccessor<DateTimeOffset>..ctor
	|-PropertyAccessor<Decimal>..ctor
	|-PropertyAccessor<EmptyStruct>..ctor
	|-PropertyAccessor<double>..ctor
	|-PropertyAccessor<Guid>..ctor
	|-PropertyAccessor<short>..ctor
	|-PropertyAccessor<int>..ctor
	|-PropertyAccessor<long>..ctor
	|-PropertyAccessor<IntPtr>..ctor
	|-PropertyAccessor<object>..ctor
	|-PropertyAccessor<sbyte>..ctor
	|-PropertyAccessor<float>..ctor
	|-PropertyAccessor<TimeSpan>..ctor
	|-PropertyAccessor<ushort>..ctor
	|-PropertyAccessor<uint>..ctor
	|-PropertyAccessor<ulong>..ctor
	|-PropertyAccessor<UIntPtr>..ctor
	*/

}

internal class NonGenericProperytWriter<ContainerType> : PropertyAccessor<ContainerType> // TypeDefIndex: 1527
{	// Fields
	private readonly TraceLoggingTypeInfo typeInfo; // 0x0
	private readonly MethodInfo getterInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(PropertyAnalysis property) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B52A60 Offset: 0x1B51060 VA: 0x181B52A60
	|-NonGenericProperytWriter<bool>..ctor
	|-NonGenericProperytWriter<byte>..ctor
	|-NonGenericProperytWriter<char>..ctor
	|-NonGenericProperytWriter<KeyValuePair<object, object>>..ctor
	|-NonGenericProperytWriter<DateTime>..ctor
	|-NonGenericProperytWriter<DateTimeOffset>..ctor
	|-NonGenericProperytWriter<Decimal>..ctor
	|-NonGenericProperytWriter<EmptyStruct>..ctor
	|-NonGenericProperytWriter<double>..ctor
	|-NonGenericProperytWriter<Guid>..ctor
	|-NonGenericProperytWriter<short>..ctor
	|-NonGenericProperytWriter<int>..ctor
	|-NonGenericProperytWriter<long>..ctor
	|-NonGenericProperytWriter<IntPtr>..ctor
	|-NonGenericProperytWriter<object>..ctor
	|-NonGenericProperytWriter<sbyte>..ctor
	|-NonGenericProperytWriter<float>..ctor
	|-NonGenericProperytWriter<TimeSpan>..ctor
	|-NonGenericProperytWriter<ushort>..ctor
	|-NonGenericProperytWriter<uint>..ctor
	|-NonGenericProperytWriter<ulong>..ctor
	|-NonGenericProperytWriter<UIntPtr>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Write(TraceLoggingDataCollector collector, ref ContainerType container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B525E0 Offset: 0x1B50BE0 VA: 0x181B525E0
	|-NonGenericProperytWriter<bool>.Write
	|-NonGenericProperytWriter<byte>.Write
	|-NonGenericProperytWriter<EmptyStruct>.Write
	|-NonGenericProperytWriter<sbyte>.Write
	|
	|-RVA: 0x1B52690 Offset: 0x1B50C90 VA: 0x181B52690
	|-NonGenericProperytWriter<char>.Write
	|-NonGenericProperytWriter<short>.Write
	|-NonGenericProperytWriter<ushort>.Write
	|
	|-RVA: 0x1B527F0 Offset: 0x1B50DF0 VA: 0x181B527F0
	|-NonGenericProperytWriter<KeyValuePair<object, object>>.Write
	|-NonGenericProperytWriter<DateTimeOffset>.Write
	|-NonGenericProperytWriter<Decimal>.Write
	|-NonGenericProperytWriter<Guid>.Write
	|
	|-RVA: 0x1B52530 Offset: 0x1B50B30 VA: 0x181B52530
	|-NonGenericProperytWriter<DateTime>.Write
	|-NonGenericProperytWriter<long>.Write
	|-NonGenericProperytWriter<IntPtr>.Write
	|-NonGenericProperytWriter<TimeSpan>.Write
	|-NonGenericProperytWriter<ulong>.Write
	|-NonGenericProperytWriter<UIntPtr>.Write
	|
	|-RVA: 0x1B52740 Offset: 0x1B50D40 VA: 0x181B52740
	|-NonGenericProperytWriter<double>.Write
	|
	|-RVA: 0x1B528A0 Offset: 0x1B50EA0 VA: 0x181B528A0
	|-NonGenericProperytWriter<int>.Write
	|-NonGenericProperytWriter<uint>.Write
	|
	|-RVA: 0x1B52A00 Offset: 0x1B51000 VA: 0x181B52A00
	|-NonGenericProperytWriter<object>.Write
	|
	|-RVA: 0x1B52950 Offset: 0x1B50F50 VA: 0x181B52950
	|-NonGenericProperytWriter<float>.Write
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override object GetData(ContainerType container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B523B0 Offset: 0x1B509B0 VA: 0x181B523B0
	|-NonGenericProperytWriter<bool>.GetData
	|-NonGenericProperytWriter<byte>.GetData
	|-NonGenericProperytWriter<EmptyStruct>.GetData
	|-NonGenericProperytWriter<sbyte>.GetData
	|
	|-RVA: 0x1B52340 Offset: 0x1B50940 VA: 0x181B52340
	|-NonGenericProperytWriter<char>.GetData
	|-NonGenericProperytWriter<short>.GetData
	|-NonGenericProperytWriter<ushort>.GetData
	|
	|-RVA: 0x1B52260 Offset: 0x1B50860 VA: 0x181B52260
	|-NonGenericProperytWriter<KeyValuePair<object, object>>.GetData
	|-NonGenericProperytWriter<DateTimeOffset>.GetData
	|-NonGenericProperytWriter<Decimal>.GetData
	|-NonGenericProperytWriter<Guid>.GetData
	|
	|-RVA: 0x1B521F0 Offset: 0x1B507F0 VA: 0x181B521F0
	|-NonGenericProperytWriter<DateTime>.GetData
	|-NonGenericProperytWriter<long>.GetData
	|-NonGenericProperytWriter<IntPtr>.GetData
	|-NonGenericProperytWriter<TimeSpan>.GetData
	|-NonGenericProperytWriter<ulong>.GetData
	|-NonGenericProperytWriter<UIntPtr>.GetData
	|
	|-RVA: 0x1B522D0 Offset: 0x1B508D0 VA: 0x181B522D0
	|-NonGenericProperytWriter<double>.GetData
	|
	|-RVA: 0x1B524C0 Offset: 0x1B50AC0 VA: 0x181B524C0
	|-NonGenericProperytWriter<int>.GetData
	|-NonGenericProperytWriter<uint>.GetData
	|
	|-RVA: 0x1B52490 Offset: 0x1B50A90 VA: 0x181B52490
	|-NonGenericProperytWriter<object>.GetData
	|
	|-RVA: 0x1B52420 Offset: 0x1B50A20 VA: 0x181B52420
	|-NonGenericProperytWriter<float>.GetData
	*/

}

internal class ClassPropertyWriter<ContainerType, ValueType> : PropertyAccessor<ContainerType> // TypeDefIndex: 1528
{	// Fields
	private readonly TraceLoggingTypeInfo<ValueType> valueTypeInfo; // 0x0
	private readonly ClassPropertyWriter.Getter<ContainerType, ValueType> getter; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(PropertyAnalysis property) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20C0E00 Offset: 0x20BF400 VA: 0x1820C0E00
	|-ClassPropertyWriter<bool, int>..ctor
	|
	|-RVA: 0x20C4200 Offset: 0x20C2800 VA: 0x1820C4200
	|-ClassPropertyWriter<bool, long>..ctor
	|
	|-RVA: 0x20C4880 Offset: 0x20C2E80 VA: 0x1820C4880
	|-ClassPropertyWriter<bool, object>..ctor
	|
	|-RVA: 0x20C1480 Offset: 0x20BFA80 VA: 0x1820C1480
	|-ClassPropertyWriter<byte, int>..ctor
	|
	|-RVA: 0x20C53E0 Offset: 0x20C39E0 VA: 0x1820C53E0
	|-ClassPropertyWriter<byte, long>..ctor
	|
	|-RVA: 0x20C46E0 Offset: 0x20C2CE0 VA: 0x1820C46E0
	|-ClassPropertyWriter<byte, object>..ctor
	|
	|-RVA: 0x20C1140 Offset: 0x20BF740 VA: 0x1820C1140
	|-ClassPropertyWriter<char, int>..ctor
	|
	|-RVA: 0x20C3B80 Offset: 0x20C2180 VA: 0x1820C3B80
	|-ClassPropertyWriter<char, long>..ctor
	|
	|-RVA: 0x20C2320 Offset: 0x20C0920 VA: 0x1820C2320
	|-ClassPropertyWriter<char, object>..ctor
	|
	|-RVA: 0x20C3840 Offset: 0x20C1E40 VA: 0x1820C3840
	|-ClassPropertyWriter<KeyValuePair<object, object>, int>..ctor
	|
	|-RVA: 0x20C1B00 Offset: 0x20C0100 VA: 0x1820C1B00
	|-ClassPropertyWriter<KeyValuePair<object, object>, long>..ctor
	|
	|-RVA: 0x20C1620 Offset: 0x20BFC20 VA: 0x1820C1620
	|-ClassPropertyWriter<KeyValuePair<object, object>, object>..ctor
	|
	|-RVA: 0x20C17C0 Offset: 0x20BFDC0 VA: 0x1820C17C0
	|-ClassPropertyWriter<DateTime, int>..ctor
	|
	|-RVA: 0x20C4BC0 Offset: 0x20C31C0 VA: 0x1820C4BC0
	|-ClassPropertyWriter<DateTime, long>..ctor
	|
	|-RVA: 0x20C0FA0 Offset: 0x20BF5A0 VA: 0x1820C0FA0
	|-ClassPropertyWriter<DateTime, object>..ctor
	|
	|-RVA: 0x20C2CE0 Offset: 0x20C12E0 VA: 0x1820C2CE0
	|-ClassPropertyWriter<DateTimeOffset, int>..ctor
	|
	|-RVA: 0x20C1960 Offset: 0x20BFF60 VA: 0x1820C1960
	|-ClassPropertyWriter<DateTimeOffset, long>..ctor
	|
	|-RVA: 0x20C4060 Offset: 0x20C2660 VA: 0x1820C4060
	|-ClassPropertyWriter<DateTimeOffset, object>..ctor
	|
	|-RVA: 0x20C2660 Offset: 0x20C0C60 VA: 0x1820C2660
	|-ClassPropertyWriter<Decimal, int>..ctor
	|
	|-RVA: 0x20C4A20 Offset: 0x20C3020 VA: 0x1820C4A20
	|-ClassPropertyWriter<Decimal, long>..ctor
	|
	|-RVA: 0x20C50A0 Offset: 0x20C36A0 VA: 0x1820C50A0
	|-ClassPropertyWriter<Decimal, object>..ctor
	|
	|-RVA: 0x20C2B40 Offset: 0x20C1140 VA: 0x1820C2B40
	|-ClassPropertyWriter<EmptyStruct, int>..ctor
	|
	|-RVA: 0x20C2E80 Offset: 0x20C1480 VA: 0x1820C2E80
	|-ClassPropertyWriter<EmptyStruct, long>..ctor
	|
	|-RVA: 0x20C29A0 Offset: 0x20C0FA0 VA: 0x1820C29A0
	|-ClassPropertyWriter<EmptyStruct, object>..ctor
	|
	|-RVA: 0x20C3500 Offset: 0x20C1B00 VA: 0x1820C3500
	|-ClassPropertyWriter<double, int>..ctor
	|
	|-RVA: 0x20C3EC0 Offset: 0x20C24C0 VA: 0x1820C3EC0
	|-ClassPropertyWriter<double, long>..ctor
	|
	|-RVA: 0x20C4D60 Offset: 0x20C3360 VA: 0x1820C4D60
	|-ClassPropertyWriter<double, object>..ctor
	|
	|-RVA: 0x20C36A0 Offset: 0x20C1CA0 VA: 0x1820C36A0
	|-ClassPropertyWriter<Guid, int>..ctor
	|
	|-RVA: 0x20C3020 Offset: 0x20C1620 VA: 0x1820C3020
	|-ClassPropertyWriter<Guid, long>..ctor
	|
	|-RVA: 0x20C4540 Offset: 0x20C2B40 VA: 0x1820C4540
	|-ClassPropertyWriter<Guid, object>..ctor
	|
	|-RVA: 0x20C1FE0 Offset: 0x20C05E0 VA: 0x1820C1FE0
	|-ClassPropertyWriter<short, int>..ctor
	|
	|-RVA: 0x20C24C0 Offset: 0x20C0AC0 VA: 0x1820C24C0
	|-ClassPropertyWriter<short, long>..ctor
	|
	|-RVA: 0x20C1CA0 Offset: 0x20C02A0 VA: 0x1820C1CA0
	|-ClassPropertyWriter<short, object>..ctor
	|
	|-RVA: 0x20C12E0 Offset: 0x20BF8E0 VA: 0x1820C12E0
	|-ClassPropertyWriter<int, int>..ctor
	|
	|-RVA: 0x20C4F00 Offset: 0x20C3500 VA: 0x1820C4F00
	|-ClassPropertyWriter<int, long>..ctor
	|
	|-RVA: 0x20C43A0 Offset: 0x20C29A0 VA: 0x1820C43A0
	|-ClassPropertyWriter<int, object>..ctor
	|
	|-RVA: 0x20C0C60 Offset: 0x20BF260 VA: 0x1820C0C60
	|-ClassPropertyWriter<long, int>..ctor
	|
	|-RVA: 0x20C2800 Offset: 0x20C0E00 VA: 0x1820C2800
	|-ClassPropertyWriter<long, long>..ctor
	|
	|-RVA: 0x20C3360 Offset: 0x20C1960 VA: 0x1820C3360
	|-ClassPropertyWriter<long, object>..ctor
	|
	|-RVA: 0x20C3D20 Offset: 0x20C2320 VA: 0x1820C3D20
	|-ClassPropertyWriter<IntPtr, int>..ctor
	|
	|-RVA: 0x20C5580 Offset: 0x20C3B80 VA: 0x1820C5580
	|-ClassPropertyWriter<IntPtr, long>..ctor
	|
	|-RVA: 0x20C5240 Offset: 0x20C3840 VA: 0x1820C5240
	|-ClassPropertyWriter<IntPtr, object>..ctor
	|
	|-RVA: 0x20C1E40 Offset: 0x20C0440 VA: 0x1820C1E40
	|-ClassPropertyWriter<object, int>..ctor
	|
	|-RVA: 0x20C31C0 Offset: 0x20C17C0 VA: 0x1820C31C0
	|-ClassPropertyWriter<object, long>..ctor
	|
	|-RVA: 0x20C2180 Offset: 0x20C0780 VA: 0x1820C2180
	|-ClassPropertyWriter<object, object>..ctor
	|
	|-RVA: 0x20C39E0 Offset: 0x20C1FE0 VA: 0x1820C39E0
	|-ClassPropertyWriter<sbyte, int>..ctor
	|
	|-RVA: 0x20C5720 Offset: 0x20C3D20 VA: 0x1820C5720
	|-ClassPropertyWriter<sbyte, long>..ctor
	|
	|-RVA: 0x1B0F860 Offset: 0x1B0DE60 VA: 0x181B0F860
	|-ClassPropertyWriter<sbyte, object>..ctor
	|
	|-RVA: 0x1B115A0 Offset: 0x1B0FBA0 VA: 0x181B115A0
	|-ClassPropertyWriter<float, int>..ctor
	|
	|-RVA: 0x1B10F20 Offset: 0x1B0F520 VA: 0x181B10F20
	|-ClassPropertyWriter<float, long>..ctor
	|
	|-RVA: 0x1B0FA00 Offset: 0x1B0E000 VA: 0x181B0FA00
	|-ClassPropertyWriter<float, object>..ctor
	|
	|-RVA: 0x1B10A40 Offset: 0x1B0F040 VA: 0x181B10A40
	|-ClassPropertyWriter<TimeSpan, int>..ctor
	|
	|-RVA: 0x1B10D80 Offset: 0x1B0F380 VA: 0x181B10D80
	|-ClassPropertyWriter<TimeSpan, long>..ctor
	|
	|-RVA: 0x1B103C0 Offset: 0x1B0E9C0 VA: 0x181B103C0
	|-ClassPropertyWriter<TimeSpan, object>..ctor
	|
	|-RVA: 0x1B0FEE0 Offset: 0x1B0E4E0 VA: 0x181B0FEE0
	|-ClassPropertyWriter<ushort, int>..ctor
	|
	|-RVA: 0x1B10080 Offset: 0x1B0E680 VA: 0x181B10080
	|-ClassPropertyWriter<ushort, long>..ctor
	|
	|-RVA: 0x1B11400 Offset: 0x1B0FA00 VA: 0x181B11400
	|-ClassPropertyWriter<ushort, object>..ctor
	|
	|-RVA: 0x1B110C0 Offset: 0x1B0F6C0 VA: 0x181B110C0
	|-ClassPropertyWriter<uint, int>..ctor
	|
	|-RVA: 0x1B11260 Offset: 0x1B0F860 VA: 0x181B11260
	|-ClassPropertyWriter<uint, long>..ctor
	|
	|-RVA: 0x1B10560 Offset: 0x1B0EB60 VA: 0x181B10560
	|-ClassPropertyWriter<uint, object>..ctor
	|
	|-RVA: 0x1B10700 Offset: 0x1B0ED00 VA: 0x181B10700
	|-ClassPropertyWriter<ulong, int>..ctor
	|
	|-RVA: 0x1B108A0 Offset: 0x1B0EEA0 VA: 0x181B108A0
	|-ClassPropertyWriter<ulong, long>..ctor
	|
	|-RVA: 0x1B0FD40 Offset: 0x1B0E340 VA: 0x181B0FD40
	|-ClassPropertyWriter<ulong, object>..ctor
	|
	|-RVA: 0x1B0FBA0 Offset: 0x1B0E1A0 VA: 0x181B0FBA0
	|-ClassPropertyWriter<UIntPtr, int>..ctor
	|
	|-RVA: 0x1B10220 Offset: 0x1B0E820 VA: 0x181B10220
	|-ClassPropertyWriter<UIntPtr, long>..ctor
	|
	|-RVA: 0x1B10BE0 Offset: 0x1B0F1E0 VA: 0x181B10BE0
	|-ClassPropertyWriter<UIntPtr, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Write(TraceLoggingDataCollector collector, ref ContainerType container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20C09C0 Offset: 0x20BEFC0 VA: 0x1820C09C0
	|-ClassPropertyWriter<bool, int>.Write
	|-ClassPropertyWriter<byte, int>.Write
	|-ClassPropertyWriter<sbyte, int>.Write
	|
	|-RVA: 0x1B0F400 Offset: 0x1B0DA00 VA: 0x181B0F400
	|-ClassPropertyWriter<bool, long>.Write
	|-ClassPropertyWriter<bool, object>.Write
	|-ClassPropertyWriter<byte, long>.Write
	|-ClassPropertyWriter<byte, object>.Write
	|-ClassPropertyWriter<sbyte, long>.Write
	|-ClassPropertyWriter<sbyte, object>.Write
	|
	|-RVA: 0x1B0F6A0 Offset: 0x1B0DCA0 VA: 0x181B0F6A0
	|-ClassPropertyWriter<char, int>.Write
	|-ClassPropertyWriter<short, int>.Write
	|-ClassPropertyWriter<ushort, int>.Write
	|
	|-RVA: 0x1B0F390 Offset: 0x1B0D990 VA: 0x181B0F390
	|-ClassPropertyWriter<char, long>.Write
	|-ClassPropertyWriter<char, object>.Write
	|-ClassPropertyWriter<short, long>.Write
	|-ClassPropertyWriter<short, object>.Write
	|-ClassPropertyWriter<ushort, long>.Write
	|-ClassPropertyWriter<ushort, object>.Write
	|
	|-RVA: 0x20C0940 Offset: 0x20BEF40 VA: 0x1820C0940
	|-ClassPropertyWriter<KeyValuePair<object, object>, int>.Write
	|-ClassPropertyWriter<DateTimeOffset, int>.Write
	|-ClassPropertyWriter<Decimal, int>.Write
	|-ClassPropertyWriter<Guid, int>.Write
	|
	|-RVA: 0x20C0850 Offset: 0x20BEE50 VA: 0x1820C0850
	|-ClassPropertyWriter<KeyValuePair<object, object>, long>.Write
	|-ClassPropertyWriter<KeyValuePair<object, object>, object>.Write
	|-ClassPropertyWriter<DateTimeOffset, long>.Write
	|-ClassPropertyWriter<DateTimeOffset, object>.Write
	|-ClassPropertyWriter<Decimal, long>.Write
	|-ClassPropertyWriter<Decimal, object>.Write
	|-ClassPropertyWriter<Guid, long>.Write
	|-ClassPropertyWriter<Guid, object>.Write
	|
	|-RVA: 0x1B0F710 Offset: 0x1B0DD10 VA: 0x181B0F710
	|-ClassPropertyWriter<DateTime, int>.Write
	|-ClassPropertyWriter<TimeSpan, int>.Write
	|
	|-RVA: 0x1B0F780 Offset: 0x1B0DD80 VA: 0x181B0F780
	|-ClassPropertyWriter<DateTime, long>.Write
	|-ClassPropertyWriter<DateTime, object>.Write
	|-ClassPropertyWriter<TimeSpan, long>.Write
	|-ClassPropertyWriter<TimeSpan, object>.Write
	|
	|-RVA: 0x20C0BF0 Offset: 0x20BF1F0 VA: 0x1820C0BF0
	|-ClassPropertyWriter<EmptyStruct, int>.Write
	|
	|-RVA: 0x20C08D0 Offset: 0x20BEED0 VA: 0x1820C08D0
	|-ClassPropertyWriter<EmptyStruct, long>.Write
	|-ClassPropertyWriter<EmptyStruct, object>.Write
	|
	|-RVA: 0x20C0B80 Offset: 0x20BF180 VA: 0x1820C0B80
	|-ClassPropertyWriter<double, int>.Write
	|
	|-RVA: 0x20C0AA0 Offset: 0x20BF0A0 VA: 0x1820C0AA0
	|-ClassPropertyWriter<double, long>.Write
	|-ClassPropertyWriter<double, object>.Write
	|
	|-RVA: 0x1B0F7F0 Offset: 0x1B0DDF0 VA: 0x181B0F7F0
	|-ClassPropertyWriter<int, int>.Write
	|-ClassPropertyWriter<uint, int>.Write
	|
	|-RVA: 0x1B0F550 Offset: 0x1B0DB50 VA: 0x181B0F550
	|-ClassPropertyWriter<int, long>.Write
	|-ClassPropertyWriter<int, object>.Write
	|-ClassPropertyWriter<uint, long>.Write
	|-ClassPropertyWriter<uint, object>.Write
	|
	|-RVA: 0x1B0F630 Offset: 0x1B0DC30 VA: 0x181B0F630
	|-ClassPropertyWriter<long, int>.Write
	|-ClassPropertyWriter<IntPtr, int>.Write
	|-ClassPropertyWriter<ulong, int>.Write
	|-ClassPropertyWriter<UIntPtr, int>.Write
	|
	|-RVA: 0x1B0F4E0 Offset: 0x1B0DAE0 VA: 0x181B0F4E0
	|-ClassPropertyWriter<long, long>.Write
	|-ClassPropertyWriter<long, object>.Write
	|-ClassPropertyWriter<IntPtr, long>.Write
	|-ClassPropertyWriter<IntPtr, object>.Write
	|-ClassPropertyWriter<ulong, long>.Write
	|-ClassPropertyWriter<ulong, object>.Write
	|-ClassPropertyWriter<UIntPtr, long>.Write
	|-ClassPropertyWriter<UIntPtr, object>.Write
	|
	|-RVA: 0x20C0B10 Offset: 0x20BF110 VA: 0x1820C0B10
	|-ClassPropertyWriter<object, int>.Write
	|
	|-RVA: 0x20C0A30 Offset: 0x20BF030 VA: 0x1820C0A30
	|-ClassPropertyWriter<object, long>.Write
	|-ClassPropertyWriter<object, object>.Write
	|
	|-RVA: 0x1B0F5C0 Offset: 0x1B0DBC0 VA: 0x181B0F5C0
	|-ClassPropertyWriter<float, int>.Write
	|
	|-RVA: 0x1B0F470 Offset: 0x1B0DA70 VA: 0x181B0F470
	|-ClassPropertyWriter<float, long>.Write
	|-ClassPropertyWriter<float, object>.Write
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override object GetData(ContainerType container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B0F1A0 Offset: 0x1B0D7A0 VA: 0x181B0F1A0
	|-ClassPropertyWriter<bool, int>.GetData
	|-ClassPropertyWriter<byte, int>.GetData
	|-ClassPropertyWriter<char, int>.GetData
	|-ClassPropertyWriter<EmptyStruct, int>.GetData
	|-ClassPropertyWriter<short, int>.GetData
	|-ClassPropertyWriter<int, int>.GetData
	|-ClassPropertyWriter<sbyte, int>.GetData
	|-ClassPropertyWriter<ushort, int>.GetData
	|-ClassPropertyWriter<uint, int>.GetData
	|
	|-RVA: 0x1B0F100 Offset: 0x1B0D700 VA: 0x181B0F100
	|-ClassPropertyWriter<bool, long>.GetData
	|-ClassPropertyWriter<byte, long>.GetData
	|-ClassPropertyWriter<char, long>.GetData
	|-ClassPropertyWriter<DateTime, long>.GetData
	|-ClassPropertyWriter<EmptyStruct, long>.GetData
	|-ClassPropertyWriter<short, long>.GetData
	|-ClassPropertyWriter<int, long>.GetData
	|-ClassPropertyWriter<long, long>.GetData
	|-ClassPropertyWriter<IntPtr, long>.GetData
	|-ClassPropertyWriter<sbyte, long>.GetData
	|-ClassPropertyWriter<TimeSpan, long>.GetData
	|-ClassPropertyWriter<ushort, long>.GetData
	|-ClassPropertyWriter<uint, long>.GetData
	|-ClassPropertyWriter<ulong, long>.GetData
	|-ClassPropertyWriter<UIntPtr, long>.GetData
	|
	|-RVA: 0x1B0F170 Offset: 0x1B0D770 VA: 0x181B0F170
	|-ClassPropertyWriter<bool, object>.GetData
	|-ClassPropertyWriter<byte, object>.GetData
	|-ClassPropertyWriter<char, object>.GetData
	|-ClassPropertyWriter<DateTime, object>.GetData
	|-ClassPropertyWriter<EmptyStruct, object>.GetData
	|-ClassPropertyWriter<short, object>.GetData
	|-ClassPropertyWriter<int, object>.GetData
	|-ClassPropertyWriter<long, object>.GetData
	|-ClassPropertyWriter<IntPtr, object>.GetData
	|-ClassPropertyWriter<sbyte, object>.GetData
	|-ClassPropertyWriter<TimeSpan, object>.GetData
	|-ClassPropertyWriter<ushort, object>.GetData
	|-ClassPropertyWriter<uint, object>.GetData
	|-ClassPropertyWriter<ulong, object>.GetData
	|-ClassPropertyWriter<UIntPtr, object>.GetData
	|
	|-RVA: 0x20C0570 Offset: 0x20BEB70 VA: 0x1820C0570
	|-ClassPropertyWriter<KeyValuePair<object, object>, int>.GetData
	|-ClassPropertyWriter<DateTimeOffset, int>.GetData
	|-ClassPropertyWriter<Decimal, int>.GetData
	|-ClassPropertyWriter<Guid, int>.GetData
	|
	|-RVA: 0x20C0620 Offset: 0x20BEC20 VA: 0x1820C0620
	|-ClassPropertyWriter<KeyValuePair<object, object>, long>.GetData
	|-ClassPropertyWriter<DateTimeOffset, long>.GetData
	|-ClassPropertyWriter<Decimal, long>.GetData
	|-ClassPropertyWriter<Guid, long>.GetData
	|
	|-RVA: 0x20C05E0 Offset: 0x20BEBE0 VA: 0x1820C05E0
	|-ClassPropertyWriter<KeyValuePair<object, object>, object>.GetData
	|-ClassPropertyWriter<DateTimeOffset, object>.GetData
	|-ClassPropertyWriter<Decimal, object>.GetData
	|-ClassPropertyWriter<Guid, object>.GetData
	|
	|-RVA: 0x1B0F210 Offset: 0x1B0D810 VA: 0x181B0F210
	|-ClassPropertyWriter<DateTime, int>.GetData
	|-ClassPropertyWriter<long, int>.GetData
	|-ClassPropertyWriter<IntPtr, int>.GetData
	|-ClassPropertyWriter<TimeSpan, int>.GetData
	|-ClassPropertyWriter<ulong, int>.GetData
	|-ClassPropertyWriter<UIntPtr, int>.GetData
	|
	|-RVA: 0x20C0760 Offset: 0x20BED60 VA: 0x1820C0760
	|-ClassPropertyWriter<double, int>.GetData
	|
	|-RVA: 0x1B0F2F0 Offset: 0x1B0D8F0 VA: 0x181B0F2F0
	|-ClassPropertyWriter<double, long>.GetData
	|-ClassPropertyWriter<float, long>.GetData
	|
	|-RVA: 0x1B0F360 Offset: 0x1B0D960 VA: 0x181B0F360
	|-ClassPropertyWriter<double, object>.GetData
	|-ClassPropertyWriter<float, object>.GetData
	|
	|-RVA: 0x20C07D0 Offset: 0x20BEDD0 VA: 0x1820C07D0
	|-ClassPropertyWriter<object, int>.GetData
	|
	|-RVA: 0x20C06E0 Offset: 0x20BECE0 VA: 0x1820C06E0
	|-ClassPropertyWriter<object, long>.GetData
	|
	|-RVA: 0x20C06A0 Offset: 0x20BECA0 VA: 0x1820C06A0
	|-ClassPropertyWriter<object, object>.GetData
	|
	|-RVA: 0x1B0F280 Offset: 0x1B0D880 VA: 0x181B0F280
	|-ClassPropertyWriter<float, int>.GetData
	*/

}

internal sealed class NullTypeInfo<DataType> : TraceLoggingTypeInfo<DataType> // TypeDefIndex: 1531
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B52AC0 Offset: 0x1B510C0 VA: 0x181B52AC0
	|-NullTypeInfo<EmptyStruct>.WriteMetadata
	|-NullTypeInfo<object>.WriteMetadata
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref DataType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	|-NullTypeInfo<EmptyStruct>.WriteData
	|-NullTypeInfo<object>.WriteData
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override object GetData(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	|-NullTypeInfo<EmptyStruct>.GetData
	|-NullTypeInfo<object>.GetData
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B6670 Offset: 0x11B4C70 VA: 0x1811B6670
	|-NullTypeInfo<EmptyStruct>..ctor
	|-NullTypeInfo<object>..ctor
	*/

}

internal abstract class TraceLoggingTypeInfo<DataType> : TraceLoggingTypeInfo // TypeDefIndex: 1590
{	// Fields
	private static TraceLoggingTypeInfo<DataType> instance; // 0x0

	// Properties
	public static TraceLoggingTypeInfo<DataType> Instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B58580 Offset: 0x1B56B80 VA: 0x181B58580
	|-TraceLoggingTypeInfo<bool>..ctor
	|
	|-RVA: 0x1B9C850 Offset: 0x1B9AE50 VA: 0x181B9C850
	|-TraceLoggingTypeInfo<bool[]>..ctor
	|-TraceLoggingTypeInfo<byte[]>..ctor
	|-TraceLoggingTypeInfo<char[]>..ctor
	|-TraceLoggingTypeInfo<double[]>..ctor
	|-TraceLoggingTypeInfo<Guid[]>..ctor
	|-TraceLoggingTypeInfo<short[]>..ctor
	|-TraceLoggingTypeInfo<int[]>..ctor
	|-TraceLoggingTypeInfo<long[]>..ctor
	|-TraceLoggingTypeInfo<IntPtr[]>..ctor
	|-TraceLoggingTypeInfo<object>..ctor
	|-TraceLoggingTypeInfo<sbyte[]>..ctor
	|-TraceLoggingTypeInfo<float[]>..ctor
	|-TraceLoggingTypeInfo<string>..ctor
	|-TraceLoggingTypeInfo<ushort[]>..ctor
	|-TraceLoggingTypeInfo<uint[]>..ctor
	|-TraceLoggingTypeInfo<ulong[]>..ctor
	|-TraceLoggingTypeInfo<UIntPtr[]>..ctor
	|
	|-RVA: 0x1B9B7A0 Offset: 0x1B99DA0 VA: 0x181B9B7A0
	|-TraceLoggingTypeInfo<byte>..ctor
	|
	|-RVA: 0x1B9B630 Offset: 0x1B99C30 VA: 0x181B9B630
	|-TraceLoggingTypeInfo<char>..ctor
	|
	|-RVA: 0x1B9C650 Offset: 0x1B9AC50 VA: 0x181B9C650
	|-TraceLoggingTypeInfo<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x1B9C5C0 Offset: 0x1B9ABC0 VA: 0x181B9C5C0
	|-TraceLoggingTypeInfo<DateTime>..ctor
	|
	|-RVA: 0x1B9C170 Offset: 0x1B9A770 VA: 0x181B9C170
	|-TraceLoggingTypeInfo<DateTimeOffset>..ctor
	|
	|-RVA: 0x1B9C200 Offset: 0x1B9A800 VA: 0x181B9C200
	|-TraceLoggingTypeInfo<Decimal>..ctor
	|
	|-RVA: 0x1B9B4C0 Offset: 0x1B99AC0 VA: 0x181B9B4C0
	|-TraceLoggingTypeInfo<EmptyStruct>..ctor
	|
	|-RVA: 0x1B9B9F0 Offset: 0x1B99FF0 VA: 0x181B9B9F0
	|-TraceLoggingTypeInfo<double>..ctor
	|
	|-RVA: 0x1B9CCA0 Offset: 0x1B9B2A0 VA: 0x181B9CCA0
	|-TraceLoggingTypeInfo<Guid>..ctor
	|
	|-RVA: 0x1B9CB30 Offset: 0x1B9B130 VA: 0x181B9CB30
	|-TraceLoggingTypeInfo<short>..ctor
	|
	|-RVA: 0x1B9BC40 Offset: 0x1B9A240 VA: 0x181B9BC40
	|-TraceLoggingTypeInfo<int>..ctor
	|
	|-RVA: 0x1B9BF70 Offset: 0x1B9A570 VA: 0x181B9BF70
	|-TraceLoggingTypeInfo<long>..ctor
	|
	|-RVA: 0x1B9C6E0 Offset: 0x1B9ACE0 VA: 0x181B9C6E0
	|-TraceLoggingTypeInfo<IntPtr>..ctor
	|
	|-RVA: 0x1B9C290 Offset: 0x1B9A890 VA: 0x181B9C290
	|-TraceLoggingTypeInfo<sbyte>..ctor
	|
	|-RVA: 0x1B9C9C0 Offset: 0x1B9AFC0 VA: 0x181B9C9C0
	|-TraceLoggingTypeInfo<float>..ctor
	|
	|-RVA: 0x1B9B070 Offset: 0x1B99670 VA: 0x181B9B070
	|-TraceLoggingTypeInfo<TimeSpan>..ctor
	|
	|-RVA: 0x1B9CE10 Offset: 0x1B9B410 VA: 0x181B9CE10
	|-TraceLoggingTypeInfo<ushort>..ctor
	|
	|-RVA: 0x1B9C000 Offset: 0x1B9A600 VA: 0x181B9C000
	|-TraceLoggingTypeInfo<uint>..ctor
	|
	|-RVA: 0x1B9B270 Offset: 0x1B99870 VA: 0x181B9B270
	|-TraceLoggingTypeInfo<ulong>..ctor
	|
	|-RVA: 0x1B9B100 Offset: 0x1B99700 VA: 0x181B9B100
	|-TraceLoggingTypeInfo<UIntPtr>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(string name, EventLevel level, EventOpcode opcode, EventKeywords keywords, EventTags tags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B584A0 Offset: 0x1B56AA0 VA: 0x181B584A0
	|-TraceLoggingTypeInfo<bool>..ctor
	|
	|-RVA: 0x1B9CBC0 Offset: 0x1B9B1C0 VA: 0x181B9CBC0
	|-TraceLoggingTypeInfo<byte>..ctor
	|
	|-RVA: 0x1B9BCD0 Offset: 0x1B9A2D0 VA: 0x181B9BCD0
	|-TraceLoggingTypeInfo<char>..ctor
	|
	|-RVA: 0x1B9BA80 Offset: 0x1B9A080 VA: 0x181B9BA80
	|-TraceLoggingTypeInfo<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x1B9BE90 Offset: 0x1B9A490 VA: 0x181B9BE90
	|-TraceLoggingTypeInfo<DateTime>..ctor
	|
	|-RVA: 0x1B9C770 Offset: 0x1B9AD70 VA: 0x181B9C770
	|-TraceLoggingTypeInfo<DateTimeOffset>..ctor
	|
	|-RVA: 0x1B9B910 Offset: 0x1B99F10 VA: 0x181B9B910
	|-TraceLoggingTypeInfo<Decimal>..ctor
	|
	|-RVA: 0x1B9BB60 Offset: 0x1B9A160 VA: 0x181B9BB60
	|-TraceLoggingTypeInfo<EmptyStruct>..ctor
	|
	|-RVA: 0x1B9BDB0 Offset: 0x1B9A3B0 VA: 0x181B9BDB0
	|-TraceLoggingTypeInfo<double>..ctor
	|
	|-RVA: 0x1B9B3E0 Offset: 0x1B999E0 VA: 0x181B9B3E0
	|-TraceLoggingTypeInfo<Guid>..ctor
	|
	|-RVA: 0x1B9CD30 Offset: 0x1B9B330 VA: 0x181B9CD30
	|-TraceLoggingTypeInfo<short>..ctor
	|
	|-RVA: 0x1B9B6C0 Offset: 0x1B99CC0 VA: 0x181B9B6C0
	|-TraceLoggingTypeInfo<int>..ctor
	|
	|-RVA: 0x1B9B300 Offset: 0x1B99900 VA: 0x181B9B300
	|-TraceLoggingTypeInfo<long>..ctor
	|
	|-RVA: 0x1B9C320 Offset: 0x1B9A920 VA: 0x181B9C320
	|-TraceLoggingTypeInfo<IntPtr>..ctor
	|
	|-RVA: 0x1B9B550 Offset: 0x1B99B50 VA: 0x181B9B550
	|-TraceLoggingTypeInfo<object>..ctor
	|
	|-RVA: 0x1B9C400 Offset: 0x1B9AA00 VA: 0x181B9C400
	|-TraceLoggingTypeInfo<sbyte>..ctor
	|
	|-RVA: 0x1B9C090 Offset: 0x1B9A690 VA: 0x181B9C090
	|-TraceLoggingTypeInfo<float>..ctor
	|
	|-RVA: 0x1B9C4E0 Offset: 0x1B9AAE0 VA: 0x181B9C4E0
	|-TraceLoggingTypeInfo<TimeSpan>..ctor
	|
	|-RVA: 0x1B9B190 Offset: 0x1B99790 VA: 0x181B9B190
	|-TraceLoggingTypeInfo<ushort>..ctor
	|
	|-RVA: 0x1B9CA50 Offset: 0x1B9B050 VA: 0x181B9CA50
	|-TraceLoggingTypeInfo<uint>..ctor
	|
	|-RVA: 0x1B9B830 Offset: 0x1B99E30 VA: 0x181B9B830
	|-TraceLoggingTypeInfo<ulong>..ctor
	|
	|-RVA: 0x1B9C8E0 Offset: 0x1B9AEE0 VA: 0x181B9C8E0
	|-TraceLoggingTypeInfo<UIntPtr>..ctor
	*/

	// RVA: -1 Offset: -1
	public static TraceLoggingTypeInfo<DataType> get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B58610 Offset: 0x1B56C10 VA: 0x181B58610
	|-TraceLoggingTypeInfo<bool>.get_Instance
	|-TraceLoggingTypeInfo<byte>.get_Instance
	|-TraceLoggingTypeInfo<char>.get_Instance
	|-TraceLoggingTypeInfo<KeyValuePair<object, object>>.get_Instance
	|-TraceLoggingTypeInfo<DateTime>.get_Instance
	|-TraceLoggingTypeInfo<DateTimeOffset>.get_Instance
	|-TraceLoggingTypeInfo<Decimal>.get_Instance
	|-TraceLoggingTypeInfo<EmptyStruct>.get_Instance
	|-TraceLoggingTypeInfo<double>.get_Instance
	|-TraceLoggingTypeInfo<Guid>.get_Instance
	|-TraceLoggingTypeInfo<short>.get_Instance
	|-TraceLoggingTypeInfo<int>.get_Instance
	|-TraceLoggingTypeInfo<long>.get_Instance
	|-TraceLoggingTypeInfo<IntPtr>.get_Instance
	|-TraceLoggingTypeInfo<object>.get_Instance
	|-TraceLoggingTypeInfo<sbyte>.get_Instance
	|-TraceLoggingTypeInfo<float>.get_Instance
	|-TraceLoggingTypeInfo<string>.get_Instance
	|-TraceLoggingTypeInfo<TimeSpan>.get_Instance
	|-TraceLoggingTypeInfo<ushort>.get_Instance
	|-TraceLoggingTypeInfo<uint>.get_Instance
	|-TraceLoggingTypeInfo<ulong>.get_Instance
	|-TraceLoggingTypeInfo<UIntPtr>.get_Instance
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void WriteData(TraceLoggingDataCollector collector, ref DataType value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TraceLoggingTypeInfo<object>.WriteData
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override void WriteObjectData(TraceLoggingDataCollector collector, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B583F0 Offset: 0x1B569F0 VA: 0x181B583F0
	|-TraceLoggingTypeInfo<bool>.WriteObjectData
	|-TraceLoggingTypeInfo<byte>.WriteObjectData
	|-TraceLoggingTypeInfo<EmptyStruct>.WriteObjectData
	|-TraceLoggingTypeInfo<sbyte>.WriteObjectData
	|
	|-RVA: 0x1B9AE60 Offset: 0x1B99460 VA: 0x181B9AE60
	|-TraceLoggingTypeInfo<bool[]>.WriteObjectData
	|-TraceLoggingTypeInfo<byte[]>.WriteObjectData
	|-TraceLoggingTypeInfo<char[]>.WriteObjectData
	|-TraceLoggingTypeInfo<double[]>.WriteObjectData
	|-TraceLoggingTypeInfo<Guid[]>.WriteObjectData
	|-TraceLoggingTypeInfo<short[]>.WriteObjectData
	|-TraceLoggingTypeInfo<int[]>.WriteObjectData
	|-TraceLoggingTypeInfo<long[]>.WriteObjectData
	|-TraceLoggingTypeInfo<IntPtr[]>.WriteObjectData
	|-TraceLoggingTypeInfo<object>.WriteObjectData
	|-TraceLoggingTypeInfo<sbyte[]>.WriteObjectData
	|-TraceLoggingTypeInfo<float[]>.WriteObjectData
	|-TraceLoggingTypeInfo<string>.WriteObjectData
	|-TraceLoggingTypeInfo<ushort[]>.WriteObjectData
	|-TraceLoggingTypeInfo<uint[]>.WriteObjectData
	|-TraceLoggingTypeInfo<ulong[]>.WriteObjectData
	|-TraceLoggingTypeInfo<UIntPtr[]>.WriteObjectData
	|
	|-RVA: 0x1B9AD00 Offset: 0x1B99300 VA: 0x181B9AD00
	|-TraceLoggingTypeInfo<char>.WriteObjectData
	|-TraceLoggingTypeInfo<short>.WriteObjectData
	|-TraceLoggingTypeInfo<ushort>.WriteObjectData
	|
	|-RVA: 0x1B9AC50 Offset: 0x1B99250 VA: 0x181B9AC50
	|-TraceLoggingTypeInfo<KeyValuePair<object, object>>.WriteObjectData
	|-TraceLoggingTypeInfo<DateTimeOffset>.WriteObjectData
	|-TraceLoggingTypeInfo<Decimal>.WriteObjectData
	|-TraceLoggingTypeInfo<Guid>.WriteObjectData
	|
	|-RVA: 0x1B9ABA0 Offset: 0x1B991A0 VA: 0x181B9ABA0
	|-TraceLoggingTypeInfo<DateTime>.WriteObjectData
	|-TraceLoggingTypeInfo<long>.WriteObjectData
	|-TraceLoggingTypeInfo<IntPtr>.WriteObjectData
	|-TraceLoggingTypeInfo<TimeSpan>.WriteObjectData
	|-TraceLoggingTypeInfo<ulong>.WriteObjectData
	|-TraceLoggingTypeInfo<UIntPtr>.WriteObjectData
	|
	|-RVA: 0x1B9AFC0 Offset: 0x1B995C0 VA: 0x181B9AFC0
	|-TraceLoggingTypeInfo<double>.WriteObjectData
	|
	|-RVA: 0x1B9AF10 Offset: 0x1B99510 VA: 0x181B9AF10
	|-TraceLoggingTypeInfo<int>.WriteObjectData
	|-TraceLoggingTypeInfo<uint>.WriteObjectData
	|
	|-RVA: 0x1B9ADB0 Offset: 0x1B993B0 VA: 0x181B9ADB0
	|-TraceLoggingTypeInfo<float>.WriteObjectData
	*/

	// RVA: -1 Offset: -1
	internal static TraceLoggingTypeInfo<DataType> GetInstance(List<Type> recursionCheck) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B58190 Offset: 0x1B56790 VA: 0x181B58190
	|-TraceLoggingTypeInfo<bool>.GetInstance
	|
	|-RVA: 0x1B98080 Offset: 0x1B96680 VA: 0x181B98080
	|-TraceLoggingTypeInfo<byte>.GetInstance
	|
	|-RVA: 0x1B99820 Offset: 0x1B97E20 VA: 0x181B99820
	|-TraceLoggingTypeInfo<char>.GetInstance
	|
	|-RVA: 0x1B99310 Offset: 0x1B97910 VA: 0x181B99310
	|-TraceLoggingTypeInfo<KeyValuePair<object, object>>.GetInstance
	|
	|-RVA: 0x1B99B80 Offset: 0x1B98180 VA: 0x181B99B80
	|-TraceLoggingTypeInfo<DateTime>.GetInstance
	|
	|-RVA: 0x1B988F0 Offset: 0x1B96EF0 VA: 0x181B988F0
	|-TraceLoggingTypeInfo<DateTimeOffset>.GetInstance
	|
	|-RVA: 0x1B98FB0 Offset: 0x1B975B0 VA: 0x181B98FB0
	|-TraceLoggingTypeInfo<Decimal>.GetInstance
	|
	|-RVA: 0x1B999D0 Offset: 0x1B97FD0 VA: 0x181B999D0
	|-TraceLoggingTypeInfo<EmptyStruct>.GetInstance
	|
	|-RVA: 0x1B98740 Offset: 0x1B96D40 VA: 0x181B98740
	|-TraceLoggingTypeInfo<double>.GetInstance
	|
	|-RVA: 0x1B99670 Offset: 0x1B97C70 VA: 0x181B99670
	|-TraceLoggingTypeInfo<Guid>.GetInstance
	|
	|-RVA: 0x1B98AA0 Offset: 0x1B970A0 VA: 0x181B98AA0
	|-TraceLoggingTypeInfo<short>.GetInstance
	|
	|-RVA: 0x1B98230 Offset: 0x1B96830 VA: 0x181B98230
	|-TraceLoggingTypeInfo<int>.GetInstance
	|
	|-RVA: 0x1B994C0 Offset: 0x1B97AC0 VA: 0x181B994C0
	|-TraceLoggingTypeInfo<long>.GetInstance
	|
	|-RVA: 0x1B99160 Offset: 0x1B97760 VA: 0x181B99160
	|-TraceLoggingTypeInfo<IntPtr>.GetInstance
	|
	|-RVA: 0x1B983E0 Offset: 0x1B969E0 VA: 0x181B983E0
	|-TraceLoggingTypeInfo<object>.GetInstance
	|
	|-RVA: 0x1B979C0 Offset: 0x1B95FC0 VA: 0x181B979C0
	|-TraceLoggingTypeInfo<sbyte>.GetInstance
	|
	|-RVA: 0x1B98E00 Offset: 0x1B97400 VA: 0x181B98E00
	|-TraceLoggingTypeInfo<float>.GetInstance
	|
	|-RVA: 0x1B97ED0 Offset: 0x1B964D0 VA: 0x181B97ED0
	|-TraceLoggingTypeInfo<TimeSpan>.GetInstance
	|
	|-RVA: 0x1B97D20 Offset: 0x1B96320 VA: 0x181B97D20
	|-TraceLoggingTypeInfo<ushort>.GetInstance
	|
	|-RVA: 0x1B97B70 Offset: 0x1B96170 VA: 0x181B97B70
	|-TraceLoggingTypeInfo<uint>.GetInstance
	|
	|-RVA: 0x1B98590 Offset: 0x1B96B90 VA: 0x181B98590
	|-TraceLoggingTypeInfo<ulong>.GetInstance
	|
	|-RVA: 0x1B98C50 Offset: 0x1B97250 VA: 0x181B98C50
	|-TraceLoggingTypeInfo<UIntPtr>.GetInstance
	*/

	// RVA: -1 Offset: -1
	private static TraceLoggingTypeInfo<DataType> InitInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B58340 Offset: 0x1B56940 VA: 0x181B58340
	|-TraceLoggingTypeInfo<bool>.InitInstance
	|
	|-RVA: 0x1B9A200 Offset: 0x1B98800 VA: 0x181B9A200
	|-TraceLoggingTypeInfo<byte>.InitInstance
	|
	|-RVA: 0x1B9A990 Offset: 0x1B98F90 VA: 0x181B9A990
	|-TraceLoggingTypeInfo<char>.InitInstance
	|
	|-RVA: 0x1B99FF0 Offset: 0x1B985F0 VA: 0x181B99FF0
	|-TraceLoggingTypeInfo<KeyValuePair<object, object>>.InitInstance
	|
	|-RVA: 0x1B9A6D0 Offset: 0x1B98CD0 VA: 0x181B9A6D0
	|-TraceLoggingTypeInfo<DateTime>.InitInstance
	|
	|-RVA: 0x1B99DE0 Offset: 0x1B983E0 VA: 0x181B99DE0
	|-TraceLoggingTypeInfo<DateTimeOffset>.InitInstance
	|
	|-RVA: 0x1B9A410 Offset: 0x1B98A10 VA: 0x181B9A410
	|-TraceLoggingTypeInfo<Decimal>.InitInstance
	|
	|-RVA: 0x1B99E90 Offset: 0x1B98490 VA: 0x181B99E90
	|-TraceLoggingTypeInfo<EmptyStruct>.InitInstance
	|
	|-RVA: 0x1B9A620 Offset: 0x1B98C20 VA: 0x181B9A620
	|-TraceLoggingTypeInfo<double>.InitInstance
	|
	|-RVA: 0x1B99D30 Offset: 0x1B98330 VA: 0x181B99D30
	|-TraceLoggingTypeInfo<Guid>.InitInstance
	|
	|-RVA: 0x1B9AAF0 Offset: 0x1B990F0 VA: 0x181B9AAF0
	|-TraceLoggingTypeInfo<short>.InitInstance
	|
	|-RVA: 0x1B9A570 Offset: 0x1B98B70 VA: 0x181B9A570
	|-TraceLoggingTypeInfo<int>.InitInstance
	|
	|-RVA: 0x1B99F40 Offset: 0x1B98540 VA: 0x181B99F40
	|-TraceLoggingTypeInfo<long>.InitInstance
	|
	|-RVA: 0x1B9A360 Offset: 0x1B98960 VA: 0x181B9A360
	|-TraceLoggingTypeInfo<IntPtr>.InitInstance
	|
	|-RVA: 0x1B9A830 Offset: 0x1B98E30 VA: 0x181B9A830
	|-TraceLoggingTypeInfo<object>.InitInstance
	|
	|-RVA: 0x1B9A4C0 Offset: 0x1B98AC0 VA: 0x181B9A4C0
	|-TraceLoggingTypeInfo<sbyte>.InitInstance
	|
	|-RVA: 0x1B9AA40 Offset: 0x1B99040 VA: 0x181B9AA40
	|-TraceLoggingTypeInfo<float>.InitInstance
	|
	|-RVA: 0x1B9A2B0 Offset: 0x1B988B0 VA: 0x181B9A2B0
	|-TraceLoggingTypeInfo<TimeSpan>.InitInstance
	|
	|-RVA: 0x1B9A780 Offset: 0x1B98D80 VA: 0x181B9A780
	|-TraceLoggingTypeInfo<ushort>.InitInstance
	|
	|-RVA: 0x1B9A0A0 Offset: 0x1B986A0 VA: 0x181B9A0A0
	|-TraceLoggingTypeInfo<uint>.InitInstance
	|
	|-RVA: 0x1B9A8E0 Offset: 0x1B98EE0 VA: 0x181B9A8E0
	|-TraceLoggingTypeInfo<ulong>.InitInstance
	|
	|-RVA: 0x1B9A150 Offset: 0x1B98750 VA: 0x181B9A150
	|-TraceLoggingTypeInfo<UIntPtr>.InitInstance
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 1635
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 0392525BCB01691D1F319D89F2C12BF93A478467 /*Metadata offset 0x521BC8*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 0588059ACBD52F7EA2835882F977A9CF72EB9775 /*Metadata offset 0x521CC8*/; // 0x100
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=84 0A1ADB22C1D3E1F4B2448EE3F27DF9DE63329C4C /*Metadata offset 0x521D10*/; // 0x148
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=240 121EC59E23F7559B28D338D562528F6299C2DE22 /*Metadata offset 0x521D64*/; // 0x19C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 12D04472A8285260EA12FD3813CDFA9F2D2B548C /*Metadata offset 0x521E54*/; // 0x28C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 13A35EF1A549297C70E2AD46045BBD2ECA17852D /*Metadata offset 0x521E57*/; // 0x28F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 1730F09044E91DB8371B849EFF5E6D17BDE4AED0 /*Metadata offset 0x521E5A*/; // 0x292
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 1A84029C80CB5518379F199F53FF08A7B764F8FD /*Metadata offset 0x521E72*/; // 0x2AA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096 1AEF3D8DF416A46288C91C724CBF7B154D9E5BF3 /*Metadata offset 0x521E75*/; // 0x2AD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 1E41C4CD0767AEA21C00DEABA2EA9407F1E6CEA5 /*Metadata offset 0x522E75*/; // 0x12AD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 1FE6CE411858B3D864679DE2139FB081F08BFACD /*Metadata offset 0x523675*/; // 0x1AAD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 235D99572263B22ADFEE10FDA0C25E12F4D94FFC /*Metadata offset 0x523685*/; // 0x1ABD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 25420D0055076FA8D3E4DD96BC53AE24DE6E619F /*Metadata offset 0x523688*/; // 0x1AC0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1208 25CF935D2AE9EDF05DD75BCD47FF84D9255D6F6E /*Metadata offset 0x5236B0*/; // 0x1AE8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=42 29C1A61550F0E3260E1953D4FAD71C256218EF40 /*Metadata offset 0x523B68*/; // 0x1FA0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 2B33BEC8C30DFDC49DAFE20D3BDE19487850D717 /*Metadata offset 0x523B92*/; // 0x1FCA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 2BA840FF6020B8FF623DBCB7188248CF853FAF4F /*Metadata offset 0x523B9E*/; // 0x1FD6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 2C840AFA48C27B9C05593E468C1232CA1CC74AFD /*Metadata offset 0x523BC2*/; // 0x1FFA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 2D1DA5BB407F0C11C3B5116196C0C6374D932B20 /*Metadata offset 0x523C0A*/; // 0x2042
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=14 2D3CF0F15AC2DDEC2956EA1B7BBE43FB8B923130 /*Metadata offset 0x523C1A*/; // 0x2052
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 2F71D2DA12F3CD0A6A112F5A5A75B4FDC6FE8547 /*Metadata offset 0x523C28*/; // 0x2060
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 320B018758ECE3752FFEDBAEB1A6DB67C80B9359 /*Metadata offset 0x523C70*/; // 0x20A8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 34476C29F6F81C989CFCA42F7C06E84C66236834 /*Metadata offset 0x523CB0*/; // 0x20E8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2382 35EED060772F2748D13B745DAEC8CD7BD3B87604 /*Metadata offset 0x523CF8*/; // 0x2130
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=38 375F9AE9769A3D1DA789E9ACFE81F3A1BB14F0D3 /*Metadata offset 0x524646*/; // 0x2A7E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1450 379C06C9E702D31469C29033F0DD63931EB349F5 /*Metadata offset 0x52466C*/; // 0x2AA4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 399BD13E240F33F808CA7940293D6EC4E6FD5A00 /*Metadata offset 0x524C16*/; // 0x304E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 39C9CE73C7B0619D409EF28344F687C1B5C130FE /*Metadata offset 0x524C20*/; // 0x3058
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=320 3C53AFB51FEC23491684C7BEDBC6D4E0F409F851 /*Metadata offset 0x524C68*/; // 0x30A0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 3E3442C7396F3F2BB4C7348F4A2074C7DC677D68 /*Metadata offset 0x524DA8*/; // 0x31E0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 3E4BBF9D0CDD2E34F78AA7A9A3979DCE1F7B02BD /*Metadata offset 0x524DAB*/; // 0x31E3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 3E823444D2DFECF0F90B436B88F02A533CB376F1 /*Metadata offset 0x524DEB*/; // 0x3223
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 3FE6C283BCF384FD2C8789880DFF59664E2AB4A1 /*Metadata offset 0x524DF7*/; // 0x322F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1665 40981BAA39513E58B28DCF0103CC04DE2A0A0444 /*Metadata offset 0x524E3F*/; // 0x3277
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 40E7C49413D261F3F38AD3A870C0AC69C8BDA048 /*Metadata offset 0x5254C0*/; // 0x38F8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 421EC7E82F2967DF6CA8C3605514DC6F29EE5845 /*Metadata offset 0x5254E8*/; // 0x3920
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 433175D38B13FFE177FDD661A309F1B528B3F6E2 /*Metadata offset 0x525530*/; // 0x3968
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=120 46232052BC757E030490D851F265FB47FA100902 /*Metadata offset 0x525630*/; // 0x3A68
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 4858DB4AA76D3933F1CA9E6712D4FDB16903F628 /*Metadata offset 0x5256A8*/; // 0x3AE0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 4E3B533C39447AAEB59A8E48FABD7E15B5B5D195 /*Metadata offset 0x5256F0*/; // 0x3B28
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 4F7A8890F332B22B8DE0BD29D36FA7364748D76A /*Metadata offset 0x525720*/; // 0x3B58
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 536422B321459B242ADED7240B7447E904E083E3 /*Metadata offset 0x525748*/; // 0x3B80
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1080 5382CEF491F422BFE0D6FC46EFAFF9EF9D4C89F3 /*Metadata offset 0x525790*/; // 0x3BC8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 56DFA5053B3131883637F53219E7D88CCEF35949 /*Metadata offset 0x525BC8*/; // 0x4000
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 57218C316B6921E2CD61027A2387EDC31A2D9471 /*Metadata offset 0x525BD2*/; // 0x400A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 57F320D62696EC99727E0FE2045A05F1289CC0C6 /*Metadata offset 0x525BD5*/; // 0x400D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=212 594A33A00BC4F785DFD43E3C6C44FBA1242CCAF3 /*Metadata offset 0x525BFD*/; // 0x4035
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 5BBDF8058D4235C33F2E8DCF76004031B6187A2F /*Metadata offset 0x525CD1*/; // 0x4109
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=288 5BCD21C341BE6DDF8FFFAE1A23ABA24DCBB612BF /*Metadata offset 0x525CF5*/; // 0x412D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 5BFE2819B4778217C56416C7585FF0E56EBACD89 /*Metadata offset 0x525E15*/; // 0x424D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 609C0E8D8DA86A09D6013D301C86BA8782C16B8C /*Metadata offset 0x525E5D*/; // 0x4295
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 62BAB0F245E66C3EB982CF5A7015F0A7C3382283 /*Metadata offset 0x525EDD*/; // 0x4315
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 646036A65DECCD6835C914A46E6E44B729433B60 /*Metadata offset 0x525F0D*/; // 0x4345
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 65E32B4E150FD8D24B93B0D42A17F1DAD146162B /*Metadata offset 0x52670D*/; // 0x4B45
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 6770974FEF1E98B9C1864370E2B5B786EB0EA39E /*Metadata offset 0x526735*/; // 0x4B6D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 67EEAD805D708D9AA4E14BF747E44CED801744F3 /*Metadata offset 0x526769*/; // 0x4BA1
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=120 6C71197D228427B2864C69B357FEF73D8C9D59DF /*Metadata offset 0x5267B1*/; // 0x4BE9
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 6CEE45445AFD150B047A5866FFA76AA651CDB7B7 /*Metadata offset 0x526829*/; // 0x4C61
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9 6D49C9D487D7AD3491ECE08732D68A593CC2038D /*Metadata offset 0x526839*/; // 0x4C71
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 6D797C11E1D4FB68B6570CF2A92B792433527065 /*Metadata offset 0x526842*/; // 0x4C7A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3132 6E5DC824F803F8565AF31B42199DAE39FE7F4EA9 /*Metadata offset 0x527042*/; // 0x547A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=76 6FC754859E4EC74E447048364B216D825C6F8FE7 /*Metadata offset 0x527C7E*/; // 0x60B6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 704939CD172085D1295FCE3F1D92431D685D7AA2 /*Metadata offset 0x527CCA*/; // 0x6102
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 7088AAE49F0627B72729078DE6E3182DDCF8ED99 /*Metadata offset 0x527CF2*/; // 0x612A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 7341C933A70EAE383CC50C4B945ADB8E08F06737 /*Metadata offset 0x527D0A*/; // 0x6142
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 736D39815215889F11249D9958F6ED12D37B9F57 /*Metadata offset 0x527D52*/; // 0x618A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096 7F42F2EDC974BE29B2746957416ED1AEFA605F47 /*Metadata offset 0x527D55*/; // 0x618D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 7FE820C9CF0F0B90445A71F1D262D22E4F0C4C68 /*Metadata offset 0x528D55*/; // 0x718D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=21252 811A927B7DADD378BE60BBDE794B9277AA9B50EC /*Metadata offset 0x528D7D*/; // 0x71B5
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 81917F1E21F3C22B9F916994547A614FB03E968E /*Metadata offset 0x52E081*/; // 0xC4B9
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 823566DA642D6EA356E15585921F2A4CA23D6760 /*Metadata offset 0x52E0A5*/; // 0xC4DD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 82C2A59850B2E85BCE1A45A479537A384DF6098D /*Metadata offset 0x52E0CD*/; // 0xC505
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 82C383F8E6E4D3D87AEBB986A5D0077E8AD157C4 /*Metadata offset 0x52E0D9*/; // 0xC511
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 86F4F563FA2C61798AE6238D789139739428463A /*Metadata offset 0x52E105*/; // 0xC53D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 871B9CF85DB352BAADF12BAE8F19857683E385AC /*Metadata offset 0x52E108*/; // 0xC540
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 89A040451C8CC5C8FB268BE44BDD74964C104155 /*Metadata offset 0x52E130*/; // 0xC568
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 8CAA092E783257106251246FF5C97F88D28517A6 /*Metadata offset 0x52E140*/; // 0xC578
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2100 8D231DD55FE1AD7631BBD0905A17D5EB616C2154 /*Metadata offset 0x52E168*/; // 0xC5A0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 8E10AC2F34545DFBBF3FCBC06055D797A8C99991 /*Metadata offset 0x52E99C*/; // 0xCDD4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 8F22C9ECE1331718CBD268A9BBFD2F5E451441E3 /*Metadata offset 0x52E9C4*/; // 0xCDFC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=640 90A0542282A011472F94E97CEAE59F8B3B1A3291 /*Metadata offset 0x52EAC4*/; // 0xCEFC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 93A63E90605400F34B49F0EB3361D23C89164BDA /*Metadata offset 0x52ED44*/; // 0xD17C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 94841DD2F330CCB1089BF413E4FA9B04505152E2 /*Metadata offset 0x52ED50*/; // 0xD188
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 95264589E48F94B7857CFF398FB72A537E13EEE2 /*Metadata offset 0x52ED98*/; // 0xD1D0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 95C48758CAE1715783472FB073AB158AB8A0AB2A /*Metadata offset 0x52EDA4*/; // 0xD1DC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 973417296623D8DC6961B09664E54039E44CA5D8 /*Metadata offset 0x52EDEC*/; // 0xD224
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 97FB30C84FF4A41CD4625B44B2940BFC8DB43003 /*Metadata offset 0x52EE34*/; // 0xD26C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096 99E2E88877D14C7DDC4E957A0ED7079CA0E9EB24 /*Metadata offset 0x52EE37*/; // 0xD26F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 9A9C3962CD4753376E3507C8CB5FD8FCC4B4EDB5 /*Metadata offset 0x52FE37*/; // 0xE26F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 9BB00D1FCCBAF03165447FC8028E7CA07CA9FE88 /*Metadata offset 0x52FE77*/; // 0xE2AF
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 A0074C15377C0C870B055927403EA9FA7A349D12 /*Metadata offset 0x52FE7A*/; // 0xE2B2
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=130 A1319B706116AB2C6D44483F60A7D0ACEA543396 /*Metadata offset 0x52FEA2*/; // 0xE2DA
	internal static readonly long A13AA52274D951A18029131A8DDECF76B569A15D = -44474084896931794; // 0xE360
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 A323DB0813C4D072957BA6FDA79D9776674CD06B /*Metadata offset 0x52FF2C*/; // 0xE368
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=212 A5444763673307F6828C748D4B9708CFC02B0959 /*Metadata offset 0x52FF2F*/; // 0xE36B
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 A6732F8E7FC23766AB329B492D6BF82E3B33233F /*Metadata offset 0x530003*/; // 0xE43F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=174 A705A106D95282BD15E13EEA6B0AF583FF786D83 /*Metadata offset 0x53004B*/; // 0xE487
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1018 A8A491E4CED49AE0027560476C10D933CE70C8DF /*Metadata offset 0x5300F9*/; // 0xE535
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 AC791C4F39504D1184B73478943D0636258DA7B1 /*Metadata offset 0x5304F3*/; // 0xE92F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 AFCD4E1211233E99373A3367B23105A3D624B1F2 /*Metadata offset 0x53053B*/; // 0xE977
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 B472ED77CB3B2A66D49D179F1EE2081B70A6AB61 /*Metadata offset 0x53056F*/; // 0xE9AB
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 B4FBD02AAB5B16E0F4BD858DA5D9E348F3CE501D /*Metadata offset 0x530597*/; // 0xE9D3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 B53A2C6DF21FC88B17AEFC40EB895B8D63210CDF /*Metadata offset 0x5305A7*/; // 0xE9E3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096 B6002BBF29B2704922EC3BBF0F9EE40ABF185D6B /*Metadata offset 0x5306A7*/; // 0xEAE3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=998 B881DA88BE0B68D8A6B6B6893822586B8B2CFC45 /*Metadata offset 0x5316A7*/; // 0xFAE3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=162 B8864ACB9DD69E3D42151513C840AAE270BF21C8 /*Metadata offset 0x531A8D*/; // 0xFEC9
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=360 B8F87834C3597B2EEF22BA6D3A392CC925636401 /*Metadata offset 0x531B2F*/; // 0xFF6B
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 B9B670F134A59FB1107AF01A9FE8F8E3980B3093 /*Metadata offset 0x531C97*/; // 0x100D3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 BE1BDEC0AA74B4DCB079943E70528096CCA985F8 /*Metadata offset 0x531CDF*/; // 0x1011B
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 BEBC9ECC660A13EFC359BA3383411F698CFF25DB /*Metadata offset 0x531CF3*/; // 0x1012F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 BEE1CFE5DFAA408E14CE4AF4DCD824FA2E42DCB7 /*Metadata offset 0x531D3B*/; // 0x10177
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 BF477463CE2F5EF38FC4C644BBBF4DF109E7670A /*Metadata offset 0x531D63*/; // 0x1019F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 BF5EB60806ECB74EE484105DD9D6F463BF994867 /*Metadata offset 0x531D66*/; // 0x101A2
	internal static readonly long C1A1100642BA9685B30A84D97348484E14AA1865 = 23362753784184900; // 0x101A8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 C6F364A0AD934EFED8909446C215752E565D77C1 /*Metadata offset 0x531D74*/; // 0x101B0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=174 CE5835130F5277F63D716FC9115526B0AC68FFAD /*Metadata offset 0x531D84*/; // 0x101C0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 CE93C35B755802BC4B3D180716B048FC61701EF7 /*Metadata offset 0x531E32*/; // 0x1026E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 CF0B42666EF5E37EDEA0AB8E173E42C196D03814 /*Metadata offset 0x531E38*/; // 0x10274
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 D002CBBE1FF33721AF7C4D1D3ECAD1B7DB5258B7 /*Metadata offset 0x531E78*/; // 0x102B4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 D117188BE8D4609C0D531C51B0BB911A4219DEBE /*Metadata offset 0x531F78*/; // 0x103B4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 D28E8ABDBD777A482CE0EE5C24814ACAE52AABFE /*Metadata offset 0x531F98*/; // 0x103D4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 D2C5BAE967587C6F3D9F2C4551911E0575A1101F /*Metadata offset 0x531FB8*/; // 0x103F4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=82 D76478B994B312CD022DCA207AA2254880D2FCC9 /*Metadata offset 0x5320B8*/; // 0x104F4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 D78D08081C7A5AD6FBA7A8DC86BCD6D7A577C636 /*Metadata offset 0x53210A*/; // 0x10546
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=76 DA19DB47B583EFCF7825D2E39D661D2354F28219 /*Metadata offset 0x532136*/; // 0x10572
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 DC2B830D8CD59AD6A4E4332D21CA0DCA2821AD82 /*Metadata offset 0x532182*/; // 0x105BE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 DD3AEFEADB1CD615F3017763F1568179FEE640B0 /*Metadata offset 0x5321BA*/; // 0x105F6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 E1827270A5FE1C85F5352A66FD87BA747213D006 /*Metadata offset 0x5321EE*/; // 0x1062A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 E45BAB43F7D5D038672B3E3431F92E34A7AF2571 /*Metadata offset 0x532212*/; // 0x1064E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 E75835D001C843F156FBA01B001DFE1B8029AC17 /*Metadata offset 0x53223A*/; // 0x10676
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 E92B39D8233061927D9ACDE54665E68E7535635A /*Metadata offset 0x53227A*/; // 0x106B6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 EA9506959484C55CFE0C139C624DF6060E285866 /*Metadata offset 0x5322AE*/; // 0x106EA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=262 EB5E9A80A40096AB74D2E226650C7258D7BC5E9D /*Metadata offset 0x5322BA*/; // 0x106F6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 EBF68F411848D603D059DFDEA2321C5A5EA78044 /*Metadata offset 0x5323C0*/; // 0x107FC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 EC5BB4F59D4B9B2E9ECD3904D44A8275F23AFB11 /*Metadata offset 0x532400*/; // 0x1083C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 EC83FB16C20052BEE2B4025159BC2ED45C9C70C3 /*Metadata offset 0x53240A*/; // 0x10846
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 EC89C317EA2BF49A70EFF5E89C691E34733D7C37 /*Metadata offset 0x53240D*/; // 0x10849
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 F06E829E62F3AFBC045D064E10A4F5DF7C969612 /*Metadata offset 0x532455*/; // 0x10891
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=11614 F073AA332018FDA0D572E99448FFF1D6422BD520 /*Metadata offset 0x53247D*/; // 0x108B9
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=120 F34B0E10653402E8F788F8BC3F7CD7090928A429 /*Metadata offset 0x5351DB*/; // 0x13617
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 F37E34BEADB04F34FCC31078A59F49856CA83D5B /*Metadata offset 0x535253*/; // 0x1368F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=94 F512A9ABF88066AAEB92684F95CC05D8101B462B /*Metadata offset 0x53529B*/; // 0x136D7
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 F8FAABB821300AA500C2CEC6091B3782A7FB44A4 /*Metadata offset 0x5352F9*/; // 0x13735
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2350 FCBD2781A933F0828ED4AAF88FD8B08D76DDD49B /*Metadata offset 0x535305*/; // 0x13741

	// Methods

	// RVA: 0xAAB240 Offset: 0xAA9840 VA: 0x180AAB240
	internal static uint ComputeStringHash(string s) { }

}

internal class __Il2CppComObject // TypeDefIndex: 1690
{	// Methods

	// RVA: 0x214CBF0 Offset: 0x214B1F0 VA: 0x18214CBF0 Slot: 1
	protected override void Finalize() { }

}

internal sealed class __Il2CppComDelegate : __Il2CppComObject // TypeDefIndex: 1691
{	// Methods

	// RVA: 0x214CBF0 Offset: 0x214B1F0 VA: 0x18214CBF0 Slot: 1
	protected override void Finalize() { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 1772
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 12D04472A8285260EA12FD3813CDFA9F2D2B548C /*Metadata offset 0x535F0B*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 13A35EF1A549297C70E2AD46045BBD2ECA17852D /*Metadata offset 0x535F0E*/; // 0x3
	internal static readonly long 16968835DEF6DD3BB86EABA9DEC53BF41851CD6D = -1295888024253181014; // 0x8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 1A84029C80CB5518379F199F53FF08A7B764F8FD /*Metadata offset 0x535F19*/; // 0x10
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 235D99572263B22ADFEE10FDA0C25E12F4D94FFC /*Metadata offset 0x535F1C*/; // 0x13
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=14 2D3CF0F15AC2DDEC2956EA1B7BBE43FB8B923130 /*Metadata offset 0x535F1F*/; // 0x16
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 320B018758ECE3752FFEDBAEB1A6DB67C80B9359 /*Metadata offset 0x535F2D*/; // 0x24
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 3E3442C7396F3F2BB4C7348F4A2074C7DC677D68 /*Metadata offset 0x535F6D*/; // 0x64
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 4E3B533C39447AAEB59A8E48FABD7E15B5B5D195 /*Metadata offset 0x535F70*/; // 0x67
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 56DFA5053B3131883637F53219E7D88CCEF35949 /*Metadata offset 0x535FA0*/; // 0x97
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9 6D49C9D487D7AD3491ECE08732D68A593CC2038D /*Metadata offset 0x535FAA*/; // 0xA1
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3132 6E5DC824F803F8565AF31B42199DAE39FE7F4EA9 /*Metadata offset 0x535FB3*/; // 0xAA
	internal static readonly long 6FA00AC9FFFD87F82A38A7F9ECC8134F4A7052AF = 22609615381091406; // 0xCE8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 736D39815215889F11249D9958F6ED12D37B9F57 /*Metadata offset 0x536BF7*/; // 0xCF0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 86F4F563FA2C61798AE6238D789139739428463A /*Metadata offset 0x536BFA*/; // 0xCF3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 97FB30C84FF4A41CD4625B44B2940BFC8DB43003 /*Metadata offset 0x536BFD*/; // 0xCF6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 9A9C3962CD4753376E3507C8CB5FD8FCC4B4EDB5 /*Metadata offset 0x536C00*/; // 0xCF9
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 9BB00D1FCCBAF03165447FC8028E7CA07CA9FE88 /*Metadata offset 0x536C40*/; // 0xD39
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 A323DB0813C4D072957BA6FDA79D9776674CD06B /*Metadata offset 0x536C43*/; // 0xD3C
	internal static readonly long AEA5F1CC5CFE1660539EDD691FE017F775F63A0D = 2676302836908902219; // 0xD40
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 BE1BDEC0AA74B4DCB079943E70528096CCA985F8 /*Metadata offset 0x536C4E*/; // 0xD48
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 BF477463CE2F5EF38FC4C644BBBF4DF109E7670A /*Metadata offset 0x536C62*/; // 0xD5C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 CF0B42666EF5E37EDEA0AB8E173E42C196D03814 /*Metadata offset 0x536C65*/; // 0xD5F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 D28E8ABDBD777A482CE0EE5C24814ACAE52AABFE /*Metadata offset 0x536CA5*/; // 0xD9F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 D2C5BAE967587C6F3D9F2C4551911E0575A1101F /*Metadata offset 0x536CC5*/; // 0xDBF
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 E75835D001C843F156FBA01B001DFE1B8029AC17 /*Metadata offset 0x536DC5*/; // 0xEBF
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 EC5BB4F59D4B9B2E9ECD3904D44A8275F23AFB11 /*Metadata offset 0x536E05*/; // 0xEFF
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 EC83FB16C20052BEE2B4025159BC2ED45C9C70C3 /*Metadata offset 0x536E0F*/; // 0xF09

	// Methods

	// RVA: 0xAAB240 Offset: 0xAA9840 VA: 0x180AAB240
	internal static uint ComputeStringHash(string s) { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 2431
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 0701435C4E2C38EFE43C51BD22C114AB8B80124D /*Metadata offset 0x537D79*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 0EE6555EB2C89F29655BD23FAB0573D8D684331A /*Metadata offset 0x537D85*/; // 0xC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=68 0F6A1E2CEA2FA691D57F3F3FDCF9B82A3FBF6EE1 /*Metadata offset 0x537DA9*/; // 0x30
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 161F91CE1721D8F16622810CBB39887D21C47031 /*Metadata offset 0x537DED*/; // 0x74
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 2051D7520B96DCC12F2E4DE851CB9F203D623805 /*Metadata offset 0x537DF9*/; // 0x80
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 221CE291CD044114B4369175B9B91177F5932876 /*Metadata offset 0x537E19*/; // 0xA0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=38 2A4F1BD548EC71F652E24985361CD72F0FE1BE7D /*Metadata offset 0x537E45*/; // 0xCC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 360487BE4278986419B568EFD887F6145383168A /*Metadata offset 0x537E6B*/; // 0xF2
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 42DDBEE388AB59C20A3D7D4D6555E78D74A45AE1 /*Metadata offset 0x537E93*/; // 0x11A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 485F43E332C2F7530815B17C08DAC169A8F697E0 /*Metadata offset 0x537EA7*/; // 0x12E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=112 49C5BA13401986EC93E4677F52CBE2248184DFBD /*Metadata offset 0x537EC7*/; // 0x14E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 51E4CA1C2B009A2876C6E57D8E69E3502BCA3440 /*Metadata offset 0x537F37*/; // 0x1BE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=960 553E235E202D57C9F1156E7D232E02BBDC920165 /*Metadata offset 0x537F4F*/; // 0x1D6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 574B9D4E4C39F6E8004181E5765B627B75EB1AD1 /*Metadata offset 0x53830F*/; // 0x596
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 5BE9DB9EEB9CBB4D22472CA9734B1FA1D36126BD /*Metadata offset 0x538347*/; // 0x5CE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 5D100A87B697F3AE2015A5D3B2A7B5419E1BCA98 /*Metadata offset 0x538353*/; // 0x5DA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=664 68D0F86889D5D656483EEE829BCEECDFEC91D8EA /*Metadata offset 0x538359*/; // 0x5E0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=416 6A0D50D692745A6663128CD315B71079584F3E59 /*Metadata offset 0x5385F1*/; // 0x878
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 702F6A3276CBE481D247A77C20B5459FB94D07D2 /*Metadata offset 0x538791*/; // 0xA18
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 7A32E1A19C182315E4263A65A72066492550D8CD /*Metadata offset 0x5387A9*/; // 0xA30
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 8B4E5E81A88D29642679AFCE41DCA380F9000462 /*Metadata offset 0x5387C9*/; // 0xA50
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=960 977375E4E1ED54F588076ACA36CC17E6C2195CB9 /*Metadata offset 0x5387D9*/; // 0xA60
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 99F0664C2AC8464B51252D92FC24F3834C6FB90C /*Metadata offset 0x538B99*/; // 0xE20
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 9E31F24F64765FCAA589F589324D17C9FCF6A06D /*Metadata offset 0x538BA5*/; // 0xE2C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 9E374D7263B2452E25DE3D6E617F6A728D98A439 /*Metadata offset 0x538BC1*/; // 0xE48
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=68 A933F173482FF50754B4942AF8DFC584EF14A45B /*Metadata offset 0x538C51*/; // 0xED8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 AB4EAD1DB94B8220FAAEDAA6A593B2E6DB0A8A9C /*Metadata offset 0x538C95*/; // 0xF1C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=416 B368804F0C6DAB083B253A6B106D0783D5C32E90 /*Metadata offset 0x538CAD*/; // 0xF34
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 B9F0004E3873FDDCABFDA6174EA18F0859B637B4 /*Metadata offset 0x538E4D*/; // 0x10D4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 BAD037B714E1CD1052149B51238A3D4351DD10B5 /*Metadata offset 0x538E75*/; // 0x10FC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 C2D6E36D84DDA5D661B95D7B32D3F47CD7ACBF6C /*Metadata offset 0x538E89*/; // 0x1110
	internal static readonly long DB9F879BE80CC2DA24DEF633D23DBB2B1ADBCC81 = 361700859878507267; // 0x1120
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 DCF398750721AA7A27A6BA56E99350329B06E8B1 /*Metadata offset 0x538EA1*/; // 0x1128
	internal static readonly long EBC658B067B5C785A3F0BB67D73755F6FEE7F70C = 3659217647501344; // 0x1138
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 ED18A4A1FF7C89B400D7CA156BA8D11BB09E1DE4 /*Metadata offset 0x538EB9*/; // 0x1140
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 EE3413A2C088FF9432054D6E60A7CB6A498D25F0 /*Metadata offset 0x538EDD*/; // 0x1164
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 F64F25EAE9A3D7A356813C4218000185541D7779 /*Metadata offset 0x538F1D*/; // 0x11A4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1212 FB0C58D8B3094F018764CC6E3094B9576DB08069 /*Metadata offset 0x538F41*/; // 0x11C8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 FFE3F15642234E7FAD6951D432F1134D5AD15922 /*Metadata offset 0x5393FD*/; // 0x1684

	// Methods

	// RVA: 0xAAB240 Offset: 0xAA9840 VA: 0x180AAB240
	internal static uint ComputeStringHash(string s) { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 3155
{
// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 3155
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=14 0283A6AF88802AB45989B29549915BEA0F6CD515 /*Metadata offset 0x53A5B7*/; // 0x0
	internal static readonly long 03F4297FCC30D0FD5E420E5D26E7FA711167C7EF = 2533317740920864; // 0x10
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9 1A39764B112685485A5BA7B2880D878B858C1A7A /*Metadata offset 0x53A5CD*/; // 0x18
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 1A84029C80CB5518379F199F53FF08A7B764F8FD /*Metadata offset 0x53A5D6*/; // 0x21
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 3BE77BF818331C2D8400FFFFF9FADD3F16AD89AC /*Metadata offset 0x53A5D9*/; // 0x24
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 53437C3B2572EDB9B8640C3195DF3BC2729C5EA1 /*Metadata offset 0x53A5E5*/; // 0x30
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 59F5BD34B6C013DEACC784F69C67E95150033A84 /*Metadata offset 0x53A5EF*/; // 0x3A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 5BC3486B05BA8CF4689C7BDB198B3F477BB4E20C /*Metadata offset 0x53A60F*/; // 0x5A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9 6D49C9D487D7AD3491ECE08732D68A593CC2038D /*Metadata offset 0x53A615*/; // 0x60
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 6F3AD3DC3AF8047587C4C9D696EB68A01FEF796E /*Metadata offset 0x53A61E*/; // 0x69
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 8821BF2BDFF225D177372C9F3E0A8286EE241FF4 /*Metadata offset 0x53A69E*/; // 0xE9
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 8E0EF3D67A3EB1863224EE3CACB424BC2F8CFBA3 /*Metadata offset 0x53A6A4*/; // 0xEF
	internal static readonly long 98A44A6F8606AE6F23FE230286C1D6FBCC407226 = 11540663026319392; // 0x120
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 C02C28AFEBE998F767E4AF43E3BE8F5E9FA11536 /*Metadata offset 0x53A6D8*/; // 0x128
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 CCEEADA43268372341F81AE0C9208C6856441C04 /*Metadata offset 0x53A6F8*/; // 0x148
	internal static readonly long E5BC1BAFADE1862DD6E0B9FB632BFAA6C3873A78 = 2533330625626144; // 0x1C8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 EC5842B3154E1AF94500B57220EB9F684BCCC42A /*Metadata offset 0x53A780*/; // 0x1D0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 EEAFE8C6E1AB017237567305EE925C976CDB6458 /*Metadata offset 0x53A7A0*/; // 0x1F0

	// Methods

	// RVA: 0xAAB240 Offset: 0xAA9840 VA: 0x180AAB240
	internal static uint ComputeStringHash(string s) { }

}

internal class EmptyEnumerable<TElement> // TypeDefIndex: 3221
{	// Fields
	public static readonly TElement[] Instance; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD62100 Offset: 0xD60700 VA: 0x180D62100
	|-EmptyEnumerable<byte>..cctor
	|-EmptyEnumerable<object>..cctor
	*/

}

internal class IdentityFunction<TElement> // TypeDefIndex: 3222
{	// Properties
	public static Func<TElement, TElement> Instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static Func<TElement, TElement> get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17642B0 Offset: 0x17628B0 VA: 0x1817642B0
	|-IdentityFunction<InventoryItem>.get_Instance
	|-IdentityFunction<object>.get_Instance
	|-IdentityFunction<Resolution>.get_Instance
	*/

}

internal class Set<TElement> // TypeDefIndex: 3230
{	// Fields
	private int[] buckets; // 0x0
	private Set.Slot<TElement>[] slots; // 0x0
	private int count; // 0x0
	private int freeList; // 0x0
	private IEqualityComparer<TElement> comparer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TElement> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176B300 Offset: 0x1769900 VA: 0x18176B300
	|-Set<ServerInfo>..ctor
	|
	|-RVA: 0x176B120 Offset: 0x1769720 VA: 0x18176B120
	|-Set<char>..ctor
	|
	|-RVA: 0x176B030 Offset: 0x1769630 VA: 0x18176B030
	|-Set<object>..ctor
	|
	|-RVA: 0x176AF40 Offset: 0x1769540 VA: 0x18176AF40
	|-Set<float>..ctor
	|
	|-RVA: 0x176B210 Offset: 0x1769810 VA: 0x18176B210
	|-Set<Vector2>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool Add(TElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17690E0 Offset: 0x17676E0 VA: 0x1817690E0
	|-Set<ServerInfo>.Add
	|
	|-RVA: 0x17690B0 Offset: 0x17676B0 VA: 0x1817690B0
	|-Set<char>.Add
	|-Set<object>.Add
	|
	|-RVA: 0x17691B0 Offset: 0x17677B0 VA: 0x1817691B0
	|-Set<float>.Add
	|
	|-RVA: 0x1769170 Offset: 0x1767770 VA: 0x181769170
	|-Set<Vector2>.Add
	*/

	// RVA: -1 Offset: -1
	private bool Find(TElement value, bool add) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17691E0 Offset: 0x17677E0 VA: 0x1817691E0
	|-Set<ServerInfo>.Find
	|
	|-RVA: 0x1769F10 Offset: 0x1768510 VA: 0x181769F10
	|-Set<char>.Find
	|
	|-RVA: 0x1769900 Offset: 0x1767F00 VA: 0x181769900
	|-Set<object>.Find
	|
	|-RVA: 0x1769610 Offset: 0x1767C10 VA: 0x181769610
	|-Set<float>.Find
	|
	|-RVA: 0x1769BF0 Offset: 0x17681F0 VA: 0x181769BF0
	|-Set<Vector2>.Find
	*/

	// RVA: -1 Offset: -1
	private void Resize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176A9D0 Offset: 0x1768FD0 VA: 0x18176A9D0
	|-Set<ServerInfo>.Resize
	|
	|-RVA: 0x176ABA0 Offset: 0x17691A0 VA: 0x18176ABA0
	|-Set<char>.Resize
	|
	|-RVA: 0x176AD70 Offset: 0x1769370 VA: 0x18176AD70
	|-Set<object>.Resize
	|
	|-RVA: 0x176A800 Offset: 0x1768E00 VA: 0x18176A800
	|-Set<float>.Resize
	|
	|-RVA: 0x176A630 Offset: 0x1768C30 VA: 0x18176A630
	|-Set<Vector2>.Resize
	*/

	// RVA: -1 Offset: -1
	internal int InternalGetHashCode(TElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176A500 Offset: 0x1768B00 VA: 0x18176A500
	|-Set<ServerInfo>.InternalGetHashCode
	|
	|-RVA: 0x176A210 Offset: 0x1768810 VA: 0x18176A210
	|-Set<char>.InternalGetHashCode
	|
	|-RVA: 0x176A2E0 Offset: 0x17688E0 VA: 0x18176A2E0
	|-Set<object>.InternalGetHashCode
	|
	|-RVA: 0x176A430 Offset: 0x1768A30 VA: 0x18176A430
	|-Set<float>.InternalGetHashCode
	|
	|-RVA: 0x176A360 Offset: 0x1768960 VA: 0x18176A360
	|-Set<Vector2>.InternalGetHashCode
	*/

}

internal class GroupedEnumerable<TSource, TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>, IEnumerable // TypeDefIndex: 3232
{	// Fields
	private IEnumerable<TSource> source; // 0x0
	private Func<TSource, TKey> keySelector; // 0x0
	private Func<TSource, TElement> elementSelector; // 0x0
	private IEqualityComparer<TKey> comparer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1760E70 Offset: 0x175F470 VA: 0x181760E70
	|-GroupedEnumerable<InventoryItem, InventoryDefId, InventoryItem>..ctor
	|
	|-RVA: 0x1760F80 Offset: 0x175F580 VA: 0x181760F80
	|-GroupedEnumerable<object, InventoryDefId, object>..ctor
	|
	|-RVA: 0x1761090 Offset: 0x175F690 VA: 0x181761090
	|-GroupedEnumerable<object, Int32Enum, object>..ctor
	|
	|-RVA: 0x17612B0 Offset: 0x175F8B0 VA: 0x1817612B0
	|-GroupedEnumerable<object, object, object>..ctor
	|
	|-RVA: 0x17611A0 Offset: 0x175F7A0 VA: 0x1817611A0
	|-GroupedEnumerable<object, uint, object>..ctor
	|
	|-RVA: 0x17613C0 Offset: 0x175F9C0 VA: 0x1817613C0
	|-GroupedEnumerable<Resolution, Vector2Int, Resolution>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1760DE0 Offset: 0x175F3E0 VA: 0x181760DE0
	|-GroupedEnumerable<InventoryItem, InventoryDefId, InventoryItem>.GetEnumerator
	|-GroupedEnumerable<object, InventoryDefId, object>.GetEnumerator
	|-GroupedEnumerable<object, Int32Enum, object>.GetEnumerator
	|-GroupedEnumerable<object, object, object>.GetEnumerator
	|-GroupedEnumerable<object, uint, object>.GetEnumerator
	|-GroupedEnumerable<Resolution, Vector2Int, Resolution>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1760E40 Offset: 0x175F440 VA: 0x181760E40
	|-GroupedEnumerable<InventoryItem, InventoryDefId, InventoryItem>.System.Collections.IEnumerable.GetEnumerator
	|-GroupedEnumerable<object, InventoryDefId, object>.System.Collections.IEnumerable.GetEnumerator
	|-GroupedEnumerable<object, Int32Enum, object>.System.Collections.IEnumerable.GetEnumerator
	|-GroupedEnumerable<object, object, object>.System.Collections.IEnumerable.GetEnumerator
	|-GroupedEnumerable<object, uint, object>.System.Collections.IEnumerable.GetEnumerator
	|-GroupedEnumerable<Resolution, Vector2Int, Resolution>.System.Collections.IEnumerable.GetEnumerator
	*/

}

internal abstract class OrderedEnumerable<TElement> : IOrderedEnumerable<TElement>, IEnumerable<TElement>, IEnumerable // TypeDefIndex: 3233
{	// Fields
	internal IEnumerable<TElement> source; // 0x0

	// Methods

	[IteratorStateMachineAttribute] // RVA: 0xD1A60 Offset: 0xD0E60 VA: 0x1800D1A60
	// RVA: -1 Offset: -1 Slot: 5
	public IEnumerator<TElement> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1767510 Offset: 0x1765B10 VA: 0x181767510
	|-OrderedEnumerable<Demos.DemoInfo>.GetEnumerator
	|
	|-RVA: 0x1767480 Offset: 0x1765A80 VA: 0x181767480
	|-OrderedEnumerable<ServerInfo>.GetEnumerator
	|
	|-RVA: 0x17672D0 Offset: 0x17658D0 VA: 0x1817672D0
	|-OrderedEnumerable<Item>.GetEnumerator
	|
	|-RVA: 0x1767360 Offset: 0x1765960 VA: 0x181767360
	|-OrderedEnumerable<KeyValuePair<object, int>>.GetEnumerator
	|-OrderedEnumerable<KeyValuePair<object, long>>.GetEnumerator
	|-OrderedEnumerable<KeyValuePair<object, object>>.GetEnumerator
	|
	|-RVA: 0x17673F0 Offset: 0x17659F0 VA: 0x1817673F0
	|-OrderedEnumerable<double>.GetEnumerator
	|-OrderedEnumerable<object>.GetEnumerator
	|-OrderedEnumerable<Resolution>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-OrderedEnumerable<object>.GetEnumerableSorter
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1355EA0 Offset: 0x13544A0 VA: 0x181355EA0
	|-OrderedEnumerable<Demos.DemoInfo>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<ServerInfo>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<Item>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<KeyValuePair<object, int>>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<KeyValuePair<object, long>>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<KeyValuePair<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<double>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<object>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<Resolution>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IOrderedEnumerable<TElement> System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED6F00 Offset: 0xED5500 VA: 0x180ED6F00
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<DateTime>
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<int>
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<Int32Enum>
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<object>
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<uint>
	|-OrderedEnumerable<Resolution>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<int>
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5AD60 Offset: 0xD59360 VA: 0x180D5AD60
	|-OrderedEnumerable<Demos.DemoInfo>..ctor
	|-OrderedEnumerable<ServerInfo>..ctor
	|-OrderedEnumerable<Item>..ctor
	|-OrderedEnumerable<KeyValuePair<object, int>>..ctor
	|-OrderedEnumerable<KeyValuePair<object, long>>..ctor
	|-OrderedEnumerable<KeyValuePair<object, object>>..ctor
	|-OrderedEnumerable<double>..ctor
	|-OrderedEnumerable<object>..ctor
	|-OrderedEnumerable<Resolution>..ctor
	*/

}

internal class OrderedEnumerable<TElement, TKey> : OrderedEnumerable<TElement> // TypeDefIndex: 3235
{	// Fields
	internal OrderedEnumerable<TElement> parent; // 0x0
	internal Func<TElement, TKey> keySelector; // 0x0
	internal IComparer<TKey> comparer; // 0x0
	internal bool descending; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(IEnumerable<TElement> source, Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1767F30 Offset: 0x1766530 VA: 0x181767F30
	|-OrderedEnumerable<Demos.DemoInfo, DateTime>..ctor
	|
	|-RVA: 0x1768E30 Offset: 0x1767430 VA: 0x181768E30
	|-OrderedEnumerable<Demos.DemoInfo, object>..ctor
	|
	|-RVA: 0x17686B0 Offset: 0x1766CB0 VA: 0x1817686B0
	|-OrderedEnumerable<Demos.DemoInfo, TimeSpan>..ctor
	|
	|-RVA: 0x17687F0 Offset: 0x1766DF0 VA: 0x1817687F0
	|-OrderedEnumerable<ServerInfo, int>..ctor
	|
	|-RVA: 0x1767DF0 Offset: 0x17663F0 VA: 0x181767DF0
	|-OrderedEnumerable<ServerInfo, object>..ctor
	|
	|-RVA: 0x1768070 Offset: 0x1766670 VA: 0x181768070
	|-OrderedEnumerable<ServerInfo, uint>..ctor
	|
	|-RVA: 0x1767B70 Offset: 0x1766170 VA: 0x181767B70
	|-OrderedEnumerable<Item, DateTime>..ctor
	|
	|-RVA: 0x1768570 Offset: 0x1766B70 VA: 0x181768570
	|-OrderedEnumerable<KeyValuePair<object, int>, int>..ctor
	|
	|-RVA: 0x1768A70 Offset: 0x1767070 VA: 0x181768A70
	|-OrderedEnumerable<KeyValuePair<object, long>, long>..ctor
	|
	|-RVA: 0x1767CB0 Offset: 0x17662B0 VA: 0x181767CB0
	|-OrderedEnumerable<KeyValuePair<object, object>, long>..ctor
	|
	|-RVA: 0x17677B0 Offset: 0x1765DB0 VA: 0x1817677B0
	|-OrderedEnumerable<double, double>..ctor
	|
	|-RVA: 0x1768BB0 Offset: 0x17671B0 VA: 0x181768BB0
	|-OrderedEnumerable<object, bool>..ctor
	|
	|-RVA: 0x1768430 Offset: 0x1766A30 VA: 0x181768430
	|-OrderedEnumerable<object, DateTime>..ctor
	|
	|-RVA: 0x1767670 Offset: 0x1765C70 VA: 0x181767670
	|-OrderedEnumerable<object, DateTimeOffset>..ctor
	|
	|-RVA: 0x17681B0 Offset: 0x17667B0 VA: 0x1817681B0
	|-OrderedEnumerable<object, Guid>..ctor
	|
	|-RVA: 0x1767A30 Offset: 0x1766030 VA: 0x181767A30
	|-OrderedEnumerable<object, int>..ctor
	|
	|-RVA: 0x17682F0 Offset: 0x17668F0 VA: 0x1817682F0
	|-OrderedEnumerable<object, Int32Enum>..ctor
	|
	|-RVA: 0x1768930 Offset: 0x1766F30 VA: 0x181768930
	|-OrderedEnumerable<object, object>..ctor
	|
	|-RVA: 0x17678F0 Offset: 0x1765EF0 VA: 0x1817678F0
	|-OrderedEnumerable<object, float>..ctor
	|
	|-RVA: 0x1768CF0 Offset: 0x17672F0 VA: 0x181768CF0
	|-OrderedEnumerable<object, uint>..ctor
	|
	|-RVA: 0x1768F70 Offset: 0x1767570 VA: 0x181768F70
	|-OrderedEnumerable<Resolution, int>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17675A0 Offset: 0x1765BA0 VA: 0x1817675A0
	|-OrderedEnumerable<Demos.DemoInfo, DateTime>.GetEnumerableSorter
	|-OrderedEnumerable<Demos.DemoInfo, object>.GetEnumerableSorter
	|-OrderedEnumerable<Demos.DemoInfo, TimeSpan>.GetEnumerableSorter
	|-OrderedEnumerable<ServerInfo, int>.GetEnumerableSorter
	|-OrderedEnumerable<ServerInfo, object>.GetEnumerableSorter
	|-OrderedEnumerable<ServerInfo, uint>.GetEnumerableSorter
	|-OrderedEnumerable<Item, DateTime>.GetEnumerableSorter
	|-OrderedEnumerable<KeyValuePair<object, int>, int>.GetEnumerableSorter
	|-OrderedEnumerable<KeyValuePair<object, long>, long>.GetEnumerableSorter
	|-OrderedEnumerable<KeyValuePair<object, object>, long>.GetEnumerableSorter
	|-OrderedEnumerable<double, double>.GetEnumerableSorter
	|-OrderedEnumerable<object, bool>.GetEnumerableSorter
	|-OrderedEnumerable<object, DateTime>.GetEnumerableSorter
	|-OrderedEnumerable<object, DateTimeOffset>.GetEnumerableSorter
	|-OrderedEnumerable<object, Guid>.GetEnumerableSorter
	|-OrderedEnumerable<object, int>.GetEnumerableSorter
	|-OrderedEnumerable<object, Int32Enum>.GetEnumerableSorter
	|-OrderedEnumerable<object, object>.GetEnumerableSorter
	|-OrderedEnumerable<object, float>.GetEnumerableSorter
	|-OrderedEnumerable<object, uint>.GetEnumerableSorter
	|-OrderedEnumerable<Resolution, int>.GetEnumerableSorter
	*/

}

internal struct Buffer<TElement> // TypeDefIndex: 3238
{	// Fields
	internal TElement[] items; // 0x0
	internal int count; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(IEnumerable<TElement> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2253A0 Offset: 0x2247A0 VA: 0x1802253A0
	|-Buffer<Debugging.EntityInfo>..ctor
	|
	|-RVA: 0x2253D0 Offset: 0x2247D0 VA: 0x1802253D0
	|-Buffer<Demos.DemoInfo>..ctor
	|
	|-RVA: 0x225470 Offset: 0x224870 VA: 0x180225470
	|-Buffer<GameStat.Stat>..ctor
	|
	|-RVA: 0x225330 Offset: 0x224730 VA: 0x180225330
	|-Buffer<ItemSkinDirectory.Skin>..ctor
	|
	|-RVA: 0x225350 Offset: 0x224750 VA: 0x180225350
	|-Buffer<FourBitNumber>..ctor
	|
	|-RVA: 0x225390 Offset: 0x224790 VA: 0x180225390
	|-Buffer<SevenBitNumber>..ctor
	|
	|-RVA: 0x225460 Offset: 0x224860 VA: 0x180225460
	|-Buffer<Option>..ctor
	|
	|-RVA: 0x225430 Offset: 0x224830 VA: 0x180225430
	|-Buffer<ServerInfo>..ctor
	|
	|-RVA: 0x225360 Offset: 0x224760 VA: 0x180225360
	|-Buffer<SkinnedMultiMesh.Part>..ctor
	|
	|-RVA: 0x225410 Offset: 0x224810 VA: 0x180225410
	|-Buffer<InventoryDefId>..ctor
	|
	|-RVA: 0x225480 Offset: 0x224880 VA: 0x180225480
	|-Buffer<InventoryItemId>..ctor
	|
	|-RVA: 0x225340 Offset: 0x224740 VA: 0x180225340
	|-Buffer<InventoryItem>..ctor
	|
	|-RVA: 0x225440 Offset: 0x224840 VA: 0x180225440
	|-Buffer<InventoryRecipe.Ingredient>..ctor
	|
	|-RVA: 0x2253F0 Offset: 0x2247F0 VA: 0x1802253F0
	|-Buffer<InventoryRecipe>..ctor
	|
	|-RVA: 0x225380 Offset: 0x224780 VA: 0x180225380
	|-Buffer<Item>..ctor
	|
	|-RVA: 0x2253E0 Offset: 0x2247E0 VA: 0x1802253E0
	|-Buffer<byte>..ctor
	|
	|-RVA: 0x225450 Offset: 0x224850 VA: 0x180225450
	|-Buffer<char>..ctor
	|
	|-RVA: 0x2253B0 Offset: 0x2247B0 VA: 0x1802253B0
	|-Buffer<KeyValuePair<object, int>>..ctor
	|
	|-RVA: 0x225400 Offset: 0x224800 VA: 0x180225400
	|-Buffer<KeyValuePair<object, long>>..ctor
	|
	|-RVA: 0x2253C0 Offset: 0x2247C0 VA: 0x1802253C0
	|-Buffer<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x225490 Offset: 0x224890 VA: 0x180225490
	|-Buffer<double>..ctor
	|
	|-RVA: 0x225300 Offset: 0x224700 VA: 0x180225300
	|-Buffer<int>..ctor
	|
	|-RVA: 0x225370 Offset: 0x224770 VA: 0x180225370
	|-Buffer<Int32Enum>..ctor
	|
	|-RVA: 0x225420 Offset: 0x224820 VA: 0x180225420
	|-Buffer<long>..ctor
	|
	|-RVA: 0x2254A0 Offset: 0x2248A0 VA: 0x1802254A0
	|-Buffer<object>..ctor
	|
	|-RVA: 0x225310 Offset: 0x224710 VA: 0x180225310
	|-Buffer<uint>..ctor
	|
	|-RVA: 0x225320 Offset: 0x224720 VA: 0x180225320
	|-Buffer<Resolution>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TElement[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x225200 Offset: 0x224600 VA: 0x180225200
	|-Buffer<Debugging.EntityInfo>.ToArray
	|-Buffer<Demos.DemoInfo>.ToArray
	|-Buffer<GameStat.Stat>.ToArray
	|-Buffer<ItemSkinDirectory.Skin>.ToArray
	|-Buffer<FourBitNumber>.ToArray
	|-Buffer<SevenBitNumber>.ToArray
	|-Buffer<Option>.ToArray
	|-Buffer<ServerInfo>.ToArray
	|-Buffer<SkinnedMultiMesh.Part>.ToArray
	|-Buffer<InventoryDefId>.ToArray
	|-Buffer<InventoryItemId>.ToArray
	|-Buffer<InventoryItem>.ToArray
	|-Buffer<InventoryRecipe.Ingredient>.ToArray
	|-Buffer<InventoryRecipe>.ToArray
	|-Buffer<Item>.ToArray
	|-Buffer<byte>.ToArray
	|-Buffer<char>.ToArray
	|-Buffer<KeyValuePair<object, int>>.ToArray
	|-Buffer<KeyValuePair<object, long>>.ToArray
	|-Buffer<KeyValuePair<object, object>>.ToArray
	|-Buffer<double>.ToArray
	|-Buffer<int>.ToArray
	|-Buffer<Int32Enum>.ToArray
	|-Buffer<long>.ToArray
	|-Buffer<object>.ToArray
	|-Buffer<uint>.ToArray
	|-Buffer<Resolution>.ToArray
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 3258
{
// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 3258
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=120 0AA802CD6847EB893FE786B5EA5168B2FDCD7B93 /*Metadata offset 0x53AA37*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 0C4110BC17D746F018F47B49E0EB0D6590F69939 /*Metadata offset 0x53AAAF*/; // 0x78
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 20733E1283D873EBE47133A95C233E11B76F5F11 /*Metadata offset 0x53ABAF*/; // 0x178
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 21F4CBF8283FF1CAEB4A39316A97FC1D6DF1D35E /*Metadata offset 0x53AFAF*/; // 0x578
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 23DFDCA6F045D4257BF5AC8CB1CF2EFADAFE9B94 /*Metadata offset 0x53B3AF*/; // 0x978
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 30A0358B25B1372DD598BB4B1AC56AD6B8F08A47 /*Metadata offset 0x53B7AF*/; // 0xD78
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 5B5DF5A459E902D96F7DB0FB235A25346CA85C5D /*Metadata offset 0x53BBAF*/; // 0x1178
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 5BE411F1438EAEF33726D855E99011D5FECDDD4E /*Metadata offset 0x53BFAF*/; // 0x1578
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 8F22C9ECE1331718CBD268A9BBFD2F5E451441E3 /*Metadata offset 0x53C3AF*/; // 0x1978
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 A02DD1D8604EA8EC2D2BDA717A93A4EE85F13E53 /*Metadata offset 0x53C4AF*/; // 0x1A78
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 AE2F76ECEF8B08F0BC7EA95DCFE945E1727927C9 /*Metadata offset 0x53C8AF*/; // 0x1E78

}

public struct BatchQueryJob<CommandT, ResultT> // TypeDefIndex: 3307
{	// Fields
	[ReadOnlyAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal NativeArray<CommandT> commands; // 0x0
	internal NativeArray<ResultT> results; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(NativeArray<CommandT> commands, NativeArray<ResultT> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FA0B0 Offset: 0x1F94B0 VA: 0x1801FA0B0
	|-BatchQueryJob<RaycastCommand, RaycastHit>..ctor
	*/

}

internal class InvokableCall<T1> : BaseInvokableCall // TypeDefIndex: 3629
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private UnityAction<T1> Delegate; // 0x0

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	protected void add_Delegate(UnityAction<T1> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ACD70 Offset: 0x17AB370 VA: 0x1817ACD70
	|-InvokableCall<Option>.add_Delegate
	|-InvokableCall<bool>.add_Delegate
	|-InvokableCall<int>.add_Delegate
	|-InvokableCall<Int32Enum>.add_Delegate
	|-InvokableCall<object>.add_Delegate
	|-InvokableCall<float>.add_Delegate
	|-InvokableCall<Color>.add_Delegate
	|-InvokableCall<Vector2>.add_Delegate
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	protected void remove_Delegate(UnityAction<T1> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ACE30 Offset: 0x17AB430 VA: 0x1817ACE30
	|-InvokableCall<Option>.remove_Delegate
	|-InvokableCall<bool>.remove_Delegate
	|-InvokableCall<int>.remove_Delegate
	|-InvokableCall<Int32Enum>.remove_Delegate
	|-InvokableCall<object>.remove_Delegate
	|-InvokableCall<float>.remove_Delegate
	|-InvokableCall<Color>.remove_Delegate
	|-InvokableCall<Vector2>.remove_Delegate
	*/

	// RVA: -1 Offset: -1
	public void .ctor(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AC5F0 Offset: 0x17AABF0 VA: 0x1817AC5F0
	|-InvokableCall<Option>..ctor
	|
	|-RVA: 0x17ACC40 Offset: 0x17AB240 VA: 0x1817ACC40
	|-InvokableCall<bool>..ctor
	|
	|-RVA: 0x17AC720 Offset: 0x17AAD20 VA: 0x1817AC720
	|-InvokableCall<int>..ctor
	|
	|-RVA: 0x17AC9E0 Offset: 0x17AAFE0 VA: 0x1817AC9E0
	|-InvokableCall<Int32Enum>..ctor
	|
	|-RVA: 0x17AC8B0 Offset: 0x17AAEB0 VA: 0x1817AC8B0
	|-InvokableCall<object>..ctor
	|
	|-RVA: 0x17ACB10 Offset: 0x17AB110 VA: 0x1817ACB10
	|-InvokableCall<float>..ctor
	|
	|-RVA: 0x19BD9F0 Offset: 0x19BBFF0 VA: 0x1819BD9F0
	|-InvokableCall<Color>..ctor
	|
	|-RVA: 0x19BD8C0 Offset: 0x19BBEC0 VA: 0x1819BD8C0
	|-InvokableCall<Vector2>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UnityAction<T1> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AC850 Offset: 0x17AAE50 VA: 0x1817AC850
	|-InvokableCall<Option>..ctor
	|-InvokableCall<bool>..ctor
	|-InvokableCall<int>..ctor
	|-InvokableCall<Int32Enum>..ctor
	|-InvokableCall<object>..ctor
	|-InvokableCall<float>..ctor
	|-InvokableCall<Color>..ctor
	|-InvokableCall<Vector2>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Invoke(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AC000 Offset: 0x17AA600 VA: 0x1817AC000
	|-InvokableCall<Option>.Invoke
	|
	|-RVA: 0x17AC370 Offset: 0x17AA970 VA: 0x1817AC370
	|-InvokableCall<bool>.Invoke
	|
	|-RVA: 0x17ABE00 Offset: 0x17AA400 VA: 0x1817ABE00
	|-InvokableCall<int>.Invoke
	|
	|-RVA: 0x17AC1D0 Offset: 0x17AA7D0 VA: 0x1817AC1D0
	|-InvokableCall<Int32Enum>.Invoke
	|
	|-RVA: 0x17AC4B0 Offset: 0x17AAAB0 VA: 0x1817AC4B0
	|-InvokableCall<object>.Invoke
	|
	|-RVA: 0x17ABC60 Offset: 0x17AA260 VA: 0x1817ABC60
	|-InvokableCall<float>.Invoke
	|
	|-RVA: 0x19BD540 Offset: 0x19BBB40 VA: 0x1819BD540
	|-InvokableCall<Color>.Invoke
	|
	|-RVA: 0x19BD690 Offset: 0x19BBC90 VA: 0x1819BD690
	|-InvokableCall<Vector2>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public virtual void Invoke(T1 args0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AC160 Offset: 0x17AA760 VA: 0x1817AC160
	|-InvokableCall<Option>.Invoke
	|
	|-RVA: 0x17ABF40 Offset: 0x17AA540 VA: 0x1817ABF40
	|-InvokableCall<bool>.Invoke
	|
	|-RVA: 0x17ABFA0 Offset: 0x17AA5A0 VA: 0x1817ABFA0
	|-InvokableCall<int>.Invoke
	|-InvokableCall<Int32Enum>.Invoke
	|
	|-RVA: 0x17AC310 Offset: 0x17AA910 VA: 0x1817AC310
	|-InvokableCall<object>.Invoke
	|
	|-RVA: 0x17ABDA0 Offset: 0x17AA3A0 VA: 0x1817ABDA0
	|-InvokableCall<float>.Invoke
	|
	|-RVA: 0x19BD7E0 Offset: 0x19BBDE0 VA: 0x1819BD7E0
	|-InvokableCall<Color>.Invoke
	|
	|-RVA: 0x19BD850 Offset: 0x19BBE50 VA: 0x1819BD850
	|-InvokableCall<Vector2>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override bool Find(object targetObj, MethodInfo method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ABC00 Offset: 0x17AA200 VA: 0x1817ABC00
	|-InvokableCall<Option>.Find
	|-InvokableCall<bool>.Find
	|-InvokableCall<int>.Find
	|-InvokableCall<Int32Enum>.Find
	|-InvokableCall<object>.Find
	|-InvokableCall<float>.Find
	|-InvokableCall<Color>.Find
	|-InvokableCall<Vector2>.Find
	*/

}

public sealed class UnityAction<T0> : MulticastDelegate // TypeDefIndex: 3641
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-UnityAction<Option>..ctor
	|-UnityAction<bool>..ctor
	|-UnityAction<List<IEventSystemHandler>>..ctor
	|-UnityAction<int>..ctor
	|-UnityAction<Int32Enum>..ctor
	|-UnityAction<object>..ctor
	|-UnityAction<float>..ctor
	|-UnityAction<string>..ctor
	|-UnityAction<Color>..ctor
	|-UnityAction<Component>..ctor
	|-UnityAction<MessageEventArgs>..ctor
	|-UnityAction<Scene>..ctor
	|-UnityAction<LayoutRebuilder>..ctor
	|-UnityAction<Vector2>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C8870 Offset: 0x19C6E70 VA: 0x1819C8870
	|-UnityAction<Option>.Invoke
	|
	|-RVA: 0x19C8310 Offset: 0x19C6910 VA: 0x1819C8310
	|-UnityAction<bool>.Invoke
	|
	|-RVA: 0x19C8120 Offset: 0x19C6720 VA: 0x1819C8120
	|-UnityAction<int>.Invoke
	|-UnityAction<Int32Enum>.Invoke
	|
	|-RVA: 0x19C7E00 Offset: 0x19C6400 VA: 0x1819C7E00
	|-UnityAction<object>.Invoke
	|-UnityAction<Component>.Invoke
	|
	|-RVA: 0x19C7840 Offset: 0x19C5E40 VA: 0x1819C7840
	|-UnityAction<float>.Invoke
	|
	|-RVA: 0x12A5590 Offset: 0x12A3B90 VA: 0x1812A5590
	|-UnityAction<Color>.Invoke
	|
	|-RVA: 0x19C7B20 Offset: 0x19C6120 VA: 0x1819C7B20
	|-UnityAction<Scene>.Invoke
	|
	|-RVA: 0x19C8590 Offset: 0x19C6B90 VA: 0x1819C8590
	|-UnityAction<Vector2>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(T0 arg0, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C74C0 Offset: 0x19C5AC0 VA: 0x1819C74C0
	|-UnityAction<Option>.BeginInvoke
	|
	|-RVA: 0x19C75C0 Offset: 0x19C5BC0 VA: 0x1819C75C0
	|-UnityAction<bool>.BeginInvoke
	|
	|-RVA: 0x19C7540 Offset: 0x19C5B40 VA: 0x1819C7540
	|-UnityAction<int>.BeginInvoke
	|
	|-RVA: 0x19C7440 Offset: 0x19C5A40 VA: 0x1819C7440
	|-UnityAction<Int32Enum>.BeginInvoke
	|
	|-RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380
	|-UnityAction<object>.BeginInvoke
	|
	|-RVA: 0x19C7740 Offset: 0x19C5D40 VA: 0x1819C7740
	|-UnityAction<float>.BeginInvoke
	|
	|-RVA: 0x19C77C0 Offset: 0x19C5DC0 VA: 0x1819C77C0
	|-UnityAction<Color>.BeginInvoke
	|
	|-RVA: 0x19C7640 Offset: 0x19C5C40 VA: 0x1819C7640
	|-UnityAction<Scene>.BeginInvoke
	|
	|-RVA: 0x19C76C0 Offset: 0x19C5CC0 VA: 0x1819C76C0
	|-UnityAction<Vector2>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0
	|-UnityAction<Option>.EndInvoke
	|-UnityAction<bool>.EndInvoke
	|-UnityAction<int>.EndInvoke
	|-UnityAction<Int32Enum>.EndInvoke
	|-UnityAction<object>.EndInvoke
	|-UnityAction<float>.EndInvoke
	|-UnityAction<Color>.EndInvoke
	|-UnityAction<Scene>.EndInvoke
	|-UnityAction<Vector2>.EndInvoke
	*/

}

public abstract class UnityEvent<T0> : UnityEventBase // TypeDefIndex: 3642
{	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CBD10 Offset: 0x19CA310 VA: 0x1819CBD10
	|-UnityEvent<Brush>..ctor
	|-UnityEvent<Option>..ctor
	|-UnityEvent<bool>..ctor
	|-UnityEvent<int>..ctor
	|-UnityEvent<Int32Enum>..ctor
	|-UnityEvent<object>..ctor
	|-UnityEvent<float>..ctor
	|-UnityEvent<string>..ctor
	|-UnityEvent<Color>..ctor
	|-UnityEvent<BaseEventData>..ctor
	|-UnityEvent<MessageEventArgs>..ctor
	|-UnityEvent<TouchScreenKeyboard.Status>..ctor
	|-UnityEvent<Vector2>..ctor
	*/

	// RVA: -1 Offset: -1
	public void AddListener(UnityAction<T0> call) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C9EA0 Offset: 0x19C84A0 VA: 0x1819C9EA0
	|-UnityEvent<Option>.AddListener
	|-UnityEvent<bool>.AddListener
	|-UnityEvent<int>.AddListener
	|-UnityEvent<Int32Enum>.AddListener
	|-UnityEvent<object>.AddListener
	|-UnityEvent<float>.AddListener
	|-UnityEvent<string>.AddListener
	|-UnityEvent<Color>.AddListener
	|-UnityEvent<MessageEventArgs>.AddListener
	|-UnityEvent<Vector2>.AddListener
	*/

	// RVA: -1 Offset: -1
	public void RemoveListener(UnityAction<T0> call) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CBCC0 Offset: 0x19CA2C0 VA: 0x1819CBCC0
	|-UnityEvent<Option>.RemoveListener
	|-UnityEvent<bool>.RemoveListener
	|-UnityEvent<int>.RemoveListener
	|-UnityEvent<Int32Enum>.RemoveListener
	|-UnityEvent<object>.RemoveListener
	|-UnityEvent<float>.RemoveListener
	|-UnityEvent<Color>.RemoveListener
	|-UnityEvent<MessageEventArgs>.RemoveListener
	|-UnityEvent<Vector2>.RemoveListener
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, object targetObj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CA540 Offset: 0x19C8B40 VA: 0x1819CA540
	|-UnityEvent<Brush>.FindMethod_Impl
	|-UnityEvent<object>.FindMethod_Impl
	|-UnityEvent<string>.FindMethod_Impl
	|-UnityEvent<BaseEventData>.FindMethod_Impl
	|-UnityEvent<MessageEventArgs>.FindMethod_Impl
	|
	|-RVA: 0x19C9EE0 Offset: 0x19C84E0 VA: 0x1819C9EE0
	|-UnityEvent<Option>.FindMethod_Impl
	|
	|-RVA: 0x19CA210 Offset: 0x19C8810 VA: 0x1819CA210
	|-UnityEvent<bool>.FindMethod_Impl
	|
	|-RVA: 0x19CA100 Offset: 0x19C8700 VA: 0x1819CA100
	|-UnityEvent<int>.FindMethod_Impl
	|
	|-RVA: 0x19CA430 Offset: 0x19C8A30 VA: 0x1819CA430
	|-UnityEvent<Int32Enum>.FindMethod_Impl
	|-UnityEvent<TouchScreenKeyboard.Status>.FindMethod_Impl
	|
	|-RVA: 0x19C9FF0 Offset: 0x19C85F0 VA: 0x1819C9FF0
	|-UnityEvent<float>.FindMethod_Impl
	|
	|-RVA: 0x19CA320 Offset: 0x19C8920 VA: 0x1819CA320
	|-UnityEvent<Color>.FindMethod_Impl
	|
	|-RVA: 0x19CA650 Offset: 0x19C8C50 VA: 0x1819CA650
	|-UnityEvent<Vector2>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CA760 Offset: 0x19C8D60 VA: 0x1819CA760
	|-UnityEvent<Brush>.GetDelegate
	|-UnityEvent<Option>.GetDelegate
	|-UnityEvent<bool>.GetDelegate
	|-UnityEvent<int>.GetDelegate
	|-UnityEvent<Int32Enum>.GetDelegate
	|-UnityEvent<object>.GetDelegate
	|-UnityEvent<float>.GetDelegate
	|-UnityEvent<string>.GetDelegate
	|-UnityEvent<Color>.GetDelegate
	|-UnityEvent<BaseEventData>.GetDelegate
	|-UnityEvent<MessageEventArgs>.GetDelegate
	|-UnityEvent<TouchScreenKeyboard.Status>.GetDelegate
	|-UnityEvent<Vector2>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	private static BaseInvokableCall GetDelegate(UnityAction<T0> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CA7E0 Offset: 0x19C8DE0 VA: 0x1819CA7E0
	|-UnityEvent<Option>.GetDelegate
	|-UnityEvent<bool>.GetDelegate
	|-UnityEvent<int>.GetDelegate
	|-UnityEvent<Int32Enum>.GetDelegate
	|-UnityEvent<object>.GetDelegate
	|-UnityEvent<float>.GetDelegate
	|-UnityEvent<Color>.GetDelegate
	|-UnityEvent<Vector2>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CA8B0 Offset: 0x19C8EB0 VA: 0x1819CA8B0
	|-UnityEvent<Brush>.Invoke
	|-UnityEvent<object>.Invoke
	|-UnityEvent<string>.Invoke
	|-UnityEvent<BaseEventData>.Invoke
	|-UnityEvent<MessageEventArgs>.Invoke
	|
	|-RVA: 0x19CB280 Offset: 0x19C9880 VA: 0x1819CB280
	|-UnityEvent<Option>.Invoke
	|
	|-RVA: 0x19CB540 Offset: 0x19C9B40 VA: 0x1819CB540
	|-UnityEvent<bool>.Invoke
	|
	|-RVA: 0x19CB7C0 Offset: 0x19C9DC0 VA: 0x1819CB7C0
	|-UnityEvent<int>.Invoke
	|
	|-RVA: 0x19CAAE0 Offset: 0x19C90E0 VA: 0x1819CAAE0
	|-UnityEvent<Int32Enum>.Invoke
	|-UnityEvent<TouchScreenKeyboard.Status>.Invoke
	|
	|-RVA: 0x19CB000 Offset: 0x19C9600 VA: 0x1819CB000
	|-UnityEvent<float>.Invoke
	|
	|-RVA: 0x19CAD60 Offset: 0x19C9360 VA: 0x1819CAD60
	|-UnityEvent<Color>.Invoke
	|
	|-RVA: 0x19CBA40 Offset: 0x19CA040 VA: 0x1819CBA40
	|-UnityEvent<Vector2>.Invoke
	*/

}

public sealed class UnityAction<T0, T1> : MulticastDelegate // TypeDefIndex: 3643
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-UnityAction<object, object>..ctor
	|-UnityAction<ulong, object>..ctor
	|-UnityAction<Scene, Int32Enum>..ctor
	|-UnityAction<Scene, LoadSceneMode>..ctor
	|-UnityAction<Scene, Scene>..ctor
	|-UnityAction<Vector2, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1111140 Offset: 0x110F740 VA: 0x181111140
	|-UnityAction<object, object>.Invoke
	|
	|-RVA: 0x19C8E50 Offset: 0x19C7450 VA: 0x1819C8E50
	|-UnityAction<ulong, object>.Invoke
	|
	|-RVA: 0x19C9790 Offset: 0x19C7D90 VA: 0x1819C9790
	|-UnityAction<Scene, Int32Enum>.Invoke
	|-UnityAction<Scene, LoadSceneMode>.Invoke
	|
	|-RVA: 0x19C9180 Offset: 0x19C7780 VA: 0x1819C9180
	|-UnityAction<Scene, Scene>.Invoke
	|
	|-RVA: 0x19C9490 Offset: 0x19C7A90 VA: 0x1819C9490
	|-UnityAction<Vector2, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(T0 arg0, T1 arg1, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAE4580 Offset: 0xAE2B80 VA: 0x180AE4580
	|-UnityAction<object, object>.BeginInvoke
	|
	|-RVA: 0x19C8D30 Offset: 0x19C7330 VA: 0x1819C8D30
	|-UnityAction<ulong, object>.BeginInvoke
	|
	|-RVA: 0x19C8CA0 Offset: 0x19C72A0 VA: 0x1819C8CA0
	|-UnityAction<Scene, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x19C8DC0 Offset: 0x19C73C0 VA: 0x1819C8DC0
	|-UnityAction<Scene, Scene>.BeginInvoke
	|
	|-RVA: 0x19C8C10 Offset: 0x19C7210 VA: 0x1819C8C10
	|-UnityAction<Vector2, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0
	|-UnityAction<object, object>.EndInvoke
	|-UnityAction<ulong, object>.EndInvoke
	|-UnityAction<Scene, Int32Enum>.EndInvoke
	|-UnityAction<Scene, Scene>.EndInvoke
	|-UnityAction<Vector2, object>.EndInvoke
	*/

}

public abstract class UnityEvent<T0, T1> : UnityEventBase // TypeDefIndex: 3644
{	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CBD10 Offset: 0x19CA310 VA: 0x1819CBD10
	|-UnityEvent<object, object>..ctor
	|-UnityEvent<ulong, object>..ctor
	|-UnityEvent<ulong, string>..ctor
	|-UnityEvent<Vector2, Brush>..ctor
	|-UnityEvent<Vector2, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, object targetObj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CBD40 Offset: 0x19CA340 VA: 0x1819CBD40
	|-UnityEvent<object, object>.FindMethod_Impl
	|
	|-RVA: 0x19CC060 Offset: 0x19CA660 VA: 0x1819CC060
	|-UnityEvent<ulong, object>.FindMethod_Impl
	|-UnityEvent<ulong, string>.FindMethod_Impl
	|
	|-RVA: 0x19CBED0 Offset: 0x19CA4D0 VA: 0x1819CBED0
	|-UnityEvent<Vector2, Brush>.FindMethod_Impl
	|-UnityEvent<Vector2, object>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CC1F0 Offset: 0x19CA7F0 VA: 0x1819CC1F0
	|-UnityEvent<object, object>.GetDelegate
	|-UnityEvent<ulong, object>.GetDelegate
	|-UnityEvent<ulong, string>.GetDelegate
	|-UnityEvent<Vector2, Brush>.GetDelegate
	|-UnityEvent<Vector2, object>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CC870 Offset: 0x19CAE70 VA: 0x1819CC870
	|-UnityEvent<object, object>.Invoke
	|
	|-RVA: 0x19CC270 Offset: 0x19CA870 VA: 0x1819CC270
	|-UnityEvent<ulong, object>.Invoke
	|-UnityEvent<ulong, string>.Invoke
	|
	|-RVA: 0x19CC570 Offset: 0x19CAB70 VA: 0x1819CC570
	|-UnityEvent<Vector2, Brush>.Invoke
	|-UnityEvent<Vector2, object>.Invoke
	*/

}

public sealed class UnityAction<T0, T1, T2> : MulticastDelegate // TypeDefIndex: 3645
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-UnityAction<object, int, int>..ctor
	|-UnityAction<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1349BF0 Offset: 0x13481F0 VA: 0x181349BF0
	|-UnityAction<object, int, int>.Invoke
	|
	|-RVA: 0x19C9B40 Offset: 0x19C8140 VA: 0x1819C9B40
	|-UnityAction<object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(T0 arg0, T1 arg1, T2 arg2, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C9AA0 Offset: 0x19C80A0 VA: 0x1819C9AA0
	|-UnityAction<object, int, int>.BeginInvoke
	|
	|-RVA: 0x130F9A0 Offset: 0x130DFA0 VA: 0x18130F9A0
	|-UnityAction<object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0
	|-UnityAction<object, int, int>.EndInvoke
	|-UnityAction<object, object, object>.EndInvoke
	*/

}

public abstract class UnityEvent<T0, T1, T2> : UnityEventBase // TypeDefIndex: 3646
{	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CBD10 Offset: 0x19CA310 VA: 0x1819CBD10
	|-UnityEvent<object, int, int>..ctor
	|-UnityEvent<object, object, object>..ctor
	|-UnityEvent<string, int, int>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, object targetObj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CCB10 Offset: 0x19CB110 VA: 0x1819CCB10
	|-UnityEvent<object, int, int>.FindMethod_Impl
	|-UnityEvent<string, int, int>.FindMethod_Impl
	|
	|-RVA: 0x19CCD10 Offset: 0x19CB310 VA: 0x1819CCD10
	|-UnityEvent<object, object, object>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CA760 Offset: 0x19C8D60 VA: 0x1819CA760
	|-UnityEvent<object, int, int>.GetDelegate
	|-UnityEvent<object, object, object>.GetDelegate
	|-UnityEvent<string, int, int>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CD230 Offset: 0x19CB830 VA: 0x1819CD230
	|-UnityEvent<object, int, int>.Invoke
	|-UnityEvent<string, int, int>.Invoke
	|
	|-RVA: 0x19CCF10 Offset: 0x19CB510 VA: 0x1819CCF10
	|-UnityEvent<object, object, object>.Invoke
	*/

}

public sealed class UnityAction<T0, T1, T2, T3> : MulticastDelegate // TypeDefIndex: 3647
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-UnityAction<object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1311570 Offset: 0x130FB70 VA: 0x181311570
	|-UnityAction<object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFF9340 Offset: 0xFF7940 VA: 0x180FF9340
	|-UnityAction<object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0
	|-UnityAction<object, object, object, object>.EndInvoke
	*/

}

public abstract class UnityEvent<T0, T1, T2, T3> : UnityEventBase // TypeDefIndex: 3648
{	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CBD10 Offset: 0x19CA310 VA: 0x1819CBD10
	|-UnityEvent<object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, object targetObj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CD5E0 Offset: 0x19CBBE0 VA: 0x1819CD5E0
	|-UnityEvent<object, object, object, object>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CD850 Offset: 0x19CBE50 VA: 0x1819CD850
	|-UnityEvent<object, object, object, object>.GetDelegate
	*/

}

public class IntegratedSubsystemDescriptor<TSubsystem> : IntegratedSubsystemDescriptor // TypeDefIndex: 3941
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD50CE0 Offset: 0xD4F2E0 VA: 0x180D50CE0
	|-IntegratedSubsystemDescriptor<object>..ctor
	|-IntegratedSubsystemDescriptor<XRDisplaySubsystem>..ctor
	|-IntegratedSubsystemDescriptor<XRInputSubsystem>..ctor
	|-IntegratedSubsystemDescriptor<XRMeshSubsystem>..ctor
	*/

}

public class IntegratedSubsystem<TSubsystemDescriptor> : IntegratedSubsystem // TypeDefIndex: 3947
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD50CE0 Offset: 0xD4F2E0 VA: 0x180D50CE0
	|-IntegratedSubsystem<object>..ctor
	|-IntegratedSubsystem<XRDisplaySubsystemDescriptor>..ctor
	|-IntegratedSubsystem<XRInputSubsystemDescriptor>..ctor
	|-IntegratedSubsystem<XRMeshSubsystemDescriptor>..ctor
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 4066
{	// Methods

	// RVA: 0xAAB240 Offset: 0xAA9840 VA: 0x180AAB240
	internal static uint ComputeStringHash(string s) { }

}

internal abstract class RBTree<K> : IEnumerable // TypeDefIndex: 4286
{	// Fields
	private RBTree.TreePage<K>[] _pageTable; // 0x0
	private int[] _pageTableMap; // 0x0
	private int _inUsePageCount; // 0x0
	private int _nextFreePageLine; // 0x0
	public int root; // 0x0
	private int _version; // 0x0
	private int _inUseNodeCount; // 0x0
	private int _inUseSatelliteTreeCount; // 0x0
	private readonly TreeAccessMethod _accessMethod; // 0x0

	// Properties
	public int Count { get; }
	public bool HasDuplicates { get; }
	public K Item { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract int CompareNode(K record1, K record2);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RBTree<object>.CompareNode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract int CompareSateliteTreeNode(K record1, K record2);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RBTree<object>.CompareSateliteTreeNode
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(TreeAccessMethod accessMethod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178C5C0 Offset: 0x178ABC0 VA: 0x18178C5C0
	|-RBTree<DataRow>..ctor
	|-RBTree<int>..ctor
	|-RBTree<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void InitTree() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17886F0 Offset: 0x1786CF0 VA: 0x1817886F0
	|-RBTree<int>.InitTree
	|
	|-RVA: 0x20C96F0 Offset: 0x20C7CF0 VA: 0x1820C96F0
	|-RBTree<object>.InitTree
	*/

	// RVA: -1 Offset: -1
	private void FreePage(RBTree.TreePage<K> page) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17879E0 Offset: 0x1785FE0 VA: 0x1817879E0
	|-RBTree<int>.FreePage
	|-RBTree<object>.FreePage
	*/

	// RVA: -1 Offset: -1
	private RBTree.TreePage<K> AllocPage(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1786A60 Offset: 0x1785060 VA: 0x181786A60
	|-RBTree<int>.AllocPage
	|
	|-RVA: 0x20C8330 Offset: 0x20C6930 VA: 0x1820C8330
	|-RBTree<object>.AllocPage
	*/

	// RVA: -1 Offset: -1
	private void MarkPageFull(RBTree.TreePage<K> page) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1789020 Offset: 0x1787620 VA: 0x181789020
	|-RBTree<int>.MarkPageFull
	|-RBTree<object>.MarkPageFull
	*/

	// RVA: -1 Offset: -1
	private void MarkPageFree(RBTree.TreePage<K> page) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1788F60 Offset: 0x1787560 VA: 0x181788F60
	|-RBTree<int>.MarkPageFree
	|-RBTree<object>.MarkPageFree
	*/

	// RVA: -1 Offset: -1
	private static int GetIntValueFromBitMap(uint bitMap) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1787FD0 Offset: 0x17865D0 VA: 0x181787FD0
	|-RBTree<int>.GetIntValueFromBitMap
	|-RBTree<object>.GetIntValueFromBitMap
	*/

	// RVA: -1 Offset: -1
	private void FreeNode(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1787840 Offset: 0x1785E40 VA: 0x181787840
	|-RBTree<int>.FreeNode
	|
	|-RVA: 0x20C8B20 Offset: 0x20C7120 VA: 0x1820C8B20
	|-RBTree<object>.FreeNode
	*/

	// RVA: -1 Offset: -1
	private int GetIndexOfPageWithFreeSlot(bool allocatedPage) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1787DD0 Offset: 0x17863D0 VA: 0x181787DD0
	|-RBTree<int>.GetIndexOfPageWithFreeSlot
	|
	|-RVA: 0x20C8E90 Offset: 0x20C7490 VA: 0x1820C8E90
	|-RBTree<object>.GetIndexOfPageWithFreeSlot
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178C690 Offset: 0x178AC90 VA: 0x18178C690
	|-RBTree<DataRow>.get_Count
	|-RBTree<int>.get_Count
	|-RBTree<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public bool get_HasDuplicates() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178C6A0 Offset: 0x178ACA0 VA: 0x18178C6A0
	|-RBTree<int>.get_HasDuplicates
	|-RBTree<object>.get_HasDuplicates
	*/

	// RVA: -1 Offset: -1
	private int GetNewNode(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1788040 Offset: 0x1786640 VA: 0x181788040
	|-RBTree<int>.GetNewNode
	|
	|-RVA: 0x20C9090 Offset: 0x20C7690 VA: 0x1820C9090
	|-RBTree<object>.GetNewNode
	*/

	// RVA: -1 Offset: -1
	private int Successor(int x_id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178C3F0 Offset: 0x178A9F0 VA: 0x18178C3F0
	|-RBTree<int>.Successor
	|-RBTree<object>.Successor
	*/

	// RVA: -1 Offset: -1
	private bool Successor(ref int nodeId, ref int mainTreeNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178C290 Offset: 0x178A890 VA: 0x18178C290
	|-RBTree<int>.Successor
	|
	|-RVA: 0x20CD000 Offset: 0x20CB600 VA: 0x1820CD000
	|-RBTree<object>.Successor
	*/

	// RVA: -1 Offset: -1
	private int Minimum(int x_id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17890E0 Offset: 0x17876E0 VA: 0x1817890E0
	|-RBTree<int>.Minimum
	|-RBTree<object>.Minimum
	*/

	// RVA: -1 Offset: -1
	private int LeftRotate(int root_id, int x_id, int mainTreeNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1788A20 Offset: 0x1787020 VA: 0x181788A20
	|-RBTree<int>.LeftRotate
	|
	|-RVA: 0x20C99F0 Offset: 0x20C7FF0 VA: 0x1820C99F0
	|-RBTree<object>.LeftRotate
	*/

	// RVA: -1 Offset: -1
	private int RightRotate(int root_id, int x_id, int mainTreeNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178B8D0 Offset: 0x1789ED0 VA: 0x18178B8D0
	|-RBTree<int>.RightRotate
	|
	|-RVA: 0x20CC630 Offset: 0x20CAC30 VA: 0x1820CC630
	|-RBTree<object>.RightRotate
	*/

	// RVA: -1 Offset: -1
	private int RBInsert(int root_id, int x_id, int mainTreeNodeID, int position, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178A7D0 Offset: 0x1788DD0 VA: 0x18178A7D0
	|-RBTree<int>.RBInsert
	|
	|-RVA: 0x20CB560 Offset: 0x20C9B60 VA: 0x1820CB560
	|-RBTree<object>.RBInsert
	*/

	// RVA: -1 Offset: -1
	public void UpdateNodeKey(K currentKey, K newKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178C4F0 Offset: 0x178AAF0 VA: 0x18178C4F0
	|-RBTree<int>.UpdateNodeKey
	|
	|-RVA: 0x20CD160 Offset: 0x20CB760 VA: 0x1820CD160
	|-RBTree<object>.UpdateNodeKey
	*/

	// RVA: -1 Offset: -1
	public K DeleteByIndex(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1787790 Offset: 0x1785D90 VA: 0x181787790
	|-RBTree<int>.DeleteByIndex
	|
	|-RVA: 0x20C8A70 Offset: 0x20C7070 VA: 0x1820C8A70
	|-RBTree<object>.DeleteByIndex
	*/

	// RVA: -1 Offset: -1
	public int RBDelete(int z_id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178A790 Offset: 0x1788D90 VA: 0x18178A790
	|-RBTree<DataRow>.RBDelete
	|-RBTree<int>.RBDelete
	|-RBTree<object>.RBDelete
	*/

	// RVA: -1 Offset: -1
	private int RBDeleteX(int root_id, int z_id, int mainTreeNodeID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1789B10 Offset: 0x1788110 VA: 0x181789B10
	|-RBTree<int>.RBDeleteX
	|
	|-RVA: 0x20CA8E0 Offset: 0x20C8EE0 VA: 0x1820CA8E0
	|-RBTree<object>.RBDeleteX
	*/

	// RVA: -1 Offset: -1
	private int RBDeleteFixup(int root_id, int x_id, int px_id, int mainTreeNodeID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1789240 Offset: 0x1787840 VA: 0x181789240
	|-RBTree<int>.RBDeleteFixup
	|
	|-RVA: 0x20CA010 Offset: 0x20C8610 VA: 0x1820CA010
	|-RBTree<object>.RBDeleteFixup
	*/

	// RVA: -1 Offset: -1
	private int SearchSubTree(int root_id, K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178BE00 Offset: 0x178A400 VA: 0x18178BE00
	|-RBTree<int>.SearchSubTree
	|
	|-RVA: 0x20CCB60 Offset: 0x20CB160 VA: 0x1820CCB60
	|-RBTree<object>.SearchSubTree
	*/

	// RVA: -1 Offset: -1
	public K get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178C6B0 Offset: 0x178ACB0 VA: 0x18178C6B0
	|-RBTree<DataRow>.get_Item
	|-RBTree<int>.get_Item
	|-RBTree<object>.get_Item
	*/

	// RVA: -1 Offset: -1
	private RBTree.NodePath<K> GetNodeByKey(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17883C0 Offset: 0x17869C0 VA: 0x1817883C0
	|-RBTree<int>.GetNodeByKey
	|
	|-RVA: 0x20C9440 Offset: 0x20C7A40 VA: 0x1820C9440
	|-RBTree<object>.GetNodeByKey
	*/

	// RVA: -1 Offset: -1
	public int GetIndexByKey(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1787B40 Offset: 0x1786140 VA: 0x181787B40
	|-RBTree<int>.GetIndexByKey
	|-RBTree<object>.GetIndexByKey
	*/

	// RVA: -1 Offset: -1
	public int GetIndexByNode(int node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1787C80 Offset: 0x1786280 VA: 0x181787C80
	|-RBTree<int>.GetIndexByNode
	|
	|-RVA: 0x20C8D40 Offset: 0x20C7340 VA: 0x1820C8D40
	|-RBTree<object>.GetIndexByNode
	*/

	// RVA: -1 Offset: -1
	private int GetIndexByNodePath(RBTree.NodePath<K> path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1787BC0 Offset: 0x17861C0 VA: 0x181787BC0
	|-RBTree<int>.GetIndexByNodePath
	|-RBTree<object>.GetIndexByNodePath
	*/

	// RVA: -1 Offset: -1
	private int ComputeIndexByNode(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1786E00 Offset: 0x1785400 VA: 0x181786E00
	|-RBTree<int>.ComputeIndexByNode
	|-RBTree<object>.ComputeIndexByNode
	*/

	// RVA: -1 Offset: -1
	private int ComputeIndexWithSatelliteByNode(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1786F20 Offset: 0x1785520 VA: 0x181786F20
	|-RBTree<int>.ComputeIndexWithSatelliteByNode
	|-RBTree<object>.ComputeIndexWithSatelliteByNode
	*/

	// RVA: -1 Offset: -1
	private RBTree.NodePath<K> GetNodeByIndex(int userIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17882E0 Offset: 0x17868E0 VA: 0x1817882E0
	|-RBTree<int>.GetNodeByIndex
	|
	|-RVA: 0x20C9340 Offset: 0x20C7940 VA: 0x1820C9340
	|-RBTree<object>.GetNodeByIndex
	*/

	// RVA: -1 Offset: -1
	private int ComputeNodeByIndex(int index, out int satelliteRootId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17870A0 Offset: 0x17856A0 VA: 0x1817870A0
	|-RBTree<int>.ComputeNodeByIndex
	|-RBTree<object>.ComputeNodeByIndex
	*/

	// RVA: -1 Offset: -1
	private int ComputeNodeByIndex(int x_id, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17872C0 Offset: 0x17858C0 VA: 0x1817872C0
	|-RBTree<int>.ComputeNodeByIndex
	|-RBTree<object>.ComputeNodeByIndex
	*/

	// RVA: -1 Offset: -1
	public int Insert(K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17869E0 Offset: 0x1784FE0 VA: 0x1817869E0
	|-RBTree<int>.Insert
	|-RBTree<object>.Insert
	*/

	// RVA: -1 Offset: -1
	public int Add(K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17869E0 Offset: 0x1784FE0 VA: 0x1817869E0
	|-RBTree<DataRow>.Add
	|-RBTree<int>.Add
	|-RBTree<object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20C8CC0 Offset: 0x20C72C0 VA: 0x1820C8CC0
	|-RBTree<DataRow>.GetEnumerator
	|-RBTree<object>.GetEnumerator
	|
	|-RVA: 0x1787A90 Offset: 0x1786090 VA: 0x181787A90
	|-RBTree<int>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(int nodeId, K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20C95F0 Offset: 0x20C7BF0 VA: 0x1820C95F0
	|-RBTree<DataRow>.IndexOf
	|-RBTree<object>.IndexOf
	|
	|-RVA: 0x1788560 Offset: 0x1786B60 VA: 0x181788560
	|-RBTree<int>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public int Insert(int position, K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1788980 Offset: 0x1786F80 VA: 0x181788980
	|-RBTree<DataRow>.Insert
	|-RBTree<int>.Insert
	|-RBTree<object>.Insert
	*/

	// RVA: -1 Offset: -1
	public int InsertAt(int position, K item, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17888E0 Offset: 0x1786EE0 VA: 0x1817888E0
	|-RBTree<int>.InsertAt
	|
	|-RVA: 0x20C98E0 Offset: 0x20C7EE0 VA: 0x1820C98E0
	|-RBTree<object>.InsertAt
	*/

	// RVA: -1 Offset: -1
	public void RemoveAt(int position) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178B8A0 Offset: 0x1789EA0 VA: 0x18178B8A0
	|-RBTree<DataRow>.RemoveAt
	|-RBTree<int>.RemoveAt
	|-RBTree<object>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1786DD0 Offset: 0x17853D0 VA: 0x181786DD0
	|-RBTree<DataRow>.Clear
	|-RBTree<int>.Clear
	|-RBTree<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20C86A0 Offset: 0x20C6CA0 VA: 0x1820C86A0
	|-RBTree<DataRow>.CopyTo
	|-RBTree<object>.CopyTo
	|
	|-RVA: 0x1787530 Offset: 0x1785B30 VA: 0x181787530
	|-RBTree<int>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(K[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20C8840 Offset: 0x20C6E40 VA: 0x1820C8840
	|-RBTree<DataRow>.CopyTo
	|-RBTree<object>.CopyTo
	|
	|-RVA: 0x1787380 Offset: 0x1785980 VA: 0x181787380
	|-RBTree<int>.CopyTo
	*/

	// RVA: -1 Offset: -1
	private void SetRight(int nodeId, int rightNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178C140 Offset: 0x178A740 VA: 0x18178C140
	|-RBTree<int>.SetRight
	|
	|-RVA: 0x20CCEB0 Offset: 0x20CB4B0 VA: 0x1820CCEB0
	|-RBTree<object>.SetRight
	*/

	// RVA: -1 Offset: -1
	private void SetLeft(int nodeId, int leftNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178BFF0 Offset: 0x178A5F0 VA: 0x18178BFF0
	|-RBTree<int>.SetLeft
	|
	|-RVA: 0x20CCD60 Offset: 0x20CB360 VA: 0x1820CCD60
	|-RBTree<object>.SetLeft
	*/

	// RVA: -1 Offset: -1
	private void SetParent(int nodeId, int parentNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178C0D0 Offset: 0x178A6D0 VA: 0x18178C0D0
	|-RBTree<int>.SetParent
	|
	|-RVA: 0x20CCE40 Offset: 0x20CB440 VA: 0x1820CCE40
	|-RBTree<object>.SetParent
	*/

	// RVA: -1 Offset: -1
	private void SetColor(int nodeId, RBTree.NodeColor<K> color) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178BF10 Offset: 0x178A510 VA: 0x18178BF10
	|-RBTree<int>.SetColor
	|
	|-RVA: 0x20CCC70 Offset: 0x20CB270 VA: 0x1820CCC70
	|-RBTree<object>.SetColor
	*/

	// RVA: -1 Offset: -1
	private void SetKey(int nodeId, K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178BF80 Offset: 0x178A580 VA: 0x18178BF80
	|-RBTree<int>.SetKey
	|
	|-RVA: 0x20CCCE0 Offset: 0x20CB2E0 VA: 0x1820CCCE0
	|-RBTree<object>.SetKey
	*/

	// RVA: -1 Offset: -1
	private void SetNext(int nodeId, int nextNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178C060 Offset: 0x178A660 VA: 0x18178C060
	|-RBTree<int>.SetNext
	|
	|-RVA: 0x20CCDD0 Offset: 0x20CB3D0 VA: 0x1820CCDD0
	|-RBTree<object>.SetNext
	*/

	// RVA: -1 Offset: -1
	private void SetSubTreeSize(int nodeId, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178C1B0 Offset: 0x178A7B0 VA: 0x18178C1B0
	|-RBTree<int>.SetSubTreeSize
	|
	|-RVA: 0x20CCF20 Offset: 0x20CB520 VA: 0x1820CCF20
	|-RBTree<object>.SetSubTreeSize
	*/

	// RVA: -1 Offset: -1
	private void IncreaseSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17884F0 Offset: 0x1786AF0 VA: 0x1817884F0
	|-RBTree<int>.IncreaseSize
	|
	|-RVA: 0x20C9580 Offset: 0x20C7B80 VA: 0x1820C9580
	|-RBTree<object>.IncreaseSize
	*/

	// RVA: -1 Offset: -1
	private void RecomputeSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178B710 Offset: 0x1789D10 VA: 0x18178B710
	|-RBTree<int>.RecomputeSize
	|
	|-RVA: 0x20CC4A0 Offset: 0x20CAAA0 VA: 0x1820CC4A0
	|-RBTree<object>.RecomputeSize
	*/

	// RVA: -1 Offset: -1
	private void DecreaseSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1787720 Offset: 0x1785D20 VA: 0x181787720
	|-RBTree<int>.DecreaseSize
	|
	|-RVA: 0x20C8A00 Offset: 0x20C7000 VA: 0x1820C8A00
	|-RBTree<object>.DecreaseSize
	*/

	// RVA: -1 Offset: -1
	public int Right(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178BD90 Offset: 0x178A390 VA: 0x18178BD90
	|-RBTree<int>.Right
	|
	|-RVA: 0x20CCAF0 Offset: 0x20CB0F0 VA: 0x1820CCAF0
	|-RBTree<object>.Right
	*/

	// RVA: -1 Offset: -1
	public int Left(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1788EF0 Offset: 0x17874F0 VA: 0x181788EF0
	|-RBTree<int>.Left
	|
	|-RVA: 0x20C9EC0 Offset: 0x20C84C0 VA: 0x1820C9EC0
	|-RBTree<object>.Left
	*/

	// RVA: -1 Offset: -1
	public int Parent(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17891D0 Offset: 0x17877D0 VA: 0x1817891D0
	|-RBTree<int>.Parent
	|
	|-RVA: 0x20C9FA0 Offset: 0x20C85A0 VA: 0x1820C9FA0
	|-RBTree<object>.Parent
	*/

	// RVA: -1 Offset: -1
	private RBTree.NodeColor<K> color(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178C620 Offset: 0x178AC20 VA: 0x18178C620
	|-RBTree<int>.color
	|
	|-RVA: 0x20CD230 Offset: 0x20CB830 VA: 0x1820CD230
	|-RBTree<object>.color
	*/

	// RVA: -1 Offset: -1
	public int Next(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1789160 Offset: 0x1787760 VA: 0x181789160
	|-RBTree<int>.Next
	|
	|-RVA: 0x20C9F30 Offset: 0x20C8530 VA: 0x1820C9F30
	|-RBTree<object>.Next
	*/

	// RVA: -1 Offset: -1
	public int SubTreeSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178C220 Offset: 0x178A820 VA: 0x18178C220
	|-RBTree<int>.SubTreeSize
	|
	|-RVA: 0x20CCF90 Offset: 0x20CB590 VA: 0x1820CCF90
	|-RBTree<object>.SubTreeSize
	*/

	// RVA: -1 Offset: -1
	public K Key(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17889B0 Offset: 0x1786FB0 VA: 0x1817889B0
	|-RBTree<int>.Key
	|
	|-RVA: 0x20C9980 Offset: 0x20C7F80 VA: 0x1820C9980
	|-RBTree<object>.Key
	*/

}

internal sealed class Listeners<TElem> // TypeDefIndex: 4304
{	// Fields
	private readonly List<TElem> _listeners; // 0x0
	private readonly Listeners.Func<TElem, TElem, bool> _filter; // 0x0
	private readonly int _objectID; // 0x0
	private int _listenerReaderCount; // 0x0

	// Properties
	internal bool HasListeners { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int ObjectID, Listeners.Func<TElem, TElem, bool> notifyFilter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1786620 Offset: 0x1784C20 VA: 0x181786620
	|-Listeners<DataViewListener>..ctor
	|-Listeners<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool get_HasListeners() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17866F0 Offset: 0x1784CF0 VA: 0x1817866F0
	|-Listeners<DataViewListener>.get_HasListeners
	|-Listeners<object>.get_HasListeners
	*/

	// RVA: -1 Offset: -1
	internal void Add(TElem listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE045B0 Offset: 0xE02BB0 VA: 0x180E045B0
	|-Listeners<DataViewListener>.Add
	|-Listeners<object>.Add
	*/

	// RVA: -1 Offset: -1
	internal int IndexOfReference(TElem listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17864D0 Offset: 0x1784AD0 VA: 0x1817864D0
	|-Listeners<object>.IndexOfReference
	*/

	// RVA: -1 Offset: -1
	internal void Remove(TElem listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1786570 Offset: 0x1784B70 VA: 0x181786570
	|-Listeners<DataViewListener>.Remove
	|-Listeners<object>.Remove
	*/

	// RVA: -1 Offset: -1
	internal void Notify<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3, Listeners.Action<TElem, TElem, T1, T2, T3> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE02370 Offset: 0xE00970 VA: 0x180E02370
	|-Listeners<DataViewListener>.Notify<ListChangedEventArgs, bool, bool>
	|-Listeners<object>.Notify<object, bool, bool>
	|
	|-RVA: 0xE02170 Offset: 0xE00770 VA: 0x180E02170
	|-Listeners<DataViewListener>.Notify<ListChangedType, DataRow, bool>
	|-Listeners<object>.Notify<Int32Enum, object, bool>
	|
	|-RVA: 0xE02570 Offset: 0xE00B70 VA: 0x180E02570
	|-Listeners<object>.Notify<object, object, object>
	*/

	// RVA: -1 Offset: -1
	private void RemoveNullListeners(int nullIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17864F0 Offset: 0x1784AF0 VA: 0x1817864F0
	|-Listeners<object>.RemoveNullListeners
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 4436
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 0EE6555EB2C89F29655BD23FAB0573D8D684331A /*Metadata offset 0x53EE63*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 229F48C8598232AD9236772DD710E64615D0EE51 /*Metadata offset 0x53EE87*/; // 0x24
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=38 2A4F1BD548EC71F652E24985361CD72F0FE1BE7D /*Metadata offset 0x53EF1F*/; // 0xBC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 547FF12759F2EA9866F3E2095113686A6379ABBF /*Metadata offset 0x53EF45*/; // 0xE2
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=176 57F92A12C48A0856350D3C95C4145F2AF4C9DEFF /*Metadata offset 0x53EFDD*/; // 0x17A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 624B37B4C211942F3422DFFEAE9F44901E57339C /*Metadata offset 0x53F08D*/; // 0x22A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 DD3AEFEADB1CD615F3017763F1568179FEE640B0 /*Metadata offset 0x53F125*/; // 0x2C2
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 E92B39D8233061927D9ACDE54665E68E7535635A /*Metadata offset 0x53F159*/; // 0x2F6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 FA7899481F1198B5A3F90368A998C285FCE19878 /*Metadata offset 0x53F18D*/; // 0x32A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 FF8FD0AC7542FD42A8A7C8D145E120345BA51C56 /*Metadata offset 0x53F1CD*/; // 0x36A

}

internal sealed class _AndroidJNIHelper // TypeDefIndex: 4471
{	// Methods

	// RVA: 0x227AE10 Offset: 0x2279410 VA: 0x18227AE10
	public static IntPtr CreateJavaProxy(IntPtr delegateHandle, AndroidJavaProxy proxy) { }

	// RVA: 0x2272490 Offset: 0x2270A90 VA: 0x182272490
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x227C030 Offset: 0x227A630 VA: 0x18227C030
	public static IntPtr InvokeJavaProxyMethod(AndroidJavaProxy proxy, IntPtr jmethodName, IntPtr jargs) { }

	// RVA: 0x227A360 Offset: 0x2278960 VA: 0x18227A360
	public static jvalue[] CreateJNIArgArray(object[] args) { }

	// RVA: 0x227C300 Offset: 0x227A900 VA: 0x18227C300
	public static object UnboxArray(AndroidJavaObject obj) { }

	// RVA: 0x227C830 Offset: 0x227AE30 VA: 0x18227C830
	public static object Unbox(AndroidJavaObject obj) { }

	// RVA: 0x2278B80 Offset: 0x2277180 VA: 0x182278B80
	public static AndroidJavaObject Box(object obj) { }

	// RVA: 0x22725C0 Offset: 0x2270BC0 VA: 0x1822725C0
	public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs) { }

	// RVA: 0x2279A70 Offset: 0x2278070 VA: 0x182279A70
	public static IntPtr ConvertToJNIArray(Array array) { }

	// RVA: -1 Offset: -1
	public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125F2C0 Offset: 0x125D8C0 VA: 0x18125F2C0
	|-_AndroidJNIHelper.ConvertFromJNIArray<bool>
	|
	|-RVA: 0x125FB70 Offset: 0x125E170 VA: 0x18125FB70
	|-_AndroidJNIHelper.ConvertFromJNIArray<char>
	|
	|-RVA: 0x1260420 Offset: 0x125EA20 VA: 0x181260420
	|-_AndroidJNIHelper.ConvertFromJNIArray<double>
	|
	|-RVA: 0x1260CD0 Offset: 0x125F2D0 VA: 0x181260CD0
	|-_AndroidJNIHelper.ConvertFromJNIArray<short>
	|
	|-RVA: 0x1261580 Offset: 0x125FB80 VA: 0x181261580
	|-_AndroidJNIHelper.ConvertFromJNIArray<int>
	|
	|-RVA: 0x1261E30 Offset: 0x1260430 VA: 0x181261E30
	|-_AndroidJNIHelper.ConvertFromJNIArray<long>
	|
	|-RVA: 0x12626E0 Offset: 0x1260CE0 VA: 0x1812626E0
	|-_AndroidJNIHelper.ConvertFromJNIArray<object>
	|
	|-RVA: 0x1262FD0 Offset: 0x12615D0 VA: 0x181262FD0
	|-_AndroidJNIHelper.ConvertFromJNIArray<sbyte>
	|
	|-RVA: 0x1263880 Offset: 0x1261E80 VA: 0x181263880
	|-_AndroidJNIHelper.ConvertFromJNIArray<float>
	*/

	// RVA: 0x22726F0 Offset: 0x2270CF0 VA: 0x1822726F0
	public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	// RVA: -1 Offset: -1
	public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED97C0 Offset: 0xED7DC0 VA: 0x180ED97C0
	|-_AndroidJNIHelper.GetMethodID<bool>
	|-_AndroidJNIHelper.GetMethodID<char>
	|-_AndroidJNIHelper.GetMethodID<double>
	|-_AndroidJNIHelper.GetMethodID<short>
	|-_AndroidJNIHelper.GetMethodID<int>
	|-_AndroidJNIHelper.GetMethodID<long>
	|-_AndroidJNIHelper.GetMethodID<object>
	|-_AndroidJNIHelper.GetMethodID<sbyte>
	|-_AndroidJNIHelper.GetMethodID<float>
	*/

	// RVA: 0x227AF70 Offset: 0x2279570 VA: 0x18227AF70
	public static IntPtr GetConstructorID(IntPtr jclass, string signature) { }

	// RVA: 0x227B1D0 Offset: 0x22797D0 VA: 0x18227B1D0
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x227B140 Offset: 0x2279740 VA: 0x18227B140
	private static IntPtr GetMethodIDFallback(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x227B3B0 Offset: 0x22799B0 VA: 0x18227B3B0
	public static string GetSignature(object obj) { }

	// RVA: 0x227BF50 Offset: 0x227A550 VA: 0x18227BF50
	public static string GetSignature(object[] args) { }

	// RVA: -1 Offset: -1
	public static string GetSignature<ReturnType>(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED9820 Offset: 0xED7E20 VA: 0x180ED9820
	|-_AndroidJNIHelper.GetSignature<bool>
	|
	|-RVA: 0xED9960 Offset: 0xED7F60 VA: 0x180ED9960
	|-_AndroidJNIHelper.GetSignature<char>
	|
	|-RVA: 0xED9AA0 Offset: 0xED80A0 VA: 0x180ED9AA0
	|-_AndroidJNIHelper.GetSignature<double>
	|
	|-RVA: 0xED9BE0 Offset: 0xED81E0 VA: 0x180ED9BE0
	|-_AndroidJNIHelper.GetSignature<short>
	|
	|-RVA: 0xED9D20 Offset: 0xED8320 VA: 0x180ED9D20
	|-_AndroidJNIHelper.GetSignature<int>
	|
	|-RVA: 0xED9E60 Offset: 0xED8460 VA: 0x180ED9E60
	|-_AndroidJNIHelper.GetSignature<long>
	|
	|-RVA: 0xED9FA0 Offset: 0xED85A0 VA: 0x180ED9FA0
	|-_AndroidJNIHelper.GetSignature<object>
	|
	|-RVA: 0xEDA0E0 Offset: 0xED86E0 VA: 0x180EDA0E0
	|-_AndroidJNIHelper.GetSignature<sbyte>
	|
	|-RVA: 0xEDA220 Offset: 0xED8820 VA: 0x180EDA220
	|-_AndroidJNIHelper.GetSignature<float>
	*/

}

public class Memoized<TResult, TArgs> // TypeDefIndex: 4824
{	// Fields
	private readonly Func<TArgs, TResult> _factory; // 0x0
	private readonly Dictionary<TArgs, TResult> _cache; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Func<TArgs, TResult> factory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F8890 Offset: 0x17F6E90 VA: 0x1817F8890
	|-Memoized<object, int>..ctor
	|-Memoized<Material[], int>..ctor
	|
	|-RVA: 0x17F8A70 Offset: 0x17F7070 VA: 0x1817F8A70
	|-Memoized<object, object>..ctor
	|-Memoized<string, string>..ctor
	|
	|-RVA: 0x17F8980 Offset: 0x17F6F80 VA: 0x1817F8980
	|-Memoized<object, ValueTuple<Int32Enum, int>>..ctor
	|-Memoized<string, ValueTuple<ItemDefinition.AmountType, int>>..ctor
	*/

	// RVA: -1 Offset: -1
	public TResult Get(TArgs args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F8650 Offset: 0x17F6C50 VA: 0x1817F8650
	|-Memoized<string, string>.Get
	|-Memoized<object, object>.Get
	|
	|-RVA: 0x17F87D0 Offset: 0x17F6DD0 VA: 0x1817F87D0
	|-Memoized<string, ValueTuple<ItemDefinition.AmountType, int>>.Get
	|-Memoized<object, ValueTuple<Int32Enum, int>>.Get
	|
	|-RVA: 0x17F8710 Offset: 0x17F6D10 VA: 0x1817F8710
	|-Memoized<Material[], int>.Get
	|-Memoized<object, int>.Get
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 4849
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=146 062825E0D4AB4302B73500604BF9520511ACFD15 /*Metadata offset 0x53F777*/; // 0x136E0

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 4899
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=104 1D1E8406C3A31F2298952B0976625EEDFB010FDC /*Metadata offset 0x53F8DD*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=76 339A8BB625A037BA37DB4DF24A276E689D62172D /*Metadata offset 0x53F945*/; // 0x68
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=76 48DE754CC0C776DAD1A85DB81BEFAAADE3A447E9 /*Metadata offset 0x53F991*/; // 0xB4
	internal static readonly long A5F5D64EF7BB696455C9841B907D2E09986EA902 = 2533317740920876; // 0x100

	// Methods

	// RVA: 0xAAB240 Offset: 0xAA9840 VA: 0x180AAB240
	internal static uint ComputeStringHash(string s) { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5096
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 7BBE37982E6C057ED87163CAFC7FD6E5E42EEA46 /*Metadata offset 0x53FCEB*/; // 0x2B11160

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5561
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5 B1A9AA820F353E1BEF1F7D40CD3F58447AA91D123BC2539918BC70F8A66E75B9 /*Metadata offset 0x540925*/; // 0x2B111D0

	// Methods

	// RVA: 0xAAB240 Offset: 0xAA9840 VA: 0x180AAB240
	internal static uint ComputeStringHash(string s) { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5616
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 BA8C008E9A9CA9629B0D5A47EB9DFDC7E9E88D61 /*Metadata offset 0x540B01*/; // 0x2B11160

}

internal class PriorityQueue<TPriority, TItem> // TypeDefIndex: 5668
{	// Fields
	private readonly SortedDictionary<TPriority, Queue<TItem>> _subqueues; // 0x0

	// Properties
	public bool HasItems { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IComparer<TPriority> priorityComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E8760 Offset: 0x15E6D60 VA: 0x1815E8760
	|-PriorityQueue<long, object>..ctor
	|-PriorityQueue<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E8800 Offset: 0x15E6E00 VA: 0x1815E8800
	|-PriorityQueue<long, TimedBlock>..ctor
	|-PriorityQueue<long, object>..ctor
	|-PriorityQueue<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Enqueue(TPriority priority, TItem item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E8500 Offset: 0x15E6B00 VA: 0x1815E8500
	|-PriorityQueue<long, TimedBlock>.Enqueue
	|-PriorityQueue<long, object>.Enqueue
	|-PriorityQueue<object, object>.Enqueue
	*/

	// RVA: -1 Offset: -1
	private void AddQueueOfPriority(TPriority priority) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E8250 Offset: 0x15E6850 VA: 0x1815E8250
	|-PriorityQueue<long, object>.AddQueueOfPriority
	|-PriorityQueue<object, object>.AddQueueOfPriority
	*/

	// RVA: -1 Offset: -1
	public TItem Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E85C0 Offset: 0x15E6BC0 VA: 0x1815E85C0
	|-PriorityQueue<long, TimedBlock>.Peek
	|-PriorityQueue<long, object>.Peek
	|
	|-RVA: 0x15E8690 Offset: 0x15E6C90 VA: 0x1815E8690
	|-PriorityQueue<object, object>.Peek
	*/

	// RVA: -1 Offset: -1
	public bool get_HasItems() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E8860 Offset: 0x15E6E60 VA: 0x1815E8860
	|-PriorityQueue<long, TimedBlock>.get_HasItems
	|-PriorityQueue<long, object>.get_HasItems
	|-PriorityQueue<object, object>.get_HasItems
	*/

	// RVA: -1 Offset: -1
	public TItem Dequeue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E83C0 Offset: 0x15E69C0 VA: 0x1815E83C0
	|-PriorityQueue<long, TimedBlock>.Dequeue
	|-PriorityQueue<long, object>.Dequeue
	|
	|-RVA: 0x15E8460 Offset: 0x15E6A60 VA: 0x1815E8460
	|-PriorityQueue<object, object>.Dequeue
	*/

	// RVA: -1 Offset: -1
	private TItem DequeueFromHighPriorityQueue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E82F0 Offset: 0x15E68F0 VA: 0x1815E82F0
	|-PriorityQueue<long, object>.DequeueFromHighPriorityQueue
	|-PriorityQueue<object, object>.DequeueFromHighPriorityQueue
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5677
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 00C40B3F013EDA60390F2E849C4581815A9419E4 /*Metadata offset 0x540B7F*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 03B569C38E3CD6B720388919D43735A904012C52 /*Metadata offset 0x540BA7*/; // 0x28
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=76 1FDC8DB567F5AAA7068D0D2A601CD71657CBDF38 /*Metadata offset 0x540BCF*/; // 0x50
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 373B494F210C656134C5728D551D4C97B013EB33 /*Metadata offset 0x540C1B*/; // 0x9C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 6BC4EAB0D604C8D4599021AD611C5DBA7FF7E306 /*Metadata offset 0x54101B*/; // 0x49C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 89CE0E8EA590FD37283D6BEFD9E6805C8C47ADBD /*Metadata offset 0x541043*/; // 0x4C4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 DB7C763C9670DD0F6ED34B75B3410A39D835F964 /*Metadata offset 0x541053*/; // 0x4D4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 ED032026472FF77A8A17BA4AFF3FC57AF4B4BF79 /*Metadata offset 0x54107B*/; // 0x4FC

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5812
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=127 A097044521F478B3A2A9A3AC52887BA733E4DE56 /*Metadata offset 0x541124*/; // 0x2B11170

	// Methods

	// RVA: 0xAAB240 Offset: 0xAA9840 VA: 0x180AAB240
	internal static uint ComputeStringHash(string s) { }

}

internal sealed class XHashtable<TValue> // TypeDefIndex: 5818
{	// Fields
	private XHashtable.XHashtableState<TValue> state; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(XHashtable.ExtractKeyDelegate<TValue> extractKey, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A685A0 Offset: 0x1A66BA0 VA: 0x181A685A0
	|-XHashtable<object>..ctor
	|-XHashtable<WeakReference>..ctor
	|-XHashtable<XName>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(string key, int index, int count, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A68560 Offset: 0x1A66B60 VA: 0x181A68560
	|-XHashtable<object>.TryGetValue
	|-XHashtable<WeakReference>.TryGetValue
	|-XHashtable<XName>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public TValue Add(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A683D0 Offset: 0x1A669D0 VA: 0x181A683D0
	|-XHashtable<object>.Add
	|-XHashtable<WeakReference>.Add
	|-XHashtable<XName>.Add
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5852
{
// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5852
	// Methods

	// RVA: 0xAAB240 Offset: 0xAA9840 VA: 0x180AAB240
	internal static uint ComputeStringHash(string s) { }

}

internal sealed class MethodCall<T, TResult> : MulticastDelegate // TypeDefIndex: 5930
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-MethodCall<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual TResult Invoke(T target, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD59170 Offset: 0xD57770 VA: 0x180D59170
	|-MethodCall<object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(T target, object[] args, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAE4580 Offset: 0xAE2B80 VA: 0x180AE4580
	|-MethodCall<object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0
	|-MethodCall<object, object>.EndInvoke
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 6148
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 9E31F24F64765FCAA589F589324D17C9FCF6A06D /*Metadata offset 0x54158E*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 ADFD2E1C801C825415DD53F4F2F72A13B389313C /*Metadata offset 0x5415AA*/; // 0x1C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 D40004AB0E92BF6C8DFE481B56BE3D04ABDA76EB /*Metadata offset 0x5415B6*/; // 0x28
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 DD3AEFEADB1CD615F3017763F1568179FEE640B0 /*Metadata offset 0x5415C0*/; // 0x32
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 E92B39D8233061927D9ACDE54665E68E7535635A /*Metadata offset 0x5415F4*/; // 0x66

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 6262
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 553AD71118F2B31C74BC988917343BADFA8F78EE /*Metadata offset 0x541741*/; // 0x2B11170

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 6635
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 373B494F210C656134C5728D551D4C97B013EB33 /*Metadata offset 0x541D9A*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 E03C5B88B476F381E452F92C935A5B86131DFC4A /*Metadata offset 0x54219A*/; // 0x400

}

internal class <PrivateImplementationDetails>{A0874672-3A49-45D7-A8B0-51E6098CECDA} // TypeDefIndex: 6713
{	// Fields
	internal static <PrivateImplementationDetails>{A0874672-3A49-45D7-A8B0-51E6098CECDA}.__StaticArrayInitTypeSize=32 $$method0x600002d-1 /*Metadata offset 0x542A83*/; // 0x0
	internal static <PrivateImplementationDetails>{A0874672-3A49-45D7-A8B0-51E6098CECDA}.__StaticArrayInitTypeSize=32 $$method0x600002d-2 /*Metadata offset 0x542AA3*/; // 0x20
	internal static <PrivateImplementationDetails>{A0874672-3A49-45D7-A8B0-51E6098CECDA}.__StaticArrayInitTypeSize=128 $$method0x600002d-3 /*Metadata offset 0x542AC3*/; // 0x40
	internal static <PrivateImplementationDetails>{A0874672-3A49-45D7-A8B0-51E6098CECDA}.__StaticArrayInitTypeSize=256 $$method0x600002d-4 /*Metadata offset 0x542B43*/; // 0xC0

}

public class FastAction<A> // TypeDefIndex: 6738
{	// Fields
	private LinkedList<Action<A>> delegates; // 0x0
	private Dictionary<Action<A>, LinkedListNode<Action<A>>> lookup; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Add(Action<A> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AB6B0 Offset: 0x17A9CB0 VA: 0x1817AB6B0
	|-FastAction<bool>.Add
	|-FastAction<object>.Add
	|-FastAction<Object>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<A> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AB800 Offset: 0x17A9E00 VA: 0x1817AB800
	|-FastAction<bool>.Remove
	|-FastAction<object>.Remove
	|-FastAction<Object>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Call(A a) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A53240 Offset: 0x1A51840 VA: 0x181A53240
	|-FastAction<bool>.Call
	|
	|-RVA: 0x17AB750 Offset: 0x17A9D50 VA: 0x1817AB750
	|-FastAction<object>.Call
	|-FastAction<TMP_ColorGradient>.Call
	|-FastAction<Object>.Call
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AB8A0 Offset: 0x17A9EA0 VA: 0x1817AB8A0
	|-FastAction<bool>..ctor
	|-FastAction<object>..ctor
	|-FastAction<TMP_ColorGradient>..ctor
	|-FastAction<Object>..ctor
	*/

}

public class FastAction<A, B> // TypeDefIndex: 6739
{	// Fields
	private LinkedList<Action<A, B>> delegates; // 0x0
	private Dictionary<Action<A, B>, LinkedListNode<Action<A, B>>> lookup; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Add(Action<A, B> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AB6B0 Offset: 0x17A9CB0 VA: 0x1817AB6B0
	|-FastAction<bool, object>.Add
	|-FastAction<object, object>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<A, B> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AB800 Offset: 0x17A9E00 VA: 0x1817AB800
	|-FastAction<bool, object>.Remove
	|-FastAction<object, object>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Call(A a, B b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ABA50 Offset: 0x17AA050 VA: 0x1817ABA50
	|-FastAction<bool, object>.Call
	|-FastAction<bool, TMP_FontAsset>.Call
	|-FastAction<bool, TextMeshPro>.Call
	|-FastAction<bool, TextMeshProUGUI>.Call
	|-FastAction<bool, Material>.Call
	|-FastAction<bool, Object>.Call
	|
	|-RVA: 0x17AB980 Offset: 0x17A9F80 VA: 0x1817AB980
	|-FastAction<object, object>.Call
	|-FastAction<object, Compute_DT_EventArgs>.Call
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AB8A0 Offset: 0x17A9EA0 VA: 0x1817AB8A0
	|-FastAction<bool, object>..ctor
	|-FastAction<bool, TMP_FontAsset>..ctor
	|-FastAction<bool, TextMeshPro>..ctor
	|-FastAction<bool, TextMeshProUGUI>..ctor
	|-FastAction<bool, Material>..ctor
	|-FastAction<bool, Object>..ctor
	|-FastAction<object, object>..ctor
	|-FastAction<object, Compute_DT_EventArgs>..ctor
	*/

}

public class FastAction<A, B, C> // TypeDefIndex: 6740
{	// Fields
	private LinkedList<Action<A, B, C>> delegates; // 0x0
	private Dictionary<Action<A, B, C>, LinkedListNode<Action<A, B, C>>> lookup; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Add(Action<A, B, C> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AB6B0 Offset: 0x17A9CB0 VA: 0x1817AB6B0
	|-FastAction<object, object, object>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<A, B, C> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AB800 Offset: 0x17A9E00 VA: 0x1817AB800
	|-FastAction<object, object, object>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Call(A a, B b, C c) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ABB20 Offset: 0x17AA120 VA: 0x1817ABB20
	|-FastAction<object, object, object>.Call
	|-FastAction<GameObject, Material, Material>.Call
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AB8A0 Offset: 0x17A9EA0 VA: 0x1817AB8A0
	|-FastAction<object, object, object>..ctor
	|-FastAction<GameObject, Material, Material>..ctor
	*/

}

public enum _HorizontalAlignmentOptions // TypeDefIndex: 6827
{	// Fields
	public int value__; // 0x0
	public const _HorizontalAlignmentOptions Left = 1;
	public const _HorizontalAlignmentOptions Center = 2;
	public const _HorizontalAlignmentOptions Right = 4;
	public const _HorizontalAlignmentOptions Justified = 8;
	public const _HorizontalAlignmentOptions Flush = 16;
	public const _HorizontalAlignmentOptions Geometry = 32;

}

public enum _VerticalAlignmentOptions // TypeDefIndex: 6828
{	// Fields
	public int value__; // 0x0
	public const _VerticalAlignmentOptions Top = 256;
	public const _VerticalAlignmentOptions Middle = 512;
	public const _VerticalAlignmentOptions Bottom = 1024;
	public const _VerticalAlignmentOptions Baseline = 2048;
	public const _VerticalAlignmentOptions Geometry = 4096;
	public const _VerticalAlignmentOptions Capline = 8192;

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 6870
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 7BBE37982E6C057ED87163CAFC7FD6E5E42EEA46 /*Metadata offset 0x543253*/; // 0x38A0

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 6937
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=18 B633673BF635D4C719EF5A0496BD28129A8CE5D3B76217371B6C1FDDFFDD780B /*Metadata offset 0x5432AD*/; // 0x2B11180

}

internal class <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7} // TypeDefIndex: 6968
{	// Fields
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=76 $$method0x6000504-1 /*Metadata offset 0x5433B3*/; // 0x0
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=68 $$method0x6000505-1 /*Metadata offset 0x5433FF*/; // 0x4C
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=6144 $$method0x6000507-1 /*Metadata offset 0x543443*/; // 0x90
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=384 $$method0x6000507-2 /*Metadata offset 0x544C43*/; // 0x1890
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=124 $$method0x6000507-3 /*Metadata offset 0x544DC3*/; // 0x1A10
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=124 $$method0x6000507-4 /*Metadata offset 0x544E3F*/; // 0x1A8C
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=120 $$method0x6000507-5 /*Metadata offset 0x544EBB*/; // 0x1B08
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=120 $$method0x6000507-6 /*Metadata offset 0x544F33*/; // 0x1B80
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=116 $$method0x6000509-1 /*Metadata offset 0x544FAB*/; // 0x1BF8
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=120 $$method0x6000509-2 /*Metadata offset 0x54501F*/; // 0x1C6C
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=76 $$method0x6000509-3 /*Metadata offset 0x545097*/; // 0x1CE4
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=19 $$method0x6000509-4 /*Metadata offset 0x5450E3*/; // 0x1D30
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=512 $$method0x6000509-5 /*Metadata offset 0x5450F6*/; // 0x1D43
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=256 $$method0x6000509-6 /*Metadata offset 0x5452F6*/; // 0x1F43
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=116 $$method0x6000509-7 /*Metadata offset 0x5453F6*/; // 0x2043
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=120 $$method0x6000509-8 /*Metadata offset 0x54546A*/; // 0x20B7
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=1152 $$method0x6000475-1 /*Metadata offset 0x5454E2*/; // 0x212F
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=120 $$method0x6000475-2 /*Metadata offset 0x545962*/; // 0x25AF

}

internal class <PrivateImplementationDetails>{4136EF42-BA0E-48C1-8B0C-A481CDC84FC8} // TypeDefIndex: 6993
{	// Fields
	internal static <PrivateImplementationDetails>{4136EF42-BA0E-48C1-8B0C-A481CDC84FC8}.__StaticArrayInitTypeSize=32 $$method0x600007d-1 /*Metadata offset 0x545A13*/; // 0x0
	internal static <PrivateImplementationDetails>{4136EF42-BA0E-48C1-8B0C-A481CDC84FC8}.__StaticArrayInitTypeSize=32 $$method0x600007d-2 /*Metadata offset 0x545A33*/; // 0x20
	internal static <PrivateImplementationDetails>{4136EF42-BA0E-48C1-8B0C-A481CDC84FC8}.__StaticArrayInitTypeSize=128 $$method0x600007d-3 /*Metadata offset 0x545A53*/; // 0x40
	internal static <PrivateImplementationDetails>{4136EF42-BA0E-48C1-8B0C-A481CDC84FC8}.__StaticArrayInitTypeSize=256 $$method0x600007d-4 /*Metadata offset 0x545AD3*/; // 0xC0

}

public struct ValueTask<TResult> : IEquatable<ValueTask<TResult>> // TypeDefIndex: 7086
{	// Fields
	internal readonly object _obj; // 0x0
	internal readonly TResult _result; // 0x0
	internal readonly short _token; // 0x0
	internal readonly bool _continueOnCapturedContext; // 0x0

	// Properties
	public bool IsCompleted { get; }
	public bool IsCompletedSuccessfully { get; }
	public TResult Result { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x228D90 Offset: 0x228190 VA: 0x180228D90
	|-ValueTask<bool>..ctor
	|
	|-RVA: 0x228D00 Offset: 0x228100 VA: 0x180228D00
	|-ValueTask<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Task<TResult> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x228CB0 Offset: 0x2280B0 VA: 0x180228CB0
	|-ValueTask<bool>..ctor
	|
	|-RVA: 0x228D40 Offset: 0x228140 VA: 0x180228D40
	|-ValueTask<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x228A90 Offset: 0x227E90 VA: 0x180228A90
	|-ValueTask<bool>.GetHashCode
	|
	|-RVA: 0x228AD0 Offset: 0x227ED0 VA: 0x180228AD0
	|-ValueTask<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x228750 Offset: 0x227B50 VA: 0x180228750
	|-ValueTask<bool>.Equals
	|
	|-RVA: 0x228890 Offset: 0x227C90 VA: 0x180228890
	|-ValueTask<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTask<TResult> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2289B0 Offset: 0x227DB0 VA: 0x1802289B0
	|-ValueTask<bool>.Equals
	|
	|-RVA: 0x228860 Offset: 0x227C60 VA: 0x180228860
	|-ValueTask<object>.Equals
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x228DF0 Offset: 0x2281F0 VA: 0x180228DF0
	|-ValueTask<bool>.get_IsCompleted
	|
	|-RVA: 0x228F30 Offset: 0x228330 VA: 0x180228F30
	|-ValueTask<object>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompletedSuccessfully() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x228DE0 Offset: 0x2281E0 VA: 0x180228DE0
	|-ValueTask<bool>.get_IsCompletedSuccessfully
	|
	|-RVA: 0x228DD0 Offset: 0x2281D0 VA: 0x180228DD0
	|-ValueTask<object>.get_IsCompletedSuccessfully
	*/

	// RVA: -1 Offset: -1
	public TResult get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229080 Offset: 0x228480 VA: 0x180229080
	|-ValueTask<bool>.get_Result
	|
	|-RVA: 0x229070 Offset: 0x228470 VA: 0x180229070
	|-ValueTask<object>.get_Result
	*/

	// RVA: -1 Offset: -1
	public ValueTaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2289D0 Offset: 0x227DD0 VA: 0x1802289D0
	|-ValueTask<bool>.GetAwaiter
	|
	|-RVA: 0x228A20 Offset: 0x227E20 VA: 0x180228A20
	|-ValueTask<object>.GetAwaiter
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x228BE0 Offset: 0x227FE0 VA: 0x180228BE0
	|-ValueTask<bool>.ToString
	|
	|-RVA: 0x228B10 Offset: 0x227F10 VA: 0x180228B10
	|-ValueTask<object>.ToString
	*/

}

public struct ValueTaskAwaiter<TResult> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 7096
{	// Fields
	private readonly ValueTask<TResult> _value; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ValueTask<TResult> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3DB0 Offset: 0x1E31B0 VA: 0x1801E3DB0
	|-ValueTaskAwaiter<bool>..ctor
	|
	|-RVA: 0x1E3DD0 Offset: 0x1E31D0 VA: 0x1801E3DD0
	|-ValueTaskAwaiter<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3E30 Offset: 0x1E3230 VA: 0x1801E3E30
	|-ValueTaskAwaiter<bool>.get_IsCompleted
	|
	|-RVA: 0x1E3DF0 Offset: 0x1E31F0 VA: 0x1801E3DF0
	|-ValueTaskAwaiter<object>.get_IsCompleted
	*/

	[StackTraceHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public TResult GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3CF0 Offset: 0x1E30F0 VA: 0x1801E3CF0
	|-ValueTaskAwaiter<bool>.GetResult
	|
	|-RVA: 0x1E3D30 Offset: 0x1E3130 VA: 0x1801E3D30
	|-ValueTaskAwaiter<object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3D80 Offset: 0x1E3180 VA: 0x1801E3D80
	|-ValueTaskAwaiter<bool>.OnCompleted
	|
	|-RVA: 0x1E3D70 Offset: 0x1E3170 VA: 0x1801E3D70
	|-ValueTaskAwaiter<object>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3D90 Offset: 0x1E3190 VA: 0x1801E3D90
	|-ValueTaskAwaiter<bool>.UnsafeOnCompleted
	|
	|-RVA: 0x1E3DA0 Offset: 0x1E31A0 VA: 0x1801E3DA0
	|-ValueTaskAwaiter<object>.UnsafeOnCompleted
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 7366
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 C92FBDBB320D6C40BEB41D97EE6C7B301C4ADB1D /*Metadata offset 0x547ACB*/; // 0x2B11168

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 7415
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 021F8912B268BE164A590D1440F05920A3F2A63B9874F994402C7AFFC6F92F82 /*Metadata offset 0x548307*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 02E68C9160BF270CAF19E18D3A77BC2EAA90EFCB3ECA3C454B58CD5BBA5FF7ED /*Metadata offset 0x548347*/; // 0x40
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 047D891CAC8D4F883998ACEFD1EB63F6A679046FFD19EC1276A057F847EE37F6 /*Metadata offset 0x548447*/; // 0x140
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 06ADCD404637282636289E77FA01C56630CB4945332C96D5FA2D9239FE0D6B04 /*Metadata offset 0x548457*/; // 0x150
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 06D49AE61368F7B7C195381125B5A5E8F6830EA024D49F5C1A62950E74DBAF3D /*Metadata offset 0x5484D7*/; // 0x1D0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 091971E0756262C068D16B941EA6256855E94532833A9CE3374D9768E27E4596 /*Metadata offset 0x548517*/; // 0x210
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 124360CE49E1C84604EFA93F8F0C3292C1D216DB605CF153414D893922B18C9F /*Metadata offset 0x5485A7*/; // 0x2A0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 13BE6783CC652C89CC0161446DBD67966CAC410DEA4DE4279FC767A259EFD546 /*Metadata offset 0x5485E7*/; // 0x2E0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 1B8D49F1227D3FC61644822B9FC00CE70A3B2438A1064323BFBE6A022A26F042 /*Metadata offset 0x54861F*/; // 0x318
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 1C01F69BD2391DE00F8F1B377D2D9E5991674702AD777030BA910AC531E4B0FE /*Metadata offset 0x54862F*/; // 0x328
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 22E5D3D9ABC124EE0214CEF7079F24CFF9BE30FD6AF6BA5BBE15920C57497EA1 /*Metadata offset 0x54866F*/; // 0x368
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 2A03DC27FE2EB4E5D0A4358E22435065F2FB1BBF8CC2C4D9F754A9F24089344E /*Metadata offset 0x54867F*/; // 0x378
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=60 2A1C6CEE1B003A06B471AA7632C6B5C4ED18A4E1A4784BF8CA09BD4F38BA4BB5 /*Metadata offset 0x5486BF*/; // 0x3B8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 2BCE8E19B19AAD97CC510F21B5828CCB319639FA317FB59926A436ED3543F58D /*Metadata offset 0x5486FB*/; // 0x3F4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 2C72B27AAD08F98379E9F3E0F6A2D625F895C9E55F61404790377FC196FA14B8 /*Metadata offset 0x54873B*/; // 0x434
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 2F4596419894C88417AC4DF5C99E98A374EFE4B57B7A4EB89CE65FEB92850A61 /*Metadata offset 0x54877B*/; // 0x474
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 320B0930454D74130DD5E245B70DA1736A2C1B5E664DD5BB82B490E60F3ECA2A /*Metadata offset 0x54878B*/; // 0x484
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 3229DAC3DA84FAC1A1018091DAF2A0C3D6B3624AC33BECF13A371238DAC95055 /*Metadata offset 0x54879B*/; // 0x494
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 3543AE0E1ED6A92350687219F717764E126E06D4FA179DE5B0CB3E2BDFE4AC9E /*Metadata offset 0x5487AB*/; // 0x4A4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 3554CE8BB09083C24D298DF77456CB67242E6EEE3DEDFE595E11B90D2F70C0FF /*Metadata offset 0x548807*/; // 0x500
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1500 3B42FF7B534B27868E300720C678882AF0698E9434D0FA135656E097480324FF /*Metadata offset 0x548847*/; // 0x540
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 3EDD050356C639DD16815E64CA19652B1B981F1BA2FF76176BB3995FF0DB860D /*Metadata offset 0x548E23*/; // 0xB1C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 4053901EA5134D137292C48A98E1382B09C1E49C98EEF77C2D00D8FF24481D4F /*Metadata offset 0x548E33*/; // 0xB2C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 419EB5F371A1171DBE8C085F1BB25D78AA0647C1365608E167054A37BFEAD834 /*Metadata offset 0x548E73*/; // 0xB6C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 4517AF16CD9D95D0B56C33292D289749B763021F170127ED439165498D243E69 /*Metadata offset 0x548E83*/; // 0xB7C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 4E7A2BE1E8600FA773FA4952A14AE27AD21E294C2C90F674BEA6BB8B089F39C1 /*Metadata offset 0x548E97*/; // 0xB90
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 550560694565D72C91221BEE89B41C8AA412660E1CF28C626BC523BC959438A9 /*Metadata offset 0x548EB7*/; // 0xBB0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=8748 5600405012DD0807E058E5A8F3F7A9AF31716C8560F552613672D0D770364603 /*Metadata offset 0x548EF7*/; // 0xBF0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 56C5F192F58A478FC32D5428DA86D03B15A95E9A982E82BA5026E6EBE259FE48 /*Metadata offset 0x54B123*/; // 0x2E1C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 57CD95842F6B0D5A0823F7A82A33632D2D4DA79615A834507722CBBBD054E3CF /*Metadata offset 0x54B1B3*/; // 0x2EAC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 58BB6050E828A1FDB65D46F61ADBE862543CF7261AA487580A1328D24E944BBD /*Metadata offset 0x54B1F3*/; // 0x2EEC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 5ED52DA9C543DD730BD7056787DF87C0AED3189F42C3321C4196EA8B70C87D2A /*Metadata offset 0x54B203*/; // 0x2EFC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=88 6547EC5EB178C3DBF6A302152A1FE3BDF747E8E5EB41343EECEA2F45D745E5D1 /*Metadata offset 0x54B293*/; // 0x2F8C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 673F8620472294A2666EB7018FC21EF377E5B15A76872E89803CBDBDBC17F1B8 /*Metadata offset 0x54B2EB*/; // 0x2FE4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 6807ED2269DB8E9A70F5D22C6D41806D26C51C306050C58861DEBD9B21D76D0B /*Metadata offset 0x54B2FB*/; // 0x2FF4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 6810D47101B1F88C982302E36EF8DBDB344EAFDF31E058B2AE9B23522DA15D89 /*Metadata offset 0x54B30B*/; // 0x3004
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 683133215F3906FE49DACDB11CE3F917EF1B439110BF4CE1092DB8F15D087E2F /*Metadata offset 0x54B31B*/; // 0x3014
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 68F20C1D1F9AD9A40A6FF9C3879482F58AED8E4A58995CEB0F83B2575DCFD2BC /*Metadata offset 0x54B377*/; // 0x3070
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 6B6C31FF54224894CC66030691DB54C3EEE6BE4D42DB3DDA43EEC126F036360E /*Metadata offset 0x54B387*/; // 0x3080
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 70CBEAD43E82DC4CCC445D5552A983D797EEF8D2AD3665EB8FAAB2187F64F6FE /*Metadata offset 0x54B3C7*/; // 0x30C0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 70CF9A93794FD166C020BBDF13AE34B6B43B3A2271EC768A35797C135FC62D20 /*Metadata offset 0x54B407*/; // 0x3100
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 79B6797C01D7827A0E35892156B642BD84A9FA528E603C743515D3822864A051 /*Metadata offset 0x54B43F*/; // 0x3138
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 7A5DCFD7518F8A0A3FA422FA014FF84FE08070112345B17E00C0FB0AFC6D7461 /*Metadata offset 0x54B45F*/; // 0x3158
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 7CC4C8FC1CA4B0FA871FEB4911499E0268FE161D01C6ADFD186B0378C4063EBA /*Metadata offset 0x54B47F*/; // 0x3178
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 8C6C0F60451FBE1D2DDDF80A2A9F0B7684893D5B0B8CEAB4CA837EE615B3954E /*Metadata offset 0x54B49F*/; // 0x3198
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 941D4DCAADBEC3CC42B0F9F20212661AC83343F86BC7F873B237BC25AF1B195C /*Metadata offset 0x54BC9F*/; // 0x3998
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 9742CA838C60363B639BEC16A2086253E96A532C05331B73181E45ED9D213F13 /*Metadata offset 0x54BCDF*/; // 0x39D8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=324 9F53690DAB4D28E43D6BB3EB96D00F76FAF99D7681A6E8F0061297C8DD5EFF33 /*Metadata offset 0x54BD1F*/; // 0x3A18
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 9FB71D398994B2E0C6CE3CE99EE4CBD26EE1524A81DDB919603C13A2885F5483 /*Metadata offset 0x54BE63*/; // 0x3B5C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 A28E77C3345C5351A69C7393656A759AABE24F2E59F5BFC49A771E190D9C9FCC /*Metadata offset 0x54BEA3*/; // 0x3B9C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 A3F937EE796D2312148DDB921F1293E76047E426F9BF3864DD12817D66034E74 /*Metadata offset 0x54BEB3*/; // 0x3BAC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 A4B3F75E2EA169B5351F2BAA4DBAB862A18EDFBAE5B1CB4DBEFAEC4E22DA6BD3 /*Metadata offset 0x54BEF3*/; // 0x3BEC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 A84E72B8CD1EB5B569F80091ADA35B15F45C05E48515346C276DFBC7457817CD /*Metadata offset 0x54BF33*/; // 0x3C2C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 AC808BDFC94A2720F9A403E96C598F28C4A82AACBF21E2A1A6347C32A66B6425 /*Metadata offset 0x54BFB3*/; // 0x3CAC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 B107577D43B15DF28D27533ADF012E72BD63868C2A2E688AC15978DC38CD5677 /*Metadata offset 0x54BFC3*/; // 0x3CBC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 B10D5342782BFD3820C0FFBD8DDCDF80BAA0ED5F0DF5746D2EA885110239AC7A /*Metadata offset 0x54BFD3*/; // 0x3CCC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 B79C140A0DE10B238571FE854A6BC223D6D8C50F6ED4E227CCC677094DCB3558 /*Metadata offset 0x54C013*/; // 0x3D0C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 B9C5D4C45600219530B355BB1786AA4E282347901A9E3BF35DC8EE98E1307DFB /*Metadata offset 0x54C033*/; // 0x3D2C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 BBDCD859D8A76172AF0C213EFB99A6F64E8AB028BECE6D313FA5B6BCF96CD15A /*Metadata offset 0x54C043*/; // 0x3D3C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 C271A86BEFE71CEF20615946687F7A3A13E980C14FD4637951697CD4A6112156 /*Metadata offset 0x54C09F*/; // 0x3D98
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 C31F1438706DA962938E7F1D03470E164E0EA9EE1CD0F0D19CA29C7E932C91DC /*Metadata offset 0x54C0FB*/; // 0x3DF4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 C3FBE83D14A8E5B3DCCAF45D7AD6C35F769326FFAED483A102ACF50FB824C9C2 /*Metadata offset 0x54C10B*/; // 0x3E04
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 C6D060549430A52150918BF2837FCCD94C6D727B74A5946A8F7EF51B940C3CF7 /*Metadata offset 0x54C14B*/; // 0x3E44
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 C775F22681F0D15310756B294BB58FC4364A5DE6030B819E8D3EEC4E75454915 /*Metadata offset 0x54C183*/; // 0x3E7C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 C807773510A04834C84A6A093A8267D127DC4413714AD99057315D8CABE1D467 /*Metadata offset 0x54C1DF*/; // 0x3ED8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 C842A7F36E23186A8F55DC7D0E63E781469950969CB88357227234F95C35DEA9 /*Metadata offset 0x54C1FF*/; // 0x3EF8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 CCC564D5CDB40E327F07151E33EF8AD040EEB5129CE505D00FE6EC11BD28C359 /*Metadata offset 0x54C25B*/; // 0x3F54
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 CD4DE47C20503BFF1B99694EAF6390723510293766C75243F8B3CA7B56C89359 /*Metadata offset 0x54C293*/; // 0x3F8C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 D20525C66D9D2B26BC9D3A773951775A3813FC7F97CC4A2EADFF258D3C9D869E /*Metadata offset 0x54C323*/; // 0x401C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 D3310F8730C74E00C7014874471A5E27574CD015457352EFB0373E8C5DA85FD1 /*Metadata offset 0x54C333*/; // 0x402C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 DD54E6E73536232DFD682C64D36E265B59ACF8AD04FC6062A2EB7225BBDDDB02 /*Metadata offset 0x54C343*/; // 0x403C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 DDC358E79464AB64B601CE4D8FBC308D787438D4CE92844B5FD77F2DE1E21575 /*Metadata offset 0x54C37B*/; // 0x4074
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 DE26AA4452A148F1FCFF9D95EA656766D0DC19BDCEE086F85BC3F9BD8AB7F25B /*Metadata offset 0x54C47B*/; // 0x4174
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 E2AA696710083FEFF382491A86DF649DB1E8EE6AA4ECF99E8D98CFBF871BFCE4 /*Metadata offset 0x54C48B*/; // 0x4184
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=60 ED977BBA7102E7758BEF3DA21CD69B44B8864A1D6F43BB20E6BF59862487ECBA /*Metadata offset 0x54C49B*/; // 0x4194
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 EFC52C86FFF3F24CE6C0C14D161FCF00584AB329C5997334034F2B4D91225307 /*Metadata offset 0x54C4D7*/; // 0x41D0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 F1B0145A5F0D3E964A90201094730422F3013B94D7B9E73B6FFDED5643D486A2 /*Metadata offset 0x54C51F*/; // 0x4218
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 F8756C1F7B8F886752A7B73230C5AC5397F7CE2B1BFDC5C139DBED513BD228C3 /*Metadata offset 0x54C557*/; // 0x4250

}

internal sealed class TimedObjectsComparer<TObject> : IComparer<TObject> // TypeDefIndex: 7464
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public int Compare(TObject x, TObject y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FBB60 Offset: 0x17FA160 VA: 0x1817FBB60
	|-TimedObjectsComparer<object>.Compare
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5AD60 Offset: 0xD59360 VA: 0x180D5AD60
	|-TimedObjectsComparer<object>..ctor
	*/

}

public sealed class ValueChange<TValue> : ITimedObject // TypeDefIndex: 7504
{	// Fields
	private readonly long _time; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly TValue <Value>k__BackingField; // 0x0

	// Properties
	public long Time { get; }
	public TValue Value { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(long time, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FCB80 Offset: 0x17FB180 VA: 0x1817FCB80
	|-ValueChange<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public long get_Time() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	|-ValueChange<Tempo>.get_Time
	|-ValueChange<TimeSignature>.get_Time
	|-ValueChange<object>.get_Time
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public TValue get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-ValueChange<Tempo>.get_Value
	|-ValueChange<TimeSignature>.get_Value
	|-ValueChange<object>.get_Value
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(ValueChange<TValue> change1, ValueChange<TValue> change2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FCC10 Offset: 0x17FB210 VA: 0x1817FCC10
	|-ValueChange<object>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(ValueChange<TValue> change1, ValueChange<TValue> change2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FCDE0 Offset: 0x17FB3E0 VA: 0x1817FCDE0
	|-ValueChange<object>.op_Inequality
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FCAD0 Offset: 0x17FB0D0 VA: 0x1817FCAD0
	|-ValueChange<object>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FC9B0 Offset: 0x17FAFB0 VA: 0x1817FC9B0
	|-ValueChange<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FCA30 Offset: 0x17FB030 VA: 0x1817FCA30
	|-ValueChange<object>.GetHashCode
	*/

}

public sealed class ValueLine<TValue> : IEnumerable<ValueChange<TValue>>, IEnumerable // TypeDefIndex: 7505
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private EventHandler ValuesChanged; // 0x0
	private readonly TimedObjectsComparer<ValueChange<TValue>> _comparer; // 0x0
	private readonly List<ValueChange<TValue>> _valueChanges; // 0x0
	private readonly TValue _defaultValue; // 0x0
	private bool _valuesChanged; // 0x0
	private long _maxTime; // 0x0

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	internal void add_ValuesChanged(EventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FDC00 Offset: 0x17FC200 VA: 0x1817FDC00
	|-ValueLine<Tempo>.add_ValuesChanged
	|-ValueLine<TimeSignature>.add_ValuesChanged
	|-ValueLine<object>.add_ValuesChanged
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	internal void remove_ValuesChanged(EventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FDCB0 Offset: 0x17FC2B0 VA: 0x1817FDCB0
	|-ValueLine<Tempo>.remove_ValuesChanged
	|-ValueLine<TimeSignature>.remove_ValuesChanged
	|-ValueLine<object>.remove_ValuesChanged
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(TValue defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FDB00 Offset: 0x17FC100 VA: 0x1817FDB00
	|-ValueLine<Tempo>..ctor
	|-ValueLine<TimeSignature>..ctor
	|-ValueLine<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TValue GetValueAtTime(long time) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FCF20 Offset: 0x17FB520 VA: 0x1817FCF20
	|-ValueLine<TimeSignature>.GetValueAtTime
	|-ValueLine<object>.GetValueAtTime
	*/

	// RVA: -1 Offset: -1
	internal ValueChange<TValue> GetValueChangeAtTime(long time) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FCFC0 Offset: 0x17FB5C0 VA: 0x1817FCFC0
	|-ValueLine<object>.GetValueChangeAtTime
	*/

	// RVA: -1 Offset: -1
	internal void SetValue(long time, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FD8A0 Offset: 0x17FBEA0 VA: 0x1817FD8A0
	|-ValueLine<Tempo>.SetValue
	|-ValueLine<TimeSignature>.SetValue
	|-ValueLine<object>.SetValue
	*/

	// RVA: -1 Offset: -1
	internal ValueLine<TValue> Reverse(long centerTime) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FD170 Offset: 0x17FB770 VA: 0x1817FD170
	|-ValueLine<Tempo>.Reverse
	|-ValueLine<TimeSignature>.Reverse
	|-ValueLine<object>.Reverse
	*/

	// RVA: -1 Offset: -1
	private void OnValuesChanged(bool forceSort = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FD0B0 Offset: 0x17FB6B0 VA: 0x1817FD0B0
	|-ValueLine<object>.OnValuesChanged
	*/

	// RVA: -1 Offset: -1
	private void OnValueChangesNeedSorting() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC8260 Offset: 0xFC6860 VA: 0x180FC8260
	|-ValueLine<object>.OnValueChangesNeedSorting
	*/

	// RVA: -1 Offset: -1
	private void OnValueChangesSortingCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF5FD60 Offset: 0xF5E360 VA: 0x180F5FD60
	|-ValueLine<object>.OnValueChangesSortingCompleted
	*/

	// RVA: -1 Offset: -1
	private void SortValueChanges() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FDA60 Offset: 0x17FC060 VA: 0x1817FDA60
	|-ValueLine<object>.SortValueChanges
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<ValueChange<TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FCE70 Offset: 0x17FB470 VA: 0x1817FCE70
	|-ValueLine<Tempo>.GetEnumerator
	|-ValueLine<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FDAD0 Offset: 0x17FC0D0 VA: 0x1817FDAD0
	|-ValueLine<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 7638
{	// Fields
	internal static readonly int B52DDE3D967E604310620E80EFBFBED9B6FB8C0605B3CB29D31534DAA6181A7C = 505223448; // 0x2B112D4

}

internal class <PrivateImplementationDetails> // TypeDefIndex: 7836
{	// Fields
	internal static <PrivateImplementationDetails>.$ArrayType$132 $$field-0 /*Metadata offset 0x54D5A5*/; // 0x2300

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

internal class <PrivateImplementationDetails> // TypeDefIndex: 7854
{	// Fields
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-0 /*Metadata offset 0x54DDD5*/; // 0x0
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-1 /*Metadata offset 0x54DFD5*/; // 0x200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-2 /*Metadata offset 0x54E1D5*/; // 0x400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-3 /*Metadata offset 0x54E3D5*/; // 0x600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-4 /*Metadata offset 0x54E5D5*/; // 0x800
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-5 /*Metadata offset 0x54E7D5*/; // 0xA00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-6 /*Metadata offset 0x54E9D5*/; // 0xC00

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

internal class <PrivateImplementationDetails> // TypeDefIndex: 7895
{	// Fields
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-0 /*Metadata offset 0x54F381*/; // 0x0
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-1 /*Metadata offset 0x54F581*/; // 0x200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-2 /*Metadata offset 0x54F781*/; // 0x400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-3 /*Metadata offset 0x54F981*/; // 0x600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-4 /*Metadata offset 0x54FB81*/; // 0x800
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-5 /*Metadata offset 0x54FD81*/; // 0xA00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-6 /*Metadata offset 0x54FF81*/; // 0xC00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-7 /*Metadata offset 0x550181*/; // 0xE00

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

internal class <PrivateImplementationDetails> // TypeDefIndex: 7973
{	// Fields
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-0 /*Metadata offset 0x550B2D*/; // 0x0
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-1 /*Metadata offset 0x550D2D*/; // 0x200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-2 /*Metadata offset 0x550F2D*/; // 0x400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-3 /*Metadata offset 0x55112D*/; // 0x600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-4 /*Metadata offset 0x55132D*/; // 0x800
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-5 /*Metadata offset 0x55152D*/; // 0xA00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-6 /*Metadata offset 0x55172D*/; // 0xC00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-7 /*Metadata offset 0x55192D*/; // 0xE00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-8 /*Metadata offset 0x551B2D*/; // 0x1000
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-9 /*Metadata offset 0x551D2D*/; // 0x1200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-10 /*Metadata offset 0x551F2D*/; // 0x1400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-11 /*Metadata offset 0x55212D*/; // 0x1600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-12 /*Metadata offset 0x55232D*/; // 0x1800
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-13 /*Metadata offset 0x55252D*/; // 0x1A00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-14 /*Metadata offset 0x55272D*/; // 0x1C00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-15 /*Metadata offset 0x55292D*/; // 0x1E00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-16 /*Metadata offset 0x552B2D*/; // 0x2000
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-17 /*Metadata offset 0x552D2D*/; // 0x2200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-18 /*Metadata offset 0x552F2D*/; // 0x2400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-19 /*Metadata offset 0x55312D*/; // 0x2600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-20 /*Metadata offset 0x55332D*/; // 0x2800
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-21 /*Metadata offset 0x55352D*/; // 0x2A00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-22 /*Metadata offset 0x55372D*/; // 0x2C00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-23 /*Metadata offset 0x55392D*/; // 0x2E00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-24 /*Metadata offset 0x553B2D*/; // 0x3000
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-25 /*Metadata offset 0x553D2D*/; // 0x3200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-26 /*Metadata offset 0x553F2D*/; // 0x3400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-27 /*Metadata offset 0x55412D*/; // 0x3600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-28 /*Metadata offset 0x55432D*/; // 0x3800
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-29 /*Metadata offset 0x55452D*/; // 0x3A00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-30 /*Metadata offset 0x55472D*/; // 0x3C00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-31 /*Metadata offset 0x55492D*/; // 0x3E00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-32 /*Metadata offset 0x554B2D*/; // 0x4000
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-33 /*Metadata offset 0x554D2D*/; // 0x4200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-34 /*Metadata offset 0x554F2D*/; // 0x4400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-35 /*Metadata offset 0x55512D*/; // 0x4600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-36 /*Metadata offset 0x55532D*/; // 0x4800

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

internal class <PrivateImplementationDetails> // TypeDefIndex: 8007
{	// Fields
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-0 /*Metadata offset 0x555CD9*/; // 0x0
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-1 /*Metadata offset 0x555ED9*/; // 0x200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-2 /*Metadata offset 0x5560D9*/; // 0x400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-3 /*Metadata offset 0x5562D9*/; // 0x600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-4 /*Metadata offset 0x5564D9*/; // 0x800
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-5 /*Metadata offset 0x5566D9*/; // 0xA00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-6 /*Metadata offset 0x5568D9*/; // 0xC00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-7 /*Metadata offset 0x556AD9*/; // 0xE00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-8 /*Metadata offset 0x556CD9*/; // 0x1000
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-9 /*Metadata offset 0x556ED9*/; // 0x1200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-10 /*Metadata offset 0x5570D9*/; // 0x1400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-11 /*Metadata offset 0x5572D9*/; // 0x1600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-12 /*Metadata offset 0x5574D9*/; // 0x1800
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-13 /*Metadata offset 0x5576D9*/; // 0x1A00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-14 /*Metadata offset 0x5578D9*/; // 0x1C00

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class CC_AnalogTV : CC_Base // TypeDefIndex: 8034
{	// Fields
	public float phase; // 0x28
	public bool grayscale; // 0x2C
	public float noiseIntensity; // 0x30
	public float scanlinesIntensity; // 0x34
	public float scanlinesCount; // 0x38
	public float distortion; // 0x3C
	public float cubicDistortion; // 0x40
	public float scale; // 0x44

	// Methods

	// RVA: 0x1068660 Offset: 0x1066C60 VA: 0x181068660
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1068840 Offset: 0x1066E40 VA: 0x181068840
	public void .ctor() { }

}

public class CC_Base : MonoBehaviour // TypeDefIndex: 8035
{	// Fields
	public Shader shader; // 0x18
	protected Material _material; // 0x20

	// Properties
	protected Material material { get; }

	// Methods

	// RVA: 0x1068910 Offset: 0x1066F10 VA: 0x181068910 Slot: 4
	protected virtual void Start() { }

	// RVA: 0x10689B0 Offset: 0x1066FB0 VA: 0x1810689B0
	protected Material get_material() { }

	// RVA: 0x1068880 Offset: 0x1066E80 VA: 0x181068880 Slot: 5
	protected virtual void OnDisable() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class CC_BleachBypass : CC_Base // TypeDefIndex: 8036
{	// Fields
	public float amount; // 0x28

	// Methods

	// RVA: 0x1068A70 Offset: 0x1067070 VA: 0x181068A70
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0xA330C0 Offset: 0xA316C0 VA: 0x180A330C0
	public void .ctor() { }

}

public class CC_Blend : CC_Base // TypeDefIndex: 8037
{	// Fields
	public Texture texture; // 0x28
	public float amount; // 0x30
	public int mode; // 0x34

	// Methods

	// RVA: 0x1068B70 Offset: 0x1067170 VA: 0x181068B70
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1068CE0 Offset: 0x10672E0 VA: 0x181068CE0
	public void .ctor() { }

}

public class CC_BrightnessContrastGamma : CC_Base // TypeDefIndex: 8038
{	// Fields
	public float redCoeff; // 0x28
	public float greenCoeff; // 0x2C
	public float blueCoeff; // 0x30
	public float brightness; // 0x34
	public float contrast; // 0x38
	public float gamma; // 0x3C

	// Methods

	// RVA: 0x1068CF0 Offset: 0x10672F0 VA: 0x181068CF0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1068F00 Offset: 0x1067500 VA: 0x181068F00
	public void .ctor() { }

}

public class CC_ChannelMixer : CC_Base // TypeDefIndex: 8039
{	// Fields
	public float redR; // 0x28
	public float redG; // 0x2C
	public float redB; // 0x30
	public float greenR; // 0x34
	public float greenG; // 0x38
	public float greenB; // 0x3C
	public float blueR; // 0x40
	public float blueG; // 0x44
	public float blueB; // 0x48
	public float constantR; // 0x4C
	public float constantG; // 0x50
	public float constantB; // 0x54

	// Methods

	// RVA: 0x1068F30 Offset: 0x1067530 VA: 0x181068F30
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1069190 Offset: 0x1067790 VA: 0x181069190
	public void .ctor() { }

}

public class CC_Convolution3x3 : CC_Base // TypeDefIndex: 8040
{	// Fields
	public Vector3 kernelTop; // 0x28
	public Vector3 kernelMiddle; // 0x34
	public Vector3 kernelBottom; // 0x40
	public float divisor; // 0x4C
	public float amount; // 0x50

	// Methods

	// RVA: 0x10691B0 Offset: 0x10677B0 VA: 0x1810691B0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x10694C0 Offset: 0x1067AC0 VA: 0x1810694C0
	public void .ctor() { }

}

public class CC_CrossStitch : CC_Base // TypeDefIndex: 8041
{	// Fields
	public int size; // 0x28
	public float brightness; // 0x2C
	public bool invert; // 0x30
	public bool pixelize; // 0x31

	// Methods

	// RVA: 0x1069570 Offset: 0x1067B70 VA: 0x181069570
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1069750 Offset: 0x1067D50 VA: 0x181069750
	public void .ctor() { }

}

public class CC_DoubleVision : CC_Base, IImageEffect // TypeDefIndex: 8042
{	// Fields
	public Vector2 displace; // 0x28
	public float amount; // 0x30

	// Methods

	// RVA: 0x1069770 Offset: 0x1067D70 VA: 0x181069770 Slot: 6
	public bool IsActive() { }

	// RVA: 0x10697B0 Offset: 0x1067DB0 VA: 0x1810697B0 Slot: 7
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1069970 Offset: 0x1067F70 VA: 0x181069970
	public void .ctor() { }

}

public class CC_FastVignette : CC_Base // TypeDefIndex: 8043
{	// Fields
	public float sharpness; // 0x28
	public float darkness; // 0x2C
	public bool desaturate; // 0x30

	// Methods

	// RVA: 0x10699C0 Offset: 0x1067FC0 VA: 0x1810699C0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1069AD0 Offset: 0x10680D0 VA: 0x181069AD0
	public void .ctor() { }

}

public class CC_Frost : CC_Base, IImageEffect // TypeDefIndex: 8044
{	// Fields
	public float scale; // 0x28
	public float sharpness; // 0x2C
	public float darkness; // 0x30
	public bool enableVignette; // 0x34

	// Methods

	// RVA: 0x1069AF0 Offset: 0x10680F0 VA: 0x181069AF0 Slot: 6
	public bool IsActive() { }

	// RVA: 0x1069B30 Offset: 0x1068130 VA: 0x181069B30 Slot: 7
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1069CC0 Offset: 0x10682C0 VA: 0x181069CC0
	public void .ctor() { }

}

public class CC_GradientRamp : CC_Base // TypeDefIndex: 8045
{	// Fields
	public Texture rampTexture; // 0x28
	public float amount; // 0x30

	// Methods

	// RVA: 0x1069CE0 Offset: 0x10682E0 VA: 0x181069CE0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1068CE0 Offset: 0x10672E0 VA: 0x181068CE0
	public void .ctor() { }

}

public class CC_Grayscale : CC_Base, IImageEffect // TypeDefIndex: 8046
{	// Fields
	public float redLuminance; // 0x28
	public float greenLuminance; // 0x2C
	public float blueLuminance; // 0x30
	public float amount; // 0x34

	// Methods

	// RVA: 0x1069E40 Offset: 0x1068440 VA: 0x181069E40 Slot: 6
	public bool IsActive() { }

	// RVA: 0x1069E80 Offset: 0x1068480 VA: 0x181069E80 Slot: 7
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1069FD0 Offset: 0x10685D0 VA: 0x181069FD0
	public void .ctor() { }

}

public class CC_Halftone : CC_Base // TypeDefIndex: 8047
{	// Fields
	public float density; // 0x28
	public int mode; // 0x2C
	public bool antialiasing; // 0x30
	public bool showOriginal; // 0x31

	// Methods

	// RVA: 0x106A000 Offset: 0x1068600 VA: 0x18106A000
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x106A100 Offset: 0x1068700 VA: 0x18106A100
	public void .ctor() { }

}

public class CC_HueSaturationValue : CC_Base // TypeDefIndex: 8048
{	// Fields
	public float hue; // 0x28
	public float saturation; // 0x2C
	public float value; // 0x30

	// Methods

	// RVA: 0x106A120 Offset: 0x1068720 VA: 0x18106A120
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class CC_Led : CC_Base // TypeDefIndex: 8049
{	// Fields
	public float scale; // 0x28
	public bool automaticRatio; // 0x2C
	public float ratio; // 0x30
	public float brightness; // 0x34
	public int mode; // 0x38

	// Methods

	// RVA: 0x106A2A0 Offset: 0x10688A0 VA: 0x18106A2A0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x106A460 Offset: 0x1068A60 VA: 0x18106A460
	public void .ctor() { }

}

public class CC_Levels : CC_Base // TypeDefIndex: 8050
{	// Fields
	public int mode; // 0x28
	public float inputMinL; // 0x2C
	public float inputMaxL; // 0x30
	public float inputGammaL; // 0x34
	public float inputMinR; // 0x38
	public float inputMaxR; // 0x3C
	public float inputGammaR; // 0x40
	public float inputMinG; // 0x44
	public float inputMaxG; // 0x48
	public float inputGammaG; // 0x4C
	public float inputMinB; // 0x50
	public float inputMaxB; // 0x54
	public float inputGammaB; // 0x58
	public float outputMinL; // 0x5C
	public float outputMaxL; // 0x60
	public float outputMinR; // 0x64
	public float outputMaxR; // 0x68
	public float outputMinG; // 0x6C
	public float outputMaxG; // 0x70
	public float outputMinB; // 0x74
	public float outputMaxB; // 0x78

	// Methods

	// RVA: 0x106A480 Offset: 0x1068A80 VA: 0x18106A480
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x106A950 Offset: 0x1068F50 VA: 0x18106A950
	public void .ctor() { }

}

public class CC_LookupFilter : CC_Base // TypeDefIndex: 8051
{	// Fields
	public Texture lookupTexture; // 0x28

	// Methods

	// RVA: 0x106A9B0 Offset: 0x1068FB0 VA: 0x18106A9B0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class CC_Negative : CC_Base // TypeDefIndex: 8052
{	// Fields
	public float amount; // 0x28

	// Methods

	// RVA: 0x106AAD0 Offset: 0x10690D0 VA: 0x18106AAD0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0xA330C0 Offset: 0xA316C0 VA: 0x180A330C0
	public void .ctor() { }

}

public class CC_PhotoFilter : CC_Base, IImageEffect // TypeDefIndex: 8053
{	// Fields
	public Color color; // 0x28
	public float density; // 0x38

	// Methods

	// RVA: 0x106ABD0 Offset: 0x10691D0 VA: 0x18106ABD0 Slot: 6
	public bool IsActive() { }

	// RVA: 0x106AC10 Offset: 0x1069210 VA: 0x18106AC10 Slot: 7
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x106AD40 Offset: 0x1069340 VA: 0x18106AD40
	public void .ctor() { }

}

public class CC_Pixelate : CC_Base // TypeDefIndex: 8054
{	// Fields
	public float scale; // 0x28
	public bool automaticRatio; // 0x2C
	public float ratio; // 0x30
	public int mode; // 0x34

	// Methods

	// RVA: 0x106ADB0 Offset: 0x10693B0 VA: 0x18106ADB0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x106AF50 Offset: 0x1069550 VA: 0x18106AF50
	public void .ctor() { }

}

public class CC_Posterize : CC_Base // TypeDefIndex: 8055
{	// Fields
	public int levels; // 0x28

	// Methods

	// RVA: 0x106AF70 Offset: 0x1069570 VA: 0x18106AF70
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x106B020 Offset: 0x1069620 VA: 0x18106B020
	public void .ctor() { }

}

public class CC_RGBSplit : CC_Base // TypeDefIndex: 8056
{	// Fields
	public float amount; // 0x28
	public float angle; // 0x2C

	// Methods

	// RVA: 0x106B030 Offset: 0x1069630 VA: 0x18106B030
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class CC_RadialBlur : CC_Base // TypeDefIndex: 8057
{	// Fields
	public float amount; // 0x28
	public Vector2 center; // 0x2C
	public int quality; // 0x34

	// Methods

	// RVA: 0x106B1D0 Offset: 0x10697D0 VA: 0x18106B1D0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x106B350 Offset: 0x1069950 VA: 0x18106B350
	public void .ctor() { }

}

public class CC_Sharpen : CC_Base // TypeDefIndex: 8058
{	// Fields
	public float strength; // 0x28
	public float clamp; // 0x2C

	// Methods

	// RVA: 0x106B680 Offset: 0x1069C80 VA: 0x18106B680
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x106B840 Offset: 0x1069E40 VA: 0x18106B840
	public void .ctor() { }

}

public class CC_SharpenAndVignette : CC_Base, IImageEffect // TypeDefIndex: 8059
{	// Fields
	[HeaderAttribute] // RVA: 0xC3A10 Offset: 0xC2E10 VA: 0x1800C3A10
	public bool applySharpen; // 0x28
	[RangeAttribute] // RVA: 0x759D0 Offset: 0x74DD0 VA: 0x1800759D0
	public float strength; // 0x2C
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public float clamp; // 0x30
	[HeaderAttribute] // RVA: 0xC4F40 Offset: 0xC4340 VA: 0x1800C4F40
	public bool applyVignette; // 0x34
	[RangeAttribute] // RVA: 0xC5020 Offset: 0xC4420 VA: 0x1800C5020
	public float sharpness; // 0x38
	[RangeAttribute] // RVA: 0x77D60 Offset: 0x77160 VA: 0x180077D60
	public float darkness; // 0x3C

	// Methods

	// RVA: 0x8D60F0 Offset: 0x8D46F0 VA: 0x1808D60F0 Slot: 6
	public bool IsActive() { }

	// RVA: 0x106B3B0 Offset: 0x10699B0 VA: 0x18106B3B0 Slot: 7
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x106B650 Offset: 0x1069C50 VA: 0x18106B650
	public void .ctor() { }

}

public class CC_Threshold : CC_Base // TypeDefIndex: 8060
{	// Fields
	public float threshold; // 0x28
	public bool useNoise; // 0x2C
	public float noiseRange; // 0x30

	// Methods

	// RVA: 0x106B860 Offset: 0x1069E60 VA: 0x18106B860
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x106B970 Offset: 0x1069F70 VA: 0x18106B970
	public void .ctor() { }

}

public class CC_Vibrance : CC_Base // TypeDefIndex: 8061
{	// Fields
	public float amount; // 0x28

	// Methods

	// RVA: 0x106B990 Offset: 0x1069F90 VA: 0x18106B990
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class CC_Wiggle : CC_Base, IImageEffect // TypeDefIndex: 8062
{	// Fields
	public float timer; // 0x28
	public float speed; // 0x2C
	public float scale; // 0x30

	// Methods

	// RVA: 0x106BBB0 Offset: 0x106A1B0 VA: 0x18106BBB0
	private void Update() { }

	// RVA: 0x1069770 Offset: 0x1067D70 VA: 0x181069770 Slot: 6
	public bool IsActive() { }

	// RVA: 0x106BA90 Offset: 0x106A090 VA: 0x18106BA90 Slot: 7
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x106BC00 Offset: 0x106A200 VA: 0x18106BC00
	public void .ctor() { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 8239
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=19552 1DC4C1B55DC0F7A09DD49557857282243A661721 /*Metadata offset 0x557FA4*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=420 4D97B7EA75C57A5C53C1E01B1C6253465DE43B65 /*Metadata offset 0x55CC04*/; // 0x4C60
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=15874 9B733B2872507920FB43A4A60F4CBE3E17200C8C /*Metadata offset 0x55CDA8*/; // 0x4E04
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=15874 C01F4A345A0DC451B12954EDA4ED605D0075A2A5 /*Metadata offset 0x560BAA*/; // 0x8C06
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 DD09230AEF3C2384FBC6D4B1BC4EADBE9911368E /*Metadata offset 0x5649AC*/; // 0xCA08
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9776 F2AB9A53871DA3CF4444B73A4D38E5580D8F8ED3 /*Metadata offset 0x5649E0*/; // 0xCA3C

}

internal sealed class <>f__AnonymousType0<<Identifier>j__TPar, <Name>j__TPar, <State>j__TPar> // TypeDefIndex: 8246
{
// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=420 // TypeDefIndex: 8241

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9776 // TypeDefIndex: 8242

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=15874 // TypeDefIndex: 8243

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=19552 // TypeDefIndex: 8244

// Namespace: 
internal class <Module> // TypeDefIndex: 8245

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
internal sealed class <>f__AnonymousType0<<Identifier>j__TPar, <Name>j__TPar, <State>j__TPar> // TypeDefIndex: 8246
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x9E940 Offset: 0x9DD40 VA: 0x18009E940
	private readonly <Identifier>j__TPar <Identifier>i__Field; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x9E940 Offset: 0x9DD40 VA: 0x18009E940
	private readonly <Name>j__TPar <Name>i__Field; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x9E940 Offset: 0x9DD40 VA: 0x18009E940
	private readonly <State>j__TPar <State>i__Field; // 0x0

	// Properties
	public <Identifier>j__TPar Identifier { get; }
	public <Name>j__TPar Name { get; }
	public <State>j__TPar State { get; }

	// Methods

	// RVA: -1 Offset: -1
	public <Identifier>j__TPar get_Identifier() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	|-<>f__AnonymousType0<object, object, bool>.get_Identifier
	|-<>f__AnonymousType0<object, object, object>.get_Identifier
	*/

	// RVA: -1 Offset: -1
	public <Name>j__TPar get_Name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-<>f__AnonymousType0<object, object, bool>.get_Name
	|-<>f__AnonymousType0<object, object, object>.get_Name
	*/

	// RVA: -1 Offset: -1
	public <State>j__TPar get_State() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB103F0 Offset: 0xB0E9F0 VA: 0x180B103F0
	|-<>f__AnonymousType0<object, object, bool>.get_State
	|
	|-RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	|-<>f__AnonymousType0<object, object, object>.get_State
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public void .ctor(<Identifier>j__TPar Identifier, <Name>j__TPar Name, <State>j__TPar State) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E9EA0 Offset: 0x15E84A0 VA: 0x1815E9EA0
	|-<>f__AnonymousType0<object, object, bool>..ctor
	|-<>f__AnonymousType0<string, string, bool>..ctor
	|
	|-RVA: 0x15E9F10 Offset: 0x15E8510 VA: 0x1815E9F10
	|-<>f__AnonymousType0<object, object, object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E97D0 Offset: 0x15E7DD0 VA: 0x1815E97D0
	|-<>f__AnonymousType0<object, object, bool>.Equals
	|
	|-RVA: 0x15E96B0 Offset: 0x15E7CB0 VA: 0x1815E96B0
	|-<>f__AnonymousType0<object, object, object>.Equals
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E98F0 Offset: 0x15E7EF0 VA: 0x1815E98F0
	|-<>f__AnonymousType0<object, object, bool>.GetHashCode
	|
	|-RVA: 0x15E99E0 Offset: 0x15E7FE0 VA: 0x1815E99E0
	|-<>f__AnonymousType0<object, object, object>.GetHashCode
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E9AD0 Offset: 0x15E80D0 VA: 0x1815E9AD0
	|-<>f__AnonymousType0<object, object, bool>.ToString
	|
	|-RVA: 0x15E9CB0 Offset: 0x15E82B0 VA: 0x1815E9CB0
	|-<>f__AnonymousType0<object, object, object>.ToString
	*/

}

public class v_chainsaw : MonoBehaviour // TypeDefIndex: 8896
{	// Fields
	public bool bAttacking; // 0x18
	public bool bHitMetal; // 0x19
	public bool bHitWood; // 0x1A
	public bool bHitFlesh; // 0x1B
	public bool bEngineOn; // 0x1C
	public ParticleSystem[] hitMetalFX; // 0x20
	public ParticleSystem[] hitWoodFX; // 0x28
	public ParticleSystem[] hitFleshFX; // 0x30
	public SoundDefinition hitMetalSoundDef; // 0x38
	public SoundDefinition hitWoodSoundDef; // 0x40
	public SoundDefinition hitFleshSoundDef; // 0x48
	public Sound hitSound; // 0x50
	public GameObject hitSoundTarget; // 0x58
	public float hitSoundFadeTime; // 0x60
	public ParticleSystem smokeEffect; // 0x68
	public Animator chainsawAnimator; // 0x70
	public Renderer chainRenderer; // 0x78
	public Material chainlink; // 0x80
	private MaterialPropertyBlock block; // 0x88
	private Vector2 saveST; // 0x90
	private float chainSpeed; // 0x98
	private float chainAmount; // 0x9C
	public float temp1; // 0xA0
	public float temp2; // 0xA4

	// Methods

	// RVA: 0x1AAC020 Offset: 0x1AAA620 VA: 0x181AAC020
	public void OnEnable() { }

	// RVA: 0x1AABE60 Offset: 0x1AAA460 VA: 0x181AABE60
	private void Awake() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void Start() { }

	// RVA: 0x1AAC130 Offset: 0x1AAA730 VA: 0x181AAC130
	private void ScrollChainTexture() { }

	// RVA: 0x1AAC240 Offset: 0x1AAA840 VA: 0x181AAC240
	private void Update() { }

	// RVA: 0x1AABEA0 Offset: 0x1AAA4A0 VA: 0x181AABEA0
	private void DoHitSound(SoundDefinition soundDef) { }

	// RVA: 0x1AAC7B0 Offset: 0x1AAADB0 VA: 0x181AAC7B0
	public void .ctor() { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 12153
{
// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 12153
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 08A598D3DC7ED63443A0CAF087F7CDF5BAA67E3D /*Metadata offset 0x56AAAD*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 0ED907628EE272F93737B500A23D77C9B1C88368 /*Metadata offset 0x56AAC5*/; // 0x18
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 17ADC9F18EEFE619644F7B3C7C90D5FD8DCDE2BB /*Metadata offset 0x56AAD9*/; // 0x2C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 1C910D34886830DDE4A52B59726EB240ADBF9F34 /*Metadata offset 0x56AAF5*/; // 0x48
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 2277B245F935EBA3EA2D03B6871C13871FD4D572 /*Metadata offset 0x56AAFB*/; // 0x4E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 24F287DA5BA36E31C3946E2FBE95B8388C241662 /*Metadata offset 0x56AB0B*/; // 0x5E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 386DD6935C2F38BB8114CA4DF96C8BC2D3E639DA /*Metadata offset 0x56AB23*/; // 0x76
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 42A4001D1CFDC98C761C0CFE5497A75F739D92F8 /*Metadata offset 0x56AB2F*/; // 0x82
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 43A214299CEA27B6A55E61A929FC7B62C5D4941E /*Metadata offset 0x56AB3B*/; // 0x8E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 44D235DAFB9C469EBDA7640EB1F2CC833B40E9E5 /*Metadata offset 0x56B33B*/; // 0x88E
	internal static readonly long 4CAECE539B039B16E16206EA2478F8C5FFB2CA05 = 727905341920923785; // 0x8D0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 59E933D7501F1D8F431F5807AC6C357BBA5F2D58 /*Metadata offset 0x56B383*/; // 0x8D8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 6B8D5CC14D2709C84958ED5E3855C874DA314CB4 /*Metadata offset 0x56B39B*/; // 0x8F0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 6BA637A252B6BFA8895B67AD72DCCAE79715984C /*Metadata offset 0x56B49B*/; // 0x9F0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=80 6DBA8D05A3CD51B9E01E83FDDF49241693E5D4E4 /*Metadata offset 0x56B4DB*/; // 0xA30
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 843D396E2EE569B035A7AC2BEB7A8253FC4AEDA7 /*Metadata offset 0x56B52B*/; // 0xA80
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 9365FDAD4BD75AEF9446E0B22483D217BE36E309 /*Metadata offset 0x56B537*/; // 0xA8C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=288 9EFF88EB2F3540C5CE20FEF36A8E3AA37629AF80 /*Metadata offset 0x56B54F*/; // 0xAA4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 B9B198B061D08812F585C9E56641F4E897E88E38 /*Metadata offset 0x56B66F*/; // 0xBC4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 C18072E27FC2B4816C8694EB22427195375388F0 /*Metadata offset 0x56B67B*/; // 0xBD0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 C7F420F4B2F68D0B3647564554BA8DB99509F64F /*Metadata offset 0x56B6B3*/; // 0xC08
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 D950356082C70AD4018410AD313BA99D655D4D4A /*Metadata offset 0x56B6CF*/; // 0xC24
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 E3D5EABE71635FCDE2C05162A6CDE245A9796318 /*Metadata offset 0x56B6DB*/; // 0xC30
	internal static readonly long FCBA60311CDE80DE090AE6F8834C9CEC477FA56A = 5927942488114331648; // 0xCB0

	// Methods

	// RVA: 0xAAB240 Offset: 0xAA9840 VA: 0x180AAB240
	internal static uint ComputeStringHash(string s) { }

}

