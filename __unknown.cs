internal sealed class <>f__AnonymousType0<<message>j__TPar> // TypeDefIndex: 1
{
// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
internal sealed class <>f__AnonymousType0<<message>j__TPar> // TypeDefIndex: 1
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x9E9D0 Offset: 0x9DDD0 VA: 0x18009E9D0
	private readonly <message>j__TPar <message>i__Field; // 0x0

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public void .ctor(<message>j__TPar message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x135A1D0 Offset: 0x13587D0 VA: 0x18135A1D0
	|-<>f__AnonymousType0<object>..ctor
	|-<>f__AnonymousType0<string>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E9780 Offset: 0x15E7D80 VA: 0x1815E9780
	|-<>f__AnonymousType0<object>.Equals
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E9830 Offset: 0x15E7E30 VA: 0x1815E9830
	|-<>f__AnonymousType0<object>.GetHashCode
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E9880 Offset: 0x15E7E80 VA: 0x1815E9880
	|-<>f__AnonymousType0<object>.ToString
	*/

}

internal class __Filters // TypeDefIndex: 143
{	// Fields
	internal static readonly __Filters Instance; // 0x2B111D8

	// Methods

	// RVA: 0x214C4F0 Offset: 0x214AAF0 VA: 0x18214C4F0 Slot: 4
	internal virtual bool FilterAttribute(MemberInfo m, object filterCriteria) { }

	// RVA: 0x214CAE0 Offset: 0x214B0E0 VA: 0x18214CAE0 Slot: 5
	internal virtual bool FilterName(MemberInfo m, object filterCriteria) { }

	// RVA: 0x214C920 Offset: 0x214AF20 VA: 0x18214C920 Slot: 6
	internal virtual bool FilterIgnoreCase(MemberInfo m, object filterCriteria) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x214CC90 Offset: 0x214B290 VA: 0x18214CC90
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
	|-RVA: 0x1B88D00 Offset: 0x1B87300 VA: 0x181B88D00
	|-Func<JsonSerializerSettings>.Invoke
	|-Func<IReferenceResolver>.Invoke
	|-Func<string>.Invoke
	|-Func<object>.Invoke
	|
	|-RVA: 0x1B89700 Offset: 0x1B87D00 VA: 0x181B89700
	|-Func<bool>.Invoke
	|-Func<byte>.Invoke
	|-Func<VoidTaskResult>.Invoke
	|
	|-RVA: 0x1B89490 Offset: 0x1B87A90 VA: 0x181B89490
	|-Func<int>.Invoke
	|
	|-RVA: 0x1B891E0 Offset: 0x1B877E0 VA: 0x181B891E0
	|-Func<PublishResult>.Invoke
	|-Func<Nullable<Image>>.Invoke
	|
	|-RVA: 0x1220D80 Offset: 0x121F380 VA: 0x181220D80
	|-Func<UdpReceiveResult>.Invoke
	|
	|-RVA: 0x1B89F00 Offset: 0x1B88500 VA: 0x181B89F00
	|-Func<Nullable<ServerInfo>>.Invoke
	|
	|-RVA: 0x1B88A50 Offset: 0x1B87050 VA: 0x181B88A50
	|-Func<Nullable<InventoryPurchaseResult>>.Invoke
	|-Func<Nullable<ResultPage>>.Invoke
	|
	|-RVA: 0x198AA10 Offset: 0x1989010 VA: 0x18198AA10
	|-Func<Nullable<InventoryResult>>.Invoke
	|
	|-RVA: 0x1B89970 Offset: 0x1B87F70 VA: 0x181B89970
	|-Func<Nullable<Item>>.Invoke
	|
	|-RVA: 0x1B88F70 Offset: 0x1B87570 VA: 0x181B88F70
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
	|-RVA: 0x19F9420 Offset: 0x19F7A20 VA: 0x1819F9420
	|-Func<PublishResult>.EndInvoke
	|-Func<Nullable<Image>>.EndInvoke
	|
	|-RVA: 0xFF6510 Offset: 0xFF4B10 VA: 0x180FF6510
	|-Func<bool>.EndInvoke
	|-Func<byte>.EndInvoke
	|-Func<VoidTaskResult>.EndInvoke
	|
	|-RVA: 0xB9A9D0 Offset: 0xB98FD0 VA: 0x180B9A9D0
	|-Func<int>.EndInvoke
	|
	|-RVA: 0x1220D40 Offset: 0x121F340 VA: 0x181220D40
	|-Func<UdpReceiveResult>.EndInvoke
	|
	|-RVA: 0x19F9290 Offset: 0x19F7890 VA: 0x1819F9290
	|-Func<Nullable<ServerInfo>>.EndInvoke
	|
	|-RVA: 0x19F9300 Offset: 0x19F7900 VA: 0x1819F9300
	|-Func<Nullable<InventoryPurchaseResult>>.EndInvoke
	|-Func<Nullable<ResultPage>>.EndInvoke
	|
	|-RVA: 0x198A9D0 Offset: 0x1988FD0 VA: 0x18198A9D0
	|-Func<Nullable<InventoryResult>>.EndInvoke
	|
	|-RVA: 0x19F9370 Offset: 0x19F7970 VA: 0x1819F9370
	|-Func<Nullable<Item>>.EndInvoke
	|
	|-RVA: 0x1221690 Offset: 0x121FC90 VA: 0x181221690
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
	|-RVA: 0x16D2DF0 Offset: 0x16D13F0 VA: 0x1816D2DF0
	|-Func<Entity.EntityInfo, bool>.Invoke
	|-Func<ItemSkinDirectory.Skin, bool>.Invoke
	|-Func<Option, bool>.Invoke
	|-Func<SkinnedMultiMesh.Part, bool>.Invoke
	|-Func<InventoryItem, FourBitNumber>.Invoke
	|-Func<InventoryItem, SevenBitNumber>.Invoke
	|-Func<InventoryItem, bool>.Invoke
	|
	|-RVA: 0x1B15B40 Offset: 0x1B14140 VA: 0x181B15B40
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
	|-RVA: 0x19FE190 Offset: 0x19FC790 VA: 0x1819FE190
	|-Func<Exception, bool>.Invoke
	|-Func<SimpleAsyncResult, bool>.Invoke
	|-Func<string, bool>.Invoke
	|-Func<object, bool>.Invoke
	|
	|-RVA: 0x212BAC0 Offset: 0x212A0C0 VA: 0x18212BAC0
	|-Func<int, int>.Invoke
	|-Func<Int32Enum, int>.Invoke
	|-Func<Int32Enum, Int32Enum>.Invoke
	|
	|-RVA: 0x212FFE0 Offset: 0x212E5E0 VA: 0x18212FFE0
	|-Func<int, float>.Invoke
	|-Func<Int32Enum, float>.Invoke
	|
	|-RVA: 0x19FB4C0 Offset: 0x19F9AC0 VA: 0x1819FB4C0
	|-Func<object, string>.Invoke
	|-Func<object[], JsonConverter>.Invoke
	|-Func<string, string>.Invoke
	|-Func<string, GameObject>.Invoke
	|-Func<object, object>.Invoke
	|-Func<AssemblyName, Assembly>.Invoke
	|
	|-RVA: 0x18A4D80 Offset: 0x18A3380 VA: 0x1818A4D80
	|-Func<ulong, bool>.Invoke
	|-Func<long, bool>.Invoke
	|
	|-RVA: 0x19FC340 Offset: 0x19FA940 VA: 0x1819FC340
	|-Func<ILayoutElement, float>.Invoke
	|-Func<object, float>.Invoke
	|
	|-RVA: 0x18A4890 Offset: 0x18A2E90 VA: 0x1818A4890
	|-Func<NativeInputUpdateType, bool>.Invoke
	|-Func<int, bool>.Invoke
	|-Func<Int32Enum, bool>.Invoke
	|
	|-RVA: 0x1B960E0 Offset: 0x1B946E0 VA: 0x181B960E0
	|-Func<Admin.PlayerInfo, object>.Invoke
	|
	|-RVA: 0x1B94FC0 Offset: 0x1B935C0 VA: 0x181B94FC0
	|-Func<Admin.ServerConvarInfo, object>.Invoke
	|-Func<InventoryRecipe, object>.Invoke
	|-Func<InventoryRecipe.Ingredient, long>.Invoke
	|-Func<InventoryRecipe.Ingredient, object>.Invoke
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, ulong>.Invoke
	|
	|-RVA: 0x1B8DEA0 Offset: 0x1B8C4A0 VA: 0x181B8DEA0
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
	|-RVA: 0x16D27B0 Offset: 0x16D0DB0 VA: 0x1816D27B0
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
	|-RVA: 0x1B92950 Offset: 0x1B90F50 VA: 0x181B92950
	|-Func<Demos.DemoInfo, DateTime>.Invoke
	|-Func<Demos.DemoInfo, TimeSpan>.Invoke
	|-Func<InventoryItem, PathFinder.Point>.Invoke
	|-Func<InventoryItem, InventoryItemId>.Invoke
	|
	|-RVA: 0x1B8ED60 Offset: 0x1B8D360 VA: 0x181B8ED60
	|-Func<Demos.DemoInfo, object>.Invoke
	|-Func<SkinnedMultiMesh.Part, long>.Invoke
	|-Func<InventoryItem, long>.Invoke
	|-Func<InventoryItem, object>.Invoke
	|
	|-RVA: 0x16D2AF0 Offset: 0x16D10F0 VA: 0x1816D2AF0
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
	|-RVA: 0x1B18C10 Offset: 0x1B17210 VA: 0x181B18C10
	|-Func<BurstCloth.Chain, int>.Invoke
	|-Func<PlayerItemRecipe.Ingredient, int>.Invoke
	|
	|-RVA: 0x1B93E50 Offset: 0x1B92450 VA: 0x181B93E50
	|-Func<SkeletonDefinition.Bone, Debugging.EntityInfo>.Invoke
	|-Func<SkeletonDefinition.Bone, KeyValuePair<object, int>>.Invoke
	|
	|-RVA: 0x1B97010 Offset: 0x1B95610 VA: 0x181B97010
	|-Func<SkeletonDefinition.Bone, PathFinder.Point>.Invoke
	|-Func<InventoryItem.Amount, InventoryItemId>.Invoke
	|
	|-RVA: 0x1B942F0 Offset: 0x1B928F0 VA: 0x181B942F0
	|-Func<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<SkeletonDefinition.Bone, Resolution>.Invoke
	|
	|-RVA: 0x1B8D610 Offset: 0x1B8BC10 VA: 0x181B8D610
	|-Func<SkeletonDefinition.Bone, Option>.Invoke
	|-Func<SkeletonDefinition.Bone, InventoryItem>.Invoke
	|
	|-RVA: 0x1B93690 Offset: 0x1B91C90 VA: 0x181B93690
	|-Func<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.Invoke
	|-Func<SkeletonDefinition.Bone, InventoryRecipe>.Invoke
	|
	|-RVA: 0x16D3760 Offset: 0x16D1D60 VA: 0x1816D3760
	|-Func<SkeletonDefinition.Bone, bool>.Invoke
	|-Func<InventoryItem.Amount, bool>.Invoke
	|
	|-RVA: 0x1B93B20 Offset: 0x1B92120 VA: 0x181B93B20
	|-Func<SkeletonDefinition.Bone, int>.Invoke
	|-Func<SkeletonDefinition.Bone, Int32Enum>.Invoke
	|
	|-RVA: 0x1B8E220 Offset: 0x1B8C820 VA: 0x181B8E220
	|-Func<SkeletonDefinition.Bone, long>.Invoke
	|-Func<SkeletonDefinition.Bone, object>.Invoke
	|
	|-RVA: 0x1B8DA90 Offset: 0x1B8C090 VA: 0x181B8DA90
	|-Func<SkeletonDefinition.Bone, float>.Invoke
	|
	|-RVA: 0x1B91F10 Offset: 0x1B90510 VA: 0x181B91F10
	|-Func<WeightedStringList.Container, float>.Invoke
	|-Func<PlayerItemRecipe, float>.Invoke
	|-Func<KeyValuePair<object, object>, float>.Invoke
	|-Func<KeyValuePair<uint, object>, float>.Invoke
	|
	|-RVA: 0x18A8390 Offset: 0x18A6990 VA: 0x1818A8390
	|-Func<FourBitNumber, FourBitNumber>.Invoke
	|-Func<FourBitNumber, bool>.Invoke
	|-Func<SevenBitNumber, SevenBitNumber>.Invoke
	|-Func<SevenBitNumber, bool>.Invoke
	|
	|-RVA: 0x1B95A70 Offset: 0x1B94070 VA: 0x181B95A70
	|-Func<SevenBitNumber, object>.Invoke
	|
	|-RVA: 0x1B94CC0 Offset: 0x1B932C0 VA: 0x181B94CC0
	|-Func<PathFinder.Point, PathFinder.Point>.Invoke
	|-Func<PlayerItemRecipe.Ingredient, PlayerItemRecipe.Ingredient>.Invoke
	|-Func<Achievement, PathFinder.Point>.Invoke
	|-Func<InventoryItemId, InventoryItemId>.Invoke
	|-Func<Friend, PathFinder.Point>.Invoke
	|
	|-RVA: 0x16D4730 Offset: 0x16D2D30 VA: 0x1816D4730
	|-Func<PetCommandList.PetCommandDesc, bool>.Invoke
	|
	|-RVA: 0x1B8F9E0 Offset: 0x1B8DFE0 VA: 0x181B8F9E0
	|-Func<PlayerItemRecipe, PathFinder.Point>.Invoke
	|-Func<KeyValuePair<object, object>, PathFinder.Point>.Invoke
	|-Func<KeyValuePair<uint, object>, PathFinder.Point>.Invoke
	|
	|-RVA: 0x1B90DC0 Offset: 0x1B8F3C0 VA: 0x181B90DC0
	|-Func<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<PlayerItemRecipe, Resolution>.Invoke
	|-Func<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<KeyValuePair<object, object>, Resolution>.Invoke
	|-Func<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<KeyValuePair<uint, object>, Resolution>.Invoke
	|
	|-RVA: 0x1B90740 Offset: 0x1B8ED40 VA: 0x181B90740
	|-Func<PlayerItemRecipe, Option>.Invoke
	|-Func<PlayerItemRecipe, InventoryItem>.Invoke
	|-Func<KeyValuePair<object, object>, Option>.Invoke
	|-Func<KeyValuePair<object, object>, InventoryItem>.Invoke
	|-Func<KeyValuePair<uint, object>, Option>.Invoke
	|-Func<KeyValuePair<uint, object>, InventoryItem>.Invoke
	|
	|-RVA: 0x1B90A80 Offset: 0x1B8F080 VA: 0x181B90A80
	|-Func<PlayerItemRecipe, InventoryRecipe.Ingredient>.Invoke
	|-Func<PlayerItemRecipe, InventoryRecipe>.Invoke
	|-Func<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.Invoke
	|-Func<KeyValuePair<object, object>, InventoryRecipe>.Invoke
	|-Func<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.Invoke
	|-Func<KeyValuePair<uint, object>, InventoryRecipe>.Invoke
	|
	|-RVA: 0x1B933D0 Offset: 0x1B919D0 VA: 0x181B933D0
	|-Func<PlayerItemRecipe, int>.Invoke
	|-Func<PlayerItemRecipe, Int32Enum>.Invoke
	|-Func<KeyValuePair<object, object>, int>.Invoke
	|-Func<KeyValuePair<object, object>, Int32Enum>.Invoke
	|-Func<KeyValuePair<uint, object>, int>.Invoke
	|-Func<KeyValuePair<uint, object>, Int32Enum>.Invoke
	|
	|-RVA: 0x19FBC70 Offset: 0x19FA270 VA: 0x1819FBC70
	|-Func<ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<Resolution, Resolution>.Invoke
	|
	|-RVA: 0x16D5080 Offset: 0x16D3680 VA: 0x1816D5080
	|-Func<ProjectileWeaponMod.Modifier, bool>.Invoke
	|-Func<Resolution, bool>.Invoke
	|
	|-RVA: 0x1B956C0 Offset: 0x1B93CC0 VA: 0x181B956C0
	|-Func<ProjectileWeaponMod.Modifier, float>.Invoke
	|
	|-RVA: 0x1B96590 Offset: 0x1B94B90 VA: 0x181B96590
	|-Func<Option, Option>.Invoke
	|-Func<InventoryItem, Option>.Invoke
	|-Func<InventoryItem, InventoryItem>.Invoke
	|
	|-RVA: 0x1B92250 Offset: 0x1B90850 VA: 0x181B92250
	|-Func<ServerInfo, Debugging.EntityInfo>.Invoke
	|-Func<ServerInfo, KeyValuePair<object, int>>.Invoke
	|
	|-RVA: 0x18A41D0 Offset: 0x18A27D0 VA: 0x1818A41D0
	|-Func<ServerInfo, FourBitNumber>.Invoke
	|-Func<ServerInfo, SevenBitNumber>.Invoke
	|-Func<ServerInfo, bool>.Invoke
	|-Func<ServerInfo, bool>.Invoke
	|
	|-RVA: 0x1B92D20 Offset: 0x1B91320 VA: 0x181B92D20
	|-Func<ServerInfo, PathFinder.Point>.Invoke
	|
	|-RVA: 0x1B91140 Offset: 0x1B8F740 VA: 0x181B91140
	|-Func<ServerInfo, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<ServerInfo, Resolution>.Invoke
	|
	|-RVA: 0x1B8E670 Offset: 0x1B8CC70 VA: 0x181B8E670
	|-Func<ServerInfo, Option>.Invoke
	|-Func<ServerInfo, InventoryItem>.Invoke
	|
	|-RVA: 0x1B90050 Offset: 0x1B8E650 VA: 0x181B90050
	|-Func<ServerInfo, InventoryRecipe.Ingredient>.Invoke
	|-Func<ServerInfo, InventoryRecipe>.Invoke
	|
	|-RVA: 0x1B94790 Offset: 0x1B92D90 VA: 0x181B94790
	|-Func<ServerInfo, int>.Invoke
	|-Func<ServerInfo, Int32Enum>.Invoke
	|
	|-RVA: 0x1B8F120 Offset: 0x1B8D720 VA: 0x181B8F120
	|-Func<ServerInfo, long>.Invoke
	|-Func<ServerInfo, object>.Invoke
	|-Func<ServerInfo, object>.Invoke
	|
	|-RVA: 0x1B97450 Offset: 0x1B95A50 VA: 0x181B97450
	|-Func<ServerInfo, float>.Invoke
	|
	|-RVA: 0x1B91850 Offset: 0x1B8FE50 VA: 0x181B91850
	|-Func<ServerInfo, uint>.Invoke
	|-Func<ServerInfo, int>.Invoke
	|
	|-RVA: 0x1B969A0 Offset: 0x1B94FA0 VA: 0x181B969A0
	|-Func<Achievement, Debugging.EntityInfo>.Invoke
	|-Func<Achievement, KeyValuePair<object, int>>.Invoke
	|-Func<Friend, Debugging.EntityInfo>.Invoke
	|-Func<Friend, KeyValuePair<object, int>>.Invoke
	|
	|-RVA: 0x1B95D70 Offset: 0x1B94370 VA: 0x181B95D70
	|-Func<Achievement, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<Achievement, Resolution>.Invoke
	|-Func<Friend, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<Friend, Resolution>.Invoke
	|
	|-RVA: 0x1B8FD20 Offset: 0x1B8E320 VA: 0x181B8FD20
	|-Func<Achievement, Option>.Invoke
	|-Func<Achievement, InventoryItem>.Invoke
	|-Func<Friend, Option>.Invoke
	|-Func<Friend, InventoryItem>.Invoke
	|
	|-RVA: 0x1B95390 Offset: 0x1B93990 VA: 0x181B95390
	|-Func<Achievement, InventoryRecipe.Ingredient>.Invoke
	|-Func<Achievement, InventoryRecipe>.Invoke
	|-Func<Friend, InventoryRecipe.Ingredient>.Invoke
	|-Func<Friend, InventoryRecipe>.Invoke
	|
	|-RVA: 0x1B8F7E0 Offset: 0x1B8DDE0 VA: 0x181B8F7E0
	|-Func<Achievement, int>.Invoke
	|-Func<Achievement, Int32Enum>.Invoke
	|-Func<Friend, int>.Invoke
	|-Func<Friend, Int32Enum>.Invoke
	|
	|-RVA: 0x19FD410 Offset: 0x19FBA10 VA: 0x1819FD410
	|-Func<Achievement, long>.Invoke
	|-Func<Achievement, object>.Invoke
	|-Func<Friend, long>.Invoke
	|-Func<Friend, object>.Invoke
	|-Func<ValueTuple<Int32Enum, int>, object>.Invoke
	|
	|-RVA: 0x1B96D10 Offset: 0x1B95310 VA: 0x181B96D10
	|-Func<Achievement, float>.Invoke
	|-Func<Friend, float>.Invoke
	|
	|-RVA: 0x212E750 Offset: 0x212CD50 VA: 0x18212E750
	|-Func<InventoryDefId, Debugging.EntityInfo>.Invoke
	|-Func<InventoryDefId, KeyValuePair<object, int>>.Invoke
	|
	|-RVA: 0x212CB70 Offset: 0x212B170 VA: 0x18212CB70
	|-Func<InventoryDefId, PathFinder.Point>.Invoke
	|
	|-RVA: 0x212BCC0 Offset: 0x212A2C0 VA: 0x18212BCC0
	|-Func<InventoryDefId, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<InventoryDefId, Resolution>.Invoke
	|
	|-RVA: 0x212FCB0 Offset: 0x212E2B0 VA: 0x18212FCB0
	|-Func<InventoryDefId, Option>.Invoke
	|-Func<InventoryDefId, InventoryItem>.Invoke
	|
	|-RVA: 0x212D510 Offset: 0x212BB10 VA: 0x18212D510
	|-Func<InventoryDefId, InventoryRecipe.Ingredient>.Invoke
	|-Func<InventoryDefId, InventoryRecipe>.Invoke
	|
	|-RVA: 0x18A6C60 Offset: 0x18A5260 VA: 0x1818A6C60
	|-Func<InventoryDefId, bool>.Invoke
	|
	|-RVA: 0x2130900 Offset: 0x212EF00 VA: 0x182130900
	|-Func<InventoryDefId, int>.Invoke
	|-Func<InventoryDefId, Int32Enum>.Invoke
	|
	|-RVA: 0x212F600 Offset: 0x212DC00 VA: 0x18212F600
	|-Func<InventoryDefId, long>.Invoke
	|-Func<InventoryDefId, object>.Invoke
	|
	|-RVA: 0x2132B80 Offset: 0x2131180 VA: 0x182132B80
	|-Func<InventoryDefId, float>.Invoke
	|
	|-RVA: 0x212C030 Offset: 0x212A630 VA: 0x18212C030
	|-Func<ServerInfo, ServerInfo>.Invoke
	|
	|-RVA: 0x2131D10 Offset: 0x2130310 VA: 0x182131D10
	|-Func<InventoryItem, Debugging.EntityInfo>.Invoke
	|-Func<InventoryItem, KeyValuePair<object, int>>.Invoke
	|
	|-RVA: 0x212E340 Offset: 0x212C940 VA: 0x18212E340
	|-Func<InventoryItem, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<InventoryItem, Resolution>.Invoke
	|
	|-RVA: 0x212F8F0 Offset: 0x212DEF0 VA: 0x18212F8F0
	|-Func<InventoryItem, InventoryDefId>.Invoke
	|-Func<InventoryItem, uint>.Invoke
	|
	|-RVA: 0x212DBE0 Offset: 0x212C1E0 VA: 0x18212DBE0
	|-Func<InventoryItem, InventoryRecipe.Ingredient>.Invoke
	|-Func<InventoryItem, InventoryRecipe>.Invoke
	|
	|-RVA: 0x212D1E0 Offset: 0x212B7E0 VA: 0x18212D1E0
	|-Func<InventoryItem, int>.Invoke
	|-Func<InventoryItem, Int32Enum>.Invoke
	|
	|-RVA: 0x212D840 Offset: 0x212BE40 VA: 0x18212D840
	|-Func<InventoryItem, float>.Invoke
	|
	|-RVA: 0x2132730 Offset: 0x2130D30 VA: 0x182132730
	|-Func<InventoryItem.Amount, uint>.Invoke
	|
	|-RVA: 0x212B6C0 Offset: 0x2129CC0 VA: 0x18212B6C0
	|-Func<InventoryRecipe, PlayerItemRecipe>.Invoke
	|-Func<InventoryRecipe.Ingredient, Debugging.EntityInfo>.Invoke
	|-Func<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.Invoke
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, Dispatch.ResultCallback>.Invoke
	|
	|-RVA: 0x212C770 Offset: 0x212AD70 VA: 0x18212C770
	|-Func<InventoryRecipe, InventoryRecipe>.Invoke
	|-Func<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.Invoke
	|-Func<InventoryRecipe.Ingredient, InventoryRecipe>.Invoke
	|
	|-RVA: 0x16D4370 Offset: 0x16D2970 VA: 0x1816D4370
	|-Func<InventoryRecipe, bool>.Invoke
	|-Func<InventoryRecipe.Ingredient, bool>.Invoke
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, bool>.Invoke
	|
	|-RVA: 0x2130D00 Offset: 0x212F300 VA: 0x182130D00
	|-Func<InventoryRecipe.Ingredient, PathFinder.Point>.Invoke
	|-Func<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.Invoke
	|
	|-RVA: 0x212EDF0 Offset: 0x212D3F0 VA: 0x18212EDF0
	|-Func<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<InventoryRecipe.Ingredient, Resolution>.Invoke
	|
	|-RVA: 0x212F200 Offset: 0x212D800 VA: 0x18212F200
	|-Func<InventoryRecipe.Ingredient, Option>.Invoke
	|-Func<InventoryRecipe.Ingredient, InventoryItem>.Invoke
	|
	|-RVA: 0x212DFF0 Offset: 0x212C5F0 VA: 0x18212DFF0
	|-Func<InventoryRecipe.Ingredient, int>.Invoke
	|-Func<InventoryRecipe.Ingredient, Int32Enum>.Invoke
	|
	|-RVA: 0x21301E0 Offset: 0x212E7E0 VA: 0x1821301E0
	|-Func<InventoryRecipe.Ingredient, float>.Invoke
	|
	|-RVA: 0x2131400 Offset: 0x212FA00 VA: 0x182131400
	|-Func<Item, DateTime>.Invoke
	|
	|-RVA: 0x18A3AD0 Offset: 0x18A20D0 VA: 0x1818A3AD0
	|-Func<bool, bool>.Invoke
	|
	|-RVA: 0x18A6410 Offset: 0x18A4A10 VA: 0x1818A6410
	|-Func<char, bool>.Invoke
	|
	|-RVA: 0x1B17300 Offset: 0x1B15900 VA: 0x181B17300
	|-Func<KeyValuePair<object, int>, int>.Invoke
	|-Func<KeyValuePair<uint, object>, uint>.Invoke
	|-Func<Guid, int>.Invoke
	|
	|-RVA: 0x2132120 Offset: 0x2130720 VA: 0x182132120
	|-Func<double, double>.Invoke
	|
	|-RVA: 0x146E100 Offset: 0x146C700 VA: 0x18146E100
	|-Func<int, FourBitNumber>.Invoke
	|-Func<int, SevenBitNumber>.Invoke
	|-Func<uint, bool>.Invoke
	|
	|-RVA: 0x2130B00 Offset: 0x212F100 VA: 0x182130B00
	|-Func<int, object>.Invoke
	|-Func<Int32Enum, object>.Invoke
	|
	|-RVA: 0x2130590 Offset: 0x212EB90 VA: 0x182130590
	|-Func<Int32Enum, Debugging.EntityInfo>.Invoke
	|-Func<Int32Enum, KeyValuePair<object, int>>.Invoke
	|
	|-RVA: 0x2132430 Offset: 0x2130A30 VA: 0x182132430
	|-Func<Int32Enum, PathFinder.Point>.Invoke
	|
	|-RVA: 0x212CE70 Offset: 0x212B470 VA: 0x18212CE70
	|-Func<Int32Enum, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<Int32Enum, Resolution>.Invoke
	|
	|-RVA: 0x21310D0 Offset: 0x212F6D0 VA: 0x1821310D0
	|-Func<Int32Enum, Option>.Invoke
	|-Func<Int32Enum, InventoryItem>.Invoke
	|
	|-RVA: 0x212EAC0 Offset: 0x212D0C0 VA: 0x18212EAC0
	|-Func<Int32Enum, InventoryRecipe.Ingredient>.Invoke
	|-Func<Int32Enum, InventoryRecipe>.Invoke
	|
	|-RVA: 0x20C7940 Offset: 0x20C5F40 VA: 0x1820C7940
	|-Func<Int32Enum, long>.Invoke
	|
	|-RVA: 0x19FAD30 Offset: 0x19F9330 VA: 0x1819FAD30
	|-Func<long, long>.Invoke
	|-Func<IntPtr, object>.Invoke
	|-Func<ulong, ulong>.Invoke
	|
	|-RVA: 0x19F98F0 Offset: 0x19F7EF0 VA: 0x1819F98F0
	|-Func<object, Debugging.EntityInfo>.Invoke
	|-Func<object, PlayerItemRecipe>.Invoke
	|-Func<object, KeyValuePair<object, int>>.Invoke
	|-Func<object, DateTimeOffset>.Invoke
	|-Func<object, Guid>.Invoke
	|-Func<object, UdpReceiveResult>.Invoke
	|
	|-RVA: 0x1786310 Offset: 0x1784910 VA: 0x181786310
	|-Func<object, FourBitNumber>.Invoke
	|-Func<object, SevenBitNumber>.Invoke
	|
	|-RVA: 0x19FB7F0 Offset: 0x19F9DF0 VA: 0x1819FB7F0
	|-Func<object, PathFinder.Point>.Invoke
	|-Func<object, PlayerItemRecipe.Ingredient>.Invoke
	|-Func<object, DateTime>.Invoke
	|-Func<object, Nullable<int>>.Invoke
	|-Func<object, Nullable<Int32Enum>>.Invoke
	|
	|-RVA: 0x19F9E30 Offset: 0x19F8430 VA: 0x1819F9E30
	|-Func<object, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<object, Nullable<InventoryResult>>.Invoke
	|-Func<object, Resolution>.Invoke
	|
	|-RVA: 0x19F9460 Offset: 0x19F7A60 VA: 0x1819F9460
	|-Func<object, Option>.Invoke
	|-Func<object, InventoryItem>.Invoke
	|-Func<object, Nullable<InventoryPurchaseResult>>.Invoke
	|-Func<object, Nullable<ResultPage>>.Invoke
	|
	|-RVA: 0x19FA370 Offset: 0x19F8970 VA: 0x1819FA370
	|-Func<object, InventoryDefId>.Invoke
	|-Func<object, uint>.Invoke
	|
	|-RVA: 0x148C600 Offset: 0x148AC00 VA: 0x18148C600
	|-Func<object, InventoryItemId>.Invoke
	|
	|-RVA: 0x19FB030 Offset: 0x19F9630 VA: 0x1819FB030
	|-Func<object, InventoryRecipe.Ingredient>.Invoke
	|-Func<object, InventoryRecipe>.Invoke
	|-Func<object, PublishResult>.Invoke
	|-Func<object, Nullable<Image>>.Invoke
	|
	|-RVA: 0x19FA780 Offset: 0x19F8D80 VA: 0x1819FA780
	|-Func<object, int>.Invoke
	|-Func<object, Int32Enum>.Invoke
	|
	|-RVA: 0x1477D20 Offset: 0x1476320 VA: 0x181477D20
	|-Func<object, long>.Invoke
	|
	|-RVA: 0x19FC7D0 Offset: 0x19FADD0 VA: 0x1819FC7D0
	|-Func<object, Nullable<ServerInfo>>.Invoke
	|
	|-RVA: 0x19FD710 Offset: 0x19FBD10 VA: 0x1819FD710
	|-Func<object, Nullable<Item>>.Invoke
	|
	|-RVA: 0x19FE590 Offset: 0x19FCB90 VA: 0x1819FE590
	|-Func<object, VoidTaskResult>.Invoke
	|
	|-RVA: 0x133B8A0 Offset: 0x1339EA0 VA: 0x18133B8A0
	|-Func<object, ulong>.Invoke
	|
	|-RVA: 0x18A4A90 Offset: 0x18A3090 VA: 0x1818A4A90
	|-Func<float, bool>.Invoke
	|
	|-RVA: 0x19FC050 Offset: 0x19FA650 VA: 0x1819FC050
	|-Func<float, float>.Invoke
	|
	|-RVA: 0x19FAA40 Offset: 0x19F9040 VA: 0x1819FAA40
	|-Func<uint, uint>.Invoke
	|
	|-RVA: 0x19FD070 Offset: 0x19FB670 VA: 0x1819FD070
	|-Func<Resolution, int>.Invoke
	|
	|-RVA: 0x19FCCD0 Offset: 0x19FB2D0 VA: 0x1819FCCD0
	|-Func<Resolution, Vector2Int>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(T arg, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B8CB90 Offset: 0x1B8B190 VA: 0x181B8CB90
	|-Func<Admin.PlayerInfo, object>.BeginInvoke
	|
	|-RVA: 0x1B8B210 Offset: 0x1B89810 VA: 0x181B8B210
	|-Func<Admin.ServerConvarInfo, object>.BeginInvoke
	|
	|-RVA: 0x1B8B910 Offset: 0x1B89F10 VA: 0x181B8B910
	|-Func<Debugging.EntityInfo, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x1B8D190 Offset: 0x1B8B790 VA: 0x181B8D190
	|-Func<Debugging.EntityInfo, bool>.BeginInvoke
	|
	|-RVA: 0x1B8C290 Offset: 0x1B8A890 VA: 0x181B8C290
	|-Func<Entity.EntityInfo, bool>.BeginInvoke
	|
	|-RVA: 0x1B8C190 Offset: 0x1B8A790 VA: 0x181B8C190
	|-Func<Demos.DemoInfo, DateTime>.BeginInvoke
	|
	|-RVA: 0x1B8BD10 Offset: 0x1B8A310 VA: 0x181B8BD10
	|-Func<Demos.DemoInfo, object>.BeginInvoke
	|
	|-RVA: 0x1B8C210 Offset: 0x1B8A810 VA: 0x181B8C210
	|-Func<Demos.DemoInfo, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x1B8BF90 Offset: 0x1B8A590 VA: 0x181B8BF90
	|-Func<BurstCloth.Chain, FourBitNumber>.BeginInvoke
	|
	|-RVA: 0x1B8D590 Offset: 0x1B8BB90 VA: 0x181B8D590
	|-Func<BurstCloth.Chain, SevenBitNumber>.BeginInvoke
	|
	|-RVA: 0x1B8AF90 Offset: 0x1B89590 VA: 0x181B8AF90
	|-Func<BurstCloth.Chain, bool>.BeginInvoke
	|
	|-RVA: 0x1B8AD90 Offset: 0x1B89390 VA: 0x181B8AD90
	|-Func<BurstCloth.Chain, int>.BeginInvoke
	|
	|-RVA: 0x1B8B310 Offset: 0x1B89910 VA: 0x181B8B310
	|-Func<RCon.BannedAddresses, bool>.BeginInvoke
	|
	|-RVA: 0x1B8B890 Offset: 0x1B89E90 VA: 0x181B8B890
	|-Func<SkeletonDefinition.Bone, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x1B8BB90 Offset: 0x1B8A190 VA: 0x181B8BB90
	|-Func<SkeletonDefinition.Bone, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x1B8AD10 Offset: 0x1B89310 VA: 0x181B8AD10
	|-Func<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x1B8C910 Offset: 0x1B8AF10 VA: 0x181B8C910
	|-Func<SkeletonDefinition.Bone, Option>.BeginInvoke
	|
	|-RVA: 0x1B8C790 Offset: 0x1B8AD90 VA: 0x181B8C790
	|-Func<SkeletonDefinition.Bone, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x1B8CB10 Offset: 0x1B8B110 VA: 0x181B8CB10
	|-Func<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x1B8AB90 Offset: 0x1B89190 VA: 0x181B8AB90
	|-Func<SkeletonDefinition.Bone, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x1B8CA10 Offset: 0x1B8B010 VA: 0x181B8CA10
	|-Func<SkeletonDefinition.Bone, bool>.BeginInvoke
	|
	|-RVA: 0x1B8C090 Offset: 0x1B8A690 VA: 0x181B8C090
	|-Func<SkeletonDefinition.Bone, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x1B8B990 Offset: 0x1B89F90 VA: 0x181B8B990
	|-Func<SkeletonDefinition.Bone, int>.BeginInvoke
	|
	|-RVA: 0x1B8C710 Offset: 0x1B8AD10 VA: 0x181B8C710
	|-Func<SkeletonDefinition.Bone, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x1B8D010 Offset: 0x1B8B610 VA: 0x181B8D010
	|-Func<SkeletonDefinition.Bone, long>.BeginInvoke
	|
	|-RVA: 0x1B8BD90 Offset: 0x1B8A390 VA: 0x181B8BD90
	|-Func<SkeletonDefinition.Bone, object>.BeginInvoke
	|
	|-RVA: 0x1B8CE10 Offset: 0x1B8B410 VA: 0x181B8CE10
	|-Func<SkeletonDefinition.Bone, float>.BeginInvoke
	|
	|-RVA: 0x1B8BE90 Offset: 0x1B8A490 VA: 0x181B8BE90
	|-Func<SkeletonDefinition.Bone, Resolution>.BeginInvoke
	|
	|-RVA: 0x1B8A910 Offset: 0x1B88F10 VA: 0x181B8A910
	|-Func<WeightedStringList.Container, bool>.BeginInvoke
	|
	|-RVA: 0x1B8D410 Offset: 0x1B8BA10 VA: 0x181B8D410
	|-Func<WeightedStringList.Container, float>.BeginInvoke
	|
	|-RVA: 0x1B8A310 Offset: 0x1B88910 VA: 0x181B8A310
	|-Func<GameStat.Stat, bool>.BeginInvoke
	|
	|-RVA: 0x1B8A290 Offset: 0x1B88890 VA: 0x181B8A290
	|-Func<ImageStorageEntity.ImageRequest, object>.BeginInvoke
	|
	|-RVA: 0x1B8D210 Offset: 0x1B8B810 VA: 0x181B8D210
	|-Func<ItemSkinDirectory.Skin, bool>.BeginInvoke
	|
	|-RVA: 0x1B8B290 Offset: 0x1B89890 VA: 0x181B8B290
	|-Func<FourBitNumber, FourBitNumber>.BeginInvoke
	|
	|-RVA: 0x1B8B090 Offset: 0x1B89690 VA: 0x181B8B090
	|-Func<FourBitNumber, bool>.BeginInvoke
	|
	|-RVA: 0x1B8C810 Offset: 0x1B8AE10 VA: 0x181B8C810
	|-Func<SevenBitNumber, SevenBitNumber>.BeginInvoke
	|
	|-RVA: 0x1B8C590 Offset: 0x1B8AB90 VA: 0x181B8C590
	|-Func<SevenBitNumber, bool>.BeginInvoke
	|
	|-RVA: 0x1B8A890 Offset: 0x1B88E90 VA: 0x181B8A890
	|-Func<SevenBitNumber, object>.BeginInvoke
	|
	|-RVA: 0x1B8CE90 Offset: 0x1B8B490 VA: 0x181B8CE90
	|-Func<DefaultSerializationBinder.TypeNameKey, object>.BeginInvoke
	|
	|-RVA: 0x1B8AA90 Offset: 0x1B89090 VA: 0x181B8AA90
	|-Func<ConvertUtils.TypeConvertKey, object>.BeginInvoke
	|
	|-RVA: 0x1B8CF90 Offset: 0x1B8B590 VA: 0x181B8CF90
	|-Func<PathFinder.Point, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x1B8B410 Offset: 0x1B89A10 VA: 0x181B8B410
	|-Func<PathFinder.Point, bool>.BeginInvoke
	|
	|-RVA: 0x1B8B690 Offset: 0x1B89C90 VA: 0x181B8B690
	|-Func<PetCommandList.PetCommandDesc, bool>.BeginInvoke
	|
	|-RVA: 0x1B8A510 Offset: 0x1B88B10 VA: 0x181B8A510
	|-Func<PlayerItemRecipe, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x1B8A810 Offset: 0x1B88E10 VA: 0x181B8A810
	|-Func<PlayerItemRecipe, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x1B8B390 Offset: 0x1B89990 VA: 0x181B8B390
	|-Func<PlayerItemRecipe, PlayerItemRecipe>.BeginInvoke
	|
	|-RVA: 0x1B8A710 Offset: 0x1B88D10 VA: 0x181B8A710
	|-Func<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x1B8BA90 Offset: 0x1B8A090 VA: 0x181B8BA90
	|-Func<PlayerItemRecipe, Option>.BeginInvoke
	|
	|-RVA: 0x1B8CC90 Offset: 0x1B8B290 VA: 0x181B8CC90
	|-Func<PlayerItemRecipe, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x1B8AC90 Offset: 0x1B89290 VA: 0x181B8AC90
	|-Func<PlayerItemRecipe, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x1B8AA10 Offset: 0x1B89010 VA: 0x181B8AA10
	|-Func<PlayerItemRecipe, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x1B8B790 Offset: 0x1B89D90 VA: 0x181B8B790
	|-Func<PlayerItemRecipe, bool>.BeginInvoke
	|
	|-RVA: 0x1B8AB10 Offset: 0x1B89110 VA: 0x181B8AB10
	|-Func<PlayerItemRecipe, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x1B8C410 Offset: 0x1B8AA10 VA: 0x181B8C410
	|-Func<PlayerItemRecipe, int>.BeginInvoke
	|
	|-RVA: 0x1B8A790 Offset: 0x1B88D90 VA: 0x181B8A790
	|-Func<PlayerItemRecipe, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x1B8C110 Offset: 0x1B8A710 VA: 0x181B8C110
	|-Func<PlayerItemRecipe, long>.BeginInvoke
	|
	|-RVA: 0x1B8B510 Offset: 0x1B89B10 VA: 0x181B8B510
	|-Func<PlayerItemRecipe, object>.BeginInvoke
	|
	|-RVA: 0x1B8C490 Offset: 0x1B8AA90 VA: 0x181B8C490
	|-Func<PlayerItemRecipe, float>.BeginInvoke
	|
	|-RVA: 0x1B8A490 Offset: 0x1B88A90 VA: 0x181B8A490
	|-Func<PlayerItemRecipe, Resolution>.BeginInvoke
	|
	|-RVA: 0x1B8BC90 Offset: 0x1B8A290 VA: 0x181B8BC90
	|-Func<PlayerItemRecipe.Ingredient, FourBitNumber>.BeginInvoke
	|
	|-RVA: 0x1B8BA10 Offset: 0x1B8A010 VA: 0x181B8BA10
	|-Func<PlayerItemRecipe.Ingredient, SevenBitNumber>.BeginInvoke
	|
	|-RVA: 0x1B8AC10 Offset: 0x1B89210 VA: 0x181B8AC10
	|-Func<PlayerItemRecipe.Ingredient, PlayerItemRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x1B8CD90 Offset: 0x1B8B390 VA: 0x181B8CD90
	|-Func<PlayerItemRecipe.Ingredient, bool>.BeginInvoke
	|
	|-RVA: 0x1B8B190 Offset: 0x1B89790 VA: 0x181B8B190
	|-Func<PlayerItemRecipe.Ingredient, int>.BeginInvoke
	|
	|-RVA: 0x1B8BE10 Offset: 0x1B8A410 VA: 0x181B8BE10
	|-Func<ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x1B8A590 Offset: 0x1B88B90 VA: 0x181B8A590
	|-Func<ProjectileWeaponMod.Modifier, bool>.BeginInvoke
	|
	|-RVA: 0x1B8D090 Offset: 0x1B8B690 VA: 0x181B8D090
	|-Func<ProjectileWeaponMod.Modifier, float>.BeginInvoke
	|
	|-RVA: 0x1B8D110 Offset: 0x1B8B710 VA: 0x181B8D110
	|-Func<Option, Option>.BeginInvoke
	|
	|-RVA: 0x1B8D510 Offset: 0x1B8BB10 VA: 0x181B8D510
	|-Func<Option, bool>.BeginInvoke
	|
	|-RVA: 0x1B8B710 Offset: 0x1B89D10 VA: 0x181B8B710
	|-Func<ServerInfo, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x1B8AE90 Offset: 0x1B89490 VA: 0x181B8AE90
	|-Func<ServerInfo, FourBitNumber>.BeginInvoke
	|
	|-RVA: 0x1B8BB10 Offset: 0x1B8A110 VA: 0x181B8BB10
	|-Func<ServerInfo, SevenBitNumber>.BeginInvoke
	|
	|-RVA: 0x1B8B010 Offset: 0x1B89610 VA: 0x181B8B010
	|-Func<ServerInfo, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x1B8AE10 Offset: 0x1B89410 VA: 0x181B8AE10
	|-Func<ServerInfo, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x1B8A410 Offset: 0x1B88A10 VA: 0x181B8A410
	|-Func<ServerInfo, Option>.BeginInvoke
	|
	|-RVA: 0x1B8C610 Offset: 0x1B8AC10 VA: 0x181B8C610
	|-Func<ServerInfo, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x1B8B490 Offset: 0x1B89A90 VA: 0x181B8B490
	|-Func<ServerInfo, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x1B8A390 Offset: 0x1B88990 VA: 0x181B8A390
	|-Func<ServerInfo, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x1B8CF10 Offset: 0x1B8B510 VA: 0x181B8CF10
	|-Func<ServerInfo, bool>.BeginInvoke
	|
	|-RVA: 0x1B8C010 Offset: 0x1B8A610 VA: 0x181B8C010
	|-Func<ServerInfo, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x1B8CD10 Offset: 0x1B8B310 VA: 0x181B8CD10
	|-Func<ServerInfo, int>.BeginInvoke
	|
	|-RVA: 0x1B8C690 Offset: 0x1B8AC90 VA: 0x181B8C690
	|-Func<ServerInfo, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x1B8BF10 Offset: 0x1B8A510 VA: 0x181B8BF10
	|-Func<ServerInfo, long>.BeginInvoke
	|
	|-RVA: 0x1B8C890 Offset: 0x1B8AE90 VA: 0x181B8C890
	|-Func<ServerInfo, object>.BeginInvoke
	|
	|-RVA: 0x1B8AF10 Offset: 0x1B89510 VA: 0x181B8AF10
	|-Func<ServerInfo, float>.BeginInvoke
	|
	|-RVA: 0x1B8BC10 Offset: 0x1B8A210 VA: 0x181B8BC10
	|-Func<ServerInfo, uint>.BeginInvoke
	|
	|-RVA: 0x1B8A690 Offset: 0x1B88C90 VA: 0x181B8A690
	|-Func<ServerInfo, Resolution>.BeginInvoke
	|
	|-RVA: 0x1B8C990 Offset: 0x1B8AF90 VA: 0x181B8C990
	|-Func<SkinnedMultiMesh.Part, bool>.BeginInvoke
	|
	|-RVA: 0x1B8C390 Offset: 0x1B8A990 VA: 0x181B8C390
	|-Func<SkinnedMultiMesh.Part, long>.BeginInvoke
	|
	|-RVA: 0x1B8D490 Offset: 0x1B8BA90 VA: 0x181B8D490
	|-Func<Achievement, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x1B8CC10 Offset: 0x1B8B210 VA: 0x181B8CC10
	|-Func<Achievement, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x1B8B590 Offset: 0x1B89B90 VA: 0x181B8B590
	|-Func<Achievement, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x1B8A990 Offset: 0x1B88F90 VA: 0x181B8A990
	|-Func<Achievement, Option>.BeginInvoke
	|
	|-RVA: 0x1B8C510 Offset: 0x1B8AB10 VA: 0x181B8C510
	|-Func<Achievement, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x1B8B610 Offset: 0x1B89C10 VA: 0x181B8B610
	|-Func<Achievement, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x1B8D290 Offset: 0x1B8B890 VA: 0x181B8D290
	|-Func<Achievement, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x1B8A610 Offset: 0x1B88C10 VA: 0x181B8A610
	|-Func<Achievement, bool>.BeginInvoke
	|
	|-RVA: 0x1B8D310 Offset: 0x1B8B910 VA: 0x181B8D310
	|-Func<Achievement, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x1B8B810 Offset: 0x1B89E10 VA: 0x181B8B810
	|-Func<Achievement, int>.BeginInvoke
	|
	|-RVA: 0x1B8C310 Offset: 0x1B8A910 VA: 0x181B8C310
	|-Func<Achievement, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x1B8CA90 Offset: 0x1B8B090 VA: 0x181B8CA90
	|-Func<Achievement, long>.BeginInvoke
	|
	|-RVA: 0x1B8A210 Offset: 0x1B88810 VA: 0x181B8A210
	|-Func<Achievement, object>.BeginInvoke
	|
	|-RVA: 0x1B8B110 Offset: 0x1B89710 VA: 0x181B8B110
	|-Func<Achievement, float>.BeginInvoke
	|
	|-RVA: 0x1B8D390 Offset: 0x1B8B990 VA: 0x181B8D390
	|-Func<Achievement, Resolution>.BeginInvoke
	|
	|-RVA: 0x21277A0 Offset: 0x2125DA0 VA: 0x1821277A0
	|-Func<InventoryDefId, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x2129320 Offset: 0x2127920 VA: 0x182129320
	|-Func<InventoryDefId, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x2126CA0 Offset: 0x21252A0 VA: 0x182126CA0
	|-Func<InventoryDefId, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x2128EA0 Offset: 0x21274A0 VA: 0x182128EA0
	|-Func<InventoryDefId, Option>.BeginInvoke
	|
	|-RVA: 0x2128B20 Offset: 0x2127120 VA: 0x182128B20
	|-Func<InventoryDefId, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x212AE20 Offset: 0x2129420 VA: 0x18212AE20
	|-Func<InventoryDefId, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x2126C20 Offset: 0x2125220 VA: 0x182126C20
	|-Func<InventoryDefId, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x2129CA0 Offset: 0x21282A0 VA: 0x182129CA0
	|-Func<InventoryDefId, bool>.BeginInvoke
	|
	|-RVA: 0x212A520 Offset: 0x2128B20 VA: 0x18212A520
	|-Func<InventoryDefId, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x2126AA0 Offset: 0x21250A0 VA: 0x182126AA0
	|-Func<InventoryDefId, int>.BeginInvoke
	|
	|-RVA: 0x212A120 Offset: 0x2128720 VA: 0x18212A120
	|-Func<InventoryDefId, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x2128420 Offset: 0x2126A20 VA: 0x182128420
	|-Func<InventoryDefId, long>.BeginInvoke
	|
	|-RVA: 0x212AD20 Offset: 0x2129320 VA: 0x18212AD20
	|-Func<InventoryDefId, object>.BeginInvoke
	|
	|-RVA: 0x21274A0 Offset: 0x2125AA0 VA: 0x1821274A0
	|-Func<InventoryDefId, float>.BeginInvoke
	|
	|-RVA: 0x2128C20 Offset: 0x2127220 VA: 0x182128C20
	|-Func<InventoryDefId, Resolution>.BeginInvoke
	|
	|-RVA: 0x2128220 Offset: 0x2126820 VA: 0x182128220
	|-Func<InventoryItemId, InventoryItemId>.BeginInvoke
	|
	|-RVA: 0x2127720 Offset: 0x2125D20 VA: 0x182127720
	|-Func<InventoryItemId, bool>.BeginInvoke
	|
	|-RVA: 0x212A0A0 Offset: 0x21286A0 VA: 0x18212A0A0
	|-Func<ServerInfo, ServerInfo>.BeginInvoke
	|
	|-RVA: 0x212B3A0 Offset: 0x21299A0 VA: 0x18212B3A0
	|-Func<ServerInfo, bool>.BeginInvoke
	|
	|-RVA: 0x21289A0 Offset: 0x2126FA0 VA: 0x1821289A0
	|-Func<ServerInfo, int>.BeginInvoke
	|
	|-RVA: 0x2127120 Offset: 0x2125720 VA: 0x182127120
	|-Func<ServerInfo, object>.BeginInvoke
	|
	|-RVA: 0x212B520 Offset: 0x2129B20 VA: 0x18212B520
	|-Func<Friend, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x21290A0 Offset: 0x21276A0 VA: 0x1821290A0
	|-Func<Friend, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x21280A0 Offset: 0x21266A0 VA: 0x1821280A0
	|-Func<Friend, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x212AB20 Offset: 0x2129120 VA: 0x18212AB20
	|-Func<Friend, Option>.BeginInvoke
	|
	|-RVA: 0x212A6A0 Offset: 0x2128CA0 VA: 0x18212A6A0
	|-Func<Friend, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x21270A0 Offset: 0x21256A0 VA: 0x1821270A0
	|-Func<Friend, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x21278A0 Offset: 0x2125EA0 VA: 0x1821278A0
	|-Func<Friend, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x212ACA0 Offset: 0x21292A0 VA: 0x18212ACA0
	|-Func<Friend, bool>.BeginInvoke
	|
	|-RVA: 0x212A5A0 Offset: 0x2128BA0 VA: 0x18212A5A0
	|-Func<Friend, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x2129920 Offset: 0x2127F20 VA: 0x182129920
	|-Func<Friend, int>.BeginInvoke
	|
	|-RVA: 0x212A220 Offset: 0x2128820 VA: 0x18212A220
	|-Func<Friend, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x212ABA0 Offset: 0x21291A0 VA: 0x18212ABA0
	|-Func<Friend, long>.BeginInvoke
	|
	|-RVA: 0x21294A0 Offset: 0x2127AA0 VA: 0x1821294A0
	|-Func<Friend, object>.BeginInvoke
	|
	|-RVA: 0x2129220 Offset: 0x2127820 VA: 0x182129220
	|-Func<Friend, float>.BeginInvoke
	|
	|-RVA: 0x2128FA0 Offset: 0x21275A0 VA: 0x182128FA0
	|-Func<Friend, Resolution>.BeginInvoke
	|
	|-RVA: 0x2127BA0 Offset: 0x21261A0 VA: 0x182127BA0
	|-Func<InventoryItem, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x212B0A0 Offset: 0x21296A0 VA: 0x18212B0A0
	|-Func<InventoryItem, FourBitNumber>.BeginInvoke
	|
	|-RVA: 0x212ADA0 Offset: 0x21293A0 VA: 0x18212ADA0
	|-Func<InventoryItem, SevenBitNumber>.BeginInvoke
	|
	|-RVA: 0x21283A0 Offset: 0x21269A0 VA: 0x1821283A0
	|-Func<InventoryItem, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x212A020 Offset: 0x2128620 VA: 0x18212A020
	|-Func<InventoryItem, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x2129120 Offset: 0x2127720 VA: 0x182129120
	|-Func<InventoryItem, Option>.BeginInvoke
	|
	|-RVA: 0x2129BA0 Offset: 0x21281A0 VA: 0x182129BA0
	|-Func<InventoryItem, InventoryDefId>.BeginInvoke
	|
	|-RVA: 0x2127020 Offset: 0x2125620 VA: 0x182127020
	|-Func<InventoryItem, InventoryItemId>.BeginInvoke
	|
	|-RVA: 0x212B020 Offset: 0x2129620 VA: 0x18212B020
	|-Func<InventoryItem, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x212A3A0 Offset: 0x21289A0 VA: 0x18212A3A0
	|-Func<InventoryItem, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x2127820 Offset: 0x2125E20 VA: 0x182127820
	|-Func<InventoryItem, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x2128720 Offset: 0x2126D20 VA: 0x182128720
	|-Func<InventoryItem, bool>.BeginInvoke
	|
	|-RVA: 0x2128120 Offset: 0x2126720 VA: 0x182128120
	|-Func<InventoryItem, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x21292A0 Offset: 0x21278A0 VA: 0x1821292A0
	|-Func<InventoryItem, int>.BeginInvoke
	|
	|-RVA: 0x212A1A0 Offset: 0x21287A0 VA: 0x18212A1A0
	|-Func<InventoryItem, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x2127DA0 Offset: 0x21263A0 VA: 0x182127DA0
	|-Func<InventoryItem, long>.BeginInvoke
	|
	|-RVA: 0x2128F20 Offset: 0x2127520 VA: 0x182128F20
	|-Func<InventoryItem, object>.BeginInvoke
	|
	|-RVA: 0x2127520 Offset: 0x2125B20 VA: 0x182127520
	|-Func<InventoryItem, float>.BeginInvoke
	|
	|-RVA: 0x212A8A0 Offset: 0x2128EA0 VA: 0x18212A8A0
	|-Func<InventoryItem, uint>.BeginInvoke
	|
	|-RVA: 0x21297A0 Offset: 0x2127DA0 VA: 0x1821297A0
	|-Func<InventoryItem, Resolution>.BeginInvoke
	|
	|-RVA: 0x2129F20 Offset: 0x2128520 VA: 0x182129F20
	|-Func<InventoryItem.Amount, InventoryItemId>.BeginInvoke
	|
	|-RVA: 0x21285A0 Offset: 0x2126BA0 VA: 0x1821285A0
	|-Func<InventoryItem.Amount, bool>.BeginInvoke
	|
	|-RVA: 0x212AAA0 Offset: 0x21290A0 VA: 0x18212AAA0
	|-Func<InventoryItem.Amount, uint>.BeginInvoke
	|
	|-RVA: 0x2128320 Offset: 0x2126920 VA: 0x182128320
	|-Func<InventoryRecipe, PlayerItemRecipe>.BeginInvoke
	|
	|-RVA: 0x2126EA0 Offset: 0x21254A0 VA: 0x182126EA0
	|-Func<InventoryRecipe, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x2127CA0 Offset: 0x21262A0 VA: 0x182127CA0
	|-Func<InventoryRecipe, bool>.BeginInvoke
	|
	|-RVA: 0x2127D20 Offset: 0x2126320 VA: 0x182127D20
	|-Func<InventoryRecipe, object>.BeginInvoke
	|
	|-RVA: 0x2128620 Offset: 0x2126C20 VA: 0x182128620
	|-Func<InventoryRecipe.Ingredient, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x21279A0 Offset: 0x2125FA0 VA: 0x1821279A0
	|-Func<InventoryRecipe.Ingredient, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x2128D20 Offset: 0x2127320 VA: 0x182128D20
	|-Func<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x2127F20 Offset: 0x2126520 VA: 0x182127F20
	|-Func<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x2126F20 Offset: 0x2125520 VA: 0x182126F20
	|-Func<InventoryRecipe.Ingredient, Option>.BeginInvoke
	|
	|-RVA: 0x2129520 Offset: 0x2127B20 VA: 0x182129520
	|-Func<InventoryRecipe.Ingredient, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x212A7A0 Offset: 0x2128DA0 VA: 0x18212A7A0
	|-Func<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x21271A0 Offset: 0x21257A0 VA: 0x1821271A0
	|-Func<InventoryRecipe.Ingredient, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x2127420 Offset: 0x2125A20 VA: 0x182127420
	|-Func<InventoryRecipe.Ingredient, bool>.BeginInvoke
	|
	|-RVA: 0x2129020 Offset: 0x2127620 VA: 0x182129020
	|-Func<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x2126FA0 Offset: 0x21255A0 VA: 0x182126FA0
	|-Func<InventoryRecipe.Ingredient, int>.BeginInvoke
	|
	|-RVA: 0x21293A0 Offset: 0x21279A0 VA: 0x1821293A0
	|-Func<InventoryRecipe.Ingredient, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x2129B20 Offset: 0x2128120 VA: 0x182129B20
	|-Func<InventoryRecipe.Ingredient, long>.BeginInvoke
	|
	|-RVA: 0x2129D20 Offset: 0x2128320 VA: 0x182129D20
	|-Func<InventoryRecipe.Ingredient, object>.BeginInvoke
	|
	|-RVA: 0x2129620 Offset: 0x2127C20 VA: 0x182129620
	|-Func<InventoryRecipe.Ingredient, float>.BeginInvoke
	|
	|-RVA: 0x2126DA0 Offset: 0x21253A0 VA: 0x182126DA0
	|-Func<InventoryRecipe.Ingredient, Resolution>.BeginInvoke
	|
	|-RVA: 0x2127E20 Offset: 0x2126420 VA: 0x182127E20
	|-Func<Item, DateTime>.BeginInvoke
	|
	|-RVA: 0x212AEA0 Offset: 0x21294A0 VA: 0x18212AEA0
	|-Func<ArraySegment<byte>, object>.BeginInvoke
	|
	|-RVA: 0x2129720 Offset: 0x2127D20 VA: 0x182129720
	|-Func<bool, bool>.BeginInvoke
	|
	|-RVA: 0x21298A0 Offset: 0x2127EA0 VA: 0x1821298A0
	|-Func<char, bool>.BeginInvoke
	|
	|-RVA: 0x21287A0 Offset: 0x2126DA0 VA: 0x1821287A0
	|-Func<DictionaryEntry, bool>.BeginInvoke
	|
	|-RVA: 0x212A2A0 Offset: 0x21288A0 VA: 0x18212A2A0
	|-Func<DictionaryEntry, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x2129820 Offset: 0x2127E20 VA: 0x182129820
	|-Func<DictionaryEntry, object>.BeginInvoke
	|
	|-RVA: 0x212B320 Offset: 0x2129920 VA: 0x18212B320
	|-Func<KeyValuePair<object, int>, bool>.BeginInvoke
	|
	|-RVA: 0x2129EA0 Offset: 0x21284A0 VA: 0x182129EA0
	|-Func<KeyValuePair<object, int>, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x2128AA0 Offset: 0x21270A0 VA: 0x182128AA0
	|-Func<KeyValuePair<object, int>, int>.BeginInvoke
	|
	|-RVA: 0x2128CA0 Offset: 0x21272A0 VA: 0x182128CA0
	|-Func<KeyValuePair<object, long>, long>.BeginInvoke
	|
	|-RVA: 0x2126D20 Offset: 0x2125320 VA: 0x182126D20
	|-Func<KeyValuePair<object, object>, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x2128BA0 Offset: 0x21271A0 VA: 0x182128BA0
	|-Func<KeyValuePair<object, object>, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x21282A0 Offset: 0x21268A0 VA: 0x1821282A0
	|-Func<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x21275A0 Offset: 0x2125BA0 VA: 0x1821275A0
	|-Func<KeyValuePair<object, object>, Option>.BeginInvoke
	|
	|-RVA: 0x212A9A0 Offset: 0x2128FA0 VA: 0x18212A9A0
	|-Func<KeyValuePair<object, object>, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x21296A0 Offset: 0x2127CA0 VA: 0x1821296A0
	|-Func<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x212A820 Offset: 0x2128E20 VA: 0x18212A820
	|-Func<KeyValuePair<object, object>, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x2129DA0 Offset: 0x21283A0 VA: 0x182129DA0
	|-Func<KeyValuePair<object, object>, bool>.BeginInvoke
	|
	|-RVA: 0x2128520 Offset: 0x2126B20 VA: 0x182128520
	|-Func<KeyValuePair<object, object>, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x21272A0 Offset: 0x21258A0 VA: 0x1821272A0
	|-Func<KeyValuePair<object, object>, int>.BeginInvoke
	|
	|-RVA: 0x212B120 Offset: 0x2129720 VA: 0x18212B120
	|-Func<KeyValuePair<object, object>, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x2128820 Offset: 0x2126E20 VA: 0x182128820
	|-Func<KeyValuePair<object, object>, long>.BeginInvoke
	|
	|-RVA: 0x2126B20 Offset: 0x2125120 VA: 0x182126B20
	|-Func<KeyValuePair<object, object>, object>.BeginInvoke
	|
	|-RVA: 0x212B220 Offset: 0x2129820 VA: 0x18212B220
	|-Func<KeyValuePair<object, object>, float>.BeginInvoke
	|
	|-RVA: 0x2127220 Offset: 0x2125820 VA: 0x182127220
	|-Func<KeyValuePair<object, object>, Resolution>.BeginInvoke
	|
	|-RVA: 0x212A720 Offset: 0x2128D20 VA: 0x18212A720
	|-Func<KeyValuePair<uint, object>, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x2127EA0 Offset: 0x21264A0 VA: 0x182127EA0
	|-Func<KeyValuePair<uint, object>, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x212B1A0 Offset: 0x21297A0 VA: 0x18212B1A0
	|-Func<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x212A320 Offset: 0x2128920 VA: 0x18212A320
	|-Func<KeyValuePair<uint, object>, Option>.BeginInvoke
	|
	|-RVA: 0x2128A20 Offset: 0x2127020 VA: 0x182128A20
	|-Func<KeyValuePair<uint, object>, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x212B5A0 Offset: 0x2129BA0 VA: 0x18212B5A0
	|-Func<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x2129420 Offset: 0x2127A20 VA: 0x182129420
	|-Func<KeyValuePair<uint, object>, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x212B2A0 Offset: 0x21298A0 VA: 0x18212B2A0
	|-Func<KeyValuePair<uint, object>, bool>.BeginInvoke
	|
	|-RVA: 0x212AFA0 Offset: 0x21295A0 VA: 0x18212AFA0
	|-Func<KeyValuePair<uint, object>, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x212A620 Offset: 0x2128C20 VA: 0x18212A620
	|-Func<KeyValuePair<uint, object>, int>.BeginInvoke
	|
	|-RVA: 0x2127320 Offset: 0x2125920 VA: 0x182127320
	|-Func<KeyValuePair<uint, object>, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x21299A0 Offset: 0x2127FA0 VA: 0x1821299A0
	|-Func<KeyValuePair<uint, object>, long>.BeginInvoke
	|
	|-RVA: 0x2129A20 Offset: 0x2128020 VA: 0x182129A20
	|-Func<KeyValuePair<uint, object>, object>.BeginInvoke
	|
	|-RVA: 0x2127A20 Offset: 0x2126020 VA: 0x182127A20
	|-Func<KeyValuePair<uint, object>, float>.BeginInvoke
	|
	|-RVA: 0x21281A0 Offset: 0x21267A0 VA: 0x1821281A0
	|-Func<KeyValuePair<uint, object>, uint>.BeginInvoke
	|
	|-RVA: 0x212AC20 Offset: 0x2129220 VA: 0x18212AC20
	|-Func<KeyValuePair<uint, object>, Resolution>.BeginInvoke
	|
	|-RVA: 0x2126BA0 Offset: 0x21251A0 VA: 0x182126BA0
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, Dispatch.ResultCallback>.BeginInvoke
	|
	|-RVA: 0x212A920 Offset: 0x2128F20 VA: 0x18212A920
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, bool>.BeginInvoke
	|
	|-RVA: 0x2126E20 Offset: 0x2125420 VA: 0x182126E20
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, ulong>.BeginInvoke
	|
	|-RVA: 0x2128E20 Offset: 0x2127420 VA: 0x182128E20
	|-Func<double, double>.BeginInvoke
	|
	|-RVA: 0x2127620 Offset: 0x2125C20 VA: 0x182127620
	|-Func<Guid, int>.BeginInvoke
	|
	|-RVA: 0x2128DA0 Offset: 0x21273A0 VA: 0x182128DA0
	|-Func<Guid, object>.BeginInvoke
	|
	|-RVA: 0x21273A0 Offset: 0x21259A0 VA: 0x1821273A0
	|-Func<int, FourBitNumber>.BeginInvoke
	|
	|-RVA: 0x2127AA0 Offset: 0x21260A0 VA: 0x182127AA0
	|-Func<int, SevenBitNumber>.BeginInvoke
	|
	|-RVA: 0x2127920 Offset: 0x2125F20 VA: 0x182127920
	|-Func<int, bool>.BeginInvoke
	|
	|-RVA: 0x2129AA0 Offset: 0x21280A0 VA: 0x182129AA0
	|-Func<int, int>.BeginInvoke
	|
	|-RVA: 0x21284A0 Offset: 0x2126AA0 VA: 0x1821284A0
	|-Func<int, object>.BeginInvoke
	|
	|-RVA: 0x212AF20 Offset: 0x2129520 VA: 0x18212AF20
	|-Func<int, float>.BeginInvoke
	|
	|-RVA: 0x2127C20 Offset: 0x2126220 VA: 0x182127C20
	|-Func<Int32Enum, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x2127B20 Offset: 0x2126120 VA: 0x182127B20
	|-Func<Int32Enum, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x212A420 Offset: 0x2128A20 VA: 0x18212A420
	|-Func<Int32Enum, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x212AA20 Offset: 0x2129020 VA: 0x18212AA20
	|-Func<Int32Enum, Option>.BeginInvoke
	|
	|-RVA: 0x2128920 Offset: 0x2126F20 VA: 0x182128920
	|-Func<Int32Enum, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x21276A0 Offset: 0x2125CA0 VA: 0x1821276A0
	|-Func<Int32Enum, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x21286A0 Offset: 0x2126CA0 VA: 0x1821286A0
	|-Func<Int32Enum, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x21295A0 Offset: 0x2127BA0 VA: 0x1821295A0
	|-Func<Int32Enum, bool>.BeginInvoke
	|
	|-RVA: 0x2127FA0 Offset: 0x21265A0 VA: 0x182127FA0
	|-Func<Int32Enum, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x2129C20 Offset: 0x2128220 VA: 0x182129C20
	|-Func<Int32Enum, int>.BeginInvoke
	|
	|-RVA: 0x2129E20 Offset: 0x2128420 VA: 0x182129E20
	|-Func<Int32Enum, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x212A4A0 Offset: 0x2128AA0 VA: 0x18212A4A0
	|-Func<Int32Enum, long>.BeginInvoke
	|
	|-RVA: 0x2128020 Offset: 0x2126620 VA: 0x182128020
	|-Func<Int32Enum, object>.BeginInvoke
	|
	|-RVA: 0x212B4A0 Offset: 0x2129AA0 VA: 0x18212B4A0
	|-Func<Int32Enum, float>.BeginInvoke
	|
	|-RVA: 0x21291A0 Offset: 0x21277A0 VA: 0x1821291A0
	|-Func<Int32Enum, Resolution>.BeginInvoke
	|
	|-RVA: 0x2129FA0 Offset: 0x21285A0 VA: 0x182129FA0
	|-Func<long, bool>.BeginInvoke
	|
	|-RVA: 0x21288A0 Offset: 0x2126EA0 VA: 0x1821288A0
	|-Func<long, long>.BeginInvoke
	|
	|-RVA: 0x212B420 Offset: 0x2129A20 VA: 0x18212B420
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
	|-RVA: 0x19F9010 Offset: 0x19F7610 VA: 0x1819F9010
	|-Func<float, bool>.BeginInvoke
	|
	|-RVA: 0x19F8F10 Offset: 0x19F7510 VA: 0x1819F8F10
	|-Func<float, float>.BeginInvoke
	|
	|-RVA: 0x19F8D10 Offset: 0x19F7310 VA: 0x1819F8D10
	|-Func<uint, bool>.BeginInvoke
	|
	|-RVA: 0x19F8D90 Offset: 0x19F7390 VA: 0x1819F8D90
	|-Func<uint, uint>.BeginInvoke
	|
	|-RVA: 0x19F9190 Offset: 0x19F7790 VA: 0x1819F9190
	|-Func<ulong, bool>.BeginInvoke
	|
	|-RVA: 0x19F8F90 Offset: 0x19F7590 VA: 0x1819F8F90
	|-Func<ulong, ulong>.BeginInvoke
	|
	|-RVA: 0x19F8E10 Offset: 0x19F7410 VA: 0x1819F8E10
	|-Func<ValueTuple<Int32Enum, int>, object>.BeginInvoke
	|
	|-RVA: 0x19F9210 Offset: 0x19F7810 VA: 0x1819F9210
	|-Func<Resolution, bool>.BeginInvoke
	|
	|-RVA: 0x19F9090 Offset: 0x19F7690 VA: 0x1819F9090
	|-Func<Resolution, int>.BeginInvoke
	|
	|-RVA: 0x19F9110 Offset: 0x19F7710 VA: 0x1819F9110
	|-Func<Resolution, Resolution>.BeginInvoke
	|
	|-RVA: 0x19F8E90 Offset: 0x19F7490 VA: 0x1819F8E90
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
	|-RVA: 0x1220D40 Offset: 0x121F340 VA: 0x181220D40
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
	|-RVA: 0xFF6510 Offset: 0xFF4B10 VA: 0x180FF6510
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
	|-RVA: 0x1221690 Offset: 0x121FC90 VA: 0x181221690
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
	|-RVA: 0xB9A9D0 Offset: 0xB98FD0 VA: 0x180B9A9D0
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
	|-RVA: 0x198A9D0 Offset: 0x1988FD0 VA: 0x18198A9D0
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
	|-RVA: 0x19F9300 Offset: 0x19F7900 VA: 0x1819F9300
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
	|-RVA: 0x19F9420 Offset: 0x19F7A20 VA: 0x1819F9420
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
	|-RVA: 0x19F9340 Offset: 0x19F7940 VA: 0x1819F9340
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
	|-RVA: 0x212B620 Offset: 0x2129C20 VA: 0x18212B620
	|-Func<ServerInfo, ServerInfo>.EndInvoke
	|
	|-RVA: 0x212B690 Offset: 0x2129C90 VA: 0x18212B690
	|-Func<double, double>.EndInvoke
	|
	|-RVA: 0x19F9290 Offset: 0x19F7890 VA: 0x1819F9290
	|-Func<object, Nullable<ServerInfo>>.EndInvoke
	|
	|-RVA: 0x19F9370 Offset: 0x19F7970 VA: 0x1819F9370
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
	|-RVA: 0xD59A50 Offset: 0xD58050 VA: 0x180D59A50
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

	// RVA: 0x2353B0 Offset: 0x2347B0 VA: 0x1802353B0
	internal void .ctor(string str, DateTimeFormatInfo dtfi, bool checkDigitToken) { }

	// RVA: 0x235490 Offset: 0x234890 VA: 0x180235490
	internal void .ctor(string str, DateTimeFormatInfo dtfi) { }

	// RVA: 0xF3EF0 Offset: 0xF32F0 VA: 0x1800F3EF0
	internal CompareInfo get_CompareInfo() { }

	// RVA: 0x234960 Offset: 0x233D60 VA: 0x180234960
	internal bool GetNext() { }

	// RVA: 0x234810 Offset: 0x233C10 VA: 0x180234810
	internal bool AtEnd() { }

	// RVA: 0x2347D0 Offset: 0x233BD0 VA: 0x1802347D0
	internal bool Advance(int count) { }

	// RVA: 0x2349A0 Offset: 0x233DA0 VA: 0x1802349A0
	internal void GetRegularToken(out TokenType tokenType, out int tokenValue, DateTimeFormatInfo dtfi) { }

	// RVA: 0x234A30 Offset: 0x233E30 VA: 0x180234A30
	internal TokenType GetSeparatorToken(DateTimeFormatInfo dtfi, out int indexBeforeSeparator, out char charBeforeSeparator) { }

	// RVA: 0x234DF0 Offset: 0x2341F0 VA: 0x180234DF0
	internal bool MatchSpecifiedWord(string target) { }

	// RVA: 0x234D70 Offset: 0x234170 VA: 0x180234D70
	internal bool MatchSpecifiedWord(string target, int endIndex) { }

	// RVA: 0x234E70 Offset: 0x234270 VA: 0x180234E70
	internal bool MatchSpecifiedWords(string target, bool checkWordBoundary, ref int matchLength) { }

	// RVA: 0x234E80 Offset: 0x234280 VA: 0x180234E80
	internal bool Match(string str) { }

	// RVA: 0x234F30 Offset: 0x234330 VA: 0x180234F30
	internal bool Match(char ch) { }

	// RVA: 0x234CC0 Offset: 0x2340C0 VA: 0x180234CC0
	internal int MatchLongestWords(string[] words, ref int maxMatchStrLen) { }

	// RVA: 0x2349B0 Offset: 0x233DB0 VA: 0x1802349B0
	internal int GetRepeatCount() { }

	// RVA: 0x2348E0 Offset: 0x233CE0 VA: 0x1802348E0
	internal bool GetNextDigit() { }

	// RVA: 0x234880 Offset: 0x233C80 VA: 0x180234880
	internal char GetChar() { }

	// RVA: 0x2348B0 Offset: 0x233CB0 VA: 0x1802348B0
	internal int GetDigit() { }

	// RVA: 0x235230 Offset: 0x234630 VA: 0x180235230
	internal void SkipWhiteSpaces() { }

	// RVA: 0x235220 Offset: 0x234620 VA: 0x180235220
	internal bool SkipWhiteSpaceCurrent() { }

	// RVA: 0x2352D0 Offset: 0x2346D0 VA: 0x1802352D0
	internal void TrimTail() { }

	// RVA: 0x2350B0 Offset: 0x2344B0 VA: 0x1802350B0
	internal void RemoveTrailingInQuoteSpaces() { }

	// RVA: 0x234F90 Offset: 0x234390 VA: 0x180234F90
	internal void RemoveLeadingInQuoteSpaces() { }

	// RVA: 0x234B40 Offset: 0x233F40 VA: 0x180234B40
	internal DTSubString GetSubString() { }

	// RVA: 0x234820 Offset: 0x233C20 VA: 0x180234820
	internal void ConsumeSubString(DTSubString sub) { }

	// RVA: 0x214C2B0 Offset: 0x214A8B0 VA: 0x18214C2B0
	private static void .cctor() { }

}

internal class __ComObject // TypeDefIndex: 429
{	// Methods

	// RVA: 0x214B050 Offset: 0x2149650 VA: 0x18214B050
	private void .ctor() { }

}

internal static class __Error // TypeDefIndex: 615
{	// Methods

	// RVA: 0x16873F0 Offset: 0x16859F0 VA: 0x1816873F0
	internal static void EndOfFile() { }

	// RVA: 0x1687540 Offset: 0x1685B40 VA: 0x181687540
	internal static void FileNotOpen() { }

	// RVA: 0x1687860 Offset: 0x1685E60 VA: 0x181687860
	internal static void StreamIsClosed() { }

	// RVA: 0x1687710 Offset: 0x1685D10 VA: 0x181687710
	internal static void MemoryStreamNotExpandable() { }

	// RVA: 0x16877F0 Offset: 0x1685DF0 VA: 0x1816877F0
	internal static void ReaderClosed() { }

	// RVA: 0x1687780 Offset: 0x1685D80 VA: 0x181687780
	internal static void ReadNotSupported() { }

	// RVA: 0x1688080 Offset: 0x1686680 VA: 0x181688080
	internal static void WrongAsyncResult() { }

	// RVA: 0x1687460 Offset: 0x1685A60 VA: 0x181687460
	internal static void EndReadCalledTwice() { }

	// RVA: 0x16874D0 Offset: 0x1685AD0 VA: 0x1816874D0
	internal static void EndWriteCalledTwice() { }

	// RVA: 0x16875B0 Offset: 0x1685BB0 VA: 0x1816875B0
	internal static string GetDisplayablePath(string path, bool isInvalidPath) { }

	// RVA: 0x16878D0 Offset: 0x1685ED0 VA: 0x1816878D0
	internal static void WinIOError(int errorCode, string maybeFullPath) { }

	// RVA: 0x1687FA0 Offset: 0x16865A0 VA: 0x181687FA0
	internal static void WriteNotSupported() { }

	// RVA: 0x1688010 Offset: 0x1686610 VA: 0x181688010
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
	|-RVA: 0x19E36F0 Offset: 0x19E1CF0 VA: 0x1819E36F0
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
	|-RVA: 0x1A028A0 Offset: 0x1A00EA0 VA: 0x181A028A0
	|-Iterator<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected virtual void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E24B0 Offset: 0x19E0AB0 VA: 0x1819E24B0
	|-Iterator<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<TSource> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E2570 Offset: 0x19E0B70 VA: 0x1819E2570
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
	|-RVA: 0x1356160 Offset: 0x1354760 VA: 0x181356160
	|-Iterator<object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F2390 Offset: 0x17F0990 VA: 0x1817F2390
	|-Iterator<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A02920 Offset: 0x1A00F20 VA: 0x181A02920
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
	|-RVA: 0xD5B020 Offset: 0xD59620 VA: 0x180D5B020
	|-SearchResultHandler<object>..ctor
	|-SearchResultHandler<string>..ctor
	*/

}

internal static class _ThreadPoolWaitCallback // TypeDefIndex: 814
{	// Methods

	// RVA: 0x161EAD0 Offset: 0x161D0D0 VA: 0x18161EAD0
	internal static bool PerformWaitCallback() { }

}

public class Task<TResult> : Task // TypeDefIndex: 842
{	// Fields
	internal TResult m_result; // 0x0
	private static readonly TaskFactory<TResult> s_Factory; // 0x0
	internal static readonly Func<Task<Task>, Task<TResult>> TaskWhenAnyCast; // 0x0

	// Properties
	[DebuggerBrowsableAttribute] // RVA: 0x9E9D0 Offset: 0x9DDD0 VA: 0x18009E9D0
	public TResult Result { get; }
	internal TResult ResultOnSuccess { get; }
	public static TaskFactory<TResult> Factory { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AAB630 Offset: 0x1AA9C30 VA: 0x181AAB630
	|-Task<PublishResult>..ctor
	|
	|-RVA: 0x1AA9850 Offset: 0x1AA7E50 VA: 0x181AA9850
	|-Task<bool>..ctor
	|
	|-RVA: 0x1AA9FB0 Offset: 0x1AA85B0 VA: 0x181AA9FB0
	|-Task<int>..ctor
	|
	|-RVA: 0x1AA9B50 Offset: 0x1AA8150 VA: 0x181AA9B50
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0x1AAA330 Offset: 0x1AA8930 VA: 0x181AAA330
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x1AA94E0 Offset: 0x1AA7AE0 VA: 0x181AA94E0
	|-Task<Nullable<Image>>..ctor
	|
	|-RVA: 0x1AAA9C0 Offset: 0x1AA8FC0 VA: 0x181AAA9C0
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1AAB300 Offset: 0x1AA9900 VA: 0x181AAB300
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1AA98B0 Offset: 0x1AA7EB0 VA: 0x181AA98B0
	|-Task<Nullable<Item>>..ctor
	|
	|-RVA: 0x1AA97F0 Offset: 0x1AA7DF0 VA: 0x181AA97F0
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1A57500 Offset: 0x1A55B00 VA: 0x181A57500
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x1A56CE0 Offset: 0x1A552E0 VA: 0x181A56CE0
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x1A56840 Offset: 0x1A54E40 VA: 0x181A56840
	|-Task<object>..ctor
	|-Task<Task>..ctor
	|
	|-RVA: 0x1A56D40 Offset: 0x1A55340 VA: 0x181A56D40
	|-Task<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(object state, TaskCreationOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AAA390 Offset: 0x1AA8990 VA: 0x181AAA390
	|-Task<PublishResult>..ctor
	|
	|-RVA: 0x1AAA500 Offset: 0x1AA8B00 VA: 0x181AAA500
	|-Task<bool>..ctor
	|
	|-RVA: 0x1AAB3F0 Offset: 0x1AA99F0 VA: 0x181AAB3F0
	|-Task<int>..ctor
	|
	|-RVA: 0x1AAB5A0 Offset: 0x1AA9BA0 VA: 0x181AAB5A0
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0x1AA9200 Offset: 0x1AA7800 VA: 0x181AA9200
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x1AA9AC0 Offset: 0x1AA80C0 VA: 0x181AA9AC0
	|-Task<Nullable<Image>>..ctor
	|
	|-RVA: 0x1AA96D0 Offset: 0x1AA7CD0 VA: 0x181AA96D0
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1AA9760 Offset: 0x1AA7D60 VA: 0x181AA9760
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1AA8140 Offset: 0x1AA6740 VA: 0x181AA8140
	|-Task<Nullable<Item>>..ctor
	|
	|-RVA: 0x1AA8610 Offset: 0x1AA6C10 VA: 0x181AA8610
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1A56C50 Offset: 0x1A55250 VA: 0x181A56C50
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x1A56EC0 Offset: 0x1A554C0 VA: 0x181A56EC0
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x1A57350 Offset: 0x1A55950 VA: 0x181A57350
	|-Task<object>..ctor
	|
	|-RVA: 0x1A57600 Offset: 0x1A55C00 VA: 0x181A57600
	|-Task<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AA8FA0 Offset: 0x1AA75A0 VA: 0x181AA8FA0
	|-Task<PublishResult>..ctor
	|
	|-RVA: 0x1AA7A20 Offset: 0x1AA6020 VA: 0x181AA7A20
	|-Task<bool>..ctor
	|
	|-RVA: 0x1AA81D0 Offset: 0x1AA67D0 VA: 0x181AA81D0
	|-Task<int>..ctor
	|
	|-RVA: 0x1AAB360 Offset: 0x1AA9960 VA: 0x181AAB360
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0x1AAAA20 Offset: 0x1AA9020 VA: 0x181AAAA20
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x1AAA920 Offset: 0x1AA8F20 VA: 0x181AAA920
	|-Task<Nullable<Image>>..ctor
	|
	|-RVA: 0x1AA9910 Offset: 0x1AA7F10 VA: 0x181AA9910
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1AA9450 Offset: 0x1AA7A50 VA: 0x181AA9450
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1AAAB00 Offset: 0x1AA9100 VA: 0x181AAAB00
	|-Task<Nullable<Item>>..ctor
	|
	|-RVA: 0x1AA8580 Offset: 0x1AA6B80 VA: 0x181AA8580
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1A57070 Offset: 0x1A55670 VA: 0x181A57070
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x1A55F50 Offset: 0x1A54550 VA: 0x181A55F50
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x1A569C0 Offset: 0x1A54FC0 VA: 0x181A569C0
	|-Task<object>..ctor
	|
	|-RVA: 0x1A567C0 Offset: 0x1A54DC0 VA: 0x181A567C0
	|-Task<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(bool canceled, TResult result, TaskCreationOptions creationOptions, CancellationToken ct) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AAB690 Offset: 0x1AA9C90 VA: 0x181AAB690
	|-Task<PublishResult>..ctor
	|
	|-RVA: 0x1AA86A0 Offset: 0x1AA6CA0 VA: 0x181AA86A0
	|-Task<bool>..ctor
	|
	|-RVA: 0x1AA7AA0 Offset: 0x1AA60A0 VA: 0x181AA7AA0
	|-Task<int>..ctor
	|
	|-RVA: 0x1AAA870 Offset: 0x1AA8E70 VA: 0x181AAA870
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0x1AA8940 Offset: 0x1AA6F40 VA: 0x181AA8940
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x1AA8DC0 Offset: 0x1AA73C0 VA: 0x181AA8DC0
	|-Task<Nullable<Image>>..ctor
	|
	|-RVA: 0x1AA9620 Offset: 0x1AA7C20 VA: 0x181AA9620
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1AAB250 Offset: 0x1AA9850 VA: 0x181AAB250
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1AA8250 Offset: 0x1AA6850 VA: 0x181AA8250
	|-Task<Nullable<Item>>..ctor
	|
	|-RVA: 0x1AA9150 Offset: 0x1AA7750 VA: 0x181AA9150
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1A570F0 Offset: 0x1A556F0 VA: 0x181A570F0
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x1A55FD0 Offset: 0x1A545D0 VA: 0x181A55FD0
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x1A56470 Offset: 0x1A54A70 VA: 0x181A56470
	|-Task<object>..ctor
	|
	|-RVA: 0x1A57560 Offset: 0x1A55B60 VA: 0x181A57560
	|-Task<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AAA6B0 Offset: 0x1AA8CB0 VA: 0x181AAA6B0
	|-Task<PublishResult>..ctor
	|
	|-RVA: 0x1AAA790 Offset: 0x1AA8D90 VA: 0x181AAA790
	|-Task<bool>..ctor
	|
	|-RVA: 0x1AA7EA0 Offset: 0x1AA64A0 VA: 0x181AA7EA0
	|-Task<int>..ctor
	|
	|-RVA: 0x1AA7F80 Offset: 0x1AA6580 VA: 0x181AA7F80
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0x1AA8060 Offset: 0x1AA6660 VA: 0x181AA8060
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x1AA8B20 Offset: 0x1AA7120 VA: 0x181AA8B20
	|-Task<Nullable<Image>>..ctor
	|
	|-RVA: 0x1AA9ED0 Offset: 0x1AA84D0 VA: 0x181AA9ED0
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1AA8740 Offset: 0x1AA6D40 VA: 0x181AA8740
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1AA8380 Offset: 0x1AA6980 VA: 0x181AA8380
	|-Task<Nullable<Item>>..ctor
	|
	|-RVA: 0x1AAA420 Offset: 0x1AA8A20 VA: 0x181AAA420
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1A56B70 Offset: 0x1A55170 VA: 0x181A56B70
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x1A56190 Offset: 0x1A54790 VA: 0x181A56190
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x1A56520 Offset: 0x1A54B20 VA: 0x181A56520
	|-Task<object>..ctor
	|
	|-RVA: 0x1A56270 Offset: 0x1A54870 VA: 0x181A56270
	|-Task<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AA9370 Offset: 0x1AA7970 VA: 0x181AA9370
	|-Task<PublishResult>..ctor
	|
	|-RVA: 0x1AAB170 Offset: 0x1AA9770 VA: 0x181AAB170
	|-Task<bool>..ctor
	|
	|-RVA: 0x1AAA130 Offset: 0x1AA8730 VA: 0x181AAA130
	|-Task<int>..ctor
	|
	|-RVA: 0x1AA9CD0 Offset: 0x1AA82D0 VA: 0x181AA9CD0
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0x1AA9290 Offset: 0x1AA7890 VA: 0x181AA9290
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x1AA9540 Offset: 0x1AA7B40 VA: 0x181AA9540
	|-Task<Nullable<Image>>..ctor
	|
	|-RVA: 0x1AA8A40 Offset: 0x1AA7040 VA: 0x181AA8A40
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1AA8C00 Offset: 0x1AA7200 VA: 0x181AA8C00
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1AAB090 Offset: 0x1AA9690 VA: 0x181AAB090
	|-Task<Nullable<Item>>..ctor
	|
	|-RVA: 0x1AA8CE0 Offset: 0x1AA72E0 VA: 0x181AA8CE0
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1A566E0 Offset: 0x1A54CE0 VA: 0x181A566E0
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x1A57190 Offset: 0x1A55790 VA: 0x181A57190
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x1A57270 Offset: 0x1A55870 VA: 0x181A57270
	|-Task<object>..ctor
	|
	|-RVA: 0x1A56600 Offset: 0x1A54C00 VA: 0x181A56600
	|-Task<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AAB480 Offset: 0x1AA9A80 VA: 0x181AAB480
	|-Task<PublishResult>..ctor
	|
	|-RVA: 0x1AAAC10 Offset: 0x1AA9210 VA: 0x181AAAC10
	|-Task<bool>..ctor
	|
	|-RVA: 0x1AA7B40 Offset: 0x1AA6140 VA: 0x181AA7B40
	|-Task<int>..ctor
	|
	|-RVA: 0x1AAAF70 Offset: 0x1AA9570 VA: 0x181AAAF70
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0x1AA8820 Offset: 0x1AA6E20 VA: 0x181AA8820
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x1AA7C60 Offset: 0x1AA6260 VA: 0x181AA7C60
	|-Task<Nullable<Image>>..ctor
	|
	|-RVA: 0x1AA9DB0 Offset: 0x1AA83B0 VA: 0x181AA9DB0
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1AA7900 Offset: 0x1AA5F00 VA: 0x181AA7900
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1AA7D80 Offset: 0x1AA6380 VA: 0x181AA7D80
	|-Task<Nullable<Item>>..ctor
	|
	|-RVA: 0x1AAB740 Offset: 0x1AA9D40 VA: 0x181AAB740
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1A56A50 Offset: 0x1A55050 VA: 0x181A56A50
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x1A57690 Offset: 0x1A55C90 VA: 0x181A57690
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x1A573E0 Offset: 0x1A559E0 VA: 0x181A573E0
	|-Task<object>..ctor
	|
	|-RVA: 0x1A56F50 Offset: 0x1A55550 VA: 0x181A56F50
	|-Task<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Delegate valueSelector, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AA8E80 Offset: 0x1AA7480 VA: 0x181AA8E80
	|-Task<PublishResult>..ctor
	|
	|-RVA: 0x1AA99A0 Offset: 0x1AA7FA0 VA: 0x181AA99A0
	|-Task<bool>..ctor
	|
	|-RVA: 0x1AA9030 Offset: 0x1AA7630 VA: 0x181AA9030
	|-Task<int>..ctor
	|
	|-RVA: 0x1AAAD30 Offset: 0x1AA9330 VA: 0x181AAAD30
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0x1AA8460 Offset: 0x1AA6A60 VA: 0x181AA8460
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x1AAAE50 Offset: 0x1AA9450 VA: 0x181AAAE50
	|-Task<Nullable<Image>>..ctor
	|
	|-RVA: 0x1AAA010 Offset: 0x1AA8610 VA: 0x181AAA010
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1AAA210 Offset: 0x1AA8810 VA: 0x181AAA210
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1AAA590 Offset: 0x1AA8B90 VA: 0x181AAA590
	|-Task<Nullable<Item>>..ctor
	|
	|-RVA: 0x1AA9BB0 Offset: 0x1AA81B0 VA: 0x181AA9BB0
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1A56070 Offset: 0x1A54670 VA: 0x181A56070
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x1A568A0 Offset: 0x1A54EA0 VA: 0x181A568A0
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x1A56350 Offset: 0x1A54950 VA: 0x181A56350
	|-Task<object>..ctor
	|
	|-RVA: 0x1A56DA0 Offset: 0x1A553A0 VA: 0x181A56DA0
	|-Task<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> StartNew(Task parent, Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AA6FE0 Offset: 0x1AA55E0 VA: 0x181AA6FE0
	|-Task<PublishResult>.StartNew
	|
	|-RVA: 0x1AA6260 Offset: 0x1AA4860 VA: 0x181AA6260
	|-Task<bool>.StartNew
	|
	|-RVA: 0x1AA6020 Offset: 0x1AA4620 VA: 0x181AA6020
	|-Task<int>.StartNew
	|
	|-RVA: 0x1AA66E0 Offset: 0x1AA4CE0 VA: 0x181AA66E0
	|-Task<UdpReceiveResult>.StartNew
	|
	|-RVA: 0x1AA64A0 Offset: 0x1AA4AA0 VA: 0x181AA64A0
	|-Task<Nullable<ServerInfo>>.StartNew
	|
	|-RVA: 0x1AA6DA0 Offset: 0x1AA53A0 VA: 0x181AA6DA0
	|-Task<Nullable<Image>>.StartNew
	|
	|-RVA: 0x1AA5DE0 Offset: 0x1AA43E0 VA: 0x181AA5DE0
	|-Task<Nullable<InventoryPurchaseResult>>.StartNew
	|
	|-RVA: 0x1AA5BA0 Offset: 0x1AA41A0 VA: 0x181AA5BA0
	|-Task<Nullable<InventoryResult>>.StartNew
	|
	|-RVA: 0x1AA6B60 Offset: 0x1AA5160 VA: 0x181AA6B60
	|-Task<Nullable<Item>>.StartNew
	|
	|-RVA: 0x1AA6920 Offset: 0x1AA4F20 VA: 0x181AA6920
	|-Task<Nullable<ResultPage>>.StartNew
	|
	|-RVA: 0x1A556C0 Offset: 0x1A53CC0 VA: 0x181A556C0
	|-Task<Nullable<int>>.StartNew
	|
	|-RVA: 0x1A55000 Offset: 0x1A53600 VA: 0x181A55000
	|-Task<Nullable<Int32Enum>>.StartNew
	|
	|-RVA: 0x1A55240 Offset: 0x1A53840 VA: 0x181A55240
	|-Task<object>.StartNew
	|
	|-RVA: 0x1A55480 Offset: 0x1A53A80 VA: 0x181A55480
	|-Task<VoidTaskResult>.StartNew
	*/

	// RVA: -1 Offset: -1
	internal bool TrySetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AA7840 Offset: 0x1AA5E40 VA: 0x181AA7840
	|-Task<PublishResult>.TrySetResult
	|
	|-RVA: 0x1A55BA0 Offset: 0x1A541A0 VA: 0x181A55BA0
	|-Task<bool>.TrySetResult
	|-Task<VoidTaskResult>.TrySetResult
	|
	|-RVA: 0x1AA7220 Offset: 0x1AA5820 VA: 0x181AA7220
	|-Task<int>.TrySetResult
	|
	|-RVA: 0x1AA7390 Offset: 0x1AA5990 VA: 0x181AA7390
	|-Task<UdpReceiveResult>.TrySetResult
	|
	|-RVA: 0x1AA75A0 Offset: 0x1AA5BA0 VA: 0x181AA75A0
	|-Task<Nullable<ServerInfo>>.TrySetResult
	|
	|-RVA: 0x1AA76B0 Offset: 0x1AA5CB0 VA: 0x181AA76B0
	|-Task<Nullable<Image>>.TrySetResult
	|
	|-RVA: 0x1AA72D0 Offset: 0x1AA58D0 VA: 0x181AA72D0
	|-Task<Nullable<InventoryPurchaseResult>>.TrySetResult
	|-Task<Nullable<ResultPage>>.TrySetResult
	|
	|-RVA: 0x1AA7780 Offset: 0x1AA5D80 VA: 0x181AA7780
	|-Task<Nullable<InventoryResult>>.TrySetResult
	|
	|-RVA: 0x1AA7450 Offset: 0x1AA5A50 VA: 0x181AA7450
	|-Task<Nullable<Item>>.TrySetResult
	|
	|-RVA: 0x1A55A30 Offset: 0x1A54030 VA: 0x181A55A30
	|-Task<Nullable<int>>.TrySetResult
	|-Task<Nullable<Int32Enum>>.TrySetResult
	|
	|-RVA: 0x1A55AE0 Offset: 0x1A540E0 VA: 0x181A55AE0
	|-Task<object>.TrySetResult
	|-Task<Task>.TrySetResult
	*/

	// RVA: -1 Offset: -1
	internal void DangerousSetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AA4D60 Offset: 0x1AA3360 VA: 0x181AA4D60
	|-Task<PublishResult>.DangerousSetResult
	|
	|-RVA: 0x1A54B30 Offset: 0x1A53130 VA: 0x181A54B30
	|-Task<bool>.DangerousSetResult
	|-Task<VoidTaskResult>.DangerousSetResult
	|
	|-RVA: 0x1AA4B10 Offset: 0x1AA3110 VA: 0x181AA4B10
	|-Task<int>.DangerousSetResult
	|
	|-RVA: 0x1AA4B70 Offset: 0x1AA3170 VA: 0x181AA4B70
	|-Task<UdpReceiveResult>.DangerousSetResult
	|
	|-RVA: 0x1AA4C50 Offset: 0x1AA3250 VA: 0x181AA4C50
	|-Task<Nullable<ServerInfo>>.DangerousSetResult
	|
	|-RVA: 0x1AA4DE0 Offset: 0x1AA33E0 VA: 0x181AA4DE0
	|-Task<Nullable<Image>>.DangerousSetResult
	|
	|-RVA: 0x1AA4BE0 Offset: 0x1AA31E0 VA: 0x181AA4BE0
	|-Task<Nullable<InventoryPurchaseResult>>.DangerousSetResult
	|-Task<Nullable<ResultPage>>.DangerousSetResult
	|
	|-RVA: 0x1AA4AA0 Offset: 0x1AA30A0 VA: 0x181AA4AA0
	|-Task<Nullable<InventoryResult>>.DangerousSetResult
	|
	|-RVA: 0x1AA4920 Offset: 0x1AA2F20 VA: 0x181AA4920
	|-Task<Nullable<Item>>.DangerousSetResult
	|
	|-RVA: 0x1A54B90 Offset: 0x1A53190 VA: 0x181A54B90
	|-Task<Nullable<int>>.DangerousSetResult
	|-Task<Nullable<Int32Enum>>.DangerousSetResult
	|
	|-RVA: 0x1A54BF0 Offset: 0x1A531F0 VA: 0x181A54BF0
	|-Task<object>.DangerousSetResult
	*/

	// RVA: -1 Offset: -1
	public TResult get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A577B0 Offset: 0x1A55DB0 VA: 0x181A577B0
	|-Task<ISocket>.get_Result
	|-Task<SteamInventoryCrafting.MarketPrice>.get_Result
	|-Task<Nullable<int>>.get_Result
	|-Task<Nullable<Int32Enum>>.get_Result
	|-Task<object>.get_Result
	|-Task<Task>.get_Result
	|
	|-RVA: 0x1AABD60 Offset: 0x1AAA360 VA: 0x181AABD60
	|-Task<PublishResult>.get_Result
	|-Task<Nullable<Image>>.get_Result
	|
	|-RVA: 0x1A57820 Offset: 0x1A55E20 VA: 0x181A57820
	|-Task<bool>.get_Result
	|-Task<VoidTaskResult>.get_Result
	|
	|-RVA: 0x1AABCF0 Offset: 0x1AAA2F0 VA: 0x181AABCF0
	|-Task<int>.get_Result
	|
	|-RVA: 0x1AABBD0 Offset: 0x1AAA1D0 VA: 0x181AABBD0
	|-Task<UdpReceiveResult>.get_Result
	|
	|-RVA: 0x1AABE00 Offset: 0x1AAA400 VA: 0x181AABE00
	|-Task<Nullable<ServerInfo>>.get_Result
	|
	|-RVA: 0x1AABC60 Offset: 0x1AAA260 VA: 0x181AABC60
	|-Task<Nullable<InventoryPurchaseResult>>.get_Result
	|-Task<Nullable<ResultPage>>.get_Result
	|
	|-RVA: 0x1AAB9C0 Offset: 0x1AA9FC0 VA: 0x181AAB9C0
	|-Task<Nullable<InventoryResult>>.get_Result
	|
	|-RVA: 0x1AABA60 Offset: 0x1AAA060 VA: 0x181AABA60
	|-Task<Nullable<Item>>.get_Result
	*/

	// RVA: -1 Offset: -1
	internal TResult get_ResultOnSuccess() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AAB880 Offset: 0x1AA9E80 VA: 0x181AAB880
	|-Task<PublishResult>.get_ResultOnSuccess
	|-Task<Nullable<Image>>.get_ResultOnSuccess
	|
	|-RVA: 0x77B1F0 Offset: 0x7797F0 VA: 0x18077B1F0
	|-Task<bool>.get_ResultOnSuccess
	|-Task<VoidTaskResult>.get_ResultOnSuccess
	|
	|-RVA: 0x8D9010 Offset: 0x8D7610 VA: 0x1808D9010
	|-Task<int>.get_ResultOnSuccess
	|
	|-RVA: 0x105E060 Offset: 0x105C660 VA: 0x18105E060
	|-Task<UdpReceiveResult>.get_ResultOnSuccess
	|
	|-RVA: 0x1AAB960 Offset: 0x1AA9F60 VA: 0x181AAB960
	|-Task<Nullable<ServerInfo>>.get_ResultOnSuccess
	|
	|-RVA: 0x1AAB940 Offset: 0x1AA9F40 VA: 0x181AAB940
	|-Task<Nullable<InventoryPurchaseResult>>.get_ResultOnSuccess
	|-Task<Nullable<ResultPage>>.get_ResultOnSuccess
	|
	|-RVA: 0x1AAB860 Offset: 0x1AA9E60 VA: 0x181AAB860
	|-Task<Nullable<InventoryResult>>.get_ResultOnSuccess
	|
	|-RVA: 0x1AAB8A0 Offset: 0x1AA9EA0 VA: 0x181AAB8A0
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
	|-RVA: 0x1AA4E60 Offset: 0x1AA3460 VA: 0x181AA4E60
	|-Task<PublishResult>.GetResultCore
	|-Task<Nullable<Image>>.GetResultCore
	|
	|-RVA: 0x1A54C80 Offset: 0x1A53280 VA: 0x181A54C80
	|-Task<bool>.GetResultCore
	|-Task<VoidTaskResult>.GetResultCore
	|
	|-RVA: 0x1AA5190 Offset: 0x1AA3790 VA: 0x181AA5190
	|-Task<int>.GetResultCore
	|
	|-RVA: 0x1AA5100 Offset: 0x1AA3700 VA: 0x181AA5100
	|-Task<UdpReceiveResult>.GetResultCore
	|
	|-RVA: 0x1AA5020 Offset: 0x1AA3620 VA: 0x181AA5020
	|-Task<Nullable<ServerInfo>>.GetResultCore
	|
	|-RVA: 0x1AA4F00 Offset: 0x1AA3500 VA: 0x181AA4F00
	|-Task<Nullable<InventoryPurchaseResult>>.GetResultCore
	|-Task<Nullable<ResultPage>>.GetResultCore
	|
	|-RVA: 0x1AA4F90 Offset: 0x1AA3590 VA: 0x181AA4F90
	|-Task<Nullable<InventoryResult>>.GetResultCore
	|
	|-RVA: 0x1AA5200 Offset: 0x1AA3800 VA: 0x181AA5200
	|-Task<Nullable<Item>>.GetResultCore
	|
	|-RVA: 0x1A54D00 Offset: 0x1A53300 VA: 0x181A54D00
	|-Task<Nullable<int>>.GetResultCore
	|-Task<Nullable<Int32Enum>>.GetResultCore
	|-Task<object>.GetResultCore
	*/

	// RVA: -1 Offset: -1
	internal bool TrySetException(object exceptionObject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A559B0 Offset: 0x1A53FB0 VA: 0x181A559B0
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
	|-RVA: 0x1A55900 Offset: 0x1A53F00 VA: 0x181A55900
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
	|-RVA: 0x1A55930 Offset: 0x1A53F30 VA: 0x181A55930
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
	|-RVA: 0x117DD70 Offset: 0x117C370 VA: 0x18117DD70
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
	|-RVA: 0x1AA5AB0 Offset: 0x1AA40B0 VA: 0x181AA5AB0
	|-Task<PublishResult>.InnerInvoke
	|
	|-RVA: 0x1A54F30 Offset: 0x1A53530 VA: 0x181A54F30
	|-Task<bool>.InnerInvoke
	|-Task<VoidTaskResult>.InnerInvoke
	|
	|-RVA: 0x1AA55D0 Offset: 0x1AA3BD0 VA: 0x181AA55D0
	|-Task<int>.InnerInvoke
	|
	|-RVA: 0x1AA59C0 Offset: 0x1AA3FC0 VA: 0x181AA59C0
	|-Task<UdpReceiveResult>.InnerInvoke
	|
	|-RVA: 0x1AA5790 Offset: 0x1AA3D90 VA: 0x181AA5790
	|-Task<Nullable<ServerInfo>>.InnerInvoke
	|
	|-RVA: 0x1AA5310 Offset: 0x1AA3910 VA: 0x181AA5310
	|-Task<Nullable<Image>>.InnerInvoke
	|
	|-RVA: 0x1AA56A0 Offset: 0x1AA3CA0 VA: 0x181AA56A0
	|-Task<Nullable<InventoryPurchaseResult>>.InnerInvoke
	|-Task<Nullable<ResultPage>>.InnerInvoke
	|
	|-RVA: 0x1AA58D0 Offset: 0x1AA3ED0 VA: 0x181AA58D0
	|-Task<Nullable<InventoryResult>>.InnerInvoke
	|
	|-RVA: 0x1AA5400 Offset: 0x1AA3A00 VA: 0x181AA5400
	|-Task<Nullable<Item>>.InnerInvoke
	|
	|-RVA: 0x1A54D80 Offset: 0x1A53380 VA: 0x181A54D80
	|-Task<Nullable<int>>.InnerInvoke
	|-Task<Nullable<Int32Enum>>.InnerInvoke
	|
	|-RVA: 0x1A54E50 Offset: 0x1A53450 VA: 0x181A54E50
	|-Task<object>.InnerInvoke
	|-Task<Task>.InnerInvoke
	*/

	// RVA: -1 Offset: -1
	public TaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A54C50 Offset: 0x1A53250 VA: 0x181A54C50
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
	|-RVA: 0x1A54040 Offset: 0x1A52640 VA: 0x181A54040
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
	|-RVA: 0x1A54700 Offset: 0x1A52D00 VA: 0x181A54700
	|-Task<ISocket>.ContinueWith
	|-Task<object>.ContinueWith
	|
	|-RVA: 0x1AA3590 Offset: 0x1AA1B90 VA: 0x181AA3590
	|-Task<PublishResult>.ContinueWith
	|
	|-RVA: 0x1AA3C70 Offset: 0x1AA2270 VA: 0x181AA3C70
	|-Task<bool>.ContinueWith
	|
	|-RVA: 0x1AA3BB0 Offset: 0x1AA21B0 VA: 0x181AA3BB0
	|-Task<int>.ContinueWith
	|
	|-RVA: 0x1AA3650 Offset: 0x1AA1C50 VA: 0x181AA3650
	|-Task<UdpReceiveResult>.ContinueWith
	|
	|-RVA: 0x1AA3AF0 Offset: 0x1AA20F0 VA: 0x181AA3AF0
	|-Task<Nullable<ServerInfo>>.ContinueWith
	|
	|-RVA: 0x1AA2F00 Offset: 0x1AA1500 VA: 0x181AA2F00
	|-Task<Nullable<Image>>.ContinueWith
	|
	|-RVA: 0x1AA45B0 Offset: 0x1AA2BB0 VA: 0x181AA45B0
	|-Task<Nullable<InventoryPurchaseResult>>.ContinueWith
	|
	|-RVA: 0x1AA4300 Offset: 0x1AA2900 VA: 0x181AA4300
	|-Task<Nullable<InventoryResult>>.ContinueWith
	|
	|-RVA: 0x1AA4860 Offset: 0x1AA2E60 VA: 0x181AA4860
	|-Task<Nullable<Item>>.ContinueWith
	|
	|-RVA: 0x1AA2E40 Offset: 0x1AA1440 VA: 0x181AA2E40
	|-Task<Nullable<ResultPage>>.ContinueWith
	|
	|-RVA: 0x1A549B0 Offset: 0x1A52FB0 VA: 0x181A549B0
	|-Task<Nullable<int>>.ContinueWith
	|
	|-RVA: 0x1A54450 Offset: 0x1A52A50 VA: 0x181A54450
	|-Task<Nullable<Int32Enum>>.ContinueWith
	|
	|-RVA: 0x1A54A70 Offset: 0x1A53070 VA: 0x181A54A70
	|-Task<VoidTaskResult>.ContinueWith
	*/

	// RVA: -1 Offset: -1
	internal Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AA3D30 Offset: 0x1AA2330 VA: 0x181AA3D30
	|-Task<PublishResult>.ContinueWith
	|
	|-RVA: 0x1AA4670 Offset: 0x1AA2C70 VA: 0x181AA4670
	|-Task<bool>.ContinueWith
	|
	|-RVA: 0x1AA33A0 Offset: 0x1AA19A0 VA: 0x181AA33A0
	|-Task<int>.ContinueWith
	|
	|-RVA: 0x1AA31B0 Offset: 0x1AA17B0 VA: 0x181AA31B0
	|-Task<UdpReceiveResult>.ContinueWith
	|
	|-RVA: 0x1AA3710 Offset: 0x1AA1D10 VA: 0x181AA3710
	|-Task<Nullable<ServerInfo>>.ContinueWith
	|
	|-RVA: 0x1AA2FC0 Offset: 0x1AA15C0 VA: 0x181AA2FC0
	|-Task<Nullable<Image>>.ContinueWith
	|
	|-RVA: 0x1AA3900 Offset: 0x1AA1F00 VA: 0x181AA3900
	|-Task<Nullable<InventoryPurchaseResult>>.ContinueWith
	|
	|-RVA: 0x1AA4110 Offset: 0x1AA2710 VA: 0x181AA4110
	|-Task<Nullable<InventoryResult>>.ContinueWith
	|
	|-RVA: 0x1AA43C0 Offset: 0x1AA29C0 VA: 0x181AA43C0
	|-Task<Nullable<Item>>.ContinueWith
	|
	|-RVA: 0x1AA3F20 Offset: 0x1AA2520 VA: 0x181AA3F20
	|-Task<Nullable<ResultPage>>.ContinueWith
	|
	|-RVA: 0x1A54510 Offset: 0x1A52B10 VA: 0x181A54510
	|-Task<Nullable<int>>.ContinueWith
	|
	|-RVA: 0x1A54070 Offset: 0x1A52670 VA: 0x181A54070
	|-Task<Nullable<Int32Enum>>.ContinueWith
	|
	|-RVA: 0x1A54260 Offset: 0x1A52860 VA: 0x181A54260
	|-Task<object>.ContinueWith
	|
	|-RVA: 0x1A547C0 Offset: 0x1A52DC0 VA: 0x181A547C0
	|-Task<VoidTaskResult>.ContinueWith
	*/

	// RVA: -1 Offset: -1
	public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED9240 Offset: 0xED7840 VA: 0x180ED9240
	|-Task<Dictionary<string, string>>.ContinueWith<Task<Dictionary<string, string>>>
	|-Task<object>.ContinueWith<object>
	*/

	// RVA: -1 Offset: -1
	internal Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED92F0 Offset: 0xED78F0 VA: 0x180ED92F0
	|-Task<object>.ContinueWith<object>
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A55C50 Offset: 0x1A54250 VA: 0x181A55C50
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
	|-RVA: 0x1AA2E00 Offset: 0x1AA1400 VA: 0x181AA2E00
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
	|-RVA: 0x1AA2D80 Offset: 0x1AA1380 VA: 0x181AA2D80
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
	|-RVA: 0x1AA2840 Offset: 0x1AA0E40 VA: 0x181AA2840
	|-TaskFactory<PublishResult>.StartNew
	|
	|-RVA: 0x1AA21B0 Offset: 0x1AA07B0 VA: 0x181AA21B0
	|-TaskFactory<bool>.StartNew
	|
	|-RVA: 0x1AA2060 Offset: 0x1AA0660 VA: 0x181AA2060
	|-TaskFactory<int>.StartNew
	|
	|-RVA: 0x1AA1DC0 Offset: 0x1AA03C0 VA: 0x181AA1DC0
	|-TaskFactory<UdpReceiveResult>.StartNew
	|
	|-RVA: 0x1AA2990 Offset: 0x1AA0F90 VA: 0x181AA2990
	|-TaskFactory<Nullable<ServerInfo>>.StartNew
	|
	|-RVA: 0x1AA2AE0 Offset: 0x1AA10E0 VA: 0x181AA2AE0
	|-TaskFactory<Nullable<Image>>.StartNew
	|
	|-RVA: 0x1AA1C70 Offset: 0x1AA0270 VA: 0x181AA1C70
	|-TaskFactory<Nullable<InventoryPurchaseResult>>.StartNew
	|
	|-RVA: 0x1AA26F0 Offset: 0x1AA0CF0 VA: 0x181AA26F0
	|-TaskFactory<Nullable<InventoryResult>>.StartNew
	|
	|-RVA: 0x1AA25A0 Offset: 0x1AA0BA0 VA: 0x181AA25A0
	|-TaskFactory<Nullable<Item>>.StartNew
	|
	|-RVA: 0x1AA1F10 Offset: 0x1AA0510 VA: 0x181AA1F10
	|-TaskFactory<Nullable<ResultPage>>.StartNew
	|
	|-RVA: 0x1AA2450 Offset: 0x1AA0A50 VA: 0x181AA2450
	|-TaskFactory<Nullable<int>>.StartNew
	|
	|-RVA: 0x1AA2300 Offset: 0x1AA0900 VA: 0x181AA2300
	|-TaskFactory<Nullable<Int32Enum>>.StartNew
	|
	|-RVA: 0x1AA1B20 Offset: 0x1AA0120 VA: 0x181AA1B20
	|-TaskFactory<object>.StartNew
	|
	|-RVA: 0x1AA2C30 Offset: 0x1AA1230 VA: 0x181AA2C30
	|-TaskFactory<VoidTaskResult>.StartNew
	*/

	// RVA: -1 Offset: -1
	private static void FromAsyncCoreLogic(IAsyncResult iar, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, Task<TResult> promise, bool requiresSynchronization) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A97DB0 Offset: 0x1A963B0 VA: 0x181A97DB0
	|-TaskFactory<PublishResult>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A99120 Offset: 0x1A97720 VA: 0x181A99120
	|-TaskFactory<bool>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A98730 Offset: 0x1A96D30 VA: 0x181A98730
	|-TaskFactory<int>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A995B0 Offset: 0x1A97BB0 VA: 0x181A995B0
	|-TaskFactory<UdpReceiveResult>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A98BC0 Offset: 0x1A971C0 VA: 0x181A98BC0
	|-TaskFactory<Nullable<ServerInfo>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A98270 Offset: 0x1A96870 VA: 0x181A98270
	|-TaskFactory<Nullable<Image>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A9B290 Offset: 0x1A99890 VA: 0x181A9B290
	|-TaskFactory<Nullable<InventoryPurchaseResult>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A9A370 Offset: 0x1A98970 VA: 0x181A9A370
	|-TaskFactory<Nullable<InventoryResult>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A9A810 Offset: 0x1A98E10 VA: 0x181A9A810
	|-TaskFactory<Nullable<Item>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A99A50 Offset: 0x1A98050 VA: 0x181A99A50
	|-TaskFactory<Nullable<ResultPage>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A9AE20 Offset: 0x1A99420 VA: 0x181A9AE20
	|-TaskFactory<Nullable<int>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A99F00 Offset: 0x1A98500 VA: 0x181A99F00
	|-TaskFactory<Nullable<Int32Enum>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A974B0 Offset: 0x1A95AB0 VA: 0x181A974B0
	|-TaskFactory<object>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A97940 Offset: 0x1A95F40 VA: 0x181A97940
	|-TaskFactory<VoidTaskResult>.FromAsyncCoreLogic
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AA1AD0 Offset: 0x1AA00D0 VA: 0x181AA1AD0
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
	|-RVA: 0x1A9CC80 Offset: 0x1A9B280 VA: 0x181A9CC80
	|-TaskFactory<PublishResult>.FromAsyncImpl
	|
	|-RVA: 0x1AA13E0 Offset: 0x1A9F9E0 VA: 0x181AA13E0
	|-TaskFactory<bool>.FromAsyncImpl
	|
	|-RVA: 0x1A9EA00 Offset: 0x1A9D000 VA: 0x181A9EA00
	|-TaskFactory<int>.FromAsyncImpl
	|
	|-RVA: 0x1AA0CE0 Offset: 0x1A9F2E0 VA: 0x181AA0CE0
	|-TaskFactory<UdpReceiveResult>.FromAsyncImpl
	|
	|-RVA: 0x1A9E280 Offset: 0x1A9C880 VA: 0x181A9E280
	|-TaskFactory<Nullable<ServerInfo>>.FromAsyncImpl
	|
	|-RVA: 0x1A9B740 Offset: 0x1A99D40 VA: 0x181A9B740
	|-TaskFactory<Nullable<Image>>.FromAsyncImpl
	|
	|-RVA: 0x1A9F7E0 Offset: 0x1A9DDE0 VA: 0x181A9F7E0
	|-TaskFactory<Nullable<InventoryPurchaseResult>>.FromAsyncImpl
	|
	|-RVA: 0x1A9D3B0 Offset: 0x1A9B9B0 VA: 0x181A9D3B0
	|-TaskFactory<Nullable<InventoryResult>>.FromAsyncImpl
	|
	|-RVA: 0x1A9DAD0 Offset: 0x1A9C0D0 VA: 0x181A9DAD0
	|-TaskFactory<Nullable<Item>>.FromAsyncImpl
	|
	|-RVA: 0x1A9C560 Offset: 0x1A9AB60 VA: 0x181A9C560
	|-TaskFactory<Nullable<ResultPage>>.FromAsyncImpl
	|
	|-RVA: 0x1A9F0F0 Offset: 0x1A9D6F0 VA: 0x181A9F0F0
	|-TaskFactory<Nullable<int>>.FromAsyncImpl
	|
	|-RVA: 0x1A9FF00 Offset: 0x1A9E500 VA: 0x181A9FF00
	|-TaskFactory<Nullable<Int32Enum>>.FromAsyncImpl
	|
	|-RVA: 0x1A9BE70 Offset: 0x1A9A470 VA: 0x181A9BE70
	|-TaskFactory<object>.FromAsyncImpl
	|
	|-RVA: 0x1AA05F0 Offset: 0x1A9EBF0 VA: 0x181AA05F0
	|-TaskFactory<VoidTaskResult>.FromAsyncImpl
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157C280 Offset: 0x157A880 VA: 0x18157C280
	|-TaskFactory<int>.FromAsync<byte[], int>
	|-TaskFactory<int>.FromAsync<object, int>
	|
	|-RVA: 0x157C2E0 Offset: 0x157A8E0 VA: 0x18157C2E0
	|-TaskFactory<object>.FromAsync<object, object>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromAsyncImpl<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157B0F0 Offset: 0x15796F0 VA: 0x18157B0F0
	|-TaskFactory<int>.FromAsyncImpl<object, int>
	|
	|-RVA: 0x157B730 Offset: 0x1579D30 VA: 0x18157B730
	|-TaskFactory<object>.FromAsyncImpl<object, object>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromAsyncTrim<TInstance, TArgs>(TInstance thisRef, TArgs args, Func<TInstance, TArgs, AsyncCallback, object, IAsyncResult> beginMethod, Func<TInstance, IAsyncResult, TResult> endMethod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157BD70 Offset: 0x157A370 VA: 0x18157BD70
	|-TaskFactory<int>.FromAsyncTrim<Stream, Stream.ReadWriteParameters>
	|-TaskFactory<int>.FromAsyncTrim<object, Stream.ReadWriteParameters>
	|
	|-RVA: 0x157C0D0 Offset: 0x157A6D0 VA: 0x18157C0D0
	|-TaskFactory<object>.FromAsyncTrim<object, object>
	|
	|-RVA: 0x157BF20 Offset: 0x157A520 VA: 0x18157BF20
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
	|-RVA: 0x1A60D10 Offset: 0x1A5F310 VA: 0x181A60D10
	|-UnwrapPromise<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public void Invoke(Task completingTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A60670 Offset: 0x1A5EC70 VA: 0x181A60670
	|-UnwrapPromise<object>.Invoke
	*/

	// RVA: -1 Offset: -1
	private void InvokeCore(Task completingTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A60610 Offset: 0x1A5EC10 VA: 0x181A60610
	|-UnwrapPromise<object>.InvokeCore
	*/

	// RVA: -1 Offset: -1
	private void InvokeCoreAsync(Task completingTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A603D0 Offset: 0x1A5E9D0 VA: 0x181A603D0
	|-UnwrapPromise<object>.InvokeCoreAsync
	*/

	// RVA: -1 Offset: -1
	private void ProcessCompletedOuterTask(Task task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A607E0 Offset: 0x1A5EDE0 VA: 0x181A607E0
	|-UnwrapPromise<object>.ProcessCompletedOuterTask
	*/

	// RVA: -1 Offset: -1
	private bool TrySetFromTask(Task task, bool lookForOce) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A60A40 Offset: 0x1A5F040 VA: 0x181A60A40
	|-UnwrapPromise<object>.TrySetFromTask
	*/

	// RVA: -1 Offset: -1
	private void ProcessInnerTask(Task task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A60990 Offset: 0x1A5EF90 VA: 0x181A60990
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
	|-RVA: 0x1369730 Offset: 0x1367D30 VA: 0x181369730
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
	|-RVA: 0x1369620 Offset: 0x1367C20 VA: 0x181369620
	|-TaskCompletionSource<object>.SpinUntilCompleted
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCanceled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1369700 Offset: 0x1367D00 VA: 0x181369700
	|-TaskCompletionSource<object>.TrySetCanceled
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCanceled(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1369680 Offset: 0x1367C80 VA: 0x181369680
	|-TaskCompletionSource<object>.TrySetCanceled
	*/

	// RVA: -1 Offset: -1
	public void SetCanceled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1369580 Offset: 0x1367B80 VA: 0x181369580
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
	|-RVA: 0x1365120 Offset: 0x1363720 VA: 0x181365120
	|-ContinuationTaskFromResultTask<PublishResult>..ctor
	|
	|-RVA: 0x13656C0 Offset: 0x1363CC0 VA: 0x1813656C0
	|-ContinuationTaskFromResultTask<bool>..ctor
	|
	|-RVA: 0x13654E0 Offset: 0x1363AE0 VA: 0x1813654E0
	|-ContinuationTaskFromResultTask<int>..ctor
	|
	|-RVA: 0x1365210 Offset: 0x1363810 VA: 0x181365210
	|-ContinuationTaskFromResultTask<UdpReceiveResult>..ctor
	|
	|-RVA: 0x13653F0 Offset: 0x13639F0 VA: 0x1813653F0
	|-ContinuationTaskFromResultTask<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x13655D0 Offset: 0x1363BD0 VA: 0x1813655D0
	|-ContinuationTaskFromResultTask<Nullable<Image>>..ctor
	|
	|-RVA: 0x1365030 Offset: 0x1363630 VA: 0x181365030
	|-ContinuationTaskFromResultTask<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1364D60 Offset: 0x1363360 VA: 0x181364D60
	|-ContinuationTaskFromResultTask<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1364E50 Offset: 0x1363450 VA: 0x181364E50
	|-ContinuationTaskFromResultTask<Nullable<Item>>..ctor
	|
	|-RVA: 0x13657B0 Offset: 0x1363DB0 VA: 0x1813657B0
	|-ContinuationTaskFromResultTask<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1364F40 Offset: 0x1363540 VA: 0x181364F40
	|-ContinuationTaskFromResultTask<Nullable<int>>..ctor
	|
	|-RVA: 0x1364B80 Offset: 0x1363180 VA: 0x181364B80
	|-ContinuationTaskFromResultTask<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x1364C70 Offset: 0x1363270 VA: 0x181364C70
	|-ContinuationTaskFromResultTask<object>..ctor
	|
	|-RVA: 0x1365300 Offset: 0x1363900 VA: 0x181365300
	|-ContinuationTaskFromResultTask<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 19
	internal override void InnerInvoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1364A70 Offset: 0x1363070 VA: 0x181364A70
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
	|-RVA: 0x13648E0 Offset: 0x1362EE0 VA: 0x1813648E0
	|-ContinuationResultTaskFromResultTask<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 19
	internal override void InnerInvoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13647C0 Offset: 0x1362DC0 VA: 0x1813647C0
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

	// RVA: 0x12ACF50 Offset: 0x12AB550 VA: 0x1812ACF50
	internal void .ctor(Stream sout, ObjectWriter objectWriter, FormatterTypeStyle formatterTypeStyle) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void WriteBegin() { }

	// RVA: 0x12AADD0 Offset: 0x12A93D0 VA: 0x1812AADD0
	internal void WriteEnd() { }

	// RVA: 0x12AABB0 Offset: 0x12A91B0 VA: 0x1812AABB0
	internal void WriteBoolean(bool value) { }

	// RVA: 0x12AABE0 Offset: 0x12A91E0 VA: 0x1812AABE0
	internal void WriteByte(byte value) { }

	// RVA: 0x12AAC10 Offset: 0x12A9210 VA: 0x1812AAC10
	private void WriteBytes(byte[] value) { }

	// RVA: 0x12AAC40 Offset: 0x12A9240 VA: 0x1812AAC40
	private void WriteBytes(byte[] byteA, int offset, int size) { }

	// RVA: 0x12AAC70 Offset: 0x12A9270 VA: 0x1812AAC70
	internal void WriteChar(char value) { }

	// RVA: 0x12AACA0 Offset: 0x12A92A0 VA: 0x1812AACA0
	internal void WriteChars(char[] value) { }

	// RVA: 0x12AAD00 Offset: 0x12A9300 VA: 0x1812AAD00
	internal void WriteDecimal(Decimal value) { }

	// RVA: 0x12AC5C0 Offset: 0x12AABC0 VA: 0x1812AC5C0
	internal void WriteSingle(float value) { }

	// RVA: 0x12AADA0 Offset: 0x12A93A0 VA: 0x1812AADA0
	internal void WriteDouble(double value) { }

	// RVA: 0x12AAE00 Offset: 0x12A9400 VA: 0x1812AAE00
	internal void WriteInt16(short value) { }

	// RVA: 0x12AAE30 Offset: 0x12A9430 VA: 0x1812AAE30
	internal void WriteInt32(int value) { }

	// RVA: 0x12AACD0 Offset: 0x12A92D0 VA: 0x1812AACD0
	internal void WriteInt64(long value) { }

	// RVA: 0x12AABE0 Offset: 0x12A91E0 VA: 0x1812AABE0
	internal void WriteSByte(sbyte value) { }

	// RVA: 0x12AC5F0 Offset: 0x12AABF0 VA: 0x1812AC5F0
	internal void WriteString(string value) { }

	// RVA: 0x12AACD0 Offset: 0x12A92D0 VA: 0x1812AACD0
	internal void WriteTimeSpan(TimeSpan value) { }

	// RVA: 0x12AACD0 Offset: 0x12A92D0 VA: 0x1812AACD0
	internal void WriteDateTime(DateTime value) { }

	// RVA: 0x12AC620 Offset: 0x12AAC20 VA: 0x1812AC620
	internal void WriteUInt16(ushort value) { }

	// RVA: 0x12AC650 Offset: 0x12AAC50 VA: 0x1812AC650
	internal void WriteUInt32(uint value) { }

	// RVA: 0x12AC680 Offset: 0x12AAC80 VA: 0x1812AC680
	internal void WriteUInt64(ulong value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void WriteObjectEnd(NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x12AC130 Offset: 0x12AA730 VA: 0x1812AC130
	internal void WriteSerializationHeaderEnd() { }

	// RVA: 0x12AC1B0 Offset: 0x12AA7B0 VA: 0x1812AC1B0
	internal void WriteSerializationHeader(int topId, int headerId, int minorVersion, int majorVersion) { }

	// RVA: 0x12AB650 Offset: 0x12A9C50 VA: 0x1812AB650
	internal void WriteMethodCall() { }

	// RVA: 0x12AB6F0 Offset: 0x12A9CF0 VA: 0x1812AB6F0
	internal void WriteMethodReturn() { }

	// RVA: 0x12AB9B0 Offset: 0x12A9FB0 VA: 0x1812AB9B0
	internal void WriteObject(NameInfo nameInfo, NameInfo typeNameInfo, int numMembers, string[] memberNames, Type[] memberTypes, WriteObjectInfo[] memberObjectInfos) { }

	// RVA: 0x12AB8E0 Offset: 0x12A9EE0 VA: 0x1812AB8E0
	internal void WriteObjectString(int objectId, string value) { }

	// RVA: 0x12AC270 Offset: 0x12AA870 VA: 0x1812AC270
	internal void WriteSingleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, Array array) { }

	// RVA: 0x12AA840 Offset: 0x12A8E40 VA: 0x1812AA840
	private void WriteArrayAsBytes(Array array, int typeLength) { }

	// RVA: 0x12AB0D0 Offset: 0x12A96D0 VA: 0x1812AB0D0
	internal void WriteJaggedArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound) { }

	// RVA: 0x12ABF70 Offset: 0x12AA570 VA: 0x1812ABF70
	internal void WriteRectangleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int rank, int[] lengthA, int[] lowerBoundA) { }

	// RVA: 0x12AB880 Offset: 0x12A9E80 VA: 0x1812AB880
	internal void WriteObjectByteArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, byte[] byteA) { }

	// RVA: 0x12AB4D0 Offset: 0x12A9AD0 VA: 0x1812AB4D0
	internal void WriteMember(NameInfo memberNameInfo, NameInfo typeNameInfo, object value) { }

	// RVA: 0x12AB7A0 Offset: 0x12A9DA0 VA: 0x1812AB7A0
	internal void WriteNullMember(NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x12AB310 Offset: 0x12A9910 VA: 0x1812AB310
	internal void WriteMemberObjectRef(NameInfo memberNameInfo, int idRef) { }

	// RVA: 0x12AB2E0 Offset: 0x12A98E0 VA: 0x1812AB2E0
	internal void WriteMemberNested(NameInfo memberNameInfo) { }

	// RVA: 0x12AB3E0 Offset: 0x12A99E0 VA: 0x1812AB3E0
	internal void WriteMemberString(NameInfo memberNameInfo, NameInfo typeNameInfo, string value) { }

	// RVA: 0x12AAF50 Offset: 0x12A9550 VA: 0x1812AAF50
	internal void WriteItem(NameInfo itemNameInfo, NameInfo typeNameInfo, object value) { }

	// RVA: 0x12AB790 Offset: 0x12A9D90 VA: 0x1812AB790
	internal void WriteNullItem(NameInfo itemNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x12AAD90 Offset: 0x12A9390 VA: 0x1812AAD90
	internal void WriteDelayedNullItem() { }

	// RVA: 0x12AAE60 Offset: 0x12A9460 VA: 0x1812AAE60
	internal void WriteItemEnd() { }

	// RVA: 0x12AA780 Offset: 0x12A8D80 VA: 0x1812AA780
	private void InternalWriteItemNull() { }

	// RVA: 0x12AAE70 Offset: 0x12A9470 VA: 0x1812AAE70
	internal void WriteItemObjectRef(NameInfo nameInfo, int idRef) { }

	// RVA: 0x12AAAB0 Offset: 0x12A90B0 VA: 0x1812AAAB0
	internal void WriteAssembly(Type type, string assemblyString, int assemId, bool isNew) { }

	// RVA: 0x12AC6B0 Offset: 0x12AACB0 VA: 0x1812AC6B0
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

	// RVA: 0x120F460 Offset: 0x120DA60 VA: 0x18120F460
	internal void .ctor(Stream stream, ObjectReader objectReader) { }

	// RVA: 0x120F720 Offset: 0x120DD20 VA: 0x18120F720
	internal BinaryAssemblyInfo get_SystemAssemblyInfo() { }

	// RVA: 0x120F650 Offset: 0x120DC50 VA: 0x18120F650
	internal SizedArray get_ObjectMapIdTable() { }

	// RVA: 0x120F580 Offset: 0x120DB80 VA: 0x18120F580
	internal SizedArray get_AssemIdToAssemblyTable() { }

	// RVA: 0x120F800 Offset: 0x120DE00 VA: 0x18120F800
	internal ParseRecord get_prs() { }

	// RVA: 0x120EE70 Offset: 0x120D470 VA: 0x18120EE70
	internal void Run() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void ReadBegin() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void ReadEnd() { }

	// RVA: 0x120A5E0 Offset: 0x1208BE0 VA: 0x18120A5E0
	internal bool ReadBoolean() { }

	// RVA: 0x120A610 Offset: 0x1208C10 VA: 0x18120A610
	internal byte ReadByte() { }

	// RVA: 0x120A6D0 Offset: 0x1208CD0 VA: 0x18120A6D0
	internal byte[] ReadBytes(int length) { }

	// RVA: 0x120A640 Offset: 0x1208C40 VA: 0x18120A640
	internal void ReadBytes(byte[] byteA, int offset, int size) { }

	// RVA: 0x120A700 Offset: 0x1208D00 VA: 0x18120A700
	internal char ReadChar() { }

	// RVA: 0x120A730 Offset: 0x1208D30 VA: 0x18120A730
	internal char[] ReadChars(int length) { }

	// RVA: 0x120B540 Offset: 0x1209B40 VA: 0x18120B540
	internal Decimal ReadDecimal() { }

	// RVA: 0x120E860 Offset: 0x120CE60 VA: 0x18120E860
	internal float ReadSingle() { }

	// RVA: 0x120B610 Offset: 0x1209C10 VA: 0x18120B610
	internal double ReadDouble() { }

	// RVA: 0x120B640 Offset: 0x1209C40 VA: 0x18120B640
	internal short ReadInt16() { }

	// RVA: 0x120B670 Offset: 0x1209C70 VA: 0x18120B670
	internal int ReadInt32() { }

	// RVA: 0x120B6A0 Offset: 0x1209CA0 VA: 0x18120B6A0
	internal long ReadInt64() { }

	// RVA: 0x120A610 Offset: 0x1208C10 VA: 0x18120A610
	internal sbyte ReadSByte() { }

	// RVA: 0x120E890 Offset: 0x120CE90 VA: 0x18120E890
	internal string ReadString() { }

	// RVA: 0x120B6A0 Offset: 0x1209CA0 VA: 0x18120B6A0
	internal TimeSpan ReadTimeSpan() { }

	// RVA: 0x120B4C0 Offset: 0x1209AC0 VA: 0x18120B4C0
	internal DateTime ReadDateTime() { }

	// RVA: 0x120E8C0 Offset: 0x120CEC0 VA: 0x18120E8C0
	internal ushort ReadUInt16() { }

	// RVA: 0x120E8F0 Offset: 0x120CEF0 VA: 0x18120E8F0
	internal uint ReadUInt32() { }

	// RVA: 0x120E920 Offset: 0x120CF20 VA: 0x18120E920
	internal ulong ReadUInt64() { }

	// RVA: 0x120E7B0 Offset: 0x120CDB0 VA: 0x18120E7B0
	internal void ReadSerializationHeaderRecord() { }

	// RVA: 0x120A310 Offset: 0x1208910 VA: 0x18120A310
	internal void ReadAssembly(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x120E2B0 Offset: 0x120C8B0 VA: 0x18120E2B0
	private void ReadObject() { }

	// RVA: 0x120A760 Offset: 0x1208D60 VA: 0x18120A760
	internal void ReadCrossAppDomainMap() { }

	// RVA: 0x120DBD0 Offset: 0x120C1D0 VA: 0x18120DBD0
	internal void ReadObjectWithMap(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x120DC90 Offset: 0x120C290 VA: 0x18120DC90
	private void ReadObjectWithMap(BinaryObjectWithMap record) { }

	// RVA: 0x120DB10 Offset: 0x120C110 VA: 0x18120DB10
	internal void ReadObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x120D4C0 Offset: 0x120BAC0 VA: 0x18120D4C0
	private void ReadObjectWithMapTyped(BinaryObjectWithMapTyped record) { }

	// RVA: 0x120CB20 Offset: 0x120B120 VA: 0x18120CB20
	private void ReadObjectString(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x120B6D0 Offset: 0x1209CD0 VA: 0x18120B6D0
	private void ReadMemberPrimitiveTyped() { }

	// RVA: 0x1209C20 Offset: 0x1208220 VA: 0x181209C20
	private void ReadArray(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x12096B0 Offset: 0x1207CB0 VA: 0x1812096B0
	private void ReadArrayAsBytes(ParseRecord pr) { }

	// RVA: 0x120BCD0 Offset: 0x120A2D0 VA: 0x18120BCD0
	private void ReadMemberPrimitiveUnTyped() { }

	// RVA: 0x120C210 Offset: 0x120A810 VA: 0x18120C210
	private void ReadMemberReference() { }

	// RVA: 0x120C750 Offset: 0x120AD50 VA: 0x18120C750
	private void ReadObjectNull(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x120C5D0 Offset: 0x120ABD0 VA: 0x18120C5D0
	private void ReadMessageEnd() { }

	// RVA: 0x120E950 Offset: 0x120CF50 VA: 0x18120E950
	internal object ReadValue(InternalPrimitiveTypeE code) { }

	// RVA: 0x1209470 Offset: 0x1207A70 VA: 0x181209470
	private ObjectProgress GetOp() { }

	// RVA: 0x1209610 Offset: 0x1207C10 VA: 0x181209610
	private void PutOp(ObjectProgress op) { }

	// RVA: 0x120F400 Offset: 0x120DA00 VA: 0x18120F400
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
	|-RVA: 0xF1490 Offset: 0xF0890 VA: 0x1800F1490
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
	|-RVA: 0x14C0C0 Offset: 0x14B4C0 VA: 0x18014C0C0
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
	|-RVA: 0x14CA00 Offset: 0x14BE00 VA: 0x18014CA00
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
	|-RVA: 0x14CA30 Offset: 0x14BE30 VA: 0x18014CA30
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
	|-RVA: 0x1E3C60 Offset: 0x1E3060 VA: 0x1801E3C60
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
	|-RVA: 0x1E2F10 Offset: 0x1E2310 VA: 0x1801E2F10
	|-TaskAwaiter<PublishResult>.GetResult
	|-TaskAwaiter<Nullable<Image>>.GetResult
	|
	|-RVA: 0x1E3090 Offset: 0x1E2490 VA: 0x1801E3090
	|-TaskAwaiter<UdpReceiveResult>.GetResult
	|
	|-RVA: 0x1E3140 Offset: 0x1E2540 VA: 0x1801E3140
	|-TaskAwaiter<Nullable<ServerInfo>>.GetResult
	|
	|-RVA: 0x1E2FD0 Offset: 0x1E23D0 VA: 0x1801E2FD0
	|-TaskAwaiter<Nullable<InventoryPurchaseResult>>.GetResult
	|-TaskAwaiter<Nullable<ResultPage>>.GetResult
	|
	|-RVA: 0x1E3380 Offset: 0x1E2780 VA: 0x1801E3380
	|-TaskAwaiter<Nullable<InventoryResult>>.GetResult
	|
	|-RVA: 0x1E3240 Offset: 0x1E2640 VA: 0x1801E3240
	|-TaskAwaiter<Nullable<Item>>.GetResult
	|
	|-RVA: 0x1E3C50 Offset: 0x1E3050 VA: 0x1801E3C50
	|-TaskAwaiter<bool>.GetResult
	|
	|-RVA: 0x1E2E80 Offset: 0x1E2280 VA: 0x1801E2E80
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
	|-RVA: 0x1E2E10 Offset: 0x1E2210 VA: 0x1801E2E10
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
	|-RVA: 0x14B770 Offset: 0x14AB70 VA: 0x18014B770
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
	|-RVA: 0x22B470 Offset: 0x22A870 VA: 0x18022B470
	|-ConcurrentSet<KeyValuePair<object, Int32Enum>, object>.TryGet
	|-ConcurrentSet<KeyValuePair<string, EventTags>, NameInfo>.TryGet
	|
	|-RVA: 0x22B530 Offset: 0x22A930 VA: 0x18022B530
	|-ConcurrentSet<object, object>.TryGet
	*/

	// RVA: -1 Offset: -1
	public ItemType GetOrAdd(ItemType newItem) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B460 Offset: 0x22A860 VA: 0x18022B460
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
	|-RVA: 0xD5B020 Offset: 0xD59620 VA: 0x180D5B020
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
	|-RVA: 0x1B51FD0 Offset: 0x1B505D0 VA: 0x181B51FD0
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
	|-RVA: 0x1B51990 Offset: 0x1B4FF90 VA: 0x181B51990
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
	|-RVA: 0x1B51900 Offset: 0x1B4FF00 VA: 0x181B51900
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
	|-RVA: 0x1B4FB00 Offset: 0x1B4E100 VA: 0x181B4FB00
	|-InvokeTypeInfo<bool>.GetData
	|
	|-RVA: 0x1B50780 Offset: 0x1B4ED80 VA: 0x181B50780
	|-InvokeTypeInfo<byte>.GetData
	|
	|-RVA: 0x1B4E980 Offset: 0x1B4CF80 VA: 0x181B4E980
	|-InvokeTypeInfo<char>.GetData
	|
	|-RVA: 0x1B50500 Offset: 0x1B4EB00 VA: 0x181B50500
	|-InvokeTypeInfo<KeyValuePair<object, object>>.GetData
	|
	|-RVA: 0x1B4E480 Offset: 0x1B4CA80 VA: 0x181B4E480
	|-InvokeTypeInfo<DateTime>.GetData
	|
	|-RVA: 0x1B4F600 Offset: 0x1B4DC00 VA: 0x181B4F600
	|-InvokeTypeInfo<DateTimeOffset>.GetData
	|
	|-RVA: 0x1B4E700 Offset: 0x1B4CD00 VA: 0x181B4E700
	|-InvokeTypeInfo<Decimal>.GetData
	|
	|-RVA: 0x1B4EE80 Offset: 0x1B4D480 VA: 0x181B4EE80
	|-InvokeTypeInfo<EmptyStruct>.GetData
	|
	|-RVA: 0x1B50A00 Offset: 0x1B4F000 VA: 0x181B50A00
	|-InvokeTypeInfo<double>.GetData
	|
	|-RVA: 0x1B4F100 Offset: 0x1B4D700 VA: 0x181B4F100
	|-InvokeTypeInfo<Guid>.GetData
	|
	|-RVA: 0x1B50F00 Offset: 0x1B4F500 VA: 0x181B50F00
	|-InvokeTypeInfo<short>.GetData
	|
	|-RVA: 0x1B4EC00 Offset: 0x1B4D200 VA: 0x181B4EC00
	|-InvokeTypeInfo<int>.GetData
	|
	|-RVA: 0x1B4E200 Offset: 0x1B4C800 VA: 0x181B4E200
	|-InvokeTypeInfo<long>.GetData
	|
	|-RVA: 0x1B4FD80 Offset: 0x1B4E380 VA: 0x181B4FD80
	|-InvokeTypeInfo<IntPtr>.GetData
	|
	|-RVA: 0x1B51180 Offset: 0x1B4F780 VA: 0x181B51180
	|-InvokeTypeInfo<object>.GetData
	|
	|-RVA: 0x1B4F380 Offset: 0x1B4D980 VA: 0x181B4F380
	|-InvokeTypeInfo<sbyte>.GetData
	|
	|-RVA: 0x1B50280 Offset: 0x1B4E880 VA: 0x181B50280
	|-InvokeTypeInfo<float>.GetData
	|
	|-RVA: 0x1B51680 Offset: 0x1B4FC80 VA: 0x181B51680
	|-InvokeTypeInfo<TimeSpan>.GetData
	|
	|-RVA: 0x1B4F880 Offset: 0x1B4DE80 VA: 0x181B4F880
	|-InvokeTypeInfo<ushort>.GetData
	|
	|-RVA: 0x1B50000 Offset: 0x1B4E600 VA: 0x181B50000
	|-InvokeTypeInfo<uint>.GetData
	|
	|-RVA: 0x1B50C80 Offset: 0x1B4F280 VA: 0x181B50C80
	|-InvokeTypeInfo<ulong>.GetData
	|
	|-RVA: 0x1B51400 Offset: 0x1B4FA00 VA: 0x181B51400
	|-InvokeTypeInfo<UIntPtr>.GetData
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override void WriteObjectData(TraceLoggingDataCollector collector, object valueObj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B51BC0 Offset: 0x1B501C0 VA: 0x181B51BC0
	|-InvokeTypeInfo<bool>.WriteObjectData
	|-InvokeTypeInfo<byte>.WriteObjectData
	|-InvokeTypeInfo<EmptyStruct>.WriteObjectData
	|-InvokeTypeInfo<sbyte>.WriteObjectData
	|
	|-RVA: 0x1B51DC0 Offset: 0x1B503C0 VA: 0x181B51DC0
	|-InvokeTypeInfo<char>.WriteObjectData
	|-InvokeTypeInfo<short>.WriteObjectData
	|-InvokeTypeInfo<ushort>.WriteObjectData
	|
	|-RVA: 0x1B51B10 Offset: 0x1B50110 VA: 0x181B51B10
	|-InvokeTypeInfo<KeyValuePair<object, object>>.WriteObjectData
	|-InvokeTypeInfo<DateTimeOffset>.WriteObjectData
	|-InvokeTypeInfo<Decimal>.WriteObjectData
	|-InvokeTypeInfo<Guid>.WriteObjectData
	|
	|-RVA: 0x1B51D10 Offset: 0x1B50310 VA: 0x181B51D10
	|-InvokeTypeInfo<DateTime>.WriteObjectData
	|-InvokeTypeInfo<long>.WriteObjectData
	|-InvokeTypeInfo<IntPtr>.WriteObjectData
	|-InvokeTypeInfo<TimeSpan>.WriteObjectData
	|-InvokeTypeInfo<ulong>.WriteObjectData
	|-InvokeTypeInfo<UIntPtr>.WriteObjectData
	|
	|-RVA: 0x1B51A60 Offset: 0x1B50060 VA: 0x181B51A60
	|-InvokeTypeInfo<double>.WriteObjectData
	|
	|-RVA: 0x1B51F20 Offset: 0x1B50520 VA: 0x181B51F20
	|-InvokeTypeInfo<int>.WriteObjectData
	|-InvokeTypeInfo<uint>.WriteObjectData
	|
	|-RVA: 0x1B51C70 Offset: 0x1B50270 VA: 0x181B51C70
	|-InvokeTypeInfo<object>.WriteObjectData
	|
	|-RVA: 0x1B51E70 Offset: 0x1B50470 VA: 0x181B51E70
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
	|-RVA: 0x1B56310 Offset: 0x1B54910 VA: 0x181B56310
	|-PropertyAccessor<bool>.Create
	|
	|-RVA: 0x1B53FA0 Offset: 0x1B525A0 VA: 0x181B53FA0
	|-PropertyAccessor<byte>.Create
	|
	|-RVA: 0x1B54F60 Offset: 0x1B53560 VA: 0x181B54F60
	|-PropertyAccessor<char>.Create
	|
	|-RVA: 0x1B56700 Offset: 0x1B54D00 VA: 0x181B56700
	|-PropertyAccessor<KeyValuePair<object, object>>.Create
	|
	|-RVA: 0x1B57EA0 Offset: 0x1B564A0 VA: 0x181B57EA0
	|-PropertyAccessor<DateTime>.Create
	|
	|-RVA: 0x1B54780 Offset: 0x1B52D80 VA: 0x181B54780
	|-PropertyAccessor<DateTimeOffset>.Create
	|
	|-RVA: 0x1B537C0 Offset: 0x1B51DC0 VA: 0x181B537C0
	|-PropertyAccessor<Decimal>.Create
	|
	|-RVA: 0x1B54390 Offset: 0x1B52990 VA: 0x181B54390
	|-PropertyAccessor<EmptyStruct>.Create
	|
	|-RVA: 0x1B52BF0 Offset: 0x1B511F0 VA: 0x181B52BF0
	|-PropertyAccessor<double>.Create
	|
	|-RVA: 0x1B576C0 Offset: 0x1B55CC0 VA: 0x181B576C0
	|-PropertyAccessor<Guid>.Create
	|
	|-RVA: 0x1B572D0 Offset: 0x1B558D0 VA: 0x181B572D0
	|-PropertyAccessor<short>.Create
	|
	|-RVA: 0x1B55350 Offset: 0x1B53950 VA: 0x181B55350
	|-PropertyAccessor<int>.Create
	|
	|-RVA: 0x1B54B70 Offset: 0x1B53170 VA: 0x181B54B70
	|-PropertyAccessor<long>.Create
	|
	|-RVA: 0x1B56AF0 Offset: 0x1B550F0 VA: 0x181B56AF0
	|-PropertyAccessor<IntPtr>.Create
	|
	|-RVA: 0x1B57AB0 Offset: 0x1B560B0 VA: 0x181B57AB0
	|-PropertyAccessor<object>.Create
	|
	|-RVA: 0x1B53BB0 Offset: 0x1B521B0 VA: 0x181B53BB0
	|-PropertyAccessor<sbyte>.Create
	|
	|-RVA: 0x1B55740 Offset: 0x1B53D40 VA: 0x181B55740
	|-PropertyAccessor<float>.Create
	|
	|-RVA: 0x1B55F20 Offset: 0x1B54520 VA: 0x181B55F20
	|-PropertyAccessor<TimeSpan>.Create
	|
	|-RVA: 0x1B55B30 Offset: 0x1B54130 VA: 0x181B55B30
	|-PropertyAccessor<ushort>.Create
	|
	|-RVA: 0x1B533D0 Offset: 0x1B519D0 VA: 0x181B533D0
	|-PropertyAccessor<uint>.Create
	|
	|-RVA: 0x1B52FE0 Offset: 0x1B515E0 VA: 0x181B52FE0
	|-PropertyAccessor<ulong>.Create
	|
	|-RVA: 0x1B56EE0 Offset: 0x1B554E0 VA: 0x181B56EE0
	|-PropertyAccessor<UIntPtr>.Create
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5B020 Offset: 0xD59620 VA: 0x180D5B020
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
	|-RVA: 0x1B52B60 Offset: 0x1B51160 VA: 0x181B52B60
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
	|-RVA: 0x1B526E0 Offset: 0x1B50CE0 VA: 0x181B526E0
	|-NonGenericProperytWriter<bool>.Write
	|-NonGenericProperytWriter<byte>.Write
	|-NonGenericProperytWriter<EmptyStruct>.Write
	|-NonGenericProperytWriter<sbyte>.Write
	|
	|-RVA: 0x1B52790 Offset: 0x1B50D90 VA: 0x181B52790
	|-NonGenericProperytWriter<char>.Write
	|-NonGenericProperytWriter<short>.Write
	|-NonGenericProperytWriter<ushort>.Write
	|
	|-RVA: 0x1B528F0 Offset: 0x1B50EF0 VA: 0x181B528F0
	|-NonGenericProperytWriter<KeyValuePair<object, object>>.Write
	|-NonGenericProperytWriter<DateTimeOffset>.Write
	|-NonGenericProperytWriter<Decimal>.Write
	|-NonGenericProperytWriter<Guid>.Write
	|
	|-RVA: 0x1B52630 Offset: 0x1B50C30 VA: 0x181B52630
	|-NonGenericProperytWriter<DateTime>.Write
	|-NonGenericProperytWriter<long>.Write
	|-NonGenericProperytWriter<IntPtr>.Write
	|-NonGenericProperytWriter<TimeSpan>.Write
	|-NonGenericProperytWriter<ulong>.Write
	|-NonGenericProperytWriter<UIntPtr>.Write
	|
	|-RVA: 0x1B52840 Offset: 0x1B50E40 VA: 0x181B52840
	|-NonGenericProperytWriter<double>.Write
	|
	|-RVA: 0x1B529A0 Offset: 0x1B50FA0 VA: 0x181B529A0
	|-NonGenericProperytWriter<int>.Write
	|-NonGenericProperytWriter<uint>.Write
	|
	|-RVA: 0x1B52B00 Offset: 0x1B51100 VA: 0x181B52B00
	|-NonGenericProperytWriter<object>.Write
	|
	|-RVA: 0x1B52A50 Offset: 0x1B51050 VA: 0x181B52A50
	|-NonGenericProperytWriter<float>.Write
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override object GetData(ContainerType container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B524B0 Offset: 0x1B50AB0 VA: 0x181B524B0
	|-NonGenericProperytWriter<bool>.GetData
	|-NonGenericProperytWriter<byte>.GetData
	|-NonGenericProperytWriter<EmptyStruct>.GetData
	|-NonGenericProperytWriter<sbyte>.GetData
	|
	|-RVA: 0x1B52440 Offset: 0x1B50A40 VA: 0x181B52440
	|-NonGenericProperytWriter<char>.GetData
	|-NonGenericProperytWriter<short>.GetData
	|-NonGenericProperytWriter<ushort>.GetData
	|
	|-RVA: 0x1B52360 Offset: 0x1B50960 VA: 0x181B52360
	|-NonGenericProperytWriter<KeyValuePair<object, object>>.GetData
	|-NonGenericProperytWriter<DateTimeOffset>.GetData
	|-NonGenericProperytWriter<Decimal>.GetData
	|-NonGenericProperytWriter<Guid>.GetData
	|
	|-RVA: 0x1B522F0 Offset: 0x1B508F0 VA: 0x181B522F0
	|-NonGenericProperytWriter<DateTime>.GetData
	|-NonGenericProperytWriter<long>.GetData
	|-NonGenericProperytWriter<IntPtr>.GetData
	|-NonGenericProperytWriter<TimeSpan>.GetData
	|-NonGenericProperytWriter<ulong>.GetData
	|-NonGenericProperytWriter<UIntPtr>.GetData
	|
	|-RVA: 0x1B523D0 Offset: 0x1B509D0 VA: 0x181B523D0
	|-NonGenericProperytWriter<double>.GetData
	|
	|-RVA: 0x1B525C0 Offset: 0x1B50BC0 VA: 0x181B525C0
	|-NonGenericProperytWriter<int>.GetData
	|-NonGenericProperytWriter<uint>.GetData
	|
	|-RVA: 0x1B52590 Offset: 0x1B50B90 VA: 0x181B52590
	|-NonGenericProperytWriter<object>.GetData
	|
	|-RVA: 0x1B52520 Offset: 0x1B50B20 VA: 0x181B52520
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
	|-RVA: 0x20C0F00 Offset: 0x20BF500 VA: 0x1820C0F00
	|-ClassPropertyWriter<bool, int>..ctor
	|
	|-RVA: 0x20C4300 Offset: 0x20C2900 VA: 0x1820C4300
	|-ClassPropertyWriter<bool, long>..ctor
	|
	|-RVA: 0x20C4980 Offset: 0x20C2F80 VA: 0x1820C4980
	|-ClassPropertyWriter<bool, object>..ctor
	|
	|-RVA: 0x20C1580 Offset: 0x20BFB80 VA: 0x1820C1580
	|-ClassPropertyWriter<byte, int>..ctor
	|
	|-RVA: 0x20C54E0 Offset: 0x20C3AE0 VA: 0x1820C54E0
	|-ClassPropertyWriter<byte, long>..ctor
	|
	|-RVA: 0x20C47E0 Offset: 0x20C2DE0 VA: 0x1820C47E0
	|-ClassPropertyWriter<byte, object>..ctor
	|
	|-RVA: 0x20C1240 Offset: 0x20BF840 VA: 0x1820C1240
	|-ClassPropertyWriter<char, int>..ctor
	|
	|-RVA: 0x20C3C80 Offset: 0x20C2280 VA: 0x1820C3C80
	|-ClassPropertyWriter<char, long>..ctor
	|
	|-RVA: 0x20C2420 Offset: 0x20C0A20 VA: 0x1820C2420
	|-ClassPropertyWriter<char, object>..ctor
	|
	|-RVA: 0x20C3940 Offset: 0x20C1F40 VA: 0x1820C3940
	|-ClassPropertyWriter<KeyValuePair<object, object>, int>..ctor
	|
	|-RVA: 0x20C1C00 Offset: 0x20C0200 VA: 0x1820C1C00
	|-ClassPropertyWriter<KeyValuePair<object, object>, long>..ctor
	|
	|-RVA: 0x20C1720 Offset: 0x20BFD20 VA: 0x1820C1720
	|-ClassPropertyWriter<KeyValuePair<object, object>, object>..ctor
	|
	|-RVA: 0x20C18C0 Offset: 0x20BFEC0 VA: 0x1820C18C0
	|-ClassPropertyWriter<DateTime, int>..ctor
	|
	|-RVA: 0x20C4CC0 Offset: 0x20C32C0 VA: 0x1820C4CC0
	|-ClassPropertyWriter<DateTime, long>..ctor
	|
	|-RVA: 0x20C10A0 Offset: 0x20BF6A0 VA: 0x1820C10A0
	|-ClassPropertyWriter<DateTime, object>..ctor
	|
	|-RVA: 0x20C2DE0 Offset: 0x20C13E0 VA: 0x1820C2DE0
	|-ClassPropertyWriter<DateTimeOffset, int>..ctor
	|
	|-RVA: 0x20C1A60 Offset: 0x20C0060 VA: 0x1820C1A60
	|-ClassPropertyWriter<DateTimeOffset, long>..ctor
	|
	|-RVA: 0x20C4160 Offset: 0x20C2760 VA: 0x1820C4160
	|-ClassPropertyWriter<DateTimeOffset, object>..ctor
	|
	|-RVA: 0x20C2760 Offset: 0x20C0D60 VA: 0x1820C2760
	|-ClassPropertyWriter<Decimal, int>..ctor
	|
	|-RVA: 0x20C4B20 Offset: 0x20C3120 VA: 0x1820C4B20
	|-ClassPropertyWriter<Decimal, long>..ctor
	|
	|-RVA: 0x20C51A0 Offset: 0x20C37A0 VA: 0x1820C51A0
	|-ClassPropertyWriter<Decimal, object>..ctor
	|
	|-RVA: 0x20C2C40 Offset: 0x20C1240 VA: 0x1820C2C40
	|-ClassPropertyWriter<EmptyStruct, int>..ctor
	|
	|-RVA: 0x20C2F80 Offset: 0x20C1580 VA: 0x1820C2F80
	|-ClassPropertyWriter<EmptyStruct, long>..ctor
	|
	|-RVA: 0x20C2AA0 Offset: 0x20C10A0 VA: 0x1820C2AA0
	|-ClassPropertyWriter<EmptyStruct, object>..ctor
	|
	|-RVA: 0x20C3600 Offset: 0x20C1C00 VA: 0x1820C3600
	|-ClassPropertyWriter<double, int>..ctor
	|
	|-RVA: 0x20C3FC0 Offset: 0x20C25C0 VA: 0x1820C3FC0
	|-ClassPropertyWriter<double, long>..ctor
	|
	|-RVA: 0x20C4E60 Offset: 0x20C3460 VA: 0x1820C4E60
	|-ClassPropertyWriter<double, object>..ctor
	|
	|-RVA: 0x20C37A0 Offset: 0x20C1DA0 VA: 0x1820C37A0
	|-ClassPropertyWriter<Guid, int>..ctor
	|
	|-RVA: 0x20C3120 Offset: 0x20C1720 VA: 0x1820C3120
	|-ClassPropertyWriter<Guid, long>..ctor
	|
	|-RVA: 0x20C4640 Offset: 0x20C2C40 VA: 0x1820C4640
	|-ClassPropertyWriter<Guid, object>..ctor
	|
	|-RVA: 0x20C20E0 Offset: 0x20C06E0 VA: 0x1820C20E0
	|-ClassPropertyWriter<short, int>..ctor
	|
	|-RVA: 0x20C25C0 Offset: 0x20C0BC0 VA: 0x1820C25C0
	|-ClassPropertyWriter<short, long>..ctor
	|
	|-RVA: 0x20C1DA0 Offset: 0x20C03A0 VA: 0x1820C1DA0
	|-ClassPropertyWriter<short, object>..ctor
	|
	|-RVA: 0x20C13E0 Offset: 0x20BF9E0 VA: 0x1820C13E0
	|-ClassPropertyWriter<int, int>..ctor
	|
	|-RVA: 0x20C5000 Offset: 0x20C3600 VA: 0x1820C5000
	|-ClassPropertyWriter<int, long>..ctor
	|
	|-RVA: 0x20C44A0 Offset: 0x20C2AA0 VA: 0x1820C44A0
	|-ClassPropertyWriter<int, object>..ctor
	|
	|-RVA: 0x20C0D60 Offset: 0x20BF360 VA: 0x1820C0D60
	|-ClassPropertyWriter<long, int>..ctor
	|
	|-RVA: 0x20C2900 Offset: 0x20C0F00 VA: 0x1820C2900
	|-ClassPropertyWriter<long, long>..ctor
	|
	|-RVA: 0x20C3460 Offset: 0x20C1A60 VA: 0x1820C3460
	|-ClassPropertyWriter<long, object>..ctor
	|
	|-RVA: 0x20C3E20 Offset: 0x20C2420 VA: 0x1820C3E20
	|-ClassPropertyWriter<IntPtr, int>..ctor
	|
	|-RVA: 0x20C5680 Offset: 0x20C3C80 VA: 0x1820C5680
	|-ClassPropertyWriter<IntPtr, long>..ctor
	|
	|-RVA: 0x20C5340 Offset: 0x20C3940 VA: 0x1820C5340
	|-ClassPropertyWriter<IntPtr, object>..ctor
	|
	|-RVA: 0x20C1F40 Offset: 0x20C0540 VA: 0x1820C1F40
	|-ClassPropertyWriter<object, int>..ctor
	|
	|-RVA: 0x20C32C0 Offset: 0x20C18C0 VA: 0x1820C32C0
	|-ClassPropertyWriter<object, long>..ctor
	|
	|-RVA: 0x20C2280 Offset: 0x20C0880 VA: 0x1820C2280
	|-ClassPropertyWriter<object, object>..ctor
	|
	|-RVA: 0x20C3AE0 Offset: 0x20C20E0 VA: 0x1820C3AE0
	|-ClassPropertyWriter<sbyte, int>..ctor
	|
	|-RVA: 0x20C5820 Offset: 0x20C3E20 VA: 0x1820C5820
	|-ClassPropertyWriter<sbyte, long>..ctor
	|
	|-RVA: 0x1B0F960 Offset: 0x1B0DF60 VA: 0x181B0F960
	|-ClassPropertyWriter<sbyte, object>..ctor
	|
	|-RVA: 0x1B116A0 Offset: 0x1B0FCA0 VA: 0x181B116A0
	|-ClassPropertyWriter<float, int>..ctor
	|
	|-RVA: 0x1B11020 Offset: 0x1B0F620 VA: 0x181B11020
	|-ClassPropertyWriter<float, long>..ctor
	|
	|-RVA: 0x1B0FB00 Offset: 0x1B0E100 VA: 0x181B0FB00
	|-ClassPropertyWriter<float, object>..ctor
	|
	|-RVA: 0x1B10B40 Offset: 0x1B0F140 VA: 0x181B10B40
	|-ClassPropertyWriter<TimeSpan, int>..ctor
	|
	|-RVA: 0x1B10E80 Offset: 0x1B0F480 VA: 0x181B10E80
	|-ClassPropertyWriter<TimeSpan, long>..ctor
	|
	|-RVA: 0x1B104C0 Offset: 0x1B0EAC0 VA: 0x181B104C0
	|-ClassPropertyWriter<TimeSpan, object>..ctor
	|
	|-RVA: 0x1B0FFE0 Offset: 0x1B0E5E0 VA: 0x181B0FFE0
	|-ClassPropertyWriter<ushort, int>..ctor
	|
	|-RVA: 0x1B10180 Offset: 0x1B0E780 VA: 0x181B10180
	|-ClassPropertyWriter<ushort, long>..ctor
	|
	|-RVA: 0x1B11500 Offset: 0x1B0FB00 VA: 0x181B11500
	|-ClassPropertyWriter<ushort, object>..ctor
	|
	|-RVA: 0x1B111C0 Offset: 0x1B0F7C0 VA: 0x181B111C0
	|-ClassPropertyWriter<uint, int>..ctor
	|
	|-RVA: 0x1B11360 Offset: 0x1B0F960 VA: 0x181B11360
	|-ClassPropertyWriter<uint, long>..ctor
	|
	|-RVA: 0x1B10660 Offset: 0x1B0EC60 VA: 0x181B10660
	|-ClassPropertyWriter<uint, object>..ctor
	|
	|-RVA: 0x1B10800 Offset: 0x1B0EE00 VA: 0x181B10800
	|-ClassPropertyWriter<ulong, int>..ctor
	|
	|-RVA: 0x1B109A0 Offset: 0x1B0EFA0 VA: 0x181B109A0
	|-ClassPropertyWriter<ulong, long>..ctor
	|
	|-RVA: 0x1B0FE40 Offset: 0x1B0E440 VA: 0x181B0FE40
	|-ClassPropertyWriter<ulong, object>..ctor
	|
	|-RVA: 0x1B0FCA0 Offset: 0x1B0E2A0 VA: 0x181B0FCA0
	|-ClassPropertyWriter<UIntPtr, int>..ctor
	|
	|-RVA: 0x1B10320 Offset: 0x1B0E920 VA: 0x181B10320
	|-ClassPropertyWriter<UIntPtr, long>..ctor
	|
	|-RVA: 0x1B10CE0 Offset: 0x1B0F2E0 VA: 0x181B10CE0
	|-ClassPropertyWriter<UIntPtr, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Write(TraceLoggingDataCollector collector, ref ContainerType container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20C0AC0 Offset: 0x20BF0C0 VA: 0x1820C0AC0
	|-ClassPropertyWriter<bool, int>.Write
	|-ClassPropertyWriter<byte, int>.Write
	|-ClassPropertyWriter<sbyte, int>.Write
	|
	|-RVA: 0x1B0F500 Offset: 0x1B0DB00 VA: 0x181B0F500
	|-ClassPropertyWriter<bool, long>.Write
	|-ClassPropertyWriter<bool, object>.Write
	|-ClassPropertyWriter<byte, long>.Write
	|-ClassPropertyWriter<byte, object>.Write
	|-ClassPropertyWriter<sbyte, long>.Write
	|-ClassPropertyWriter<sbyte, object>.Write
	|
	|-RVA: 0x1B0F7A0 Offset: 0x1B0DDA0 VA: 0x181B0F7A0
	|-ClassPropertyWriter<char, int>.Write
	|-ClassPropertyWriter<short, int>.Write
	|-ClassPropertyWriter<ushort, int>.Write
	|
	|-RVA: 0x1B0F490 Offset: 0x1B0DA90 VA: 0x181B0F490
	|-ClassPropertyWriter<char, long>.Write
	|-ClassPropertyWriter<char, object>.Write
	|-ClassPropertyWriter<short, long>.Write
	|-ClassPropertyWriter<short, object>.Write
	|-ClassPropertyWriter<ushort, long>.Write
	|-ClassPropertyWriter<ushort, object>.Write
	|
	|-RVA: 0x20C0A40 Offset: 0x20BF040 VA: 0x1820C0A40
	|-ClassPropertyWriter<KeyValuePair<object, object>, int>.Write
	|-ClassPropertyWriter<DateTimeOffset, int>.Write
	|-ClassPropertyWriter<Decimal, int>.Write
	|-ClassPropertyWriter<Guid, int>.Write
	|
	|-RVA: 0x20C0950 Offset: 0x20BEF50 VA: 0x1820C0950
	|-ClassPropertyWriter<KeyValuePair<object, object>, long>.Write
	|-ClassPropertyWriter<KeyValuePair<object, object>, object>.Write
	|-ClassPropertyWriter<DateTimeOffset, long>.Write
	|-ClassPropertyWriter<DateTimeOffset, object>.Write
	|-ClassPropertyWriter<Decimal, long>.Write
	|-ClassPropertyWriter<Decimal, object>.Write
	|-ClassPropertyWriter<Guid, long>.Write
	|-ClassPropertyWriter<Guid, object>.Write
	|
	|-RVA: 0x1B0F810 Offset: 0x1B0DE10 VA: 0x181B0F810
	|-ClassPropertyWriter<DateTime, int>.Write
	|-ClassPropertyWriter<TimeSpan, int>.Write
	|
	|-RVA: 0x1B0F880 Offset: 0x1B0DE80 VA: 0x181B0F880
	|-ClassPropertyWriter<DateTime, long>.Write
	|-ClassPropertyWriter<DateTime, object>.Write
	|-ClassPropertyWriter<TimeSpan, long>.Write
	|-ClassPropertyWriter<TimeSpan, object>.Write
	|
	|-RVA: 0x20C0CF0 Offset: 0x20BF2F0 VA: 0x1820C0CF0
	|-ClassPropertyWriter<EmptyStruct, int>.Write
	|
	|-RVA: 0x20C09D0 Offset: 0x20BEFD0 VA: 0x1820C09D0
	|-ClassPropertyWriter<EmptyStruct, long>.Write
	|-ClassPropertyWriter<EmptyStruct, object>.Write
	|
	|-RVA: 0x20C0C80 Offset: 0x20BF280 VA: 0x1820C0C80
	|-ClassPropertyWriter<double, int>.Write
	|
	|-RVA: 0x20C0BA0 Offset: 0x20BF1A0 VA: 0x1820C0BA0
	|-ClassPropertyWriter<double, long>.Write
	|-ClassPropertyWriter<double, object>.Write
	|
	|-RVA: 0x1B0F8F0 Offset: 0x1B0DEF0 VA: 0x181B0F8F0
	|-ClassPropertyWriter<int, int>.Write
	|-ClassPropertyWriter<uint, int>.Write
	|
	|-RVA: 0x1B0F650 Offset: 0x1B0DC50 VA: 0x181B0F650
	|-ClassPropertyWriter<int, long>.Write
	|-ClassPropertyWriter<int, object>.Write
	|-ClassPropertyWriter<uint, long>.Write
	|-ClassPropertyWriter<uint, object>.Write
	|
	|-RVA: 0x1B0F730 Offset: 0x1B0DD30 VA: 0x181B0F730
	|-ClassPropertyWriter<long, int>.Write
	|-ClassPropertyWriter<IntPtr, int>.Write
	|-ClassPropertyWriter<ulong, int>.Write
	|-ClassPropertyWriter<UIntPtr, int>.Write
	|
	|-RVA: 0x1B0F5E0 Offset: 0x1B0DBE0 VA: 0x181B0F5E0
	|-ClassPropertyWriter<long, long>.Write
	|-ClassPropertyWriter<long, object>.Write
	|-ClassPropertyWriter<IntPtr, long>.Write
	|-ClassPropertyWriter<IntPtr, object>.Write
	|-ClassPropertyWriter<ulong, long>.Write
	|-ClassPropertyWriter<ulong, object>.Write
	|-ClassPropertyWriter<UIntPtr, long>.Write
	|-ClassPropertyWriter<UIntPtr, object>.Write
	|
	|-RVA: 0x20C0C10 Offset: 0x20BF210 VA: 0x1820C0C10
	|-ClassPropertyWriter<object, int>.Write
	|
	|-RVA: 0x20C0B30 Offset: 0x20BF130 VA: 0x1820C0B30
	|-ClassPropertyWriter<object, long>.Write
	|-ClassPropertyWriter<object, object>.Write
	|
	|-RVA: 0x1B0F6C0 Offset: 0x1B0DCC0 VA: 0x181B0F6C0
	|-ClassPropertyWriter<float, int>.Write
	|
	|-RVA: 0x1B0F570 Offset: 0x1B0DB70 VA: 0x181B0F570
	|-ClassPropertyWriter<float, long>.Write
	|-ClassPropertyWriter<float, object>.Write
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override object GetData(ContainerType container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B0F2A0 Offset: 0x1B0D8A0 VA: 0x181B0F2A0
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
	|-RVA: 0x1B0F200 Offset: 0x1B0D800 VA: 0x181B0F200
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
	|-RVA: 0x1B0F270 Offset: 0x1B0D870 VA: 0x181B0F270
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
	|-RVA: 0x20C0670 Offset: 0x20BEC70 VA: 0x1820C0670
	|-ClassPropertyWriter<KeyValuePair<object, object>, int>.GetData
	|-ClassPropertyWriter<DateTimeOffset, int>.GetData
	|-ClassPropertyWriter<Decimal, int>.GetData
	|-ClassPropertyWriter<Guid, int>.GetData
	|
	|-RVA: 0x20C0720 Offset: 0x20BED20 VA: 0x1820C0720
	|-ClassPropertyWriter<KeyValuePair<object, object>, long>.GetData
	|-ClassPropertyWriter<DateTimeOffset, long>.GetData
	|-ClassPropertyWriter<Decimal, long>.GetData
	|-ClassPropertyWriter<Guid, long>.GetData
	|
	|-RVA: 0x20C06E0 Offset: 0x20BECE0 VA: 0x1820C06E0
	|-ClassPropertyWriter<KeyValuePair<object, object>, object>.GetData
	|-ClassPropertyWriter<DateTimeOffset, object>.GetData
	|-ClassPropertyWriter<Decimal, object>.GetData
	|-ClassPropertyWriter<Guid, object>.GetData
	|
	|-RVA: 0x1B0F310 Offset: 0x1B0D910 VA: 0x181B0F310
	|-ClassPropertyWriter<DateTime, int>.GetData
	|-ClassPropertyWriter<long, int>.GetData
	|-ClassPropertyWriter<IntPtr, int>.GetData
	|-ClassPropertyWriter<TimeSpan, int>.GetData
	|-ClassPropertyWriter<ulong, int>.GetData
	|-ClassPropertyWriter<UIntPtr, int>.GetData
	|
	|-RVA: 0x20C0860 Offset: 0x20BEE60 VA: 0x1820C0860
	|-ClassPropertyWriter<double, int>.GetData
	|
	|-RVA: 0x1B0F3F0 Offset: 0x1B0D9F0 VA: 0x181B0F3F0
	|-ClassPropertyWriter<double, long>.GetData
	|-ClassPropertyWriter<float, long>.GetData
	|
	|-RVA: 0x1B0F460 Offset: 0x1B0DA60 VA: 0x181B0F460
	|-ClassPropertyWriter<double, object>.GetData
	|-ClassPropertyWriter<float, object>.GetData
	|
	|-RVA: 0x20C08D0 Offset: 0x20BEED0 VA: 0x1820C08D0
	|-ClassPropertyWriter<object, int>.GetData
	|
	|-RVA: 0x20C07E0 Offset: 0x20BEDE0 VA: 0x1820C07E0
	|-ClassPropertyWriter<object, long>.GetData
	|
	|-RVA: 0x20C07A0 Offset: 0x20BEDA0 VA: 0x1820C07A0
	|-ClassPropertyWriter<object, object>.GetData
	|
	|-RVA: 0x1B0F380 Offset: 0x1B0D980 VA: 0x181B0F380
	|-ClassPropertyWriter<float, int>.GetData
	*/

}

internal sealed class NullTypeInfo<DataType> : TraceLoggingTypeInfo<DataType> // TypeDefIndex: 1531
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B52BC0 Offset: 0x1B511C0 VA: 0x181B52BC0
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
	|-RVA: 0x11B6930 Offset: 0x11B4F30 VA: 0x1811B6930
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
	|-RVA: 0x1B58680 Offset: 0x1B56C80 VA: 0x181B58680
	|-TraceLoggingTypeInfo<bool>..ctor
	|
	|-RVA: 0x1B9C950 Offset: 0x1B9AF50 VA: 0x181B9C950
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
	|-RVA: 0x1B9B8A0 Offset: 0x1B99EA0 VA: 0x181B9B8A0
	|-TraceLoggingTypeInfo<byte>..ctor
	|
	|-RVA: 0x1B9B730 Offset: 0x1B99D30 VA: 0x181B9B730
	|-TraceLoggingTypeInfo<char>..ctor
	|
	|-RVA: 0x1B9C750 Offset: 0x1B9AD50 VA: 0x181B9C750
	|-TraceLoggingTypeInfo<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x1B9C6C0 Offset: 0x1B9ACC0 VA: 0x181B9C6C0
	|-TraceLoggingTypeInfo<DateTime>..ctor
	|
	|-RVA: 0x1B9C270 Offset: 0x1B9A870 VA: 0x181B9C270
	|-TraceLoggingTypeInfo<DateTimeOffset>..ctor
	|
	|-RVA: 0x1B9C300 Offset: 0x1B9A900 VA: 0x181B9C300
	|-TraceLoggingTypeInfo<Decimal>..ctor
	|
	|-RVA: 0x1B9B5C0 Offset: 0x1B99BC0 VA: 0x181B9B5C0
	|-TraceLoggingTypeInfo<EmptyStruct>..ctor
	|
	|-RVA: 0x1B9BAF0 Offset: 0x1B9A0F0 VA: 0x181B9BAF0
	|-TraceLoggingTypeInfo<double>..ctor
	|
	|-RVA: 0x1B9CDA0 Offset: 0x1B9B3A0 VA: 0x181B9CDA0
	|-TraceLoggingTypeInfo<Guid>..ctor
	|
	|-RVA: 0x1B9CC30 Offset: 0x1B9B230 VA: 0x181B9CC30
	|-TraceLoggingTypeInfo<short>..ctor
	|
	|-RVA: 0x1B9BD40 Offset: 0x1B9A340 VA: 0x181B9BD40
	|-TraceLoggingTypeInfo<int>..ctor
	|
	|-RVA: 0x1B9C070 Offset: 0x1B9A670 VA: 0x181B9C070
	|-TraceLoggingTypeInfo<long>..ctor
	|
	|-RVA: 0x1B9C7E0 Offset: 0x1B9ADE0 VA: 0x181B9C7E0
	|-TraceLoggingTypeInfo<IntPtr>..ctor
	|
	|-RVA: 0x1B9C390 Offset: 0x1B9A990 VA: 0x181B9C390
	|-TraceLoggingTypeInfo<sbyte>..ctor
	|
	|-RVA: 0x1B9CAC0 Offset: 0x1B9B0C0 VA: 0x181B9CAC0
	|-TraceLoggingTypeInfo<float>..ctor
	|
	|-RVA: 0x1B9B170 Offset: 0x1B99770 VA: 0x181B9B170
	|-TraceLoggingTypeInfo<TimeSpan>..ctor
	|
	|-RVA: 0x1B9CF10 Offset: 0x1B9B510 VA: 0x181B9CF10
	|-TraceLoggingTypeInfo<ushort>..ctor
	|
	|-RVA: 0x1B9C100 Offset: 0x1B9A700 VA: 0x181B9C100
	|-TraceLoggingTypeInfo<uint>..ctor
	|
	|-RVA: 0x1B9B370 Offset: 0x1B99970 VA: 0x181B9B370
	|-TraceLoggingTypeInfo<ulong>..ctor
	|
	|-RVA: 0x1B9B200 Offset: 0x1B99800 VA: 0x181B9B200
	|-TraceLoggingTypeInfo<UIntPtr>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(string name, EventLevel level, EventOpcode opcode, EventKeywords keywords, EventTags tags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B585A0 Offset: 0x1B56BA0 VA: 0x181B585A0
	|-TraceLoggingTypeInfo<bool>..ctor
	|
	|-RVA: 0x1B9CCC0 Offset: 0x1B9B2C0 VA: 0x181B9CCC0
	|-TraceLoggingTypeInfo<byte>..ctor
	|
	|-RVA: 0x1B9BDD0 Offset: 0x1B9A3D0 VA: 0x181B9BDD0
	|-TraceLoggingTypeInfo<char>..ctor
	|
	|-RVA: 0x1B9BB80 Offset: 0x1B9A180 VA: 0x181B9BB80
	|-TraceLoggingTypeInfo<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x1B9BF90 Offset: 0x1B9A590 VA: 0x181B9BF90
	|-TraceLoggingTypeInfo<DateTime>..ctor
	|
	|-RVA: 0x1B9C870 Offset: 0x1B9AE70 VA: 0x181B9C870
	|-TraceLoggingTypeInfo<DateTimeOffset>..ctor
	|
	|-RVA: 0x1B9BA10 Offset: 0x1B9A010 VA: 0x181B9BA10
	|-TraceLoggingTypeInfo<Decimal>..ctor
	|
	|-RVA: 0x1B9BC60 Offset: 0x1B9A260 VA: 0x181B9BC60
	|-TraceLoggingTypeInfo<EmptyStruct>..ctor
	|
	|-RVA: 0x1B9BEB0 Offset: 0x1B9A4B0 VA: 0x181B9BEB0
	|-TraceLoggingTypeInfo<double>..ctor
	|
	|-RVA: 0x1B9B4E0 Offset: 0x1B99AE0 VA: 0x181B9B4E0
	|-TraceLoggingTypeInfo<Guid>..ctor
	|
	|-RVA: 0x1B9CE30 Offset: 0x1B9B430 VA: 0x181B9CE30
	|-TraceLoggingTypeInfo<short>..ctor
	|
	|-RVA: 0x1B9B7C0 Offset: 0x1B99DC0 VA: 0x181B9B7C0
	|-TraceLoggingTypeInfo<int>..ctor
	|
	|-RVA: 0x1B9B400 Offset: 0x1B99A00 VA: 0x181B9B400
	|-TraceLoggingTypeInfo<long>..ctor
	|
	|-RVA: 0x1B9C420 Offset: 0x1B9AA20 VA: 0x181B9C420
	|-TraceLoggingTypeInfo<IntPtr>..ctor
	|
	|-RVA: 0x1B9B650 Offset: 0x1B99C50 VA: 0x181B9B650
	|-TraceLoggingTypeInfo<object>..ctor
	|
	|-RVA: 0x1B9C500 Offset: 0x1B9AB00 VA: 0x181B9C500
	|-TraceLoggingTypeInfo<sbyte>..ctor
	|
	|-RVA: 0x1B9C190 Offset: 0x1B9A790 VA: 0x181B9C190
	|-TraceLoggingTypeInfo<float>..ctor
	|
	|-RVA: 0x1B9C5E0 Offset: 0x1B9ABE0 VA: 0x181B9C5E0
	|-TraceLoggingTypeInfo<TimeSpan>..ctor
	|
	|-RVA: 0x1B9B290 Offset: 0x1B99890 VA: 0x181B9B290
	|-TraceLoggingTypeInfo<ushort>..ctor
	|
	|-RVA: 0x1B9CB50 Offset: 0x1B9B150 VA: 0x181B9CB50
	|-TraceLoggingTypeInfo<uint>..ctor
	|
	|-RVA: 0x1B9B930 Offset: 0x1B99F30 VA: 0x181B9B930
	|-TraceLoggingTypeInfo<ulong>..ctor
	|
	|-RVA: 0x1B9C9E0 Offset: 0x1B9AFE0 VA: 0x181B9C9E0
	|-TraceLoggingTypeInfo<UIntPtr>..ctor
	*/

	// RVA: -1 Offset: -1
	public static TraceLoggingTypeInfo<DataType> get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B58710 Offset: 0x1B56D10 VA: 0x181B58710
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
	|-RVA: 0x1B584F0 Offset: 0x1B56AF0 VA: 0x181B584F0
	|-TraceLoggingTypeInfo<bool>.WriteObjectData
	|-TraceLoggingTypeInfo<byte>.WriteObjectData
	|-TraceLoggingTypeInfo<EmptyStruct>.WriteObjectData
	|-TraceLoggingTypeInfo<sbyte>.WriteObjectData
	|
	|-RVA: 0x1B9AF60 Offset: 0x1B99560 VA: 0x181B9AF60
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
	|-RVA: 0x1B9AE00 Offset: 0x1B99400 VA: 0x181B9AE00
	|-TraceLoggingTypeInfo<char>.WriteObjectData
	|-TraceLoggingTypeInfo<short>.WriteObjectData
	|-TraceLoggingTypeInfo<ushort>.WriteObjectData
	|
	|-RVA: 0x1B9AD50 Offset: 0x1B99350 VA: 0x181B9AD50
	|-TraceLoggingTypeInfo<KeyValuePair<object, object>>.WriteObjectData
	|-TraceLoggingTypeInfo<DateTimeOffset>.WriteObjectData
	|-TraceLoggingTypeInfo<Decimal>.WriteObjectData
	|-TraceLoggingTypeInfo<Guid>.WriteObjectData
	|
	|-RVA: 0x1B9ACA0 Offset: 0x1B992A0 VA: 0x181B9ACA0
	|-TraceLoggingTypeInfo<DateTime>.WriteObjectData
	|-TraceLoggingTypeInfo<long>.WriteObjectData
	|-TraceLoggingTypeInfo<IntPtr>.WriteObjectData
	|-TraceLoggingTypeInfo<TimeSpan>.WriteObjectData
	|-TraceLoggingTypeInfo<ulong>.WriteObjectData
	|-TraceLoggingTypeInfo<UIntPtr>.WriteObjectData
	|
	|-RVA: 0x1B9B0C0 Offset: 0x1B996C0 VA: 0x181B9B0C0
	|-TraceLoggingTypeInfo<double>.WriteObjectData
	|
	|-RVA: 0x1B9B010 Offset: 0x1B99610 VA: 0x181B9B010
	|-TraceLoggingTypeInfo<int>.WriteObjectData
	|-TraceLoggingTypeInfo<uint>.WriteObjectData
	|
	|-RVA: 0x1B9AEB0 Offset: 0x1B994B0 VA: 0x181B9AEB0
	|-TraceLoggingTypeInfo<float>.WriteObjectData
	*/

	// RVA: -1 Offset: -1
	internal static TraceLoggingTypeInfo<DataType> GetInstance(List<Type> recursionCheck) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B58290 Offset: 0x1B56890 VA: 0x181B58290
	|-TraceLoggingTypeInfo<bool>.GetInstance
	|
	|-RVA: 0x1B98180 Offset: 0x1B96780 VA: 0x181B98180
	|-TraceLoggingTypeInfo<byte>.GetInstance
	|
	|-RVA: 0x1B99920 Offset: 0x1B97F20 VA: 0x181B99920
	|-TraceLoggingTypeInfo<char>.GetInstance
	|
	|-RVA: 0x1B99410 Offset: 0x1B97A10 VA: 0x181B99410
	|-TraceLoggingTypeInfo<KeyValuePair<object, object>>.GetInstance
	|
	|-RVA: 0x1B99C80 Offset: 0x1B98280 VA: 0x181B99C80
	|-TraceLoggingTypeInfo<DateTime>.GetInstance
	|
	|-RVA: 0x1B989F0 Offset: 0x1B96FF0 VA: 0x181B989F0
	|-TraceLoggingTypeInfo<DateTimeOffset>.GetInstance
	|
	|-RVA: 0x1B990B0 Offset: 0x1B976B0 VA: 0x181B990B0
	|-TraceLoggingTypeInfo<Decimal>.GetInstance
	|
	|-RVA: 0x1B99AD0 Offset: 0x1B980D0 VA: 0x181B99AD0
	|-TraceLoggingTypeInfo<EmptyStruct>.GetInstance
	|
	|-RVA: 0x1B98840 Offset: 0x1B96E40 VA: 0x181B98840
	|-TraceLoggingTypeInfo<double>.GetInstance
	|
	|-RVA: 0x1B99770 Offset: 0x1B97D70 VA: 0x181B99770
	|-TraceLoggingTypeInfo<Guid>.GetInstance
	|
	|-RVA: 0x1B98BA0 Offset: 0x1B971A0 VA: 0x181B98BA0
	|-TraceLoggingTypeInfo<short>.GetInstance
	|
	|-RVA: 0x1B98330 Offset: 0x1B96930 VA: 0x181B98330
	|-TraceLoggingTypeInfo<int>.GetInstance
	|
	|-RVA: 0x1B995C0 Offset: 0x1B97BC0 VA: 0x181B995C0
	|-TraceLoggingTypeInfo<long>.GetInstance
	|
	|-RVA: 0x1B99260 Offset: 0x1B97860 VA: 0x181B99260
	|-TraceLoggingTypeInfo<IntPtr>.GetInstance
	|
	|-RVA: 0x1B984E0 Offset: 0x1B96AE0 VA: 0x181B984E0
	|-TraceLoggingTypeInfo<object>.GetInstance
	|
	|-RVA: 0x1B97AC0 Offset: 0x1B960C0 VA: 0x181B97AC0
	|-TraceLoggingTypeInfo<sbyte>.GetInstance
	|
	|-RVA: 0x1B98F00 Offset: 0x1B97500 VA: 0x181B98F00
	|-TraceLoggingTypeInfo<float>.GetInstance
	|
	|-RVA: 0x1B97FD0 Offset: 0x1B965D0 VA: 0x181B97FD0
	|-TraceLoggingTypeInfo<TimeSpan>.GetInstance
	|
	|-RVA: 0x1B97E20 Offset: 0x1B96420 VA: 0x181B97E20
	|-TraceLoggingTypeInfo<ushort>.GetInstance
	|
	|-RVA: 0x1B97C70 Offset: 0x1B96270 VA: 0x181B97C70
	|-TraceLoggingTypeInfo<uint>.GetInstance
	|
	|-RVA: 0x1B98690 Offset: 0x1B96C90 VA: 0x181B98690
	|-TraceLoggingTypeInfo<ulong>.GetInstance
	|
	|-RVA: 0x1B98D50 Offset: 0x1B97350 VA: 0x181B98D50
	|-TraceLoggingTypeInfo<UIntPtr>.GetInstance
	*/

	// RVA: -1 Offset: -1
	private static TraceLoggingTypeInfo<DataType> InitInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B58440 Offset: 0x1B56A40 VA: 0x181B58440
	|-TraceLoggingTypeInfo<bool>.InitInstance
	|
	|-RVA: 0x1B9A300 Offset: 0x1B98900 VA: 0x181B9A300
	|-TraceLoggingTypeInfo<byte>.InitInstance
	|
	|-RVA: 0x1B9AA90 Offset: 0x1B99090 VA: 0x181B9AA90
	|-TraceLoggingTypeInfo<char>.InitInstance
	|
	|-RVA: 0x1B9A0F0 Offset: 0x1B986F0 VA: 0x181B9A0F0
	|-TraceLoggingTypeInfo<KeyValuePair<object, object>>.InitInstance
	|
	|-RVA: 0x1B9A7D0 Offset: 0x1B98DD0 VA: 0x181B9A7D0
	|-TraceLoggingTypeInfo<DateTime>.InitInstance
	|
	|-RVA: 0x1B99EE0 Offset: 0x1B984E0 VA: 0x181B99EE0
	|-TraceLoggingTypeInfo<DateTimeOffset>.InitInstance
	|
	|-RVA: 0x1B9A510 Offset: 0x1B98B10 VA: 0x181B9A510
	|-TraceLoggingTypeInfo<Decimal>.InitInstance
	|
	|-RVA: 0x1B99F90 Offset: 0x1B98590 VA: 0x181B99F90
	|-TraceLoggingTypeInfo<EmptyStruct>.InitInstance
	|
	|-RVA: 0x1B9A720 Offset: 0x1B98D20 VA: 0x181B9A720
	|-TraceLoggingTypeInfo<double>.InitInstance
	|
	|-RVA: 0x1B99E30 Offset: 0x1B98430 VA: 0x181B99E30
	|-TraceLoggingTypeInfo<Guid>.InitInstance
	|
	|-RVA: 0x1B9ABF0 Offset: 0x1B991F0 VA: 0x181B9ABF0
	|-TraceLoggingTypeInfo<short>.InitInstance
	|
	|-RVA: 0x1B9A670 Offset: 0x1B98C70 VA: 0x181B9A670
	|-TraceLoggingTypeInfo<int>.InitInstance
	|
	|-RVA: 0x1B9A040 Offset: 0x1B98640 VA: 0x181B9A040
	|-TraceLoggingTypeInfo<long>.InitInstance
	|
	|-RVA: 0x1B9A460 Offset: 0x1B98A60 VA: 0x181B9A460
	|-TraceLoggingTypeInfo<IntPtr>.InitInstance
	|
	|-RVA: 0x1B9A930 Offset: 0x1B98F30 VA: 0x181B9A930
	|-TraceLoggingTypeInfo<object>.InitInstance
	|
	|-RVA: 0x1B9A5C0 Offset: 0x1B98BC0 VA: 0x181B9A5C0
	|-TraceLoggingTypeInfo<sbyte>.InitInstance
	|
	|-RVA: 0x1B9AB40 Offset: 0x1B99140 VA: 0x181B9AB40
	|-TraceLoggingTypeInfo<float>.InitInstance
	|
	|-RVA: 0x1B9A3B0 Offset: 0x1B989B0 VA: 0x181B9A3B0
	|-TraceLoggingTypeInfo<TimeSpan>.InitInstance
	|
	|-RVA: 0x1B9A880 Offset: 0x1B98E80 VA: 0x181B9A880
	|-TraceLoggingTypeInfo<ushort>.InitInstance
	|
	|-RVA: 0x1B9A1A0 Offset: 0x1B987A0 VA: 0x181B9A1A0
	|-TraceLoggingTypeInfo<uint>.InitInstance
	|
	|-RVA: 0x1B9A9E0 Offset: 0x1B98FE0 VA: 0x181B9A9E0
	|-TraceLoggingTypeInfo<ulong>.InitInstance
	|
	|-RVA: 0x1B9A250 Offset: 0x1B98850 VA: 0x181B9A250
	|-TraceLoggingTypeInfo<UIntPtr>.InitInstance
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 1635
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 0392525BCB01691D1F319D89F2C12BF93A478467 /*Metadata offset 0x521C34*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 0588059ACBD52F7EA2835882F977A9CF72EB9775 /*Metadata offset 0x521D34*/; // 0x100
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=84 0A1ADB22C1D3E1F4B2448EE3F27DF9DE63329C4C /*Metadata offset 0x521D7C*/; // 0x148
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=240 121EC59E23F7559B28D338D562528F6299C2DE22 /*Metadata offset 0x521DD0*/; // 0x19C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 12D04472A8285260EA12FD3813CDFA9F2D2B548C /*Metadata offset 0x521EC0*/; // 0x28C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 13A35EF1A549297C70E2AD46045BBD2ECA17852D /*Metadata offset 0x521EC3*/; // 0x28F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 1730F09044E91DB8371B849EFF5E6D17BDE4AED0 /*Metadata offset 0x521EC6*/; // 0x292
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 1A84029C80CB5518379F199F53FF08A7B764F8FD /*Metadata offset 0x521EDE*/; // 0x2AA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096 1AEF3D8DF416A46288C91C724CBF7B154D9E5BF3 /*Metadata offset 0x521EE1*/; // 0x2AD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 1E41C4CD0767AEA21C00DEABA2EA9407F1E6CEA5 /*Metadata offset 0x522EE1*/; // 0x12AD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 1FE6CE411858B3D864679DE2139FB081F08BFACD /*Metadata offset 0x5236E1*/; // 0x1AAD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 235D99572263B22ADFEE10FDA0C25E12F4D94FFC /*Metadata offset 0x5236F1*/; // 0x1ABD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 25420D0055076FA8D3E4DD96BC53AE24DE6E619F /*Metadata offset 0x5236F4*/; // 0x1AC0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1208 25CF935D2AE9EDF05DD75BCD47FF84D9255D6F6E /*Metadata offset 0x52371C*/; // 0x1AE8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=42 29C1A61550F0E3260E1953D4FAD71C256218EF40 /*Metadata offset 0x523BD4*/; // 0x1FA0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 2B33BEC8C30DFDC49DAFE20D3BDE19487850D717 /*Metadata offset 0x523BFE*/; // 0x1FCA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 2BA840FF6020B8FF623DBCB7188248CF853FAF4F /*Metadata offset 0x523C0A*/; // 0x1FD6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 2C840AFA48C27B9C05593E468C1232CA1CC74AFD /*Metadata offset 0x523C2E*/; // 0x1FFA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 2D1DA5BB407F0C11C3B5116196C0C6374D932B20 /*Metadata offset 0x523C76*/; // 0x2042
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=14 2D3CF0F15AC2DDEC2956EA1B7BBE43FB8B923130 /*Metadata offset 0x523C86*/; // 0x2052
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 2F71D2DA12F3CD0A6A112F5A5A75B4FDC6FE8547 /*Metadata offset 0x523C94*/; // 0x2060
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 320B018758ECE3752FFEDBAEB1A6DB67C80B9359 /*Metadata offset 0x523CDC*/; // 0x20A8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 34476C29F6F81C989CFCA42F7C06E84C66236834 /*Metadata offset 0x523D1C*/; // 0x20E8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2382 35EED060772F2748D13B745DAEC8CD7BD3B87604 /*Metadata offset 0x523D64*/; // 0x2130
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=38 375F9AE9769A3D1DA789E9ACFE81F3A1BB14F0D3 /*Metadata offset 0x5246B2*/; // 0x2A7E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1450 379C06C9E702D31469C29033F0DD63931EB349F5 /*Metadata offset 0x5246D8*/; // 0x2AA4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 399BD13E240F33F808CA7940293D6EC4E6FD5A00 /*Metadata offset 0x524C82*/; // 0x304E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 39C9CE73C7B0619D409EF28344F687C1B5C130FE /*Metadata offset 0x524C8C*/; // 0x3058
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=320 3C53AFB51FEC23491684C7BEDBC6D4E0F409F851 /*Metadata offset 0x524CD4*/; // 0x30A0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 3E3442C7396F3F2BB4C7348F4A2074C7DC677D68 /*Metadata offset 0x524E14*/; // 0x31E0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 3E4BBF9D0CDD2E34F78AA7A9A3979DCE1F7B02BD /*Metadata offset 0x524E17*/; // 0x31E3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 3E823444D2DFECF0F90B436B88F02A533CB376F1 /*Metadata offset 0x524E57*/; // 0x3223
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 3FE6C283BCF384FD2C8789880DFF59664E2AB4A1 /*Metadata offset 0x524E63*/; // 0x322F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1665 40981BAA39513E58B28DCF0103CC04DE2A0A0444 /*Metadata offset 0x524EAB*/; // 0x3277
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 40E7C49413D261F3F38AD3A870C0AC69C8BDA048 /*Metadata offset 0x52552C*/; // 0x38F8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 421EC7E82F2967DF6CA8C3605514DC6F29EE5845 /*Metadata offset 0x525554*/; // 0x3920
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 433175D38B13FFE177FDD661A309F1B528B3F6E2 /*Metadata offset 0x52559C*/; // 0x3968
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=120 46232052BC757E030490D851F265FB47FA100902 /*Metadata offset 0x52569C*/; // 0x3A68
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 4858DB4AA76D3933F1CA9E6712D4FDB16903F628 /*Metadata offset 0x525714*/; // 0x3AE0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 4E3B533C39447AAEB59A8E48FABD7E15B5B5D195 /*Metadata offset 0x52575C*/; // 0x3B28
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 4F7A8890F332B22B8DE0BD29D36FA7364748D76A /*Metadata offset 0x52578C*/; // 0x3B58
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 536422B321459B242ADED7240B7447E904E083E3 /*Metadata offset 0x5257B4*/; // 0x3B80
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1080 5382CEF491F422BFE0D6FC46EFAFF9EF9D4C89F3 /*Metadata offset 0x5257FC*/; // 0x3BC8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 56DFA5053B3131883637F53219E7D88CCEF35949 /*Metadata offset 0x525C34*/; // 0x4000
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 57218C316B6921E2CD61027A2387EDC31A2D9471 /*Metadata offset 0x525C3E*/; // 0x400A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 57F320D62696EC99727E0FE2045A05F1289CC0C6 /*Metadata offset 0x525C41*/; // 0x400D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=212 594A33A00BC4F785DFD43E3C6C44FBA1242CCAF3 /*Metadata offset 0x525C69*/; // 0x4035
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 5BBDF8058D4235C33F2E8DCF76004031B6187A2F /*Metadata offset 0x525D3D*/; // 0x4109
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=288 5BCD21C341BE6DDF8FFFAE1A23ABA24DCBB612BF /*Metadata offset 0x525D61*/; // 0x412D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 5BFE2819B4778217C56416C7585FF0E56EBACD89 /*Metadata offset 0x525E81*/; // 0x424D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 609C0E8D8DA86A09D6013D301C86BA8782C16B8C /*Metadata offset 0x525EC9*/; // 0x4295
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 62BAB0F245E66C3EB982CF5A7015F0A7C3382283 /*Metadata offset 0x525F49*/; // 0x4315
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 646036A65DECCD6835C914A46E6E44B729433B60 /*Metadata offset 0x525F79*/; // 0x4345
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 65E32B4E150FD8D24B93B0D42A17F1DAD146162B /*Metadata offset 0x526779*/; // 0x4B45
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 6770974FEF1E98B9C1864370E2B5B786EB0EA39E /*Metadata offset 0x5267A1*/; // 0x4B6D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 67EEAD805D708D9AA4E14BF747E44CED801744F3 /*Metadata offset 0x5267D5*/; // 0x4BA1
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=120 6C71197D228427B2864C69B357FEF73D8C9D59DF /*Metadata offset 0x52681D*/; // 0x4BE9
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 6CEE45445AFD150B047A5866FFA76AA651CDB7B7 /*Metadata offset 0x526895*/; // 0x4C61
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9 6D49C9D487D7AD3491ECE08732D68A593CC2038D /*Metadata offset 0x5268A5*/; // 0x4C71
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 6D797C11E1D4FB68B6570CF2A92B792433527065 /*Metadata offset 0x5268AE*/; // 0x4C7A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3132 6E5DC824F803F8565AF31B42199DAE39FE7F4EA9 /*Metadata offset 0x5270AE*/; // 0x547A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=76 6FC754859E4EC74E447048364B216D825C6F8FE7 /*Metadata offset 0x527CEA*/; // 0x60B6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 704939CD172085D1295FCE3F1D92431D685D7AA2 /*Metadata offset 0x527D36*/; // 0x6102
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 7088AAE49F0627B72729078DE6E3182DDCF8ED99 /*Metadata offset 0x527D5E*/; // 0x612A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 7341C933A70EAE383CC50C4B945ADB8E08F06737 /*Metadata offset 0x527D76*/; // 0x6142
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 736D39815215889F11249D9958F6ED12D37B9F57 /*Metadata offset 0x527DBE*/; // 0x618A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096 7F42F2EDC974BE29B2746957416ED1AEFA605F47 /*Metadata offset 0x527DC1*/; // 0x618D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 7FE820C9CF0F0B90445A71F1D262D22E4F0C4C68 /*Metadata offset 0x528DC1*/; // 0x718D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=21252 811A927B7DADD378BE60BBDE794B9277AA9B50EC /*Metadata offset 0x528DE9*/; // 0x71B5
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 81917F1E21F3C22B9F916994547A614FB03E968E /*Metadata offset 0x52E0ED*/; // 0xC4B9
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 823566DA642D6EA356E15585921F2A4CA23D6760 /*Metadata offset 0x52E111*/; // 0xC4DD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 82C2A59850B2E85BCE1A45A479537A384DF6098D /*Metadata offset 0x52E139*/; // 0xC505
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 82C383F8E6E4D3D87AEBB986A5D0077E8AD157C4 /*Metadata offset 0x52E145*/; // 0xC511
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 86F4F563FA2C61798AE6238D789139739428463A /*Metadata offset 0x52E171*/; // 0xC53D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 871B9CF85DB352BAADF12BAE8F19857683E385AC /*Metadata offset 0x52E174*/; // 0xC540
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 89A040451C8CC5C8FB268BE44BDD74964C104155 /*Metadata offset 0x52E19C*/; // 0xC568
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 8CAA092E783257106251246FF5C97F88D28517A6 /*Metadata offset 0x52E1AC*/; // 0xC578
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2100 8D231DD55FE1AD7631BBD0905A17D5EB616C2154 /*Metadata offset 0x52E1D4*/; // 0xC5A0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 8E10AC2F34545DFBBF3FCBC06055D797A8C99991 /*Metadata offset 0x52EA08*/; // 0xCDD4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 8F22C9ECE1331718CBD268A9BBFD2F5E451441E3 /*Metadata offset 0x52EA30*/; // 0xCDFC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=640 90A0542282A011472F94E97CEAE59F8B3B1A3291 /*Metadata offset 0x52EB30*/; // 0xCEFC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 93A63E90605400F34B49F0EB3361D23C89164BDA /*Metadata offset 0x52EDB0*/; // 0xD17C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 94841DD2F330CCB1089BF413E4FA9B04505152E2 /*Metadata offset 0x52EDBC*/; // 0xD188
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 95264589E48F94B7857CFF398FB72A537E13EEE2 /*Metadata offset 0x52EE04*/; // 0xD1D0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 95C48758CAE1715783472FB073AB158AB8A0AB2A /*Metadata offset 0x52EE10*/; // 0xD1DC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 973417296623D8DC6961B09664E54039E44CA5D8 /*Metadata offset 0x52EE58*/; // 0xD224
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 97FB30C84FF4A41CD4625B44B2940BFC8DB43003 /*Metadata offset 0x52EEA0*/; // 0xD26C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096 99E2E88877D14C7DDC4E957A0ED7079CA0E9EB24 /*Metadata offset 0x52EEA3*/; // 0xD26F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 9A9C3962CD4753376E3507C8CB5FD8FCC4B4EDB5 /*Metadata offset 0x52FEA3*/; // 0xE26F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 9BB00D1FCCBAF03165447FC8028E7CA07CA9FE88 /*Metadata offset 0x52FEE3*/; // 0xE2AF
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 A0074C15377C0C870B055927403EA9FA7A349D12 /*Metadata offset 0x52FEE6*/; // 0xE2B2
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=130 A1319B706116AB2C6D44483F60A7D0ACEA543396 /*Metadata offset 0x52FF0E*/; // 0xE2DA
	internal static readonly long A13AA52274D951A18029131A8DDECF76B569A15D = -44474084896931794; // 0xE360
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 A323DB0813C4D072957BA6FDA79D9776674CD06B /*Metadata offset 0x52FF98*/; // 0xE368
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=212 A5444763673307F6828C748D4B9708CFC02B0959 /*Metadata offset 0x52FF9B*/; // 0xE36B
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 A6732F8E7FC23766AB329B492D6BF82E3B33233F /*Metadata offset 0x53006F*/; // 0xE43F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=174 A705A106D95282BD15E13EEA6B0AF583FF786D83 /*Metadata offset 0x5300B7*/; // 0xE487
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1018 A8A491E4CED49AE0027560476C10D933CE70C8DF /*Metadata offset 0x530165*/; // 0xE535
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 AC791C4F39504D1184B73478943D0636258DA7B1 /*Metadata offset 0x53055F*/; // 0xE92F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 AFCD4E1211233E99373A3367B23105A3D624B1F2 /*Metadata offset 0x5305A7*/; // 0xE977
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 B472ED77CB3B2A66D49D179F1EE2081B70A6AB61 /*Metadata offset 0x5305DB*/; // 0xE9AB
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 B4FBD02AAB5B16E0F4BD858DA5D9E348F3CE501D /*Metadata offset 0x530603*/; // 0xE9D3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 B53A2C6DF21FC88B17AEFC40EB895B8D63210CDF /*Metadata offset 0x530613*/; // 0xE9E3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096 B6002BBF29B2704922EC3BBF0F9EE40ABF185D6B /*Metadata offset 0x530713*/; // 0xEAE3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=998 B881DA88BE0B68D8A6B6B6893822586B8B2CFC45 /*Metadata offset 0x531713*/; // 0xFAE3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=162 B8864ACB9DD69E3D42151513C840AAE270BF21C8 /*Metadata offset 0x531AF9*/; // 0xFEC9
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=360 B8F87834C3597B2EEF22BA6D3A392CC925636401 /*Metadata offset 0x531B9B*/; // 0xFF6B
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 B9B670F134A59FB1107AF01A9FE8F8E3980B3093 /*Metadata offset 0x531D03*/; // 0x100D3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 BE1BDEC0AA74B4DCB079943E70528096CCA985F8 /*Metadata offset 0x531D4B*/; // 0x1011B
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 BEBC9ECC660A13EFC359BA3383411F698CFF25DB /*Metadata offset 0x531D5F*/; // 0x1012F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 BEE1CFE5DFAA408E14CE4AF4DCD824FA2E42DCB7 /*Metadata offset 0x531DA7*/; // 0x10177
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 BF477463CE2F5EF38FC4C644BBBF4DF109E7670A /*Metadata offset 0x531DCF*/; // 0x1019F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 BF5EB60806ECB74EE484105DD9D6F463BF994867 /*Metadata offset 0x531DD2*/; // 0x101A2
	internal static readonly long C1A1100642BA9685B30A84D97348484E14AA1865 = 23362753784184900; // 0x101A8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 C6F364A0AD934EFED8909446C215752E565D77C1 /*Metadata offset 0x531DE0*/; // 0x101B0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=174 CE5835130F5277F63D716FC9115526B0AC68FFAD /*Metadata offset 0x531DF0*/; // 0x101C0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 CE93C35B755802BC4B3D180716B048FC61701EF7 /*Metadata offset 0x531E9E*/; // 0x1026E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 CF0B42666EF5E37EDEA0AB8E173E42C196D03814 /*Metadata offset 0x531EA4*/; // 0x10274
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 D002CBBE1FF33721AF7C4D1D3ECAD1B7DB5258B7 /*Metadata offset 0x531EE4*/; // 0x102B4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 D117188BE8D4609C0D531C51B0BB911A4219DEBE /*Metadata offset 0x531FE4*/; // 0x103B4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 D28E8ABDBD777A482CE0EE5C24814ACAE52AABFE /*Metadata offset 0x532004*/; // 0x103D4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 D2C5BAE967587C6F3D9F2C4551911E0575A1101F /*Metadata offset 0x532024*/; // 0x103F4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=82 D76478B994B312CD022DCA207AA2254880D2FCC9 /*Metadata offset 0x532124*/; // 0x104F4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 D78D08081C7A5AD6FBA7A8DC86BCD6D7A577C636 /*Metadata offset 0x532176*/; // 0x10546
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=76 DA19DB47B583EFCF7825D2E39D661D2354F28219 /*Metadata offset 0x5321A2*/; // 0x10572
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 DC2B830D8CD59AD6A4E4332D21CA0DCA2821AD82 /*Metadata offset 0x5321EE*/; // 0x105BE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 DD3AEFEADB1CD615F3017763F1568179FEE640B0 /*Metadata offset 0x532226*/; // 0x105F6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 E1827270A5FE1C85F5352A66FD87BA747213D006 /*Metadata offset 0x53225A*/; // 0x1062A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 E45BAB43F7D5D038672B3E3431F92E34A7AF2571 /*Metadata offset 0x53227E*/; // 0x1064E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 E75835D001C843F156FBA01B001DFE1B8029AC17 /*Metadata offset 0x5322A6*/; // 0x10676
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 E92B39D8233061927D9ACDE54665E68E7535635A /*Metadata offset 0x5322E6*/; // 0x106B6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 EA9506959484C55CFE0C139C624DF6060E285866 /*Metadata offset 0x53231A*/; // 0x106EA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=262 EB5E9A80A40096AB74D2E226650C7258D7BC5E9D /*Metadata offset 0x532326*/; // 0x106F6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 EBF68F411848D603D059DFDEA2321C5A5EA78044 /*Metadata offset 0x53242C*/; // 0x107FC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 EC5BB4F59D4B9B2E9ECD3904D44A8275F23AFB11 /*Metadata offset 0x53246C*/; // 0x1083C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 EC83FB16C20052BEE2B4025159BC2ED45C9C70C3 /*Metadata offset 0x532476*/; // 0x10846
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 EC89C317EA2BF49A70EFF5E89C691E34733D7C37 /*Metadata offset 0x532479*/; // 0x10849
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 F06E829E62F3AFBC045D064E10A4F5DF7C969612 /*Metadata offset 0x5324C1*/; // 0x10891
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=11614 F073AA332018FDA0D572E99448FFF1D6422BD520 /*Metadata offset 0x5324E9*/; // 0x108B9
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=120 F34B0E10653402E8F788F8BC3F7CD7090928A429 /*Metadata offset 0x535247*/; // 0x13617
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 F37E34BEADB04F34FCC31078A59F49856CA83D5B /*Metadata offset 0x5352BF*/; // 0x1368F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=94 F512A9ABF88066AAEB92684F95CC05D8101B462B /*Metadata offset 0x535307*/; // 0x136D7
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 F8FAABB821300AA500C2CEC6091B3782A7FB44A4 /*Metadata offset 0x535365*/; // 0x13735
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2350 FCBD2781A933F0828ED4AAF88FD8B08D76DDD49B /*Metadata offset 0x535371*/; // 0x13741

	// Methods

	// RVA: 0xAAB500 Offset: 0xAA9B00 VA: 0x180AAB500
	internal static uint ComputeStringHash(string s) { }

}

internal class __Il2CppComObject // TypeDefIndex: 1690
{	// Methods

	// RVA: 0x214CCF0 Offset: 0x214B2F0 VA: 0x18214CCF0 Slot: 1
	protected override void Finalize() { }

}

internal sealed class __Il2CppComDelegate : __Il2CppComObject // TypeDefIndex: 1691
{	// Methods

	// RVA: 0x214CCF0 Offset: 0x214B2F0 VA: 0x18214CCF0 Slot: 1
	protected override void Finalize() { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 1772
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 12D04472A8285260EA12FD3813CDFA9F2D2B548C /*Metadata offset 0x535F77*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 13A35EF1A549297C70E2AD46045BBD2ECA17852D /*Metadata offset 0x535F7A*/; // 0x3
	internal static readonly long 16968835DEF6DD3BB86EABA9DEC53BF41851CD6D = -1295888024253181014; // 0x8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 1A84029C80CB5518379F199F53FF08A7B764F8FD /*Metadata offset 0x535F85*/; // 0x10
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 235D99572263B22ADFEE10FDA0C25E12F4D94FFC /*Metadata offset 0x535F88*/; // 0x13
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=14 2D3CF0F15AC2DDEC2956EA1B7BBE43FB8B923130 /*Metadata offset 0x535F8B*/; // 0x16
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 320B018758ECE3752FFEDBAEB1A6DB67C80B9359 /*Metadata offset 0x535F99*/; // 0x24
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 3E3442C7396F3F2BB4C7348F4A2074C7DC677D68 /*Metadata offset 0x535FD9*/; // 0x64
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 4E3B533C39447AAEB59A8E48FABD7E15B5B5D195 /*Metadata offset 0x535FDC*/; // 0x67
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 56DFA5053B3131883637F53219E7D88CCEF35949 /*Metadata offset 0x53600C*/; // 0x97
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9 6D49C9D487D7AD3491ECE08732D68A593CC2038D /*Metadata offset 0x536016*/; // 0xA1
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3132 6E5DC824F803F8565AF31B42199DAE39FE7F4EA9 /*Metadata offset 0x53601F*/; // 0xAA
	internal static readonly long 6FA00AC9FFFD87F82A38A7F9ECC8134F4A7052AF = 22609615381091406; // 0xCE8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 736D39815215889F11249D9958F6ED12D37B9F57 /*Metadata offset 0x536C63*/; // 0xCF0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 86F4F563FA2C61798AE6238D789139739428463A /*Metadata offset 0x536C66*/; // 0xCF3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 97FB30C84FF4A41CD4625B44B2940BFC8DB43003 /*Metadata offset 0x536C69*/; // 0xCF6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 9A9C3962CD4753376E3507C8CB5FD8FCC4B4EDB5 /*Metadata offset 0x536C6C*/; // 0xCF9
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 9BB00D1FCCBAF03165447FC8028E7CA07CA9FE88 /*Metadata offset 0x536CAC*/; // 0xD39
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 A323DB0813C4D072957BA6FDA79D9776674CD06B /*Metadata offset 0x536CAF*/; // 0xD3C
	internal static readonly long AEA5F1CC5CFE1660539EDD691FE017F775F63A0D = 2676302836908902219; // 0xD40
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 BE1BDEC0AA74B4DCB079943E70528096CCA985F8 /*Metadata offset 0x536CBA*/; // 0xD48
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 BF477463CE2F5EF38FC4C644BBBF4DF109E7670A /*Metadata offset 0x536CCE*/; // 0xD5C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 CF0B42666EF5E37EDEA0AB8E173E42C196D03814 /*Metadata offset 0x536CD1*/; // 0xD5F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 D28E8ABDBD777A482CE0EE5C24814ACAE52AABFE /*Metadata offset 0x536D11*/; // 0xD9F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 D2C5BAE967587C6F3D9F2C4551911E0575A1101F /*Metadata offset 0x536D31*/; // 0xDBF
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 E75835D001C843F156FBA01B001DFE1B8029AC17 /*Metadata offset 0x536E31*/; // 0xEBF
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 EC5BB4F59D4B9B2E9ECD3904D44A8275F23AFB11 /*Metadata offset 0x536E71*/; // 0xEFF
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 EC83FB16C20052BEE2B4025159BC2ED45C9C70C3 /*Metadata offset 0x536E7B*/; // 0xF09

	// Methods

	// RVA: 0xAAB500 Offset: 0xAA9B00 VA: 0x180AAB500
	internal static uint ComputeStringHash(string s) { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 2431
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 0701435C4E2C38EFE43C51BD22C114AB8B80124D /*Metadata offset 0x537DE5*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 0EE6555EB2C89F29655BD23FAB0573D8D684331A /*Metadata offset 0x537DF1*/; // 0xC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=68 0F6A1E2CEA2FA691D57F3F3FDCF9B82A3FBF6EE1 /*Metadata offset 0x537E15*/; // 0x30
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 161F91CE1721D8F16622810CBB39887D21C47031 /*Metadata offset 0x537E59*/; // 0x74
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 2051D7520B96DCC12F2E4DE851CB9F203D623805 /*Metadata offset 0x537E65*/; // 0x80
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 221CE291CD044114B4369175B9B91177F5932876 /*Metadata offset 0x537E85*/; // 0xA0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=38 2A4F1BD548EC71F652E24985361CD72F0FE1BE7D /*Metadata offset 0x537EB1*/; // 0xCC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 360487BE4278986419B568EFD887F6145383168A /*Metadata offset 0x537ED7*/; // 0xF2
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 42DDBEE388AB59C20A3D7D4D6555E78D74A45AE1 /*Metadata offset 0x537EFF*/; // 0x11A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 485F43E332C2F7530815B17C08DAC169A8F697E0 /*Metadata offset 0x537F13*/; // 0x12E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=112 49C5BA13401986EC93E4677F52CBE2248184DFBD /*Metadata offset 0x537F33*/; // 0x14E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 51E4CA1C2B009A2876C6E57D8E69E3502BCA3440 /*Metadata offset 0x537FA3*/; // 0x1BE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=960 553E235E202D57C9F1156E7D232E02BBDC920165 /*Metadata offset 0x537FBB*/; // 0x1D6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 574B9D4E4C39F6E8004181E5765B627B75EB1AD1 /*Metadata offset 0x53837B*/; // 0x596
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 5BE9DB9EEB9CBB4D22472CA9734B1FA1D36126BD /*Metadata offset 0x5383B3*/; // 0x5CE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 5D100A87B697F3AE2015A5D3B2A7B5419E1BCA98 /*Metadata offset 0x5383BF*/; // 0x5DA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=664 68D0F86889D5D656483EEE829BCEECDFEC91D8EA /*Metadata offset 0x5383C5*/; // 0x5E0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=416 6A0D50D692745A6663128CD315B71079584F3E59 /*Metadata offset 0x53865D*/; // 0x878
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 702F6A3276CBE481D247A77C20B5459FB94D07D2 /*Metadata offset 0x5387FD*/; // 0xA18
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 7A32E1A19C182315E4263A65A72066492550D8CD /*Metadata offset 0x538815*/; // 0xA30
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 8B4E5E81A88D29642679AFCE41DCA380F9000462 /*Metadata offset 0x538835*/; // 0xA50
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=960 977375E4E1ED54F588076ACA36CC17E6C2195CB9 /*Metadata offset 0x538845*/; // 0xA60
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 99F0664C2AC8464B51252D92FC24F3834C6FB90C /*Metadata offset 0x538C05*/; // 0xE20
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 9E31F24F64765FCAA589F589324D17C9FCF6A06D /*Metadata offset 0x538C11*/; // 0xE2C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 9E374D7263B2452E25DE3D6E617F6A728D98A439 /*Metadata offset 0x538C2D*/; // 0xE48
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=68 A933F173482FF50754B4942AF8DFC584EF14A45B /*Metadata offset 0x538CBD*/; // 0xED8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 AB4EAD1DB94B8220FAAEDAA6A593B2E6DB0A8A9C /*Metadata offset 0x538D01*/; // 0xF1C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=416 B368804F0C6DAB083B253A6B106D0783D5C32E90 /*Metadata offset 0x538D19*/; // 0xF34
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 B9F0004E3873FDDCABFDA6174EA18F0859B637B4 /*Metadata offset 0x538EB9*/; // 0x10D4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 BAD037B714E1CD1052149B51238A3D4351DD10B5 /*Metadata offset 0x538EE1*/; // 0x10FC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 C2D6E36D84DDA5D661B95D7B32D3F47CD7ACBF6C /*Metadata offset 0x538EF5*/; // 0x1110
	internal static readonly long DB9F879BE80CC2DA24DEF633D23DBB2B1ADBCC81 = 361700859878507267; // 0x1120
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 DCF398750721AA7A27A6BA56E99350329B06E8B1 /*Metadata offset 0x538F0D*/; // 0x1128
	internal static readonly long EBC658B067B5C785A3F0BB67D73755F6FEE7F70C = 3659217647501344; // 0x1138
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 ED18A4A1FF7C89B400D7CA156BA8D11BB09E1DE4 /*Metadata offset 0x538F25*/; // 0x1140
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 EE3413A2C088FF9432054D6E60A7CB6A498D25F0 /*Metadata offset 0x538F49*/; // 0x1164
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 F64F25EAE9A3D7A356813C4218000185541D7779 /*Metadata offset 0x538F89*/; // 0x11A4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1212 FB0C58D8B3094F018764CC6E3094B9576DB08069 /*Metadata offset 0x538FAD*/; // 0x11C8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 FFE3F15642234E7FAD6951D432F1134D5AD15922 /*Metadata offset 0x539469*/; // 0x1684

	// Methods

	// RVA: 0xAAB500 Offset: 0xAA9B00 VA: 0x180AAB500
	internal static uint ComputeStringHash(string s) { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 3155
{
// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 3155
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=14 0283A6AF88802AB45989B29549915BEA0F6CD515 /*Metadata offset 0x53A623*/; // 0x0
	internal static readonly long 03F4297FCC30D0FD5E420E5D26E7FA711167C7EF = 2533317740920864; // 0x10
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9 1A39764B112685485A5BA7B2880D878B858C1A7A /*Metadata offset 0x53A639*/; // 0x18
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 1A84029C80CB5518379F199F53FF08A7B764F8FD /*Metadata offset 0x53A642*/; // 0x21
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 3BE77BF818331C2D8400FFFFF9FADD3F16AD89AC /*Metadata offset 0x53A645*/; // 0x24
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 53437C3B2572EDB9B8640C3195DF3BC2729C5EA1 /*Metadata offset 0x53A651*/; // 0x30
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 59F5BD34B6C013DEACC784F69C67E95150033A84 /*Metadata offset 0x53A65B*/; // 0x3A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 5BC3486B05BA8CF4689C7BDB198B3F477BB4E20C /*Metadata offset 0x53A67B*/; // 0x5A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9 6D49C9D487D7AD3491ECE08732D68A593CC2038D /*Metadata offset 0x53A681*/; // 0x60
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 6F3AD3DC3AF8047587C4C9D696EB68A01FEF796E /*Metadata offset 0x53A68A*/; // 0x69
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 8821BF2BDFF225D177372C9F3E0A8286EE241FF4 /*Metadata offset 0x53A70A*/; // 0xE9
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 8E0EF3D67A3EB1863224EE3CACB424BC2F8CFBA3 /*Metadata offset 0x53A710*/; // 0xEF
	internal static readonly long 98A44A6F8606AE6F23FE230286C1D6FBCC407226 = 11540663026319392; // 0x120
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 C02C28AFEBE998F767E4AF43E3BE8F5E9FA11536 /*Metadata offset 0x53A744*/; // 0x128
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 CCEEADA43268372341F81AE0C9208C6856441C04 /*Metadata offset 0x53A764*/; // 0x148
	internal static readonly long E5BC1BAFADE1862DD6E0B9FB632BFAA6C3873A78 = 2533330625626144; // 0x1C8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 EC5842B3154E1AF94500B57220EB9F684BCCC42A /*Metadata offset 0x53A7EC*/; // 0x1D0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 EEAFE8C6E1AB017237567305EE925C976CDB6458 /*Metadata offset 0x53A80C*/; // 0x1F0

	// Methods

	// RVA: 0xAAB500 Offset: 0xAA9B00 VA: 0x180AAB500
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
	|-RVA: 0xD623C0 Offset: 0xD609C0 VA: 0x180D623C0
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
	|-RVA: 0x1764570 Offset: 0x1762B70 VA: 0x181764570
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
	|-RVA: 0x176B5C0 Offset: 0x1769BC0 VA: 0x18176B5C0
	|-Set<ServerInfo>..ctor
	|
	|-RVA: 0x176B3E0 Offset: 0x17699E0 VA: 0x18176B3E0
	|-Set<char>..ctor
	|
	|-RVA: 0x176B2F0 Offset: 0x17698F0 VA: 0x18176B2F0
	|-Set<object>..ctor
	|
	|-RVA: 0x176B200 Offset: 0x1769800 VA: 0x18176B200
	|-Set<float>..ctor
	|
	|-RVA: 0x176B4D0 Offset: 0x1769AD0 VA: 0x18176B4D0
	|-Set<Vector2>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool Add(TElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17693A0 Offset: 0x17679A0 VA: 0x1817693A0
	|-Set<ServerInfo>.Add
	|
	|-RVA: 0x1769370 Offset: 0x1767970 VA: 0x181769370
	|-Set<char>.Add
	|-Set<object>.Add
	|
	|-RVA: 0x1769470 Offset: 0x1767A70 VA: 0x181769470
	|-Set<float>.Add
	|
	|-RVA: 0x1769430 Offset: 0x1767A30 VA: 0x181769430
	|-Set<Vector2>.Add
	*/

	// RVA: -1 Offset: -1
	private bool Find(TElement value, bool add) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17694A0 Offset: 0x1767AA0 VA: 0x1817694A0
	|-Set<ServerInfo>.Find
	|
	|-RVA: 0x176A1D0 Offset: 0x17687D0 VA: 0x18176A1D0
	|-Set<char>.Find
	|
	|-RVA: 0x1769BC0 Offset: 0x17681C0 VA: 0x181769BC0
	|-Set<object>.Find
	|
	|-RVA: 0x17698D0 Offset: 0x1767ED0 VA: 0x1817698D0
	|-Set<float>.Find
	|
	|-RVA: 0x1769EB0 Offset: 0x17684B0 VA: 0x181769EB0
	|-Set<Vector2>.Find
	*/

	// RVA: -1 Offset: -1
	private void Resize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176AC90 Offset: 0x1769290 VA: 0x18176AC90
	|-Set<ServerInfo>.Resize
	|
	|-RVA: 0x176AE60 Offset: 0x1769460 VA: 0x18176AE60
	|-Set<char>.Resize
	|
	|-RVA: 0x176B030 Offset: 0x1769630 VA: 0x18176B030
	|-Set<object>.Resize
	|
	|-RVA: 0x176AAC0 Offset: 0x17690C0 VA: 0x18176AAC0
	|-Set<float>.Resize
	|
	|-RVA: 0x176A8F0 Offset: 0x1768EF0 VA: 0x18176A8F0
	|-Set<Vector2>.Resize
	*/

	// RVA: -1 Offset: -1
	internal int InternalGetHashCode(TElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x176A7C0 Offset: 0x1768DC0 VA: 0x18176A7C0
	|-Set<ServerInfo>.InternalGetHashCode
	|
	|-RVA: 0x176A4D0 Offset: 0x1768AD0 VA: 0x18176A4D0
	|-Set<char>.InternalGetHashCode
	|
	|-RVA: 0x176A5A0 Offset: 0x1768BA0 VA: 0x18176A5A0
	|-Set<object>.InternalGetHashCode
	|
	|-RVA: 0x176A6F0 Offset: 0x1768CF0 VA: 0x18176A6F0
	|-Set<float>.InternalGetHashCode
	|
	|-RVA: 0x176A620 Offset: 0x1768C20 VA: 0x18176A620
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
	|-RVA: 0x1761130 Offset: 0x175F730 VA: 0x181761130
	|-GroupedEnumerable<InventoryItem, InventoryDefId, InventoryItem>..ctor
	|
	|-RVA: 0x1761240 Offset: 0x175F840 VA: 0x181761240
	|-GroupedEnumerable<object, InventoryDefId, object>..ctor
	|
	|-RVA: 0x1761350 Offset: 0x175F950 VA: 0x181761350
	|-GroupedEnumerable<object, Int32Enum, object>..ctor
	|
	|-RVA: 0x1761570 Offset: 0x175FB70 VA: 0x181761570
	|-GroupedEnumerable<object, object, object>..ctor
	|
	|-RVA: 0x1761460 Offset: 0x175FA60 VA: 0x181761460
	|-GroupedEnumerable<object, uint, object>..ctor
	|
	|-RVA: 0x1761680 Offset: 0x175FC80 VA: 0x181761680
	|-GroupedEnumerable<Resolution, Vector2Int, Resolution>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17610A0 Offset: 0x175F6A0 VA: 0x1817610A0
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
	|-RVA: 0x1761100 Offset: 0x175F700 VA: 0x181761100
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

	[IteratorStateMachineAttribute] // RVA: 0xD1AA0 Offset: 0xD0EA0 VA: 0x1800D1AA0
	// RVA: -1 Offset: -1 Slot: 5
	public IEnumerator<TElement> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17677D0 Offset: 0x1765DD0 VA: 0x1817677D0
	|-OrderedEnumerable<Demos.DemoInfo>.GetEnumerator
	|
	|-RVA: 0x1767740 Offset: 0x1765D40 VA: 0x181767740
	|-OrderedEnumerable<ServerInfo>.GetEnumerator
	|
	|-RVA: 0x1767590 Offset: 0x1765B90 VA: 0x181767590
	|-OrderedEnumerable<Item>.GetEnumerator
	|
	|-RVA: 0x1767620 Offset: 0x1765C20 VA: 0x181767620
	|-OrderedEnumerable<KeyValuePair<object, int>>.GetEnumerator
	|-OrderedEnumerable<KeyValuePair<object, long>>.GetEnumerator
	|-OrderedEnumerable<KeyValuePair<object, object>>.GetEnumerator
	|
	|-RVA: 0x17676B0 Offset: 0x1765CB0 VA: 0x1817676B0
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
	|-RVA: 0x1356160 Offset: 0x1354760 VA: 0x181356160
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
	|-RVA: 0xED71C0 Offset: 0xED57C0 VA: 0x180ED71C0
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
	|-RVA: 0xD5B020 Offset: 0xD59620 VA: 0x180D5B020
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
	|-RVA: 0x17681F0 Offset: 0x17667F0 VA: 0x1817681F0
	|-OrderedEnumerable<Demos.DemoInfo, DateTime>..ctor
	|
	|-RVA: 0x17690F0 Offset: 0x17676F0 VA: 0x1817690F0
	|-OrderedEnumerable<Demos.DemoInfo, object>..ctor
	|
	|-RVA: 0x1768970 Offset: 0x1766F70 VA: 0x181768970
	|-OrderedEnumerable<Demos.DemoInfo, TimeSpan>..ctor
	|
	|-RVA: 0x1768AB0 Offset: 0x17670B0 VA: 0x181768AB0
	|-OrderedEnumerable<ServerInfo, int>..ctor
	|
	|-RVA: 0x17680B0 Offset: 0x17666B0 VA: 0x1817680B0
	|-OrderedEnumerable<ServerInfo, object>..ctor
	|
	|-RVA: 0x1768330 Offset: 0x1766930 VA: 0x181768330
	|-OrderedEnumerable<ServerInfo, uint>..ctor
	|
	|-RVA: 0x1767E30 Offset: 0x1766430 VA: 0x181767E30
	|-OrderedEnumerable<Item, DateTime>..ctor
	|
	|-RVA: 0x1768830 Offset: 0x1766E30 VA: 0x181768830
	|-OrderedEnumerable<KeyValuePair<object, int>, int>..ctor
	|
	|-RVA: 0x1768D30 Offset: 0x1767330 VA: 0x181768D30
	|-OrderedEnumerable<KeyValuePair<object, long>, long>..ctor
	|
	|-RVA: 0x1767F70 Offset: 0x1766570 VA: 0x181767F70
	|-OrderedEnumerable<KeyValuePair<object, object>, long>..ctor
	|
	|-RVA: 0x1767A70 Offset: 0x1766070 VA: 0x181767A70
	|-OrderedEnumerable<double, double>..ctor
	|
	|-RVA: 0x1768E70 Offset: 0x1767470 VA: 0x181768E70
	|-OrderedEnumerable<object, bool>..ctor
	|
	|-RVA: 0x17686F0 Offset: 0x1766CF0 VA: 0x1817686F0
	|-OrderedEnumerable<object, DateTime>..ctor
	|
	|-RVA: 0x1767930 Offset: 0x1765F30 VA: 0x181767930
	|-OrderedEnumerable<object, DateTimeOffset>..ctor
	|
	|-RVA: 0x1768470 Offset: 0x1766A70 VA: 0x181768470
	|-OrderedEnumerable<object, Guid>..ctor
	|
	|-RVA: 0x1767CF0 Offset: 0x17662F0 VA: 0x181767CF0
	|-OrderedEnumerable<object, int>..ctor
	|
	|-RVA: 0x17685B0 Offset: 0x1766BB0 VA: 0x1817685B0
	|-OrderedEnumerable<object, Int32Enum>..ctor
	|
	|-RVA: 0x1768BF0 Offset: 0x17671F0 VA: 0x181768BF0
	|-OrderedEnumerable<object, object>..ctor
	|
	|-RVA: 0x1767BB0 Offset: 0x17661B0 VA: 0x181767BB0
	|-OrderedEnumerable<object, float>..ctor
	|
	|-RVA: 0x1768FB0 Offset: 0x17675B0 VA: 0x181768FB0
	|-OrderedEnumerable<object, uint>..ctor
	|
	|-RVA: 0x1769230 Offset: 0x1767830 VA: 0x181769230
	|-OrderedEnumerable<Resolution, int>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1767860 Offset: 0x1765E60 VA: 0x181767860
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
	|-RVA: 0x225320 Offset: 0x224720 VA: 0x180225320
	|-Buffer<Debugging.EntityInfo>..ctor
	|
	|-RVA: 0x225350 Offset: 0x224750 VA: 0x180225350
	|-Buffer<Demos.DemoInfo>..ctor
	|
	|-RVA: 0x2253F0 Offset: 0x2247F0 VA: 0x1802253F0
	|-Buffer<GameStat.Stat>..ctor
	|
	|-RVA: 0x2252B0 Offset: 0x2246B0 VA: 0x1802252B0
	|-Buffer<ItemSkinDirectory.Skin>..ctor
	|
	|-RVA: 0x2252D0 Offset: 0x2246D0 VA: 0x1802252D0
	|-Buffer<FourBitNumber>..ctor
	|
	|-RVA: 0x225310 Offset: 0x224710 VA: 0x180225310
	|-Buffer<SevenBitNumber>..ctor
	|
	|-RVA: 0x2253E0 Offset: 0x2247E0 VA: 0x1802253E0
	|-Buffer<Option>..ctor
	|
	|-RVA: 0x2253B0 Offset: 0x2247B0 VA: 0x1802253B0
	|-Buffer<ServerInfo>..ctor
	|
	|-RVA: 0x2252E0 Offset: 0x2246E0 VA: 0x1802252E0
	|-Buffer<SkinnedMultiMesh.Part>..ctor
	|
	|-RVA: 0x225390 Offset: 0x224790 VA: 0x180225390
	|-Buffer<InventoryDefId>..ctor
	|
	|-RVA: 0x225400 Offset: 0x224800 VA: 0x180225400
	|-Buffer<InventoryItemId>..ctor
	|
	|-RVA: 0x2252C0 Offset: 0x2246C0 VA: 0x1802252C0
	|-Buffer<InventoryItem>..ctor
	|
	|-RVA: 0x2253C0 Offset: 0x2247C0 VA: 0x1802253C0
	|-Buffer<InventoryRecipe.Ingredient>..ctor
	|
	|-RVA: 0x225370 Offset: 0x224770 VA: 0x180225370
	|-Buffer<InventoryRecipe>..ctor
	|
	|-RVA: 0x225300 Offset: 0x224700 VA: 0x180225300
	|-Buffer<Item>..ctor
	|
	|-RVA: 0x225360 Offset: 0x224760 VA: 0x180225360
	|-Buffer<byte>..ctor
	|
	|-RVA: 0x2253D0 Offset: 0x2247D0 VA: 0x1802253D0
	|-Buffer<char>..ctor
	|
	|-RVA: 0x225330 Offset: 0x224730 VA: 0x180225330
	|-Buffer<KeyValuePair<object, int>>..ctor
	|
	|-RVA: 0x225380 Offset: 0x224780 VA: 0x180225380
	|-Buffer<KeyValuePair<object, long>>..ctor
	|
	|-RVA: 0x225340 Offset: 0x224740 VA: 0x180225340
	|-Buffer<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x225410 Offset: 0x224810 VA: 0x180225410
	|-Buffer<double>..ctor
	|
	|-RVA: 0x225280 Offset: 0x224680 VA: 0x180225280
	|-Buffer<int>..ctor
	|
	|-RVA: 0x2252F0 Offset: 0x2246F0 VA: 0x1802252F0
	|-Buffer<Int32Enum>..ctor
	|
	|-RVA: 0x2253A0 Offset: 0x2247A0 VA: 0x1802253A0
	|-Buffer<long>..ctor
	|
	|-RVA: 0x225420 Offset: 0x224820 VA: 0x180225420
	|-Buffer<object>..ctor
	|
	|-RVA: 0x225290 Offset: 0x224690 VA: 0x180225290
	|-Buffer<uint>..ctor
	|
	|-RVA: 0x2252A0 Offset: 0x2246A0 VA: 0x1802252A0
	|-Buffer<Resolution>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TElement[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x225180 Offset: 0x224580 VA: 0x180225180
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
[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 3258
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=120 0AA802CD6847EB893FE786B5EA5168B2FDCD7B93 /*Metadata offset 0x53AAA3*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 0C4110BC17D746F018F47B49E0EB0D6590F69939 /*Metadata offset 0x53AB1B*/; // 0x78
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 20733E1283D873EBE47133A95C233E11B76F5F11 /*Metadata offset 0x53AC1B*/; // 0x178
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 21F4CBF8283FF1CAEB4A39316A97FC1D6DF1D35E /*Metadata offset 0x53B01B*/; // 0x578
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 23DFDCA6F045D4257BF5AC8CB1CF2EFADAFE9B94 /*Metadata offset 0x53B41B*/; // 0x978
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 30A0358B25B1372DD598BB4B1AC56AD6B8F08A47 /*Metadata offset 0x53B81B*/; // 0xD78
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 5B5DF5A459E902D96F7DB0FB235A25346CA85C5D /*Metadata offset 0x53BC1B*/; // 0x1178
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 5BE411F1438EAEF33726D855E99011D5FECDDD4E /*Metadata offset 0x53C01B*/; // 0x1578
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 8F22C9ECE1331718CBD268A9BBFD2F5E451441E3 /*Metadata offset 0x53C41B*/; // 0x1978
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 A02DD1D8604EA8EC2D2BDA717A93A4EE85F13E53 /*Metadata offset 0x53C51B*/; // 0x1A78
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 AE2F76ECEF8B08F0BC7EA95DCFE945E1727927C9 /*Metadata offset 0x53C91B*/; // 0x1E78

}

public struct BatchQueryJob<CommandT, ResultT> // TypeDefIndex: 3307
{	// Fields
	[ReadOnlyAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal NativeArray<CommandT> commands; // 0x0
	internal NativeArray<ResultT> results; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(NativeArray<CommandT> commands, NativeArray<ResultT> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FA030 Offset: 0x1F9430 VA: 0x1801FA030
	|-BatchQueryJob<RaycastCommand, RaycastHit>..ctor
	*/

}

internal class InvokableCall<T1> : BaseInvokableCall // TypeDefIndex: 3629
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private UnityAction<T1> Delegate; // 0x0

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	protected void add_Delegate(UnityAction<T1> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AD030 Offset: 0x17AB630 VA: 0x1817AD030
	|-InvokableCall<Option>.add_Delegate
	|-InvokableCall<bool>.add_Delegate
	|-InvokableCall<int>.add_Delegate
	|-InvokableCall<Int32Enum>.add_Delegate
	|-InvokableCall<object>.add_Delegate
	|-InvokableCall<float>.add_Delegate
	|-InvokableCall<Color>.add_Delegate
	|-InvokableCall<Vector2>.add_Delegate
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	protected void remove_Delegate(UnityAction<T1> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AD0F0 Offset: 0x17AB6F0 VA: 0x1817AD0F0
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
	|-RVA: 0x17AC8B0 Offset: 0x17AAEB0 VA: 0x1817AC8B0
	|-InvokableCall<Option>..ctor
	|
	|-RVA: 0x17ACF00 Offset: 0x17AB500 VA: 0x1817ACF00
	|-InvokableCall<bool>..ctor
	|
	|-RVA: 0x17AC9E0 Offset: 0x17AAFE0 VA: 0x1817AC9E0
	|-InvokableCall<int>..ctor
	|
	|-RVA: 0x17ACCA0 Offset: 0x17AB2A0 VA: 0x1817ACCA0
	|-InvokableCall<Int32Enum>..ctor
	|
	|-RVA: 0x17ACB70 Offset: 0x17AB170 VA: 0x1817ACB70
	|-InvokableCall<object>..ctor
	|
	|-RVA: 0x17ACDD0 Offset: 0x17AB3D0 VA: 0x1817ACDD0
	|-InvokableCall<float>..ctor
	|
	|-RVA: 0x19BDC70 Offset: 0x19BC270 VA: 0x1819BDC70
	|-InvokableCall<Color>..ctor
	|
	|-RVA: 0x19BDB40 Offset: 0x19BC140 VA: 0x1819BDB40
	|-InvokableCall<Vector2>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UnityAction<T1> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ACB10 Offset: 0x17AB110 VA: 0x1817ACB10
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
	|-RVA: 0x17AC2C0 Offset: 0x17AA8C0 VA: 0x1817AC2C0
	|-InvokableCall<Option>.Invoke
	|
	|-RVA: 0x17AC630 Offset: 0x17AAC30 VA: 0x1817AC630
	|-InvokableCall<bool>.Invoke
	|
	|-RVA: 0x17AC0C0 Offset: 0x17AA6C0 VA: 0x1817AC0C0
	|-InvokableCall<int>.Invoke
	|
	|-RVA: 0x17AC490 Offset: 0x17AAA90 VA: 0x1817AC490
	|-InvokableCall<Int32Enum>.Invoke
	|
	|-RVA: 0x17AC770 Offset: 0x17AAD70 VA: 0x1817AC770
	|-InvokableCall<object>.Invoke
	|
	|-RVA: 0x17ABF20 Offset: 0x17AA520 VA: 0x1817ABF20
	|-InvokableCall<float>.Invoke
	|
	|-RVA: 0x19BD7C0 Offset: 0x19BBDC0 VA: 0x1819BD7C0
	|-InvokableCall<Color>.Invoke
	|
	|-RVA: 0x19BD910 Offset: 0x19BBF10 VA: 0x1819BD910
	|-InvokableCall<Vector2>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public virtual void Invoke(T1 args0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AC420 Offset: 0x17AAA20 VA: 0x1817AC420
	|-InvokableCall<Option>.Invoke
	|
	|-RVA: 0x17AC200 Offset: 0x17AA800 VA: 0x1817AC200
	|-InvokableCall<bool>.Invoke
	|
	|-RVA: 0x17AC260 Offset: 0x17AA860 VA: 0x1817AC260
	|-InvokableCall<int>.Invoke
	|-InvokableCall<Int32Enum>.Invoke
	|
	|-RVA: 0x17AC5D0 Offset: 0x17AABD0 VA: 0x1817AC5D0
	|-InvokableCall<object>.Invoke
	|
	|-RVA: 0x17AC060 Offset: 0x17AA660 VA: 0x1817AC060
	|-InvokableCall<float>.Invoke
	|
	|-RVA: 0x19BDA60 Offset: 0x19BC060 VA: 0x1819BDA60
	|-InvokableCall<Color>.Invoke
	|
	|-RVA: 0x19BDAD0 Offset: 0x19BC0D0 VA: 0x1819BDAD0
	|-InvokableCall<Vector2>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override bool Find(object targetObj, MethodInfo method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ABEC0 Offset: 0x17AA4C0 VA: 0x1817ABEC0
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
	|-RVA: 0x19C8AF0 Offset: 0x19C70F0 VA: 0x1819C8AF0
	|-UnityAction<Option>.Invoke
	|
	|-RVA: 0x19C8590 Offset: 0x19C6B90 VA: 0x1819C8590
	|-UnityAction<bool>.Invoke
	|
	|-RVA: 0x19C83A0 Offset: 0x19C69A0 VA: 0x1819C83A0
	|-UnityAction<int>.Invoke
	|-UnityAction<Int32Enum>.Invoke
	|
	|-RVA: 0x19C8080 Offset: 0x19C6680 VA: 0x1819C8080
	|-UnityAction<object>.Invoke
	|-UnityAction<Component>.Invoke
	|
	|-RVA: 0x19C7AC0 Offset: 0x19C60C0 VA: 0x1819C7AC0
	|-UnityAction<float>.Invoke
	|
	|-RVA: 0x12A5850 Offset: 0x12A3E50 VA: 0x1812A5850
	|-UnityAction<Color>.Invoke
	|
	|-RVA: 0x19C7DA0 Offset: 0x19C63A0 VA: 0x1819C7DA0
	|-UnityAction<Scene>.Invoke
	|
	|-RVA: 0x19C8810 Offset: 0x19C6E10 VA: 0x1819C8810
	|-UnityAction<Vector2>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(T0 arg0, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C7740 Offset: 0x19C5D40 VA: 0x1819C7740
	|-UnityAction<Option>.BeginInvoke
	|
	|-RVA: 0x19C7840 Offset: 0x19C5E40 VA: 0x1819C7840
	|-UnityAction<bool>.BeginInvoke
	|
	|-RVA: 0x19C77C0 Offset: 0x19C5DC0 VA: 0x1819C77C0
	|-UnityAction<int>.BeginInvoke
	|
	|-RVA: 0x19C76C0 Offset: 0x19C5CC0 VA: 0x1819C76C0
	|-UnityAction<Int32Enum>.BeginInvoke
	|
	|-RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380
	|-UnityAction<object>.BeginInvoke
	|
	|-RVA: 0x19C79C0 Offset: 0x19C5FC0 VA: 0x1819C79C0
	|-UnityAction<float>.BeginInvoke
	|
	|-RVA: 0x19C7A40 Offset: 0x19C6040 VA: 0x1819C7A40
	|-UnityAction<Color>.BeginInvoke
	|
	|-RVA: 0x19C78C0 Offset: 0x19C5EC0 VA: 0x1819C78C0
	|-UnityAction<Scene>.BeginInvoke
	|
	|-RVA: 0x19C7940 Offset: 0x19C5F40 VA: 0x1819C7940
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

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CBF90 Offset: 0x19CA590 VA: 0x1819CBF90
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
	|-RVA: 0x19CA120 Offset: 0x19C8720 VA: 0x1819CA120
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
	|-RVA: 0x19CBF40 Offset: 0x19CA540 VA: 0x1819CBF40
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
	|-RVA: 0x19CA7C0 Offset: 0x19C8DC0 VA: 0x1819CA7C0
	|-UnityEvent<Brush>.FindMethod_Impl
	|-UnityEvent<object>.FindMethod_Impl
	|-UnityEvent<string>.FindMethod_Impl
	|-UnityEvent<BaseEventData>.FindMethod_Impl
	|-UnityEvent<MessageEventArgs>.FindMethod_Impl
	|
	|-RVA: 0x19CA160 Offset: 0x19C8760 VA: 0x1819CA160
	|-UnityEvent<Option>.FindMethod_Impl
	|
	|-RVA: 0x19CA490 Offset: 0x19C8A90 VA: 0x1819CA490
	|-UnityEvent<bool>.FindMethod_Impl
	|
	|-RVA: 0x19CA380 Offset: 0x19C8980 VA: 0x1819CA380
	|-UnityEvent<int>.FindMethod_Impl
	|
	|-RVA: 0x19CA6B0 Offset: 0x19C8CB0 VA: 0x1819CA6B0
	|-UnityEvent<Int32Enum>.FindMethod_Impl
	|-UnityEvent<TouchScreenKeyboard.Status>.FindMethod_Impl
	|
	|-RVA: 0x19CA270 Offset: 0x19C8870 VA: 0x1819CA270
	|-UnityEvent<float>.FindMethod_Impl
	|
	|-RVA: 0x19CA5A0 Offset: 0x19C8BA0 VA: 0x1819CA5A0
	|-UnityEvent<Color>.FindMethod_Impl
	|
	|-RVA: 0x19CA8D0 Offset: 0x19C8ED0 VA: 0x1819CA8D0
	|-UnityEvent<Vector2>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CA9E0 Offset: 0x19C8FE0 VA: 0x1819CA9E0
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
	|-RVA: 0x19CAA60 Offset: 0x19C9060 VA: 0x1819CAA60
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
	|-RVA: 0x19CAB30 Offset: 0x19C9130 VA: 0x1819CAB30
	|-UnityEvent<Brush>.Invoke
	|-UnityEvent<object>.Invoke
	|-UnityEvent<string>.Invoke
	|-UnityEvent<BaseEventData>.Invoke
	|-UnityEvent<MessageEventArgs>.Invoke
	|
	|-RVA: 0x19CB500 Offset: 0x19C9B00 VA: 0x1819CB500
	|-UnityEvent<Option>.Invoke
	|
	|-RVA: 0x19CB7C0 Offset: 0x19C9DC0 VA: 0x1819CB7C0
	|-UnityEvent<bool>.Invoke
	|
	|-RVA: 0x19CBA40 Offset: 0x19CA040 VA: 0x1819CBA40
	|-UnityEvent<int>.Invoke
	|
	|-RVA: 0x19CAD60 Offset: 0x19C9360 VA: 0x1819CAD60
	|-UnityEvent<Int32Enum>.Invoke
	|-UnityEvent<TouchScreenKeyboard.Status>.Invoke
	|
	|-RVA: 0x19CB280 Offset: 0x19C9880 VA: 0x1819CB280
	|-UnityEvent<float>.Invoke
	|
	|-RVA: 0x19CAFE0 Offset: 0x19C95E0 VA: 0x1819CAFE0
	|-UnityEvent<Color>.Invoke
	|
	|-RVA: 0x19CBCC0 Offset: 0x19CA2C0 VA: 0x1819CBCC0
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
	|-RVA: 0x1111400 Offset: 0x110FA00 VA: 0x181111400
	|-UnityAction<object, object>.Invoke
	|
	|-RVA: 0x19C90D0 Offset: 0x19C76D0 VA: 0x1819C90D0
	|-UnityAction<ulong, object>.Invoke
	|
	|-RVA: 0x19C9A10 Offset: 0x19C8010 VA: 0x1819C9A10
	|-UnityAction<Scene, Int32Enum>.Invoke
	|-UnityAction<Scene, LoadSceneMode>.Invoke
	|
	|-RVA: 0x19C9400 Offset: 0x19C7A00 VA: 0x1819C9400
	|-UnityAction<Scene, Scene>.Invoke
	|
	|-RVA: 0x19C9710 Offset: 0x19C7D10 VA: 0x1819C9710
	|-UnityAction<Vector2, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(T0 arg0, T1 arg1, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAE4840 Offset: 0xAE2E40 VA: 0x180AE4840
	|-UnityAction<object, object>.BeginInvoke
	|
	|-RVA: 0x19C8FB0 Offset: 0x19C75B0 VA: 0x1819C8FB0
	|-UnityAction<ulong, object>.BeginInvoke
	|
	|-RVA: 0x19C8F20 Offset: 0x19C7520 VA: 0x1819C8F20
	|-UnityAction<Scene, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x19C9040 Offset: 0x19C7640 VA: 0x1819C9040
	|-UnityAction<Scene, Scene>.BeginInvoke
	|
	|-RVA: 0x19C8E90 Offset: 0x19C7490 VA: 0x1819C8E90
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

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CBF90 Offset: 0x19CA590 VA: 0x1819CBF90
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
	|-RVA: 0x19CBFC0 Offset: 0x19CA5C0 VA: 0x1819CBFC0
	|-UnityEvent<object, object>.FindMethod_Impl
	|
	|-RVA: 0x19CC2E0 Offset: 0x19CA8E0 VA: 0x1819CC2E0
	|-UnityEvent<ulong, object>.FindMethod_Impl
	|-UnityEvent<ulong, string>.FindMethod_Impl
	|
	|-RVA: 0x19CC150 Offset: 0x19CA750 VA: 0x1819CC150
	|-UnityEvent<Vector2, Brush>.FindMethod_Impl
	|-UnityEvent<Vector2, object>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CC470 Offset: 0x19CAA70 VA: 0x1819CC470
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
	|-RVA: 0x19CCAF0 Offset: 0x19CB0F0 VA: 0x1819CCAF0
	|-UnityEvent<object, object>.Invoke
	|
	|-RVA: 0x19CC4F0 Offset: 0x19CAAF0 VA: 0x1819CC4F0
	|-UnityEvent<ulong, object>.Invoke
	|-UnityEvent<ulong, string>.Invoke
	|
	|-RVA: 0x19CC7F0 Offset: 0x19CADF0 VA: 0x1819CC7F0
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
	|-RVA: 0x1349EB0 Offset: 0x13484B0 VA: 0x181349EB0
	|-UnityAction<object, int, int>.Invoke
	|
	|-RVA: 0x19C9DC0 Offset: 0x19C83C0 VA: 0x1819C9DC0
	|-UnityAction<object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(T0 arg0, T1 arg1, T2 arg2, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C9D20 Offset: 0x19C8320 VA: 0x1819C9D20
	|-UnityAction<object, int, int>.BeginInvoke
	|
	|-RVA: 0x130FC60 Offset: 0x130E260 VA: 0x18130FC60
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

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CBF90 Offset: 0x19CA590 VA: 0x1819CBF90
	|-UnityEvent<object, int, int>..ctor
	|-UnityEvent<object, object, object>..ctor
	|-UnityEvent<string, int, int>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, object targetObj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CCD90 Offset: 0x19CB390 VA: 0x1819CCD90
	|-UnityEvent<object, int, int>.FindMethod_Impl
	|-UnityEvent<string, int, int>.FindMethod_Impl
	|
	|-RVA: 0x19CCF90 Offset: 0x19CB590 VA: 0x1819CCF90
	|-UnityEvent<object, object, object>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CA9E0 Offset: 0x19C8FE0 VA: 0x1819CA9E0
	|-UnityEvent<object, int, int>.GetDelegate
	|-UnityEvent<object, object, object>.GetDelegate
	|-UnityEvent<string, int, int>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CD4B0 Offset: 0x19CBAB0 VA: 0x1819CD4B0
	|-UnityEvent<object, int, int>.Invoke
	|-UnityEvent<string, int, int>.Invoke
	|
	|-RVA: 0x19CD190 Offset: 0x19CB790 VA: 0x1819CD190
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
	|-RVA: 0x1311830 Offset: 0x130FE30 VA: 0x181311830
	|-UnityAction<object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFF9600 Offset: 0xFF7C00 VA: 0x180FF9600
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

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CBF90 Offset: 0x19CA590 VA: 0x1819CBF90
	|-UnityEvent<object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, object targetObj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CD860 Offset: 0x19CBE60 VA: 0x1819CD860
	|-UnityEvent<object, object, object, object>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CDAD0 Offset: 0x19CC0D0 VA: 0x1819CDAD0
	|-UnityEvent<object, object, object, object>.GetDelegate
	*/

}

public class IntegratedSubsystemDescriptor<TSubsystem> : IntegratedSubsystemDescriptor // TypeDefIndex: 3941
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD50FA0 Offset: 0xD4F5A0 VA: 0x180D50FA0
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
	|-RVA: 0xD50FA0 Offset: 0xD4F5A0 VA: 0x180D50FA0
	|-IntegratedSubsystem<object>..ctor
	|-IntegratedSubsystem<XRDisplaySubsystemDescriptor>..ctor
	|-IntegratedSubsystem<XRInputSubsystemDescriptor>..ctor
	|-IntegratedSubsystem<XRMeshSubsystemDescriptor>..ctor
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 4066
{	// Methods

	// RVA: 0xAAB500 Offset: 0xAA9B00 VA: 0x180AAB500
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
	|-RVA: 0x178C880 Offset: 0x178AE80 VA: 0x18178C880
	|-RBTree<DataRow>..ctor
	|-RBTree<int>..ctor
	|-RBTree<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void InitTree() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17889B0 Offset: 0x1786FB0 VA: 0x1817889B0
	|-RBTree<int>.InitTree
	|
	|-RVA: 0x20C97F0 Offset: 0x20C7DF0 VA: 0x1820C97F0
	|-RBTree<object>.InitTree
	*/

	// RVA: -1 Offset: -1
	private void FreePage(RBTree.TreePage<K> page) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1787CA0 Offset: 0x17862A0 VA: 0x181787CA0
	|-RBTree<int>.FreePage
	|-RBTree<object>.FreePage
	*/

	// RVA: -1 Offset: -1
	private RBTree.TreePage<K> AllocPage(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1786D20 Offset: 0x1785320 VA: 0x181786D20
	|-RBTree<int>.AllocPage
	|
	|-RVA: 0x20C8430 Offset: 0x20C6A30 VA: 0x1820C8430
	|-RBTree<object>.AllocPage
	*/

	// RVA: -1 Offset: -1
	private void MarkPageFull(RBTree.TreePage<K> page) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17892E0 Offset: 0x17878E0 VA: 0x1817892E0
	|-RBTree<int>.MarkPageFull
	|-RBTree<object>.MarkPageFull
	*/

	// RVA: -1 Offset: -1
	private void MarkPageFree(RBTree.TreePage<K> page) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1789220 Offset: 0x1787820 VA: 0x181789220
	|-RBTree<int>.MarkPageFree
	|-RBTree<object>.MarkPageFree
	*/

	// RVA: -1 Offset: -1
	private static int GetIntValueFromBitMap(uint bitMap) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1788290 Offset: 0x1786890 VA: 0x181788290
	|-RBTree<int>.GetIntValueFromBitMap
	|-RBTree<object>.GetIntValueFromBitMap
	*/

	// RVA: -1 Offset: -1
	private void FreeNode(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1787B00 Offset: 0x1786100 VA: 0x181787B00
	|-RBTree<int>.FreeNode
	|
	|-RVA: 0x20C8C20 Offset: 0x20C7220 VA: 0x1820C8C20
	|-RBTree<object>.FreeNode
	*/

	// RVA: -1 Offset: -1
	private int GetIndexOfPageWithFreeSlot(bool allocatedPage) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1788090 Offset: 0x1786690 VA: 0x181788090
	|-RBTree<int>.GetIndexOfPageWithFreeSlot
	|
	|-RVA: 0x20C8F90 Offset: 0x20C7590 VA: 0x1820C8F90
	|-RBTree<object>.GetIndexOfPageWithFreeSlot
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178C950 Offset: 0x178AF50 VA: 0x18178C950
	|-RBTree<DataRow>.get_Count
	|-RBTree<int>.get_Count
	|-RBTree<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public bool get_HasDuplicates() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178C960 Offset: 0x178AF60 VA: 0x18178C960
	|-RBTree<int>.get_HasDuplicates
	|-RBTree<object>.get_HasDuplicates
	*/

	// RVA: -1 Offset: -1
	private int GetNewNode(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1788300 Offset: 0x1786900 VA: 0x181788300
	|-RBTree<int>.GetNewNode
	|
	|-RVA: 0x20C9190 Offset: 0x20C7790 VA: 0x1820C9190
	|-RBTree<object>.GetNewNode
	*/

	// RVA: -1 Offset: -1
	private int Successor(int x_id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178C6B0 Offset: 0x178ACB0 VA: 0x18178C6B0
	|-RBTree<int>.Successor
	|-RBTree<object>.Successor
	*/

	// RVA: -1 Offset: -1
	private bool Successor(ref int nodeId, ref int mainTreeNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178C550 Offset: 0x178AB50 VA: 0x18178C550
	|-RBTree<int>.Successor
	|
	|-RVA: 0x20CD100 Offset: 0x20CB700 VA: 0x1820CD100
	|-RBTree<object>.Successor
	*/

	// RVA: -1 Offset: -1
	private int Minimum(int x_id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17893A0 Offset: 0x17879A0 VA: 0x1817893A0
	|-RBTree<int>.Minimum
	|-RBTree<object>.Minimum
	*/

	// RVA: -1 Offset: -1
	private int LeftRotate(int root_id, int x_id, int mainTreeNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1788CE0 Offset: 0x17872E0 VA: 0x181788CE0
	|-RBTree<int>.LeftRotate
	|
	|-RVA: 0x20C9AF0 Offset: 0x20C80F0 VA: 0x1820C9AF0
	|-RBTree<object>.LeftRotate
	*/

	// RVA: -1 Offset: -1
	private int RightRotate(int root_id, int x_id, int mainTreeNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178BB90 Offset: 0x178A190 VA: 0x18178BB90
	|-RBTree<int>.RightRotate
	|
	|-RVA: 0x20CC730 Offset: 0x20CAD30 VA: 0x1820CC730
	|-RBTree<object>.RightRotate
	*/

	// RVA: -1 Offset: -1
	private int RBInsert(int root_id, int x_id, int mainTreeNodeID, int position, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178AA90 Offset: 0x1789090 VA: 0x18178AA90
	|-RBTree<int>.RBInsert
	|
	|-RVA: 0x20CB660 Offset: 0x20C9C60 VA: 0x1820CB660
	|-RBTree<object>.RBInsert
	*/

	// RVA: -1 Offset: -1
	public void UpdateNodeKey(K currentKey, K newKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178C7B0 Offset: 0x178ADB0 VA: 0x18178C7B0
	|-RBTree<int>.UpdateNodeKey
	|
	|-RVA: 0x20CD260 Offset: 0x20CB860 VA: 0x1820CD260
	|-RBTree<object>.UpdateNodeKey
	*/

	// RVA: -1 Offset: -1
	public K DeleteByIndex(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1787A50 Offset: 0x1786050 VA: 0x181787A50
	|-RBTree<int>.DeleteByIndex
	|
	|-RVA: 0x20C8B70 Offset: 0x20C7170 VA: 0x1820C8B70
	|-RBTree<object>.DeleteByIndex
	*/

	// RVA: -1 Offset: -1
	public int RBDelete(int z_id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178AA50 Offset: 0x1789050 VA: 0x18178AA50
	|-RBTree<DataRow>.RBDelete
	|-RBTree<int>.RBDelete
	|-RBTree<object>.RBDelete
	*/

	// RVA: -1 Offset: -1
	private int RBDeleteX(int root_id, int z_id, int mainTreeNodeID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1789DD0 Offset: 0x17883D0 VA: 0x181789DD0
	|-RBTree<int>.RBDeleteX
	|
	|-RVA: 0x20CA9E0 Offset: 0x20C8FE0 VA: 0x1820CA9E0
	|-RBTree<object>.RBDeleteX
	*/

	// RVA: -1 Offset: -1
	private int RBDeleteFixup(int root_id, int x_id, int px_id, int mainTreeNodeID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1789500 Offset: 0x1787B00 VA: 0x181789500
	|-RBTree<int>.RBDeleteFixup
	|
	|-RVA: 0x20CA110 Offset: 0x20C8710 VA: 0x1820CA110
	|-RBTree<object>.RBDeleteFixup
	*/

	// RVA: -1 Offset: -1
	private int SearchSubTree(int root_id, K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178C0C0 Offset: 0x178A6C0 VA: 0x18178C0C0
	|-RBTree<int>.SearchSubTree
	|
	|-RVA: 0x20CCC60 Offset: 0x20CB260 VA: 0x1820CCC60
	|-RBTree<object>.SearchSubTree
	*/

	// RVA: -1 Offset: -1
	public K get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178C970 Offset: 0x178AF70 VA: 0x18178C970
	|-RBTree<DataRow>.get_Item
	|-RBTree<int>.get_Item
	|-RBTree<object>.get_Item
	*/

	// RVA: -1 Offset: -1
	private RBTree.NodePath<K> GetNodeByKey(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1788680 Offset: 0x1786C80 VA: 0x181788680
	|-RBTree<int>.GetNodeByKey
	|
	|-RVA: 0x20C9540 Offset: 0x20C7B40 VA: 0x1820C9540
	|-RBTree<object>.GetNodeByKey
	*/

	// RVA: -1 Offset: -1
	public int GetIndexByKey(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1787E00 Offset: 0x1786400 VA: 0x181787E00
	|-RBTree<int>.GetIndexByKey
	|-RBTree<object>.GetIndexByKey
	*/

	// RVA: -1 Offset: -1
	public int GetIndexByNode(int node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1787F40 Offset: 0x1786540 VA: 0x181787F40
	|-RBTree<int>.GetIndexByNode
	|
	|-RVA: 0x20C8E40 Offset: 0x20C7440 VA: 0x1820C8E40
	|-RBTree<object>.GetIndexByNode
	*/

	// RVA: -1 Offset: -1
	private int GetIndexByNodePath(RBTree.NodePath<K> path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1787E80 Offset: 0x1786480 VA: 0x181787E80
	|-RBTree<int>.GetIndexByNodePath
	|-RBTree<object>.GetIndexByNodePath
	*/

	// RVA: -1 Offset: -1
	private int ComputeIndexByNode(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17870C0 Offset: 0x17856C0 VA: 0x1817870C0
	|-RBTree<int>.ComputeIndexByNode
	|-RBTree<object>.ComputeIndexByNode
	*/

	// RVA: -1 Offset: -1
	private int ComputeIndexWithSatelliteByNode(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17871E0 Offset: 0x17857E0 VA: 0x1817871E0
	|-RBTree<int>.ComputeIndexWithSatelliteByNode
	|-RBTree<object>.ComputeIndexWithSatelliteByNode
	*/

	// RVA: -1 Offset: -1
	private RBTree.NodePath<K> GetNodeByIndex(int userIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17885A0 Offset: 0x1786BA0 VA: 0x1817885A0
	|-RBTree<int>.GetNodeByIndex
	|
	|-RVA: 0x20C9440 Offset: 0x20C7A40 VA: 0x1820C9440
	|-RBTree<object>.GetNodeByIndex
	*/

	// RVA: -1 Offset: -1
	private int ComputeNodeByIndex(int index, out int satelliteRootId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1787360 Offset: 0x1785960 VA: 0x181787360
	|-RBTree<int>.ComputeNodeByIndex
	|-RBTree<object>.ComputeNodeByIndex
	*/

	// RVA: -1 Offset: -1
	private int ComputeNodeByIndex(int x_id, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1787580 Offset: 0x1785B80 VA: 0x181787580
	|-RBTree<int>.ComputeNodeByIndex
	|-RBTree<object>.ComputeNodeByIndex
	*/

	// RVA: -1 Offset: -1
	public int Insert(K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1786CA0 Offset: 0x17852A0 VA: 0x181786CA0
	|-RBTree<int>.Insert
	|-RBTree<object>.Insert
	*/

	// RVA: -1 Offset: -1
	public int Add(K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1786CA0 Offset: 0x17852A0 VA: 0x181786CA0
	|-RBTree<DataRow>.Add
	|-RBTree<int>.Add
	|-RBTree<object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20C8DC0 Offset: 0x20C73C0 VA: 0x1820C8DC0
	|-RBTree<DataRow>.GetEnumerator
	|-RBTree<object>.GetEnumerator
	|
	|-RVA: 0x1787D50 Offset: 0x1786350 VA: 0x181787D50
	|-RBTree<int>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(int nodeId, K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20C96F0 Offset: 0x20C7CF0 VA: 0x1820C96F0
	|-RBTree<DataRow>.IndexOf
	|-RBTree<object>.IndexOf
	|
	|-RVA: 0x1788820 Offset: 0x1786E20 VA: 0x181788820
	|-RBTree<int>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public int Insert(int position, K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1788C40 Offset: 0x1787240 VA: 0x181788C40
	|-RBTree<DataRow>.Insert
	|-RBTree<int>.Insert
	|-RBTree<object>.Insert
	*/

	// RVA: -1 Offset: -1
	public int InsertAt(int position, K item, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1788BA0 Offset: 0x17871A0 VA: 0x181788BA0
	|-RBTree<int>.InsertAt
	|
	|-RVA: 0x20C99E0 Offset: 0x20C7FE0 VA: 0x1820C99E0
	|-RBTree<object>.InsertAt
	*/

	// RVA: -1 Offset: -1
	public void RemoveAt(int position) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178BB60 Offset: 0x178A160 VA: 0x18178BB60
	|-RBTree<DataRow>.RemoveAt
	|-RBTree<int>.RemoveAt
	|-RBTree<object>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1787090 Offset: 0x1785690 VA: 0x181787090
	|-RBTree<DataRow>.Clear
	|-RBTree<int>.Clear
	|-RBTree<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20C87A0 Offset: 0x20C6DA0 VA: 0x1820C87A0
	|-RBTree<DataRow>.CopyTo
	|-RBTree<object>.CopyTo
	|
	|-RVA: 0x17877F0 Offset: 0x1785DF0 VA: 0x1817877F0
	|-RBTree<int>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(K[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20C8940 Offset: 0x20C6F40 VA: 0x1820C8940
	|-RBTree<DataRow>.CopyTo
	|-RBTree<object>.CopyTo
	|
	|-RVA: 0x1787640 Offset: 0x1785C40 VA: 0x181787640
	|-RBTree<int>.CopyTo
	*/

	// RVA: -1 Offset: -1
	private void SetRight(int nodeId, int rightNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178C400 Offset: 0x178AA00 VA: 0x18178C400
	|-RBTree<int>.SetRight
	|
	|-RVA: 0x20CCFB0 Offset: 0x20CB5B0 VA: 0x1820CCFB0
	|-RBTree<object>.SetRight
	*/

	// RVA: -1 Offset: -1
	private void SetLeft(int nodeId, int leftNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178C2B0 Offset: 0x178A8B0 VA: 0x18178C2B0
	|-RBTree<int>.SetLeft
	|
	|-RVA: 0x20CCE60 Offset: 0x20CB460 VA: 0x1820CCE60
	|-RBTree<object>.SetLeft
	*/

	// RVA: -1 Offset: -1
	private void SetParent(int nodeId, int parentNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178C390 Offset: 0x178A990 VA: 0x18178C390
	|-RBTree<int>.SetParent
	|
	|-RVA: 0x20CCF40 Offset: 0x20CB540 VA: 0x1820CCF40
	|-RBTree<object>.SetParent
	*/

	// RVA: -1 Offset: -1
	private void SetColor(int nodeId, RBTree.NodeColor<K> color) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178C1D0 Offset: 0x178A7D0 VA: 0x18178C1D0
	|-RBTree<int>.SetColor
	|
	|-RVA: 0x20CCD70 Offset: 0x20CB370 VA: 0x1820CCD70
	|-RBTree<object>.SetColor
	*/

	// RVA: -1 Offset: -1
	private void SetKey(int nodeId, K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178C240 Offset: 0x178A840 VA: 0x18178C240
	|-RBTree<int>.SetKey
	|
	|-RVA: 0x20CCDE0 Offset: 0x20CB3E0 VA: 0x1820CCDE0
	|-RBTree<object>.SetKey
	*/

	// RVA: -1 Offset: -1
	private void SetNext(int nodeId, int nextNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178C320 Offset: 0x178A920 VA: 0x18178C320
	|-RBTree<int>.SetNext
	|
	|-RVA: 0x20CCED0 Offset: 0x20CB4D0 VA: 0x1820CCED0
	|-RBTree<object>.SetNext
	*/

	// RVA: -1 Offset: -1
	private void SetSubTreeSize(int nodeId, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178C470 Offset: 0x178AA70 VA: 0x18178C470
	|-RBTree<int>.SetSubTreeSize
	|
	|-RVA: 0x20CD020 Offset: 0x20CB620 VA: 0x1820CD020
	|-RBTree<object>.SetSubTreeSize
	*/

	// RVA: -1 Offset: -1
	private void IncreaseSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17887B0 Offset: 0x1786DB0 VA: 0x1817887B0
	|-RBTree<int>.IncreaseSize
	|
	|-RVA: 0x20C9680 Offset: 0x20C7C80 VA: 0x1820C9680
	|-RBTree<object>.IncreaseSize
	*/

	// RVA: -1 Offset: -1
	private void RecomputeSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178B9D0 Offset: 0x1789FD0 VA: 0x18178B9D0
	|-RBTree<int>.RecomputeSize
	|
	|-RVA: 0x20CC5A0 Offset: 0x20CABA0 VA: 0x1820CC5A0
	|-RBTree<object>.RecomputeSize
	*/

	// RVA: -1 Offset: -1
	private void DecreaseSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17879E0 Offset: 0x1785FE0 VA: 0x1817879E0
	|-RBTree<int>.DecreaseSize
	|
	|-RVA: 0x20C8B00 Offset: 0x20C7100 VA: 0x1820C8B00
	|-RBTree<object>.DecreaseSize
	*/

	// RVA: -1 Offset: -1
	public int Right(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178C050 Offset: 0x178A650 VA: 0x18178C050
	|-RBTree<int>.Right
	|
	|-RVA: 0x20CCBF0 Offset: 0x20CB1F0 VA: 0x1820CCBF0
	|-RBTree<object>.Right
	*/

	// RVA: -1 Offset: -1
	public int Left(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17891B0 Offset: 0x17877B0 VA: 0x1817891B0
	|-RBTree<int>.Left
	|
	|-RVA: 0x20C9FC0 Offset: 0x20C85C0 VA: 0x1820C9FC0
	|-RBTree<object>.Left
	*/

	// RVA: -1 Offset: -1
	public int Parent(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1789490 Offset: 0x1787A90 VA: 0x181789490
	|-RBTree<int>.Parent
	|
	|-RVA: 0x20CA0A0 Offset: 0x20C86A0 VA: 0x1820CA0A0
	|-RBTree<object>.Parent
	*/

	// RVA: -1 Offset: -1
	private RBTree.NodeColor<K> color(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178C8E0 Offset: 0x178AEE0 VA: 0x18178C8E0
	|-RBTree<int>.color
	|
	|-RVA: 0x20CD330 Offset: 0x20CB930 VA: 0x1820CD330
	|-RBTree<object>.color
	*/

	// RVA: -1 Offset: -1
	public int Next(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1789420 Offset: 0x1787A20 VA: 0x181789420
	|-RBTree<int>.Next
	|
	|-RVA: 0x20CA030 Offset: 0x20C8630 VA: 0x1820CA030
	|-RBTree<object>.Next
	*/

	// RVA: -1 Offset: -1
	public int SubTreeSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178C4E0 Offset: 0x178AAE0 VA: 0x18178C4E0
	|-RBTree<int>.SubTreeSize
	|
	|-RVA: 0x20CD090 Offset: 0x20CB690 VA: 0x1820CD090
	|-RBTree<object>.SubTreeSize
	*/

	// RVA: -1 Offset: -1
	public K Key(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1788C70 Offset: 0x1787270 VA: 0x181788C70
	|-RBTree<int>.Key
	|
	|-RVA: 0x20C9A80 Offset: 0x20C8080 VA: 0x1820C9A80
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
	|-RVA: 0x17868E0 Offset: 0x1784EE0 VA: 0x1817868E0
	|-Listeners<DataViewListener>..ctor
	|-Listeners<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool get_HasListeners() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17869B0 Offset: 0x1784FB0 VA: 0x1817869B0
	|-Listeners<DataViewListener>.get_HasListeners
	|-Listeners<object>.get_HasListeners
	*/

	// RVA: -1 Offset: -1
	internal void Add(TElem listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE04870 Offset: 0xE02E70 VA: 0x180E04870
	|-Listeners<DataViewListener>.Add
	|-Listeners<object>.Add
	*/

	// RVA: -1 Offset: -1
	internal int IndexOfReference(TElem listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1786790 Offset: 0x1784D90 VA: 0x181786790
	|-Listeners<object>.IndexOfReference
	*/

	// RVA: -1 Offset: -1
	internal void Remove(TElem listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1786830 Offset: 0x1784E30 VA: 0x181786830
	|-Listeners<DataViewListener>.Remove
	|-Listeners<object>.Remove
	*/

	// RVA: -1 Offset: -1
	internal void Notify<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3, Listeners.Action<TElem, TElem, T1, T2, T3> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE02630 Offset: 0xE00C30 VA: 0x180E02630
	|-Listeners<DataViewListener>.Notify<ListChangedEventArgs, bool, bool>
	|-Listeners<object>.Notify<object, bool, bool>
	|
	|-RVA: 0xE02430 Offset: 0xE00A30 VA: 0x180E02430
	|-Listeners<DataViewListener>.Notify<ListChangedType, DataRow, bool>
	|-Listeners<object>.Notify<Int32Enum, object, bool>
	|
	|-RVA: 0xE02830 Offset: 0xE00E30 VA: 0x180E02830
	|-Listeners<object>.Notify<object, object, object>
	*/

	// RVA: -1 Offset: -1
	private void RemoveNullListeners(int nullIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17867B0 Offset: 0x1784DB0 VA: 0x1817867B0
	|-Listeners<object>.RemoveNullListeners
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 4436
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 0EE6555EB2C89F29655BD23FAB0573D8D684331A /*Metadata offset 0x53EECF*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 229F48C8598232AD9236772DD710E64615D0EE51 /*Metadata offset 0x53EEF3*/; // 0x24
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=38 2A4F1BD548EC71F652E24985361CD72F0FE1BE7D /*Metadata offset 0x53EF8B*/; // 0xBC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 547FF12759F2EA9866F3E2095113686A6379ABBF /*Metadata offset 0x53EFB1*/; // 0xE2
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=176 57F92A12C48A0856350D3C95C4145F2AF4C9DEFF /*Metadata offset 0x53F049*/; // 0x17A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 624B37B4C211942F3422DFFEAE9F44901E57339C /*Metadata offset 0x53F0F9*/; // 0x22A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 DD3AEFEADB1CD615F3017763F1568179FEE640B0 /*Metadata offset 0x53F191*/; // 0x2C2
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 E92B39D8233061927D9ACDE54665E68E7535635A /*Metadata offset 0x53F1C5*/; // 0x2F6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 FA7899481F1198B5A3F90368A998C285FCE19878 /*Metadata offset 0x53F1F9*/; // 0x32A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 FF8FD0AC7542FD42A8A7C8D145E120345BA51C56 /*Metadata offset 0x53F239*/; // 0x36A

}

internal sealed class _AndroidJNIHelper // TypeDefIndex: 4471
{	// Methods

	// RVA: 0x227AF10 Offset: 0x2279510 VA: 0x18227AF10
	public static IntPtr CreateJavaProxy(IntPtr delegateHandle, AndroidJavaProxy proxy) { }

	// RVA: 0x2272590 Offset: 0x2270B90 VA: 0x182272590
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x227C130 Offset: 0x227A730 VA: 0x18227C130
	public static IntPtr InvokeJavaProxyMethod(AndroidJavaProxy proxy, IntPtr jmethodName, IntPtr jargs) { }

	// RVA: 0x227A460 Offset: 0x2278A60 VA: 0x18227A460
	public static jvalue[] CreateJNIArgArray(object[] args) { }

	// RVA: 0x227C400 Offset: 0x227AA00 VA: 0x18227C400
	public static object UnboxArray(AndroidJavaObject obj) { }

	// RVA: 0x227C930 Offset: 0x227AF30 VA: 0x18227C930
	public static object Unbox(AndroidJavaObject obj) { }

	// RVA: 0x2278C80 Offset: 0x2277280 VA: 0x182278C80
	public static AndroidJavaObject Box(object obj) { }

	// RVA: 0x22726C0 Offset: 0x2270CC0 VA: 0x1822726C0
	public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs) { }

	// RVA: 0x2279B70 Offset: 0x2278170 VA: 0x182279B70
	public static IntPtr ConvertToJNIArray(Array array) { }

	// RVA: -1 Offset: -1
	public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125F580 Offset: 0x125DB80 VA: 0x18125F580
	|-_AndroidJNIHelper.ConvertFromJNIArray<bool>
	|
	|-RVA: 0x125FE30 Offset: 0x125E430 VA: 0x18125FE30
	|-_AndroidJNIHelper.ConvertFromJNIArray<char>
	|
	|-RVA: 0x12606E0 Offset: 0x125ECE0 VA: 0x1812606E0
	|-_AndroidJNIHelper.ConvertFromJNIArray<double>
	|
	|-RVA: 0x1260F90 Offset: 0x125F590 VA: 0x181260F90
	|-_AndroidJNIHelper.ConvertFromJNIArray<short>
	|
	|-RVA: 0x1261840 Offset: 0x125FE40 VA: 0x181261840
	|-_AndroidJNIHelper.ConvertFromJNIArray<int>
	|
	|-RVA: 0x12620F0 Offset: 0x12606F0 VA: 0x1812620F0
	|-_AndroidJNIHelper.ConvertFromJNIArray<long>
	|
	|-RVA: 0x12629A0 Offset: 0x1260FA0 VA: 0x1812629A0
	|-_AndroidJNIHelper.ConvertFromJNIArray<object>
	|
	|-RVA: 0x1263290 Offset: 0x1261890 VA: 0x181263290
	|-_AndroidJNIHelper.ConvertFromJNIArray<sbyte>
	|
	|-RVA: 0x1263B40 Offset: 0x1262140 VA: 0x181263B40
	|-_AndroidJNIHelper.ConvertFromJNIArray<float>
	*/

	// RVA: 0x22727F0 Offset: 0x2270DF0 VA: 0x1822727F0
	public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	// RVA: -1 Offset: -1
	public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED9A80 Offset: 0xED8080 VA: 0x180ED9A80
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

	// RVA: 0x227B070 Offset: 0x2279670 VA: 0x18227B070
	public static IntPtr GetConstructorID(IntPtr jclass, string signature) { }

	// RVA: 0x227B2D0 Offset: 0x22798D0 VA: 0x18227B2D0
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x227B240 Offset: 0x2279840 VA: 0x18227B240
	private static IntPtr GetMethodIDFallback(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x227B4B0 Offset: 0x2279AB0 VA: 0x18227B4B0
	public static string GetSignature(object obj) { }

	// RVA: 0x227C050 Offset: 0x227A650 VA: 0x18227C050
	public static string GetSignature(object[] args) { }

	// RVA: -1 Offset: -1
	public static string GetSignature<ReturnType>(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED9AE0 Offset: 0xED80E0 VA: 0x180ED9AE0
	|-_AndroidJNIHelper.GetSignature<bool>
	|
	|-RVA: 0xED9C20 Offset: 0xED8220 VA: 0x180ED9C20
	|-_AndroidJNIHelper.GetSignature<char>
	|
	|-RVA: 0xED9D60 Offset: 0xED8360 VA: 0x180ED9D60
	|-_AndroidJNIHelper.GetSignature<double>
	|
	|-RVA: 0xED9EA0 Offset: 0xED84A0 VA: 0x180ED9EA0
	|-_AndroidJNIHelper.GetSignature<short>
	|
	|-RVA: 0xED9FE0 Offset: 0xED85E0 VA: 0x180ED9FE0
	|-_AndroidJNIHelper.GetSignature<int>
	|
	|-RVA: 0xEDA120 Offset: 0xED8720 VA: 0x180EDA120
	|-_AndroidJNIHelper.GetSignature<long>
	|
	|-RVA: 0xEDA260 Offset: 0xED8860 VA: 0x180EDA260
	|-_AndroidJNIHelper.GetSignature<object>
	|
	|-RVA: 0xEDA3A0 Offset: 0xED89A0 VA: 0x180EDA3A0
	|-_AndroidJNIHelper.GetSignature<sbyte>
	|
	|-RVA: 0xEDA4E0 Offset: 0xED8AE0 VA: 0x180EDA4E0
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
	|-RVA: 0x17F8B50 Offset: 0x17F7150 VA: 0x1817F8B50
	|-Memoized<object, int>..ctor
	|-Memoized<Material[], int>..ctor
	|
	|-RVA: 0x17F8D30 Offset: 0x17F7330 VA: 0x1817F8D30
	|-Memoized<object, object>..ctor
	|-Memoized<string, string>..ctor
	|
	|-RVA: 0x17F8C40 Offset: 0x17F7240 VA: 0x1817F8C40
	|-Memoized<object, ValueTuple<Int32Enum, int>>..ctor
	|-Memoized<string, ValueTuple<ItemDefinition.AmountType, int>>..ctor
	*/

	// RVA: -1 Offset: -1
	public TResult Get(TArgs args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F8910 Offset: 0x17F6F10 VA: 0x1817F8910
	|-Memoized<string, string>.Get
	|-Memoized<object, object>.Get
	|
	|-RVA: 0x17F8A90 Offset: 0x17F7090 VA: 0x1817F8A90
	|-Memoized<string, ValueTuple<ItemDefinition.AmountType, int>>.Get
	|-Memoized<object, ValueTuple<Int32Enum, int>>.Get
	|
	|-RVA: 0x17F89D0 Offset: 0x17F6FD0 VA: 0x1817F89D0
	|-Memoized<Material[], int>.Get
	|-Memoized<object, int>.Get
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 4849
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=146 062825E0D4AB4302B73500604BF9520511ACFD15 /*Metadata offset 0x53F7E3*/; // 0x136E0

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 4899
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=104 1D1E8406C3A31F2298952B0976625EEDFB010FDC /*Metadata offset 0x53F949*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=76 339A8BB625A037BA37DB4DF24A276E689D62172D /*Metadata offset 0x53F9B1*/; // 0x68
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=76 48DE754CC0C776DAD1A85DB81BEFAAADE3A447E9 /*Metadata offset 0x53F9FD*/; // 0xB4
	internal static readonly long A5F5D64EF7BB696455C9841B907D2E09986EA902 = 2533317740920876; // 0x100

	// Methods

	// RVA: 0xAAB500 Offset: 0xAA9B00 VA: 0x180AAB500
	internal static uint ComputeStringHash(string s) { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5096
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 7BBE37982E6C057ED87163CAFC7FD6E5E42EEA46 /*Metadata offset 0x53FD57*/; // 0x2B111C0

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5561
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5 B1A9AA820F353E1BEF1F7D40CD3F58447AA91D123BC2539918BC70F8A66E75B9 /*Metadata offset 0x540991*/; // 0x2B11230

	// Methods

	// RVA: 0xAAB500 Offset: 0xAA9B00 VA: 0x180AAB500
	internal static uint ComputeStringHash(string s) { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5616
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 BA8C008E9A9CA9629B0D5A47EB9DFDC7E9E88D61 /*Metadata offset 0x540B6D*/; // 0x2B111C0

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
	|-RVA: 0x15E8A20 Offset: 0x15E7020 VA: 0x1815E8A20
	|-PriorityQueue<long, object>..ctor
	|-PriorityQueue<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E8AC0 Offset: 0x15E70C0 VA: 0x1815E8AC0
	|-PriorityQueue<long, TimedBlock>..ctor
	|-PriorityQueue<long, object>..ctor
	|-PriorityQueue<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Enqueue(TPriority priority, TItem item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E87C0 Offset: 0x15E6DC0 VA: 0x1815E87C0
	|-PriorityQueue<long, TimedBlock>.Enqueue
	|-PriorityQueue<long, object>.Enqueue
	|-PriorityQueue<object, object>.Enqueue
	*/

	// RVA: -1 Offset: -1
	private void AddQueueOfPriority(TPriority priority) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E8510 Offset: 0x15E6B10 VA: 0x1815E8510
	|-PriorityQueue<long, object>.AddQueueOfPriority
	|-PriorityQueue<object, object>.AddQueueOfPriority
	*/

	// RVA: -1 Offset: -1
	public TItem Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E8880 Offset: 0x15E6E80 VA: 0x1815E8880
	|-PriorityQueue<long, TimedBlock>.Peek
	|-PriorityQueue<long, object>.Peek
	|
	|-RVA: 0x15E8950 Offset: 0x15E6F50 VA: 0x1815E8950
	|-PriorityQueue<object, object>.Peek
	*/

	// RVA: -1 Offset: -1
	public bool get_HasItems() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E8B20 Offset: 0x15E7120 VA: 0x1815E8B20
	|-PriorityQueue<long, TimedBlock>.get_HasItems
	|-PriorityQueue<long, object>.get_HasItems
	|-PriorityQueue<object, object>.get_HasItems
	*/

	// RVA: -1 Offset: -1
	public TItem Dequeue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E8680 Offset: 0x15E6C80 VA: 0x1815E8680
	|-PriorityQueue<long, TimedBlock>.Dequeue
	|-PriorityQueue<long, object>.Dequeue
	|
	|-RVA: 0x15E8720 Offset: 0x15E6D20 VA: 0x1815E8720
	|-PriorityQueue<object, object>.Dequeue
	*/

	// RVA: -1 Offset: -1
	private TItem DequeueFromHighPriorityQueue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E85B0 Offset: 0x15E6BB0 VA: 0x1815E85B0
	|-PriorityQueue<long, object>.DequeueFromHighPriorityQueue
	|-PriorityQueue<object, object>.DequeueFromHighPriorityQueue
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5677
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 00C40B3F013EDA60390F2E849C4581815A9419E4 /*Metadata offset 0x540BEB*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 03B569C38E3CD6B720388919D43735A904012C52 /*Metadata offset 0x540C13*/; // 0x28
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=76 1FDC8DB567F5AAA7068D0D2A601CD71657CBDF38 /*Metadata offset 0x540C3B*/; // 0x50
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 373B494F210C656134C5728D551D4C97B013EB33 /*Metadata offset 0x540C87*/; // 0x9C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 6BC4EAB0D604C8D4599021AD611C5DBA7FF7E306 /*Metadata offset 0x541087*/; // 0x49C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 89CE0E8EA590FD37283D6BEFD9E6805C8C47ADBD /*Metadata offset 0x5410AF*/; // 0x4C4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 DB7C763C9670DD0F6ED34B75B3410A39D835F964 /*Metadata offset 0x5410BF*/; // 0x4D4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 ED032026472FF77A8A17BA4AFF3FC57AF4B4BF79 /*Metadata offset 0x5410E7*/; // 0x4FC

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5812
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=127 A097044521F478B3A2A9A3AC52887BA733E4DE56 /*Metadata offset 0x541190*/; // 0x2B111D0

	// Methods

	// RVA: 0xAAB500 Offset: 0xAA9B00 VA: 0x180AAB500
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
	|-RVA: 0x1A68820 Offset: 0x1A66E20 VA: 0x181A68820
	|-XHashtable<object>..ctor
	|-XHashtable<WeakReference>..ctor
	|-XHashtable<XName>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(string key, int index, int count, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A687E0 Offset: 0x1A66DE0 VA: 0x181A687E0
	|-XHashtable<object>.TryGetValue
	|-XHashtable<WeakReference>.TryGetValue
	|-XHashtable<XName>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public TValue Add(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A68650 Offset: 0x1A66C50 VA: 0x181A68650
	|-XHashtable<object>.Add
	|-XHashtable<WeakReference>.Add
	|-XHashtable<XName>.Add
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5852
{
// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5852
	// Methods

	// RVA: 0xAAB500 Offset: 0xAA9B00 VA: 0x180AAB500
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
	|-RVA: 0xD59430 Offset: 0xD57A30 VA: 0x180D59430
	|-MethodCall<object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(T target, object[] args, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAE4840 Offset: 0xAE2E40 VA: 0x180AE4840
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
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 9E31F24F64765FCAA589F589324D17C9FCF6A06D /*Metadata offset 0x5415FA*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 ADFD2E1C801C825415DD53F4F2F72A13B389313C /*Metadata offset 0x541616*/; // 0x1C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 D40004AB0E92BF6C8DFE481B56BE3D04ABDA76EB /*Metadata offset 0x541622*/; // 0x28
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 DD3AEFEADB1CD615F3017763F1568179FEE640B0 /*Metadata offset 0x54162C*/; // 0x32
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 E92B39D8233061927D9ACDE54665E68E7535635A /*Metadata offset 0x541660*/; // 0x66

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 6262
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 553AD71118F2B31C74BC988917343BADFA8F78EE /*Metadata offset 0x5417AD*/; // 0x2B111D0

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 6635
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 373B494F210C656134C5728D551D4C97B013EB33 /*Metadata offset 0x541E06*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 E03C5B88B476F381E452F92C935A5B86131DFC4A /*Metadata offset 0x542206*/; // 0x400

}

internal class <PrivateImplementationDetails>{A0874672-3A49-45D7-A8B0-51E6098CECDA} // TypeDefIndex: 6713
{	// Fields
	internal static <PrivateImplementationDetails>{A0874672-3A49-45D7-A8B0-51E6098CECDA}.__StaticArrayInitTypeSize=32 $$method0x600002d-1 /*Metadata offset 0x542AEF*/; // 0x0
	internal static <PrivateImplementationDetails>{A0874672-3A49-45D7-A8B0-51E6098CECDA}.__StaticArrayInitTypeSize=32 $$method0x600002d-2 /*Metadata offset 0x542B0F*/; // 0x20
	internal static <PrivateImplementationDetails>{A0874672-3A49-45D7-A8B0-51E6098CECDA}.__StaticArrayInitTypeSize=128 $$method0x600002d-3 /*Metadata offset 0x542B2F*/; // 0x40
	internal static <PrivateImplementationDetails>{A0874672-3A49-45D7-A8B0-51E6098CECDA}.__StaticArrayInitTypeSize=256 $$method0x600002d-4 /*Metadata offset 0x542BAF*/; // 0xC0

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
	|-RVA: 0x17AB970 Offset: 0x17A9F70 VA: 0x1817AB970
	|-FastAction<bool>.Add
	|-FastAction<object>.Add
	|-FastAction<Object>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<A> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ABAC0 Offset: 0x17AA0C0 VA: 0x1817ABAC0
	|-FastAction<bool>.Remove
	|-FastAction<object>.Remove
	|-FastAction<Object>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Call(A a) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A534C0 Offset: 0x1A51AC0 VA: 0x181A534C0
	|-FastAction<bool>.Call
	|
	|-RVA: 0x17ABA10 Offset: 0x17AA010 VA: 0x1817ABA10
	|-FastAction<object>.Call
	|-FastAction<TMP_ColorGradient>.Call
	|-FastAction<Object>.Call
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ABB60 Offset: 0x17AA160 VA: 0x1817ABB60
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
	|-RVA: 0x17AB970 Offset: 0x17A9F70 VA: 0x1817AB970
	|-FastAction<bool, object>.Add
	|-FastAction<object, object>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<A, B> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ABAC0 Offset: 0x17AA0C0 VA: 0x1817ABAC0
	|-FastAction<bool, object>.Remove
	|-FastAction<object, object>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Call(A a, B b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ABD10 Offset: 0x17AA310 VA: 0x1817ABD10
	|-FastAction<bool, object>.Call
	|-FastAction<bool, TMP_FontAsset>.Call
	|-FastAction<bool, TextMeshPro>.Call
	|-FastAction<bool, TextMeshProUGUI>.Call
	|-FastAction<bool, Material>.Call
	|-FastAction<bool, Object>.Call
	|
	|-RVA: 0x17ABC40 Offset: 0x17AA240 VA: 0x1817ABC40
	|-FastAction<object, object>.Call
	|-FastAction<object, Compute_DT_EventArgs>.Call
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ABB60 Offset: 0x17AA160 VA: 0x1817ABB60
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
	|-RVA: 0x17AB970 Offset: 0x17A9F70 VA: 0x1817AB970
	|-FastAction<object, object, object>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<A, B, C> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ABAC0 Offset: 0x17AA0C0 VA: 0x1817ABAC0
	|-FastAction<object, object, object>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Call(A a, B b, C c) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ABDE0 Offset: 0x17AA3E0 VA: 0x1817ABDE0
	|-FastAction<object, object, object>.Call
	|-FastAction<GameObject, Material, Material>.Call
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ABB60 Offset: 0x17AA160 VA: 0x1817ABB60
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
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 7BBE37982E6C057ED87163CAFC7FD6E5E42EEA46 /*Metadata offset 0x5432BF*/; // 0x38A0

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 6937
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=18 B633673BF635D4C719EF5A0496BD28129A8CE5D3B76217371B6C1FDDFFDD780B /*Metadata offset 0x543319*/; // 0x2B111E0

}

internal class <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7} // TypeDefIndex: 6968
{	// Fields
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=76 $$method0x6000504-1 /*Metadata offset 0x54341F*/; // 0x0
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=68 $$method0x6000505-1 /*Metadata offset 0x54346B*/; // 0x4C
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=6144 $$method0x6000507-1 /*Metadata offset 0x5434AF*/; // 0x90
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=384 $$method0x6000507-2 /*Metadata offset 0x544CAF*/; // 0x1890
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=124 $$method0x6000507-3 /*Metadata offset 0x544E2F*/; // 0x1A10
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=124 $$method0x6000507-4 /*Metadata offset 0x544EAB*/; // 0x1A8C
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=120 $$method0x6000507-5 /*Metadata offset 0x544F27*/; // 0x1B08
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=120 $$method0x6000507-6 /*Metadata offset 0x544F9F*/; // 0x1B80
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=116 $$method0x6000509-1 /*Metadata offset 0x545017*/; // 0x1BF8
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=120 $$method0x6000509-2 /*Metadata offset 0x54508B*/; // 0x1C6C
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=76 $$method0x6000509-3 /*Metadata offset 0x545103*/; // 0x1CE4
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=19 $$method0x6000509-4 /*Metadata offset 0x54514F*/; // 0x1D30
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=512 $$method0x6000509-5 /*Metadata offset 0x545162*/; // 0x1D43
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=256 $$method0x6000509-6 /*Metadata offset 0x545362*/; // 0x1F43
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=116 $$method0x6000509-7 /*Metadata offset 0x545462*/; // 0x2043
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=120 $$method0x6000509-8 /*Metadata offset 0x5454D6*/; // 0x20B7
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=1152 $$method0x6000475-1 /*Metadata offset 0x54554E*/; // 0x212F
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=120 $$method0x6000475-2 /*Metadata offset 0x5459CE*/; // 0x25AF

}

internal class <PrivateImplementationDetails>{4136EF42-BA0E-48C1-8B0C-A481CDC84FC8} // TypeDefIndex: 6993
{	// Fields
	internal static <PrivateImplementationDetails>{4136EF42-BA0E-48C1-8B0C-A481CDC84FC8}.__StaticArrayInitTypeSize=32 $$method0x600007d-1 /*Metadata offset 0x545A7F*/; // 0x0
	internal static <PrivateImplementationDetails>{4136EF42-BA0E-48C1-8B0C-A481CDC84FC8}.__StaticArrayInitTypeSize=32 $$method0x600007d-2 /*Metadata offset 0x545A9F*/; // 0x20
	internal static <PrivateImplementationDetails>{4136EF42-BA0E-48C1-8B0C-A481CDC84FC8}.__StaticArrayInitTypeSize=128 $$method0x600007d-3 /*Metadata offset 0x545ABF*/; // 0x40
	internal static <PrivateImplementationDetails>{4136EF42-BA0E-48C1-8B0C-A481CDC84FC8}.__StaticArrayInitTypeSize=256 $$method0x600007d-4 /*Metadata offset 0x545B3F*/; // 0xC0

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
	|-RVA: 0x228D10 Offset: 0x228110 VA: 0x180228D10
	|-ValueTask<bool>..ctor
	|
	|-RVA: 0x228C80 Offset: 0x228080 VA: 0x180228C80
	|-ValueTask<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Task<TResult> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x228C30 Offset: 0x228030 VA: 0x180228C30
	|-ValueTask<bool>..ctor
	|
	|-RVA: 0x228CC0 Offset: 0x2280C0 VA: 0x180228CC0
	|-ValueTask<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x228A10 Offset: 0x227E10 VA: 0x180228A10
	|-ValueTask<bool>.GetHashCode
	|
	|-RVA: 0x228A50 Offset: 0x227E50 VA: 0x180228A50
	|-ValueTask<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2286D0 Offset: 0x227AD0 VA: 0x1802286D0
	|-ValueTask<bool>.Equals
	|
	|-RVA: 0x228810 Offset: 0x227C10 VA: 0x180228810
	|-ValueTask<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTask<TResult> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x228930 Offset: 0x227D30 VA: 0x180228930
	|-ValueTask<bool>.Equals
	|
	|-RVA: 0x2287E0 Offset: 0x227BE0 VA: 0x1802287E0
	|-ValueTask<object>.Equals
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x228D70 Offset: 0x228170 VA: 0x180228D70
	|-ValueTask<bool>.get_IsCompleted
	|
	|-RVA: 0x228EB0 Offset: 0x2282B0 VA: 0x180228EB0
	|-ValueTask<object>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompletedSuccessfully() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x228D60 Offset: 0x228160 VA: 0x180228D60
	|-ValueTask<bool>.get_IsCompletedSuccessfully
	|
	|-RVA: 0x228D50 Offset: 0x228150 VA: 0x180228D50
	|-ValueTask<object>.get_IsCompletedSuccessfully
	*/

	// RVA: -1 Offset: -1
	public TResult get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229000 Offset: 0x228400 VA: 0x180229000
	|-ValueTask<bool>.get_Result
	|
	|-RVA: 0x228FF0 Offset: 0x2283F0 VA: 0x180228FF0
	|-ValueTask<object>.get_Result
	*/

	// RVA: -1 Offset: -1
	public ValueTaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x228950 Offset: 0x227D50 VA: 0x180228950
	|-ValueTask<bool>.GetAwaiter
	|
	|-RVA: 0x2289A0 Offset: 0x227DA0 VA: 0x1802289A0
	|-ValueTask<object>.GetAwaiter
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x228B60 Offset: 0x227F60 VA: 0x180228B60
	|-ValueTask<bool>.ToString
	|
	|-RVA: 0x228A90 Offset: 0x227E90 VA: 0x180228A90
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
	|-RVA: 0x1E3D30 Offset: 0x1E3130 VA: 0x1801E3D30
	|-ValueTaskAwaiter<bool>..ctor
	|
	|-RVA: 0x1E3D50 Offset: 0x1E3150 VA: 0x1801E3D50
	|-ValueTaskAwaiter<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3DB0 Offset: 0x1E31B0 VA: 0x1801E3DB0
	|-ValueTaskAwaiter<bool>.get_IsCompleted
	|
	|-RVA: 0x1E3D70 Offset: 0x1E3170 VA: 0x1801E3D70
	|-ValueTaskAwaiter<object>.get_IsCompleted
	*/

	[StackTraceHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public TResult GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3C70 Offset: 0x1E3070 VA: 0x1801E3C70
	|-ValueTaskAwaiter<bool>.GetResult
	|
	|-RVA: 0x1E3CB0 Offset: 0x1E30B0 VA: 0x1801E3CB0
	|-ValueTaskAwaiter<object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3D00 Offset: 0x1E3100 VA: 0x1801E3D00
	|-ValueTaskAwaiter<bool>.OnCompleted
	|
	|-RVA: 0x1E3CF0 Offset: 0x1E30F0 VA: 0x1801E3CF0
	|-ValueTaskAwaiter<object>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3D10 Offset: 0x1E3110 VA: 0x1801E3D10
	|-ValueTaskAwaiter<bool>.UnsafeOnCompleted
	|
	|-RVA: 0x1E3D20 Offset: 0x1E3120 VA: 0x1801E3D20
	|-ValueTaskAwaiter<object>.UnsafeOnCompleted
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 7366
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 C92FBDBB320D6C40BEB41D97EE6C7B301C4ADB1D /*Metadata offset 0x547B37*/; // 0x2B111C8

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 7415
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 021F8912B268BE164A590D1440F05920A3F2A63B9874F994402C7AFFC6F92F82 /*Metadata offset 0x548373*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 02E68C9160BF270CAF19E18D3A77BC2EAA90EFCB3ECA3C454B58CD5BBA5FF7ED /*Metadata offset 0x5483B3*/; // 0x40
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 047D891CAC8D4F883998ACEFD1EB63F6A679046FFD19EC1276A057F847EE37F6 /*Metadata offset 0x5484B3*/; // 0x140
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 06ADCD404637282636289E77FA01C56630CB4945332C96D5FA2D9239FE0D6B04 /*Metadata offset 0x5484C3*/; // 0x150
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 06D49AE61368F7B7C195381125B5A5E8F6830EA024D49F5C1A62950E74DBAF3D /*Metadata offset 0x548543*/; // 0x1D0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 091971E0756262C068D16B941EA6256855E94532833A9CE3374D9768E27E4596 /*Metadata offset 0x548583*/; // 0x210
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 124360CE49E1C84604EFA93F8F0C3292C1D216DB605CF153414D893922B18C9F /*Metadata offset 0x548613*/; // 0x2A0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 13BE6783CC652C89CC0161446DBD67966CAC410DEA4DE4279FC767A259EFD546 /*Metadata offset 0x548653*/; // 0x2E0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 1B8D49F1227D3FC61644822B9FC00CE70A3B2438A1064323BFBE6A022A26F042 /*Metadata offset 0x54868B*/; // 0x318
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 1C01F69BD2391DE00F8F1B377D2D9E5991674702AD777030BA910AC531E4B0FE /*Metadata offset 0x54869B*/; // 0x328
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 22E5D3D9ABC124EE0214CEF7079F24CFF9BE30FD6AF6BA5BBE15920C57497EA1 /*Metadata offset 0x5486DB*/; // 0x368
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 2A03DC27FE2EB4E5D0A4358E22435065F2FB1BBF8CC2C4D9F754A9F24089344E /*Metadata offset 0x5486EB*/; // 0x378
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=60 2A1C6CEE1B003A06B471AA7632C6B5C4ED18A4E1A4784BF8CA09BD4F38BA4BB5 /*Metadata offset 0x54872B*/; // 0x3B8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 2BCE8E19B19AAD97CC510F21B5828CCB319639FA317FB59926A436ED3543F58D /*Metadata offset 0x548767*/; // 0x3F4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 2C72B27AAD08F98379E9F3E0F6A2D625F895C9E55F61404790377FC196FA14B8 /*Metadata offset 0x5487A7*/; // 0x434
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 2F4596419894C88417AC4DF5C99E98A374EFE4B57B7A4EB89CE65FEB92850A61 /*Metadata offset 0x5487E7*/; // 0x474
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 320B0930454D74130DD5E245B70DA1736A2C1B5E664DD5BB82B490E60F3ECA2A /*Metadata offset 0x5487F7*/; // 0x484
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 3229DAC3DA84FAC1A1018091DAF2A0C3D6B3624AC33BECF13A371238DAC95055 /*Metadata offset 0x548807*/; // 0x494
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 3543AE0E1ED6A92350687219F717764E126E06D4FA179DE5B0CB3E2BDFE4AC9E /*Metadata offset 0x548817*/; // 0x4A4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 3554CE8BB09083C24D298DF77456CB67242E6EEE3DEDFE595E11B90D2F70C0FF /*Metadata offset 0x548873*/; // 0x500
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1500 3B42FF7B534B27868E300720C678882AF0698E9434D0FA135656E097480324FF /*Metadata offset 0x5488B3*/; // 0x540
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 3EDD050356C639DD16815E64CA19652B1B981F1BA2FF76176BB3995FF0DB860D /*Metadata offset 0x548E8F*/; // 0xB1C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 4053901EA5134D137292C48A98E1382B09C1E49C98EEF77C2D00D8FF24481D4F /*Metadata offset 0x548E9F*/; // 0xB2C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 419EB5F371A1171DBE8C085F1BB25D78AA0647C1365608E167054A37BFEAD834 /*Metadata offset 0x548EDF*/; // 0xB6C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 4517AF16CD9D95D0B56C33292D289749B763021F170127ED439165498D243E69 /*Metadata offset 0x548EEF*/; // 0xB7C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 4E7A2BE1E8600FA773FA4952A14AE27AD21E294C2C90F674BEA6BB8B089F39C1 /*Metadata offset 0x548F03*/; // 0xB90
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 550560694565D72C91221BEE89B41C8AA412660E1CF28C626BC523BC959438A9 /*Metadata offset 0x548F23*/; // 0xBB0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=8748 5600405012DD0807E058E5A8F3F7A9AF31716C8560F552613672D0D770364603 /*Metadata offset 0x548F63*/; // 0xBF0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 56C5F192F58A478FC32D5428DA86D03B15A95E9A982E82BA5026E6EBE259FE48 /*Metadata offset 0x54B18F*/; // 0x2E1C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 57CD95842F6B0D5A0823F7A82A33632D2D4DA79615A834507722CBBBD054E3CF /*Metadata offset 0x54B21F*/; // 0x2EAC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 58BB6050E828A1FDB65D46F61ADBE862543CF7261AA487580A1328D24E944BBD /*Metadata offset 0x54B25F*/; // 0x2EEC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 5ED52DA9C543DD730BD7056787DF87C0AED3189F42C3321C4196EA8B70C87D2A /*Metadata offset 0x54B26F*/; // 0x2EFC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=88 6547EC5EB178C3DBF6A302152A1FE3BDF747E8E5EB41343EECEA2F45D745E5D1 /*Metadata offset 0x54B2FF*/; // 0x2F8C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 673F8620472294A2666EB7018FC21EF377E5B15A76872E89803CBDBDBC17F1B8 /*Metadata offset 0x54B357*/; // 0x2FE4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 6807ED2269DB8E9A70F5D22C6D41806D26C51C306050C58861DEBD9B21D76D0B /*Metadata offset 0x54B367*/; // 0x2FF4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 6810D47101B1F88C982302E36EF8DBDB344EAFDF31E058B2AE9B23522DA15D89 /*Metadata offset 0x54B377*/; // 0x3004
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 683133215F3906FE49DACDB11CE3F917EF1B439110BF4CE1092DB8F15D087E2F /*Metadata offset 0x54B387*/; // 0x3014
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 68F20C1D1F9AD9A40A6FF9C3879482F58AED8E4A58995CEB0F83B2575DCFD2BC /*Metadata offset 0x54B3E3*/; // 0x3070
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 6B6C31FF54224894CC66030691DB54C3EEE6BE4D42DB3DDA43EEC126F036360E /*Metadata offset 0x54B3F3*/; // 0x3080
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 70CBEAD43E82DC4CCC445D5552A983D797EEF8D2AD3665EB8FAAB2187F64F6FE /*Metadata offset 0x54B433*/; // 0x30C0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 70CF9A93794FD166C020BBDF13AE34B6B43B3A2271EC768A35797C135FC62D20 /*Metadata offset 0x54B473*/; // 0x3100
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 79B6797C01D7827A0E35892156B642BD84A9FA528E603C743515D3822864A051 /*Metadata offset 0x54B4AB*/; // 0x3138
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 7A5DCFD7518F8A0A3FA422FA014FF84FE08070112345B17E00C0FB0AFC6D7461 /*Metadata offset 0x54B4CB*/; // 0x3158
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 7CC4C8FC1CA4B0FA871FEB4911499E0268FE161D01C6ADFD186B0378C4063EBA /*Metadata offset 0x54B4EB*/; // 0x3178
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 8C6C0F60451FBE1D2DDDF80A2A9F0B7684893D5B0B8CEAB4CA837EE615B3954E /*Metadata offset 0x54B50B*/; // 0x3198
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 941D4DCAADBEC3CC42B0F9F20212661AC83343F86BC7F873B237BC25AF1B195C /*Metadata offset 0x54BD0B*/; // 0x3998
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 9742CA838C60363B639BEC16A2086253E96A532C05331B73181E45ED9D213F13 /*Metadata offset 0x54BD4B*/; // 0x39D8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=324 9F53690DAB4D28E43D6BB3EB96D00F76FAF99D7681A6E8F0061297C8DD5EFF33 /*Metadata offset 0x54BD8B*/; // 0x3A18
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 9FB71D398994B2E0C6CE3CE99EE4CBD26EE1524A81DDB919603C13A2885F5483 /*Metadata offset 0x54BECF*/; // 0x3B5C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 A28E77C3345C5351A69C7393656A759AABE24F2E59F5BFC49A771E190D9C9FCC /*Metadata offset 0x54BF0F*/; // 0x3B9C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 A3F937EE796D2312148DDB921F1293E76047E426F9BF3864DD12817D66034E74 /*Metadata offset 0x54BF1F*/; // 0x3BAC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 A4B3F75E2EA169B5351F2BAA4DBAB862A18EDFBAE5B1CB4DBEFAEC4E22DA6BD3 /*Metadata offset 0x54BF5F*/; // 0x3BEC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 A84E72B8CD1EB5B569F80091ADA35B15F45C05E48515346C276DFBC7457817CD /*Metadata offset 0x54BF9F*/; // 0x3C2C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 AC808BDFC94A2720F9A403E96C598F28C4A82AACBF21E2A1A6347C32A66B6425 /*Metadata offset 0x54C01F*/; // 0x3CAC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 B107577D43B15DF28D27533ADF012E72BD63868C2A2E688AC15978DC38CD5677 /*Metadata offset 0x54C02F*/; // 0x3CBC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 B10D5342782BFD3820C0FFBD8DDCDF80BAA0ED5F0DF5746D2EA885110239AC7A /*Metadata offset 0x54C03F*/; // 0x3CCC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 B79C140A0DE10B238571FE854A6BC223D6D8C50F6ED4E227CCC677094DCB3558 /*Metadata offset 0x54C07F*/; // 0x3D0C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 B9C5D4C45600219530B355BB1786AA4E282347901A9E3BF35DC8EE98E1307DFB /*Metadata offset 0x54C09F*/; // 0x3D2C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 BBDCD859D8A76172AF0C213EFB99A6F64E8AB028BECE6D313FA5B6BCF96CD15A /*Metadata offset 0x54C0AF*/; // 0x3D3C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 C271A86BEFE71CEF20615946687F7A3A13E980C14FD4637951697CD4A6112156 /*Metadata offset 0x54C10B*/; // 0x3D98
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 C31F1438706DA962938E7F1D03470E164E0EA9EE1CD0F0D19CA29C7E932C91DC /*Metadata offset 0x54C167*/; // 0x3DF4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 C3FBE83D14A8E5B3DCCAF45D7AD6C35F769326FFAED483A102ACF50FB824C9C2 /*Metadata offset 0x54C177*/; // 0x3E04
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 C6D060549430A52150918BF2837FCCD94C6D727B74A5946A8F7EF51B940C3CF7 /*Metadata offset 0x54C1B7*/; // 0x3E44
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 C775F22681F0D15310756B294BB58FC4364A5DE6030B819E8D3EEC4E75454915 /*Metadata offset 0x54C1EF*/; // 0x3E7C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 C807773510A04834C84A6A093A8267D127DC4413714AD99057315D8CABE1D467 /*Metadata offset 0x54C24B*/; // 0x3ED8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 C842A7F36E23186A8F55DC7D0E63E781469950969CB88357227234F95C35DEA9 /*Metadata offset 0x54C26B*/; // 0x3EF8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 CCC564D5CDB40E327F07151E33EF8AD040EEB5129CE505D00FE6EC11BD28C359 /*Metadata offset 0x54C2C7*/; // 0x3F54
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 CD4DE47C20503BFF1B99694EAF6390723510293766C75243F8B3CA7B56C89359 /*Metadata offset 0x54C2FF*/; // 0x3F8C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 D20525C66D9D2B26BC9D3A773951775A3813FC7F97CC4A2EADFF258D3C9D869E /*Metadata offset 0x54C38F*/; // 0x401C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 D3310F8730C74E00C7014874471A5E27574CD015457352EFB0373E8C5DA85FD1 /*Metadata offset 0x54C39F*/; // 0x402C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 DD54E6E73536232DFD682C64D36E265B59ACF8AD04FC6062A2EB7225BBDDDB02 /*Metadata offset 0x54C3AF*/; // 0x403C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 DDC358E79464AB64B601CE4D8FBC308D787438D4CE92844B5FD77F2DE1E21575 /*Metadata offset 0x54C3E7*/; // 0x4074
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 DE26AA4452A148F1FCFF9D95EA656766D0DC19BDCEE086F85BC3F9BD8AB7F25B /*Metadata offset 0x54C4E7*/; // 0x4174
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 E2AA696710083FEFF382491A86DF649DB1E8EE6AA4ECF99E8D98CFBF871BFCE4 /*Metadata offset 0x54C4F7*/; // 0x4184
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=60 ED977BBA7102E7758BEF3DA21CD69B44B8864A1D6F43BB20E6BF59862487ECBA /*Metadata offset 0x54C507*/; // 0x4194
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 EFC52C86FFF3F24CE6C0C14D161FCF00584AB329C5997334034F2B4D91225307 /*Metadata offset 0x54C543*/; // 0x41D0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 F1B0145A5F0D3E964A90201094730422F3013B94D7B9E73B6FFDED5643D486A2 /*Metadata offset 0x54C58B*/; // 0x4218
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 F8756C1F7B8F886752A7B73230C5AC5397F7CE2B1BFDC5C139DBED513BD228C3 /*Metadata offset 0x54C5C3*/; // 0x4250

}

internal sealed class TimedObjectsComparer<TObject> : IComparer<TObject> // TypeDefIndex: 7464
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public int Compare(TObject x, TObject y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FBE20 Offset: 0x17FA420 VA: 0x1817FBE20
	|-TimedObjectsComparer<object>.Compare
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5B020 Offset: 0xD59620 VA: 0x180D5B020
	|-TimedObjectsComparer<object>..ctor
	*/

}

public sealed class ValueChange<TValue> : ITimedObject // TypeDefIndex: 7504
{	// Fields
	private readonly long _time; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly TValue <Value>k__BackingField; // 0x0

	// Properties
	public long Time { get; }
	public TValue Value { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(long time, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FCE40 Offset: 0x17FB440 VA: 0x1817FCE40
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

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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
	|-RVA: 0x17FCED0 Offset: 0x17FB4D0 VA: 0x1817FCED0
	|-ValueChange<object>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(ValueChange<TValue> change1, ValueChange<TValue> change2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FD0A0 Offset: 0x17FB6A0 VA: 0x1817FD0A0
	|-ValueChange<object>.op_Inequality
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FCD90 Offset: 0x17FB390 VA: 0x1817FCD90
	|-ValueChange<object>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FCC70 Offset: 0x17FB270 VA: 0x1817FCC70
	|-ValueChange<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FCCF0 Offset: 0x17FB2F0 VA: 0x1817FCCF0
	|-ValueChange<object>.GetHashCode
	*/

}

public sealed class ValueLine<TValue> : IEnumerable<ValueChange<TValue>>, IEnumerable // TypeDefIndex: 7505
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private EventHandler ValuesChanged; // 0x0
	private readonly TimedObjectsComparer<ValueChange<TValue>> _comparer; // 0x0
	private readonly List<ValueChange<TValue>> _valueChanges; // 0x0
	private readonly TValue _defaultValue; // 0x0
	private bool _valuesChanged; // 0x0
	private long _maxTime; // 0x0

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal void add_ValuesChanged(EventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FDEC0 Offset: 0x17FC4C0 VA: 0x1817FDEC0
	|-ValueLine<Tempo>.add_ValuesChanged
	|-ValueLine<TimeSignature>.add_ValuesChanged
	|-ValueLine<object>.add_ValuesChanged
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal void remove_ValuesChanged(EventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FDF70 Offset: 0x17FC570 VA: 0x1817FDF70
	|-ValueLine<Tempo>.remove_ValuesChanged
	|-ValueLine<TimeSignature>.remove_ValuesChanged
	|-ValueLine<object>.remove_ValuesChanged
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(TValue defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FDDC0 Offset: 0x17FC3C0 VA: 0x1817FDDC0
	|-ValueLine<Tempo>..ctor
	|-ValueLine<TimeSignature>..ctor
	|-ValueLine<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TValue GetValueAtTime(long time) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FD1E0 Offset: 0x17FB7E0 VA: 0x1817FD1E0
	|-ValueLine<TimeSignature>.GetValueAtTime
	|-ValueLine<object>.GetValueAtTime
	*/

	// RVA: -1 Offset: -1
	internal ValueChange<TValue> GetValueChangeAtTime(long time) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FD280 Offset: 0x17FB880 VA: 0x1817FD280
	|-ValueLine<object>.GetValueChangeAtTime
	*/

	// RVA: -1 Offset: -1
	internal void SetValue(long time, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FDB60 Offset: 0x17FC160 VA: 0x1817FDB60
	|-ValueLine<Tempo>.SetValue
	|-ValueLine<TimeSignature>.SetValue
	|-ValueLine<object>.SetValue
	*/

	// RVA: -1 Offset: -1
	internal ValueLine<TValue> Reverse(long centerTime) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FD430 Offset: 0x17FBA30 VA: 0x1817FD430
	|-ValueLine<Tempo>.Reverse
	|-ValueLine<TimeSignature>.Reverse
	|-ValueLine<object>.Reverse
	*/

	// RVA: -1 Offset: -1
	private void OnValuesChanged(bool forceSort = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FD370 Offset: 0x17FB970 VA: 0x1817FD370
	|-ValueLine<object>.OnValuesChanged
	*/

	// RVA: -1 Offset: -1
	private void OnValueChangesNeedSorting() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC8520 Offset: 0xFC6B20 VA: 0x180FC8520
	|-ValueLine<object>.OnValueChangesNeedSorting
	*/

	// RVA: -1 Offset: -1
	private void OnValueChangesSortingCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF60020 Offset: 0xF5E620 VA: 0x180F60020
	|-ValueLine<object>.OnValueChangesSortingCompleted
	*/

	// RVA: -1 Offset: -1
	private void SortValueChanges() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FDD20 Offset: 0x17FC320 VA: 0x1817FDD20
	|-ValueLine<object>.SortValueChanges
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<ValueChange<TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FD130 Offset: 0x17FB730 VA: 0x1817FD130
	|-ValueLine<Tempo>.GetEnumerator
	|-ValueLine<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17FDD90 Offset: 0x17FC390 VA: 0x1817FDD90
	|-ValueLine<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 7638
{	// Fields
	internal static readonly int B52DDE3D967E604310620E80EFBFBED9B6FB8C0605B3CB29D31534DAA6181A7C = 505223448; // 0x2B11334

}

internal class <PrivateImplementationDetails> // TypeDefIndex: 7836
{	// Fields
	internal static <PrivateImplementationDetails>.$ArrayType$132 $$field-0 /*Metadata offset 0x54D611*/; // 0x2300

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

internal class <PrivateImplementationDetails> // TypeDefIndex: 7854
{	// Fields
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-0 /*Metadata offset 0x54DE41*/; // 0x0
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-1 /*Metadata offset 0x54E041*/; // 0x200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-2 /*Metadata offset 0x54E241*/; // 0x400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-3 /*Metadata offset 0x54E441*/; // 0x600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-4 /*Metadata offset 0x54E641*/; // 0x800
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-5 /*Metadata offset 0x54E841*/; // 0xA00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-6 /*Metadata offset 0x54EA41*/; // 0xC00

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

internal class <PrivateImplementationDetails> // TypeDefIndex: 7895
{	// Fields
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-0 /*Metadata offset 0x54F3ED*/; // 0x0
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-1 /*Metadata offset 0x54F5ED*/; // 0x200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-2 /*Metadata offset 0x54F7ED*/; // 0x400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-3 /*Metadata offset 0x54F9ED*/; // 0x600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-4 /*Metadata offset 0x54FBED*/; // 0x800
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-5 /*Metadata offset 0x54FDED*/; // 0xA00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-6 /*Metadata offset 0x54FFED*/; // 0xC00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-7 /*Metadata offset 0x5501ED*/; // 0xE00

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

internal class <PrivateImplementationDetails> // TypeDefIndex: 7973
{	// Fields
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-0 /*Metadata offset 0x550B99*/; // 0x0
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-1 /*Metadata offset 0x550D99*/; // 0x200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-2 /*Metadata offset 0x550F99*/; // 0x400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-3 /*Metadata offset 0x551199*/; // 0x600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-4 /*Metadata offset 0x551399*/; // 0x800
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-5 /*Metadata offset 0x551599*/; // 0xA00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-6 /*Metadata offset 0x551799*/; // 0xC00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-7 /*Metadata offset 0x551999*/; // 0xE00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-8 /*Metadata offset 0x551B99*/; // 0x1000
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-9 /*Metadata offset 0x551D99*/; // 0x1200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-10 /*Metadata offset 0x551F99*/; // 0x1400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-11 /*Metadata offset 0x552199*/; // 0x1600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-12 /*Metadata offset 0x552399*/; // 0x1800
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-13 /*Metadata offset 0x552599*/; // 0x1A00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-14 /*Metadata offset 0x552799*/; // 0x1C00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-15 /*Metadata offset 0x552999*/; // 0x1E00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-16 /*Metadata offset 0x552B99*/; // 0x2000
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-17 /*Metadata offset 0x552D99*/; // 0x2200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-18 /*Metadata offset 0x552F99*/; // 0x2400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-19 /*Metadata offset 0x553199*/; // 0x2600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-20 /*Metadata offset 0x553399*/; // 0x2800
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-21 /*Metadata offset 0x553599*/; // 0x2A00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-22 /*Metadata offset 0x553799*/; // 0x2C00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-23 /*Metadata offset 0x553999*/; // 0x2E00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-24 /*Metadata offset 0x553B99*/; // 0x3000
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-25 /*Metadata offset 0x553D99*/; // 0x3200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-26 /*Metadata offset 0x553F99*/; // 0x3400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-27 /*Metadata offset 0x554199*/; // 0x3600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-28 /*Metadata offset 0x554399*/; // 0x3800
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-29 /*Metadata offset 0x554599*/; // 0x3A00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-30 /*Metadata offset 0x554799*/; // 0x3C00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-31 /*Metadata offset 0x554999*/; // 0x3E00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-32 /*Metadata offset 0x554B99*/; // 0x4000
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-33 /*Metadata offset 0x554D99*/; // 0x4200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-34 /*Metadata offset 0x554F99*/; // 0x4400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-35 /*Metadata offset 0x555199*/; // 0x4600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-36 /*Metadata offset 0x555399*/; // 0x4800

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

internal class <PrivateImplementationDetails> // TypeDefIndex: 8007
{	// Fields
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-0 /*Metadata offset 0x555D45*/; // 0x0
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-1 /*Metadata offset 0x555F45*/; // 0x200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-2 /*Metadata offset 0x556145*/; // 0x400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-3 /*Metadata offset 0x556345*/; // 0x600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-4 /*Metadata offset 0x556545*/; // 0x800
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-5 /*Metadata offset 0x556745*/; // 0xA00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-6 /*Metadata offset 0x556945*/; // 0xC00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-7 /*Metadata offset 0x556B45*/; // 0xE00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-8 /*Metadata offset 0x556D45*/; // 0x1000
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-9 /*Metadata offset 0x556F45*/; // 0x1200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-10 /*Metadata offset 0x557145*/; // 0x1400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-11 /*Metadata offset 0x557345*/; // 0x1600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-12 /*Metadata offset 0x557545*/; // 0x1800
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-13 /*Metadata offset 0x557745*/; // 0x1A00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-14 /*Metadata offset 0x557945*/; // 0x1C00

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

	// RVA: 0x1068920 Offset: 0x1066F20 VA: 0x181068920
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1068B00 Offset: 0x1067100 VA: 0x181068B00
	public void .ctor() { }

}

public class CC_Base : MonoBehaviour // TypeDefIndex: 8035
{	// Fields
	public Shader shader; // 0x18
	protected Material _material; // 0x20

	// Properties
	protected Material material { get; }

	// Methods

	// RVA: 0x1068BD0 Offset: 0x10671D0 VA: 0x181068BD0 Slot: 4
	protected virtual void Start() { }

	// RVA: 0x1068C70 Offset: 0x1067270 VA: 0x181068C70
	protected Material get_material() { }

	// RVA: 0x1068B40 Offset: 0x1067140 VA: 0x181068B40 Slot: 5
	protected virtual void OnDisable() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class CC_BleachBypass : CC_Base // TypeDefIndex: 8036
{	// Fields
	public float amount; // 0x28

	// Methods

	// RVA: 0x1068D30 Offset: 0x1067330 VA: 0x181068D30
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0xA33380 Offset: 0xA31980 VA: 0x180A33380
	public void .ctor() { }

}

public class CC_Blend : CC_Base // TypeDefIndex: 8037
{	// Fields
	public Texture texture; // 0x28
	public float amount; // 0x30
	public int mode; // 0x34

	// Methods

	// RVA: 0x1068E30 Offset: 0x1067430 VA: 0x181068E30
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1068FA0 Offset: 0x10675A0 VA: 0x181068FA0
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

	// RVA: 0x1068FB0 Offset: 0x10675B0 VA: 0x181068FB0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x10691C0 Offset: 0x10677C0 VA: 0x1810691C0
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

	// RVA: 0x10691F0 Offset: 0x10677F0 VA: 0x1810691F0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1069450 Offset: 0x1067A50 VA: 0x181069450
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

	// RVA: 0x1069470 Offset: 0x1067A70 VA: 0x181069470
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1069780 Offset: 0x1067D80 VA: 0x181069780
	public void .ctor() { }

}

public class CC_CrossStitch : CC_Base // TypeDefIndex: 8041
{	// Fields
	public int size; // 0x28
	public float brightness; // 0x2C
	public bool invert; // 0x30
	public bool pixelize; // 0x31

	// Methods

	// RVA: 0x1069830 Offset: 0x1067E30 VA: 0x181069830
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1069A10 Offset: 0x1068010 VA: 0x181069A10
	public void .ctor() { }

}

public class CC_DoubleVision : CC_Base, IImageEffect // TypeDefIndex: 8042
{	// Fields
	public Vector2 displace; // 0x28
	public float amount; // 0x30

	// Methods

	// RVA: 0x1069A30 Offset: 0x1068030 VA: 0x181069A30 Slot: 6
	public bool IsActive() { }

	// RVA: 0x1069A70 Offset: 0x1068070 VA: 0x181069A70 Slot: 7
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1069C30 Offset: 0x1068230 VA: 0x181069C30
	public void .ctor() { }

}

public class CC_FastVignette : CC_Base // TypeDefIndex: 8043
{	// Fields
	public float sharpness; // 0x28
	public float darkness; // 0x2C
	public bool desaturate; // 0x30

	// Methods

	// RVA: 0x1069C80 Offset: 0x1068280 VA: 0x181069C80
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1069D90 Offset: 0x1068390 VA: 0x181069D90
	public void .ctor() { }

}

public class CC_Frost : CC_Base, IImageEffect // TypeDefIndex: 8044
{	// Fields
	public float scale; // 0x28
	public float sharpness; // 0x2C
	public float darkness; // 0x30
	public bool enableVignette; // 0x34

	// Methods

	// RVA: 0x1069DB0 Offset: 0x10683B0 VA: 0x181069DB0 Slot: 6
	public bool IsActive() { }

	// RVA: 0x1069DF0 Offset: 0x10683F0 VA: 0x181069DF0 Slot: 7
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1069F80 Offset: 0x1068580 VA: 0x181069F80
	public void .ctor() { }

}

public class CC_GradientRamp : CC_Base // TypeDefIndex: 8045
{	// Fields
	public Texture rampTexture; // 0x28
	public float amount; // 0x30

	// Methods

	// RVA: 0x1069FA0 Offset: 0x10685A0 VA: 0x181069FA0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1068FA0 Offset: 0x10675A0 VA: 0x181068FA0
	public void .ctor() { }

}

public class CC_Grayscale : CC_Base, IImageEffect // TypeDefIndex: 8046
{	// Fields
	public float redLuminance; // 0x28
	public float greenLuminance; // 0x2C
	public float blueLuminance; // 0x30
	public float amount; // 0x34

	// Methods

	// RVA: 0x106A100 Offset: 0x1068700 VA: 0x18106A100 Slot: 6
	public bool IsActive() { }

	// RVA: 0x106A140 Offset: 0x1068740 VA: 0x18106A140 Slot: 7
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x106A290 Offset: 0x1068890 VA: 0x18106A290
	public void .ctor() { }

}

public class CC_Halftone : CC_Base // TypeDefIndex: 8047
{	// Fields
	public float density; // 0x28
	public int mode; // 0x2C
	public bool antialiasing; // 0x30
	public bool showOriginal; // 0x31

	// Methods

	// RVA: 0x106A2C0 Offset: 0x10688C0 VA: 0x18106A2C0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x106A3C0 Offset: 0x10689C0 VA: 0x18106A3C0
	public void .ctor() { }

}

public class CC_HueSaturationValue : CC_Base // TypeDefIndex: 8048
{	// Fields
	public float hue; // 0x28
	public float saturation; // 0x2C
	public float value; // 0x30

	// Methods

	// RVA: 0x106A3E0 Offset: 0x10689E0 VA: 0x18106A3E0
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

	// RVA: 0x106A560 Offset: 0x1068B60 VA: 0x18106A560
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x106A720 Offset: 0x1068D20 VA: 0x18106A720
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

	// RVA: 0x106A740 Offset: 0x1068D40 VA: 0x18106A740
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x106AC10 Offset: 0x1069210 VA: 0x18106AC10
	public void .ctor() { }

}

public class CC_LookupFilter : CC_Base // TypeDefIndex: 8051
{	// Fields
	public Texture lookupTexture; // 0x28

	// Methods

	// RVA: 0x106AC70 Offset: 0x1069270 VA: 0x18106AC70
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class CC_Negative : CC_Base // TypeDefIndex: 8052
{	// Fields
	public float amount; // 0x28

	// Methods

	// RVA: 0x106AD90 Offset: 0x1069390 VA: 0x18106AD90
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0xA33380 Offset: 0xA31980 VA: 0x180A33380
	public void .ctor() { }

}

public class CC_PhotoFilter : CC_Base, IImageEffect // TypeDefIndex: 8053
{	// Fields
	public Color color; // 0x28
	public float density; // 0x38

	// Methods

	// RVA: 0x106AE90 Offset: 0x1069490 VA: 0x18106AE90 Slot: 6
	public bool IsActive() { }

	// RVA: 0x106AED0 Offset: 0x10694D0 VA: 0x18106AED0 Slot: 7
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x106B000 Offset: 0x1069600 VA: 0x18106B000
	public void .ctor() { }

}

public class CC_Pixelate : CC_Base // TypeDefIndex: 8054
{	// Fields
	public float scale; // 0x28
	public bool automaticRatio; // 0x2C
	public float ratio; // 0x30
	public int mode; // 0x34

	// Methods

	// RVA: 0x106B070 Offset: 0x1069670 VA: 0x18106B070
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x106B210 Offset: 0x1069810 VA: 0x18106B210
	public void .ctor() { }

}

public class CC_Posterize : CC_Base // TypeDefIndex: 8055
{	// Fields
	public int levels; // 0x28

	// Methods

	// RVA: 0x106B230 Offset: 0x1069830 VA: 0x18106B230
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x106B2E0 Offset: 0x10698E0 VA: 0x18106B2E0
	public void .ctor() { }

}

public class CC_RGBSplit : CC_Base // TypeDefIndex: 8056
{	// Fields
	public float amount; // 0x28
	public float angle; // 0x2C

	// Methods

	// RVA: 0x106B2F0 Offset: 0x10698F0 VA: 0x18106B2F0
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

	// RVA: 0x106B490 Offset: 0x1069A90 VA: 0x18106B490
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x106B610 Offset: 0x1069C10 VA: 0x18106B610
	public void .ctor() { }

}

public class CC_Sharpen : CC_Base // TypeDefIndex: 8058
{	// Fields
	public float strength; // 0x28
	public float clamp; // 0x2C

	// Methods

	// RVA: 0x106B940 Offset: 0x1069F40 VA: 0x18106B940
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x106BB00 Offset: 0x106A100 VA: 0x18106BB00
	public void .ctor() { }

}

public class CC_SharpenAndVignette : CC_Base, IImageEffect // TypeDefIndex: 8059
{	// Fields
	[HeaderAttribute] // RVA: 0xC3AA0 Offset: 0xC2EA0 VA: 0x1800C3AA0
	public bool applySharpen; // 0x28
	[RangeAttribute] // RVA: 0x75A70 Offset: 0x74E70 VA: 0x180075A70
	public float strength; // 0x2C
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float clamp; // 0x30
	[HeaderAttribute] // RVA: 0xC5040 Offset: 0xC4440 VA: 0x1800C5040
	public bool applyVignette; // 0x34
	[RangeAttribute] // RVA: 0xC5190 Offset: 0xC4590 VA: 0x1800C5190
	public float sharpness; // 0x38
	[RangeAttribute] // RVA: 0x77EF0 Offset: 0x772F0 VA: 0x180077EF0
	public float darkness; // 0x3C

	// Methods

	// RVA: 0x8D6200 Offset: 0x8D4800 VA: 0x1808D6200 Slot: 6
	public bool IsActive() { }

	// RVA: 0x106B670 Offset: 0x1069C70 VA: 0x18106B670 Slot: 7
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x106B910 Offset: 0x1069F10 VA: 0x18106B910
	public void .ctor() { }

}

public class CC_Threshold : CC_Base // TypeDefIndex: 8060
{	// Fields
	public float threshold; // 0x28
	public bool useNoise; // 0x2C
	public float noiseRange; // 0x30

	// Methods

	// RVA: 0x106BB20 Offset: 0x106A120 VA: 0x18106BB20
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x106BC30 Offset: 0x106A230 VA: 0x18106BC30
	public void .ctor() { }

}

public class CC_Vibrance : CC_Base // TypeDefIndex: 8061
{	// Fields
	public float amount; // 0x28

	// Methods

	// RVA: 0x106BC50 Offset: 0x106A250 VA: 0x18106BC50
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

	// RVA: 0x106BE70 Offset: 0x106A470 VA: 0x18106BE70
	private void Update() { }

	// RVA: 0x1069A30 Offset: 0x1068030 VA: 0x181069A30 Slot: 6
	public bool IsActive() { }

	// RVA: 0x106BD50 Offset: 0x106A350 VA: 0x18106BD50 Slot: 7
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x106BEC0 Offset: 0x106A4C0 VA: 0x18106BEC0
	public void .ctor() { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 8239
{	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=19552 1DC4C1B55DC0F7A09DD49557857282243A661721 /*Metadata offset 0x558010*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=420 4D97B7EA75C57A5C53C1E01B1C6253465DE43B65 /*Metadata offset 0x55CC70*/; // 0x4C60
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=15874 9B733B2872507920FB43A4A60F4CBE3E17200C8C /*Metadata offset 0x55CE14*/; // 0x4E04
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=15874 C01F4A345A0DC451B12954EDA4ED605D0075A2A5 /*Metadata offset 0x560C16*/; // 0x8C06
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 DD09230AEF3C2384FBC6D4B1BC4EADBE9911368E /*Metadata offset 0x564A18*/; // 0xCA08
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9776 F2AB9A53871DA3CF4444B73A4D38E5580D8F8ED3 /*Metadata offset 0x564A4C*/; // 0xCA3C

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
[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
internal sealed class <>f__AnonymousType0<<Identifier>j__TPar, <Name>j__TPar, <State>j__TPar> // TypeDefIndex: 8246
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x9E9D0 Offset: 0x9DDD0 VA: 0x18009E9D0
	private readonly <Identifier>j__TPar <Identifier>i__Field; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x9E9D0 Offset: 0x9DDD0 VA: 0x18009E9D0
	private readonly <Name>j__TPar <Name>i__Field; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x9E9D0 Offset: 0x9DDD0 VA: 0x18009E9D0
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
	|-RVA: 0xB106B0 Offset: 0xB0ECB0 VA: 0x180B106B0
	|-<>f__AnonymousType0<object, object, bool>.get_State
	|
	|-RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	|-<>f__AnonymousType0<object, object, object>.get_State
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public void .ctor(<Identifier>j__TPar Identifier, <Name>j__TPar Name, <State>j__TPar State) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15EA160 Offset: 0x15E8760 VA: 0x1815EA160
	|-<>f__AnonymousType0<object, object, bool>..ctor
	|-<>f__AnonymousType0<string, string, bool>..ctor
	|
	|-RVA: 0x15EA1D0 Offset: 0x15E87D0 VA: 0x1815EA1D0
	|-<>f__AnonymousType0<object, object, object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E9A90 Offset: 0x15E8090 VA: 0x1815E9A90
	|-<>f__AnonymousType0<object, object, bool>.Equals
	|
	|-RVA: 0x15E9970 Offset: 0x15E7F70 VA: 0x1815E9970
	|-<>f__AnonymousType0<object, object, object>.Equals
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E9BB0 Offset: 0x15E81B0 VA: 0x1815E9BB0
	|-<>f__AnonymousType0<object, object, bool>.GetHashCode
	|
	|-RVA: 0x15E9CA0 Offset: 0x15E82A0 VA: 0x1815E9CA0
	|-<>f__AnonymousType0<object, object, object>.GetHashCode
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E9D90 Offset: 0x15E8390 VA: 0x1815E9D90
	|-<>f__AnonymousType0<object, object, bool>.ToString
	|
	|-RVA: 0x15E9F70 Offset: 0x15E8570 VA: 0x1815E9F70
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

	// RVA: 0x1A95F50 Offset: 0x1A94550 VA: 0x181A95F50
	public void OnEnable() { }

	// RVA: 0x1A95D90 Offset: 0x1A94390 VA: 0x181A95D90
	private void Awake() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void Start() { }

	// RVA: 0x1A96060 Offset: 0x1A94660 VA: 0x181A96060
	private void ScrollChainTexture() { }

	// RVA: 0x1A96170 Offset: 0x1A94770 VA: 0x181A96170
	private void Update() { }

	// RVA: 0x1A95DD0 Offset: 0x1A943D0 VA: 0x181A95DD0
	private void DoHitSound(SoundDefinition soundDef) { }

	// RVA: 0x1A966E0 Offset: 0x1A94CE0 VA: 0x181A966E0
	public void .ctor() { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 12153
{
// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 12153
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 08A598D3DC7ED63443A0CAF087F7CDF5BAA67E3D /*Metadata offset 0x56AB19*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 0ED907628EE272F93737B500A23D77C9B1C88368 /*Metadata offset 0x56AB31*/; // 0x18
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 17ADC9F18EEFE619644F7B3C7C90D5FD8DCDE2BB /*Metadata offset 0x56AB45*/; // 0x2C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 1C910D34886830DDE4A52B59726EB240ADBF9F34 /*Metadata offset 0x56AB61*/; // 0x48
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 2277B245F935EBA3EA2D03B6871C13871FD4D572 /*Metadata offset 0x56AB67*/; // 0x4E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 24F287DA5BA36E31C3946E2FBE95B8388C241662 /*Metadata offset 0x56AB77*/; // 0x5E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 386DD6935C2F38BB8114CA4DF96C8BC2D3E639DA /*Metadata offset 0x56AB8F*/; // 0x76
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 42A4001D1CFDC98C761C0CFE5497A75F739D92F8 /*Metadata offset 0x56AB9B*/; // 0x82
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 43A214299CEA27B6A55E61A929FC7B62C5D4941E /*Metadata offset 0x56ABA7*/; // 0x8E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 44D235DAFB9C469EBDA7640EB1F2CC833B40E9E5 /*Metadata offset 0x56B3A7*/; // 0x88E
	internal static readonly long 4CAECE539B039B16E16206EA2478F8C5FFB2CA05 = 727905341920923785; // 0x8D0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 59E933D7501F1D8F431F5807AC6C357BBA5F2D58 /*Metadata offset 0x56B3EF*/; // 0x8D8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 6B8D5CC14D2709C84958ED5E3855C874DA314CB4 /*Metadata offset 0x56B407*/; // 0x8F0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 6BA637A252B6BFA8895B67AD72DCCAE79715984C /*Metadata offset 0x56B507*/; // 0x9F0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=80 6DBA8D05A3CD51B9E01E83FDDF49241693E5D4E4 /*Metadata offset 0x56B547*/; // 0xA30
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 843D396E2EE569B035A7AC2BEB7A8253FC4AEDA7 /*Metadata offset 0x56B597*/; // 0xA80
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 9365FDAD4BD75AEF9446E0B22483D217BE36E309 /*Metadata offset 0x56B5A3*/; // 0xA8C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=288 9EFF88EB2F3540C5CE20FEF36A8E3AA37629AF80 /*Metadata offset 0x56B5BB*/; // 0xAA4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 B9B198B061D08812F585C9E56641F4E897E88E38 /*Metadata offset 0x56B6DB*/; // 0xBC4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 C18072E27FC2B4816C8694EB22427195375388F0 /*Metadata offset 0x56B6E7*/; // 0xBD0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 C7F420F4B2F68D0B3647564554BA8DB99509F64F /*Metadata offset 0x56B71F*/; // 0xC08
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 D950356082C70AD4018410AD313BA99D655D4D4A /*Metadata offset 0x56B73B*/; // 0xC24
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 E3D5EABE71635FCDE2C05162A6CDE245A9796318 /*Metadata offset 0x56B747*/; // 0xC30
	internal static readonly long FCBA60311CDE80DE090AE6F8834C9CEC477FA56A = 5927942488114331648; // 0xCB0

	// Methods

	// RVA: 0xAAB500 Offset: 0xAA9B00 VA: 0x180AAB500
	internal static uint ComputeStringHash(string s) { }

}

