public struct List.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 1490
{	// Fields
	private List<T> list; // 0x0
	private int index; // 0x0
	private int version; // 0x0
	private T current; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F7E0 Offset: 0x11EBE0 VA: 0x18011F7E0
	|-List.Enumerator<AdvancedChristmasLights.pointEntry>..ctor
	|-List.Enumerator<AlignedLineDrawer.LinePoint>..ctor
	|-List.Enumerator<Cassette.LoadRequest>..ctor
	|-List.Enumerator<Admin.ServerConvarInfo>..ctor
	|-List.Enumerator<Chat.MuteEntry>..ctor
	|-List.Enumerator<ERChildsSO>..ctor
	|-List.Enumerator<ExpandedLifeStats.GenericStatDisplay>..ctor
	|-List.Enumerator<LocalClock.TimedEvent>..ctor
	|-List.Enumerator<MapView.MapMarkerCluster>..ctor
	|-List.Enumerator<MapView.SleepingBagCluster>..ctor
	|-List.Enumerator<JsonPosition>..ctor
	|-List.Enumerator<TimelineEvent>..ctor
	|-List.Enumerator<TickRenderer.Tick>..ctor
	|-List.Enumerator<InventoryRecipe.Ingredient>..ctor
	|-List.Enumerator<InventoryRecipe>..ctor
	|-List.Enumerator<SynchronizedClock.TimedEvent>..ctor
	|-List.Enumerator<KeyValuePair<object, Color>>..ctor
	|-List.Enumerator<KeyValuePair<ulong, Dispatch.ResultCallback>>..ctor
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>..ctor
	|
	|-RVA: 0x11F740 Offset: 0x11EB40 VA: 0x18011F740
	|-List.Enumerator<AtmosphereVolumeRenderer.CurrentVolumeEntry>..ctor
	|-List.Enumerator<DamageRenderer.DamageShowingRenderer>..ctor
	|-List.Enumerator<DeferredExtensionMesh.MaterialLink>..ctor
	|-List.Enumerator<DeferredMeshDecal.MaterialLink>..ctor
	|-List.Enumerator<CombineClass>..ctor
	|-List.Enumerator<ERLane>..ctor
	|-List.Enumerator<EntityRef<object>>..ctor
	|-List.Enumerator<TabbedPanel.Tab>..ctor
	|-List.Enumerator<RCon.BannedAddresses>..ctor
	|-List.Enumerator<WeightedStringList.Container>..ctor
	|-List.Enumerator<GameStat.Stat>..ctor
	|-List.Enumerator<ImageStorageEntity.ImageRequest>..ctor
	|-List.Enumerator<MagnetCrane.MagnetCraneSnapshot>..ctor
	|-List.Enumerator<ParticleSystemContainer.ParticleSystemGroup>..ctor
	|-List.Enumerator<PlayerItemRecipe>..ctor
	|-List.Enumerator<DemoShotParentKeyframe>..ctor
	|-List.Enumerator<DemoShotVectorKeyframe>..ctor
	|-List.Enumerator<ReflectionProbeEx.RenderListEntry>..ctor
	|-List.Enumerator<MatchMakingKeyValuePair>..ctor
	|-List.Enumerator<Dispatch.Callback>..ctor
	|-List.Enumerator<DictionaryEntry>..ctor
	|-List.Enumerator<KeyValuePair<DateTime, object>>..ctor
	|-List.Enumerator<KeyValuePair<int, object>>..ctor
	|-List.Enumerator<KeyValuePair<Int32Enum, object>>..ctor
	|-List.Enumerator<KeyValuePair<object, object>>..ctor
	|-List.Enumerator<KeyValuePair<object, float>>..ctor
	|-List.Enumerator<KeyValuePair<uint, object>>..ctor
	|-List.Enumerator<DateTimeOffset>..ctor
	|-List.Enumerator<Decimal>..ctor
	|-List.Enumerator<Guid>..ctor
	|-List.Enumerator<ValueTuple<object, object>>..ctor
	|-List.Enumerator<RangePositionInfo>..ctor
	|-List.Enumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>..ctor
	|-List.Enumerator<TickInterpolator.Segment>..ctor
	|-List.Enumerator<NavMeshBuildMarkup>..ctor
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>..ctor
	|-List.Enumerator<Color>..ctor
	|-List.Enumerator<Rect>..ctor
	|-List.Enumerator<GlyphRect>..ctor
	|-List.Enumerator<FocusController.FocusedElement>..ctor
	|-List.Enumerator<UILineInfo>..ctor
	|-List.Enumerator<Vector4>..ctor
	|-List.Enumerator<WindZoneExManager.CurrentZoneEntry>..ctor
	|-List.Enumerator<WorldSplineData.LUTEntry.LUTPoint>..ctor
	|
	|-RVA: 0x11F6A0 Offset: 0x11EAA0 VA: 0x18011F6A0
	|-List.Enumerator<BaseEntity.ServerFileRequest>..ctor
	|-List.Enumerator<CardTableUI.KeycodeWithAction>..ctor
	|-List.Enumerator<Demos.DemoInfo>..ctor
	|-List.Enumerator<Output.Entry>..ctor
	|-List.Enumerator<IconSkinPicker.SkinButtonSetup>..ctor
	|-List.Enumerator<InvokeAction>..ctor
	|-List.Enumerator<ItemSkinDirectory.Skin>..ctor
	|-List.Enumerator<KeyframeView.UIKeyframeValue>..ctor
	|-List.Enumerator<MidiConvar.KnobBinding>..ctor
	|-List.Enumerator<MidiConvar.NoteBinding>..ctor
	|-List.Enumerator<WaypointSet.Waypoint>..ctor
	|-List.Enumerator<TransformSnapshot>..ctor
	|-List.Enumerator<Option>..ctor
	|-List.Enumerator<SkinnedMultiMesh.Part>..ctor
	|-List.Enumerator<SubmarineSonar.SonarBlip>..ctor
	|-List.Enumerator<SpawnIndividual>..ctor
	|-List.Enumerator<SpecialPurposeCamera.RenderEntry>..ctor
	|-List.Enumerator<InventoryItem>..ctor
	|
	|-RVA: 0x11F830 Offset: 0x11EC30 VA: 0x18011F830
	|-List.Enumerator<Admin.PlayerInfo>..ctor
	|-List.Enumerator<PlaceMonuments.SpawnInfo>..ctor
	|
	|-RVA: 0x11F930 Offset: 0x11ED30 VA: 0x18011F930
	|-List.Enumerator<Admin.ServerUGCInfo>..ctor
	|-List.Enumerator<CapsuleParams>..ctor
	|-List.Enumerator<SkeletonDefinition.Bone>..ctor
	|-List.Enumerator<ReflectionProbeEx.CubemapSkyboxVertex>..ctor
	|-List.Enumerator<SteamNewsSource.Story>..ctor
	|-List.Enumerator<InventoryItem.Amount>..ctor
	|-List.Enumerator<RenderTargetIdentifier>..ctor
	|-List.Enumerator<TreeInstance>..ctor
	|-List.Enumerator<ViewModelDrawEvent>..ctor
	|
	|-RVA: 0x11FA80 Offset: 0x11EE80 VA: 0x18011FA80
	|-List.Enumerator<CRedge>..ctor
	|-List.Enumerator<ProjectileWeaponMod.Modifier>..ctor
	|-List.Enumerator<VectorData>..ctor
	|-List.Enumerator<TrainCar.TrainCarSnapshot>..ctor
	|-List.Enumerator<Resolution>..ctor
	|-List.Enumerator<UICharInfo>..ctor
	|-List.Enumerator<Vector3>..ctor
	|
	|-RVA: 0x11F8E0 Offset: 0x11ECE0 VA: 0x18011F8E0
	|-List.Enumerator<ERCell>..ctor
	|-List.Enumerator<ERConnectionGUIStatus>..ctor
	|-List.Enumerator<ERTerrainChange>..ctor
	|-List.Enumerator<NormalPairs>..ctor
	|-List.Enumerator<EngineDamageOverTime.RecentDamage>..ctor
	|-List.Enumerator<BurstCloth.Chain>..ctor
	|-List.Enumerator<MeshRendererLookup.LookupEntry>..ctor
	|-List.Enumerator<PathFinder.Point>..ctor
	|-List.Enumerator<PlayerItemRecipe.Ingredient>..ctor
	|-List.Enumerator<DemoShotFloatKeyframe>..ctor
	|-List.Enumerator<Achievement>..ctor
	|-List.Enumerator<Friend>..ctor
	|-List.Enumerator<DateTime>..ctor
	|-List.Enumerator<EventProvider.SessionInfo>..ctor
	|-List.Enumerator<double>..ctor
	|-List.Enumerator<long>..ctor
	|-List.Enumerator<object>..ctor
	|-List.Enumerator<TimeSpan>..ctor
	|-List.Enumerator<ulong>..ctor
	|-List.Enumerator<Vector2>..ctor
	|-List.Enumerator<Vector2i>..ctor
	|
	|-RVA: 0x149BE0 Offset: 0x148FE0 VA: 0x180149BE0
	|-List.Enumerator<ERMeshCombineUtility.MeshInstance>..ctor
	|-List.Enumerator<RenderInfo.RendererInstance>..ctor
	|-List.Enumerator<Option>..ctor
	|
	|-RVA: 0x149B30 Offset: 0x148F30 VA: 0x180149B30
	|-List.Enumerator<ERSOSection>..ctor
	|
	|-RVA: 0x149B80 Offset: 0x148F80 VA: 0x180149B80
	|-List.Enumerator<ERSplatmap>..ctor
	|
	|-RVA: 0x11FB50 Offset: 0x11EF50 VA: 0x18011FB50
	|-List.Enumerator<ERVSData>..ctor
	|-List.Enumerator<SqliteKeyReader.KeyInfo>..ctor
	|
	|-RVA: 0x149D00 Offset: 0x149100 VA: 0x180149D00
	|-List.Enumerator<BoneData>..ctor
	|
	|-RVA: 0x11F6F0 Offset: 0x11EAF0 VA: 0x18011F6F0
	|-List.Enumerator<Tick.Entry>..ctor
	|-List.Enumerator<Gibbable.OverrideMesh>..ctor
	|-List.Enumerator<MeshInstance>..ctor
	|-List.Enumerator<PetCommandList.PetCommandDesc>..ctor
	|-List.Enumerator<PlaceMonumentsOffshore.SpawnInfo>..ctor
	|-List.Enumerator<PlaceMonumentsRailside.SpawnInfo>..ctor
	|-List.Enumerator<PlaceMonumentsRoadside.SpawnInfo>..ctor
	|-List.Enumerator<SubsurfaceProfileTexture.SubsurfaceProfileEntry>..ctor
	|
	|-RVA: 0x149D70 Offset: 0x149170 VA: 0x180149D70
	|-List.Enumerator<FoliageGridMeshData.FoliageVertex>..ctor
	|
	|-RVA: 0x11F890 Offset: 0x11EC90 VA: 0x18011F890
	|-List.Enumerator<SevenBitNumber>..ctor
	|-List.Enumerator<bool>..ctor
	|-List.Enumerator<byte>..ctor
	|-List.Enumerator<sbyte>..ctor
	|
	|-RVA: 0x11FAD0 Offset: 0x11EED0 VA: 0x18011FAD0
	|-List.Enumerator<MeshColliderInstance>..ctor
	|
	|-RVA: 0x11FC20 Offset: 0x11F020 VA: 0x18011FC20
	|-List.Enumerator<MeshColliderLookup.LookupEntry>..ctor
	|
	|-RVA: 0x11FC80 Offset: 0x11F080 VA: 0x18011FC80
	|-List.Enumerator<MeshRendererInstance>..ctor
	|
	|-RVA: 0x11F980 Offset: 0x11ED80 VA: 0x18011F980
	|-List.Enumerator<DemoShotQuaternionKeyframe>..ctor
	|
	|-RVA: 0x11FBB0 Offset: 0x11EFB0 VA: 0x18011FBB0
	|-List.Enumerator<ServerInfo>..ctor
	|-List.Enumerator<ServerInfo>..ctor
	|
	|-RVA: 0x11F9D0 Offset: 0x11EDD0 VA: 0x18011F9D0
	|-List.Enumerator<InventoryDefId>..ctor
	|-List.Enumerator<int>..ctor
	|-List.Enumerator<Int32Enum>..ctor
	|-List.Enumerator<float>..ctor
	|-List.Enumerator<uint>..ctor
	|-List.Enumerator<Color32>..ctor
	|
	|-RVA: 0x11F790 Offset: 0x11EB90 VA: 0x18011F790
	|-List.Enumerator<char>..ctor
	|-List.Enumerator<short>..ctor
	|-List.Enumerator<ushort>..ctor
	|
	|-RVA: 0x11F640 Offset: 0x11EA40 VA: 0x18011F640
	|-List.Enumerator<TraceInfo>..ctor
	|-List.Enumerator<RaycastResult>..ctor
	|
	|-RVA: 0x11FA20 Offset: 0x11EE20 VA: 0x18011FA20
	|-List.Enumerator<NavMeshBuildSource>..ctor
	|
	|-RVA: 0x221350 Offset: 0x220750 VA: 0x180221350
	|-List.Enumerator<RaycastHit2D>..ctor
	|
	|-RVA: 0x2213A0 Offset: 0x2207A0 VA: 0x1802213A0
	|-List.Enumerator<RaycastHit>..ctor
	|
	|-RVA: 0x221400 Offset: 0x220800 VA: 0x180221400
	|-List.Enumerator<UIVertex>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1F30 Offset: 0xF1330 VA: 0x1800F1F30
	|-List.Enumerator<AIMovePoint>.Dispose
	|-List.Enumerator<AIState>.Dispose
	|-List.Enumerator<AdvancedChristmasLights.pointEntry>.Dispose
	|-List.Enumerator<AlignedLineDrawer.LinePoint>.Dispose
	|-List.Enumerator<AtmosphereVolumeRenderer.CurrentVolumeEntry>.Dispose
	|-List.Enumerator<BaseAIEvent>.Dispose
	|-List.Enumerator<BaseBulb>.Dispose
	|-List.Enumerator<BaseCollision>.Dispose
	|-List.Enumerator<BaseEntity.ServerFileRequest>.Dispose
	|-List.Enumerator<BaseEntity>.Dispose
	|-List.Enumerator<BaseMeshPaintable>.Dispose
	|-List.Enumerator<BaseMission.MissionInstance>.Dispose
	|-List.Enumerator<BaseNetworkable>.Dispose
	|-List.Enumerator<BaseNpc>.Dispose
	|-List.Enumerator<BasePathNode>.Dispose
	|-List.Enumerator<BasePlayer>.Dispose
	|-List.Enumerator<BaseVehicle.MountPointInfo>.Dispose
	|-List.Enumerator<BaseVehicle>.Dispose
	|-List.Enumerator<BaseVehicleModule>.Dispose
	|-List.Enumerator<BaseViewModel>.Dispose
	|-List.Enumerator<BlendedSoundLoops.Loop>.Dispose
	|-List.Enumerator<BoneRetarget>.Dispose
	|-List.Enumerator<BuildingBlock>.Dispose
	|-List.Enumerator<CH47DropZone>.Dispose
	|-List.Enumerator<CH47LandingZone>.Dispose
	|-List.Enumerator<CardTableUI.KeycodeWithAction>.Dispose
	|-List.Enumerator<Cassette.LoadRequest>.Dispose
	|-List.Enumerator<CinematicEntity>.Dispose
	|-List.Enumerator<ClientIOLine>.Dispose
	|-List.Enumerator<CoalingTower>.Dispose
	|-List.Enumerator<ComponentInfo>.Dispose
	|-List.Enumerator<Admin.PlayerInfo>.Dispose
	|-List.Enumerator<Admin.ServerConvarInfo>.Dispose
	|-List.Enumerator<Admin.ServerUGCInfo>.Dispose
	|-List.Enumerator<Chat.MuteEntry>.Dispose
	|-List.Enumerator<ConnectedSpeaker>.Dispose
	|-List.Enumerator<ConvarComponent.ConvarEvent>.Dispose
	|-List.Enumerator<CoverageQueries.Query>.Dispose
	|-List.Enumerator<DamageRenderer.DamageShowingRenderer>.Dispose
	|-List.Enumerator<DecalRecycle>.Dispose
	|-List.Enumerator<DecorSpawn>.Dispose
	|-List.Enumerator<DeferredExtensionMesh.MaterialLink>.Dispose
	|-List.Enumerator<DeferredMeshDecal.InstanceData>.Dispose
	|-List.Enumerator<DeferredMeshDecal.MaterialLink>.Dispose
	|-List.Enumerator<DemoShotEntry>.Dispose
	|-List.Enumerator<DemoShotListFolderWidget>.Dispose
	|-List.Enumerator<Demos.DemoInfo>.Dispose
	|-List.Enumerator<DroppedItem>.Dispose
	|-List.Enumerator<DungeonBaseInfo>.Dispose
	|-List.Enumerator<DungeonBaseLink>.Dispose
	|-List.Enumerator<DungeonBaseSocket>.Dispose
	|-List.Enumerator<DungeonGridCell>.Dispose
	|-List.Enumerator<DungeonGridInfo>.Dispose
	|-List.Enumerator<DungeonVolume>.Dispose
	|-List.Enumerator<CRedge>.Dispose
	|-List.Enumerator<CombineClass>.Dispose
	|-List.Enumerator<ERCell>.Dispose
	|-List.Enumerator<ERChildsSO>.Dispose
	|-List.Enumerator<ERConnectionGUIStatus>.Dispose
	|-List.Enumerator<ERDecal>.Dispose
	|-List.Enumerator<ERLane>.Dispose
	|-List.Enumerator<ERLaneConnector>.Dispose
	|-List.Enumerator<ERLocalGrid>.Dispose
	|-List.Enumerator<ERMarkerExt>.Dispose
	|-List.Enumerator<ERMesh>.Dispose
	|-List.Enumerator<ERMeshCombineUtility.MeshInstance>.Dispose
	|-List.Enumerator<ERModularRoad>.Dispose
	|-List.Enumerator<ERSOMarkerExt>.Dispose
	|-List.Enumerator<ERSORoadExt>.Dispose
	|-List.Enumerator<ERSOSection>.Dispose
	|-List.Enumerator<ERSideWalk>.Dispose
	|-List.Enumerator<ERSplatmap>.Dispose
	|-List.Enumerator<ERTerrainChange>.Dispose
	|-List.Enumerator<ERTerrainData>.Dispose
	|-List.Enumerator<ERTreeInstance>.Dispose
	|-List.Enumerator<ERVSData>.Dispose
	|-List.Enumerator<NormalPairs>.Dispose
	|-List.Enumerator<OQQCCQCDQQ>.Dispose
	|-List.Enumerator<QDOODOQQDQODD>.Dispose
	|-List.Enumerator<QDQDOOQQDQODD>.Dispose
	|-List.Enumerator<SideObject>.Dispose
	|-List.Enumerator<tPoint>.Dispose
	|-List.Enumerator<EngineDamageOverTime.RecentDamage>.Dispose
	|-List.Enumerator<EntityRef<LootContainer>>.Dispose
	|-List.Enumerator<EntityRef<object>>.Dispose
	|-List.Enumerator<ExpandedLifeStats.GenericStatDisplay>.Dispose
	|-List.Enumerator<BurstCloth.Chain>.Dispose
	|-List.Enumerator<BurstCloth>.Dispose
	|-List.Enumerator<CapsuleParams>.Dispose
	|-List.Enumerator<BoneData>.Dispose
	|-List.Enumerator<TabbedPanel.Tab>.Dispose
	|-List.Enumerator<Input.Button>.Dispose
	|-List.Enumerator<Output.Entry>.Dispose
	|-List.Enumerator<RCon.BannedAddresses>.Dispose
	|-List.Enumerator<RCon.RConClient>.Dispose
	|-List.Enumerator<SkeletonDefinition.Bone>.Dispose
	|-List.Enumerator<SkeletonSkin>.Dispose
	|-List.Enumerator<Tick.Entry>.Dispose
	|-List.Enumerator<RenderInfo.RendererInstance>.Dispose
	|-List.Enumerator<WeightedStringList.Container>.Dispose
	|-List.Enumerator<FavouriteRadioStation>.Dispose
	|-List.Enumerator<FoliageGridMeshData.FoliageVertex>.Dispose
	|-List.Enumerator<FruitScale>.Dispose
	|-List.Enumerator<ICommandCenterListener>.Dispose
	|-List.Enumerator<JSONNode>.Dispose
	|-List.Enumerator<Option>.Dispose
	|-List.Enumerator<GameStat.Stat>.Dispose
	|-List.Enumerator<GenerateDungeonBase.DungeonSegment>.Dispose
	|-List.Enumerator<GenerateDungeonGrid.PathLink>.Dispose
	|-List.Enumerator<GenerateDungeonGrid.PathLinkSegment>.Dispose
	|-List.Enumerator<GenerateDungeonGrid.PathSegment>.Dispose
	|-List.Enumerator<GeneratePowerlineLayout.PathSegment>.Dispose
	|-List.Enumerator<GenerateRailRing.RingNode>.Dispose
	|-List.Enumerator<GenerateRoadLayout.PathNode>.Dispose
	|-List.Enumerator<GenerateRoadLayout.PathSegment>.Dispose
	|-List.Enumerator<GenerateRoadRing.RingNode>.Dispose
	|-List.Enumerator<Gib>.Dispose
	|-List.Enumerator<Gibbable.OverrideMesh>.Dispose
	|-List.Enumerator<GlassPane>.Dispose
	|-List.Enumerator<GraveyardFence>.Dispose
	|-List.Enumerator<HitboxDefinition>.Dispose
	|-List.Enumerator<HitboxSystem.HitboxShape>.Dispose
	|-List.Enumerator<IClientComponentEx>.Dispose
	|-List.Enumerator<IEffect>.Dispose
	|-List.Enumerator<IItemSetup>.Dispose
	|-List.Enumerator<IItemUpdate>.Dispose
	|-List.Enumerator<IPlayerItemDefinition>.Dispose
	|-List.Enumerator<IPrefabPostProcess>.Dispose
	|-List.Enumerator<IPrefabPreProcess>.Dispose
	|-List.Enumerator<IRagdollInhert>.Dispose
	|-List.Enumerator<IServerComponentEx>.Dispose
	|-List.Enumerator<IconSkin>.Dispose
	|-List.Enumerator<IconSkinPicker.SkinButtonSetup>.Dispose
	|-List.Enumerator<ImageEffectLayer>.Dispose
	|-List.Enumerator<ImageStorageEntity.ImageRequest>.Dispose
	|-List.Enumerator<InstrumentKeyController>.Dispose
	|-List.Enumerator<InvokeAction>.Dispose
	|-List.Enumerator<Item>.Dispose
	|-List.Enumerator<ItemAmount>.Dispose
	|-List.Enumerator<ItemBlueprint>.Dispose
	|-List.Enumerator<ItemContainer>.Dispose
	|-List.Enumerator<ItemDefinition>.Dispose
	|-List.Enumerator<ItemIcon>.Dispose
	|-List.Enumerator<ItemModConsumable.ConsumableEffect>.Dispose
	|-List.Enumerator<ItemPickupNotice>.Dispose
	|-List.Enumerator<ItemSkinDirectory.Skin>.Dispose
	|-List.Enumerator<ItemSlot>.Dispose
	|-List.Enumerator<Value>.Dispose
	|-List.Enumerator<KeyframeView.UIKeyframeValue>.Dispose
	|-List.Enumerator<KeyframeWidget>.Dispose
	|-List.Enumerator<LODComponent>.Dispose
	|-List.Enumerator<LandmarkInfo>.Dispose
	|-List.Enumerator<LifeScale>.Dispose
	|-List.Enumerator<LoadAssetsResult>.Dispose
	|-List.Enumerator<LocalClock.TimedEvent>.Dispose
	|-List.Enumerator<MagnetCrane.MagnetCraneSnapshot>.Dispose
	|-List.Enumerator<MapMarker>.Dispose
	|-List.Enumerator<MapView.MapMarkerCluster>.Dispose
	|-List.Enumerator<MapView.SleepingBagCluster>.Dispose
	|-List.Enumerator<MaterialReplacement>.Dispose
	|-List.Enumerator<SevenBitNumber>.Dispose
	|-List.Enumerator<ValueChange<TimeSignature>>.Dispose
	|-List.Enumerator<MeshColliderInstance>.Dispose
	|-List.Enumerator<MeshColliderLookup.LookupEntry>.Dispose
	|-List.Enumerator<MeshInstance>.Dispose
	|-List.Enumerator<MeshRendererInstance>.Dispose
	|-List.Enumerator<MeshRendererLookup.LookupEntry>.Dispose
	|-List.Enumerator<MidiConvar.KnobBinding>.Dispose
	|-List.Enumerator<MidiConvar.NoteBinding>.Dispose
	|-List.Enumerator<MissionMapMarker>.Dispose
	|-List.Enumerator<Modifier>.Dispose
	|-List.Enumerator<ModifierDefintion>.Dispose
	|-List.Enumerator<SqliteFunctionAttribute>.Dispose
	|-List.Enumerator<SqliteKeyReader.KeyInfo>.Dispose
	|-List.Enumerator<SqliteParameter>.Dispose
	|-List.Enumerator<MonumentInfo>.Dispose
	|-List.Enumerator<MonumentMarker>.Dispose
	|-List.Enumerator<MorphCache>.Dispose
	|-List.Enumerator<Connection>.Dispose
	|-List.Enumerator<IXmlNode>.Dispose
	|-List.Enumerator<JsonPosition>.Dispose
	|-List.Enumerator<JsonSerializerInternalReader.CreatorPropertyContext>.Dispose
	|-List.Enumerator<SerializationCallback>.Dispose
	|-List.Enumerator<OutlineObject>.Dispose
	|-List.Enumerator<PaintableItem>.Dispose
	|-List.Enumerator<ParticleSystemContainer.ParticleSystemGroup>.Dispose
	|-List.Enumerator<PathFinder.Node>.Dispose
	|-List.Enumerator<PathFinder.Point>.Dispose
	|-List.Enumerator<PathList.MeshObject>.Dispose
	|-List.Enumerator<PathList>.Dispose
	|-List.Enumerator<PatternFireworkStar>.Dispose
	|-List.Enumerator<PetCommandList.PetCommandDesc>.Dispose
	|-List.Enumerator<PlaceMonuments.SpawnInfo>.Dispose
	|-List.Enumerator<PlaceMonumentsOffshore.SpawnInfo>.Dispose
	|-List.Enumerator<PlaceMonumentsRailside.SpawnInfo>.Dispose
	|-List.Enumerator<PlaceMonumentsRoadside.SpawnInfo>.Dispose
	|-List.Enumerator<PlayerItemRecipe.Ingredient>.Dispose
	|-List.Enumerator<PlayerItemRecipe>.Dispose
	|-List.Enumerator<PlayerModel>.Dispose
	|-List.Enumerator<PlayerModelSkin>.Dispose
	|-List.Enumerator<PowerlineNode>.Dispose
	|-List.Enumerator<Projectile>.Dispose
	|-List.Enumerator<ProjectileWeaponMod.Modifier>.Dispose
	|-List.Enumerator<AIEventData>.Dispose
	|-List.Enumerator<AIStateContainer>.Dispose
	|-List.Enumerator<ArcadeGame.arcadeEnt>.Dispose
	|-List.Enumerator<CardTable.WinnerBreakdown.Winner>.Dispose
	|-List.Enumerator<DemoShot>.Dispose
	|-List.Enumerator<DemoShotFloatKeyframe>.Dispose
	|-List.Enumerator<DemoShotParentKeyframe>.Dispose
	|-List.Enumerator<DemoShotQuaternionKeyframe>.Dispose
	|-List.Enumerator<DemoShotVectorKeyframe>.Dispose
	|-List.Enumerator<EggHunt.EggHunter>.Dispose
	|-List.Enumerator<FileStorageCacheData>.Dispose
	|-List.Enumerator<GameMode.PlayerScore>.Dispose
	|-List.Enumerator<GameMode.ScoreColumn>.Dispose
	|-List.Enumerator<GameMode.TeamInfo>.Dispose
	|-List.Enumerator<InstrumentMidiBinding>.Dispose
	|-List.Enumerator<InstrumentRecordingNote>.Dispose
	|-List.Enumerator<Item>.Dispose
	|-List.Enumerator<ItemContainer>.Dispose
	|-List.Enumerator<LightString.StringPoint>.Dispose
	|-List.Enumerator<LinePoint>.Dispose
	|-List.Enumerator<MapNote>.Dispose
	|-List.Enumerator<MarketTerminal.PendingOrder>.Dispose
	|-List.Enumerator<MissionInstance>.Dispose
	|-List.Enumerator<Modifier>.Dispose
	|-List.Enumerator<NeonSign.Lights>.Dispose
	|-List.Enumerator<PatternFirework.Star>.Dispose
	|-List.Enumerator<PhoneDirectory.DirectoryEntry>.Dispose
	|-List.Enumerator<PlayerLifeStory.GenericStat>.Dispose
	|-List.Enumerator<PlayerLifeStory.WeaponStats>.Dispose
	|-List.Enumerator<PlayerTeam.TeamMember>.Dispose
	|-List.Enumerator<RelationshipManager.PlayerRelationshipInfo>.Dispose
	|-List.Enumerator<RespawnInformation.SpawnOptions>.Dispose
	|-List.Enumerator<Tree>.Dispose
	|-List.Enumerator<VectorData>.Dispose
	|-List.Enumerator<VendingMachine.SellOrder>.Dispose
	|-List.Enumerator<VoicemailEntry>.Dispose
	|-List.Enumerator<RainSurfaceAmbience.SurfaceSound>.Dispose
	|-List.Enumerator<Recipe>.Dispose
	|-List.Enumerator<ReflectionProbeEx.CubemapSkyboxVertex>.Dispose
	|-List.Enumerator<ReflectionProbeEx.RenderListEntry>.Dispose
	|-List.Enumerator<RelationshipManager.PlayerRelationshipInfo>.Dispose
	|-List.Enumerator<WaypointSet.Waypoint>.Dispose
	|-List.Enumerator<DamageTypeEntry>.Dispose
	|-List.Enumerator<TransformSnapshot>.Dispose
	|-List.Enumerator<ConditionalObject>.Dispose
	|-List.Enumerator<TimelineEvent>.Dispose
	|-List.Enumerator<Option>.Dispose
	|-List.Enumerator<TickRenderer.Tick>.Dispose
	|-List.Enumerator<RustButton>.Dispose
	|-List.Enumerator<ServerAdminPlayerEntry>.Dispose
	|-List.Enumerator<ServerAdminUGCEntry>.Dispose
	|-List.Enumerator<ServerAdminUGCEntryPattern>.Dispose
	|-List.Enumerator<TimelineMarker>.Dispose
	|-List.Enumerator<SellOrderEntry>.Dispose
	|-List.Enumerator<ServerInfo>.Dispose
	|-List.Enumerator<ShoutcastStream>.Dispose
	|-List.Enumerator<ShoutcastStreamer>.Dispose
	|-List.Enumerator<SkinnedMultiMesh.Part>.Dispose
	|-List.Enumerator<SleepingBag>.Dispose
	|-List.Enumerator<SleepingBagClusterMapMarker>.Dispose
	|-List.Enumerator<SleepingBagMapMarker>.Dispose
	|-List.Enumerator<SlotMachinePayoutWidget>.Dispose
	|-List.Enumerator<SmokeGrenade>.Dispose
	|-List.Enumerator<Socket_Base>.Dispose
	|-List.Enumerator<SubmarineSonar.SonarBlip>.Dispose
	|-List.Enumerator<Sound>.Dispose
	|-List.Enumerator<SoundDefinition.DistanceAudioClipList>.Dispose
	|-List.Enumerator<SpawnIndividual>.Dispose
	|-List.Enumerator<SpecialPurposeCamera.RenderEntry>.Dispose
	|-List.Enumerator<SteamNewsSource.Story>.Dispose
	|-List.Enumerator<Achievement>.Dispose
	|-List.Enumerator<InventoryDefId>.Dispose
	|-List.Enumerator<MatchMakingKeyValuePair>.Dispose
	|-List.Enumerator<ServerInfo>.Dispose
	|-List.Enumerator<Dispatch.Callback>.Dispose
	|-List.Enumerator<Friend>.Dispose
	|-List.Enumerator<InventoryItem.Amount>.Dispose
	|-List.Enumerator<InventoryItem>.Dispose
	|-List.Enumerator<InventoryRecipe.Ingredient>.Dispose
	|-List.Enumerator<InventoryRecipe>.Dispose
	|-List.Enumerator<SteamClass>.Dispose
	|-List.Enumerator<SubsurfaceProfileTexture.SubsurfaceProfileEntry>.Dispose
	|-List.Enumerator<SynchronizedClock.TimedEvent>.Dispose
	|-List.Enumerator<Action>.Dispose
	|-List.Enumerator<Action<IntPtr>>.Dispose
	|-List.Enumerator<bool>.Dispose
	|-List.Enumerator<byte>.Dispose
	|-List.Enumerator<char>.Dispose
	|-List.Enumerator<DictionaryEntry>.Dispose
	|-List.Enumerator<KeyValuePair<HairCapMask, Renderer>>.Dispose
	|-List.Enumerator<KeyValuePair<DateTime, object>>.Dispose
	|-List.Enumerator<KeyValuePair<int, object>>.Dispose
	|-List.Enumerator<KeyValuePair<Int32Enum, object>>.Dispose
	|-List.Enumerator<KeyValuePair<object, object>>.Dispose
	|-List.Enumerator<KeyValuePair<object, float>>.Dispose
	|-List.Enumerator<KeyValuePair<object, Color>>.Dispose
	|-List.Enumerator<KeyValuePair<uint, object>>.Dispose
	|-List.Enumerator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Dispose
	|-List.Enumerator<List<int>>.Dispose
	|-List.Enumerator<DataColumn>.Dispose
	|-List.Enumerator<DataRelation>.Dispose
	|-List.Enumerator<DataRow>.Dispose
	|-List.Enumerator<DataTable>.Dispose
	|-List.Enumerator<Index>.Dispose
	|-List.Enumerator<DateTime>.Dispose
	|-List.Enumerator<DateTimeOffset>.Dispose
	|-List.Enumerator<Decimal>.Dispose
	|-List.Enumerator<EtwSession>.Dispose
	|-List.Enumerator<EventProvider.SessionInfo>.Dispose
	|-List.Enumerator<FieldMetadata>.Dispose
	|-List.Enumerator<double>.Dispose
	|-List.Enumerator<CultureInfo>.Dispose
	|-List.Enumerator<Guid>.Dispose
	|-List.Enumerator<short>.Dispose
	|-List.Enumerator<int>.Dispose
	|-List.Enumerator<Int32Enum>.Dispose
	|-List.Enumerator<long>.Dispose
	|-List.Enumerator<ModifierSpec>.Dispose
	|-List.Enumerator<NameValueHeaderValue>.Dispose
	|-List.Enumerator<RangeItemHeaderValue>.Dispose
	|-List.Enumerator<IPAddress>.Dispose
	|-List.Enumerator<MonoChunkStream.Chunk>.Dispose
	|-List.Enumerator<WebConnection>.Dispose
	|-List.Enumerator<WebConnectionGroup>.Dispose
	|-List.Enumerator<object>.Dispose
	|-List.Enumerator<FieldInfo>.Dispose
	|-List.Enumerator<MemberInfo>.Dispose
	|-List.Enumerator<MethodInfo>.Dispose
	|-List.Enumerator<ExceptionDispatchInfo>.Dispose
	|-List.Enumerator<IContextProperty>.Dispose
	|-List.Enumerator<sbyte>.Dispose
	|-List.Enumerator<X509CertificateImpl>.Dispose
	|-List.Enumerator<float>.Dispose
	|-List.Enumerator<string>.Dispose
	|-List.Enumerator<IAsyncLocal>.Dispose
	|-List.Enumerator<Task>.Dispose
	|-List.Enumerator<Thread>.Dispose
	|-List.Enumerator<TimeSpan>.Dispose
	|-List.Enumerator<IEnlistmentNotification>.Dispose
	|-List.Enumerator<Tuple<EventProvider.SessionInfo, bool>>.Dispose
	|-List.Enumerator<Type>.Dispose
	|-List.Enumerator<TypeIdentifier>.Dispose
	|-List.Enumerator<ushort>.Dispose
	|-List.Enumerator<uint>.Dispose
	|-List.Enumerator<ulong>.Dispose
	|-List.Enumerator<ValueTuple<object, object>>.Dispose
	|-List.Enumerator<ValueTuple<string, AssetBundleRequest>>.Dispose
	|-List.Enumerator<WeakReference>.Dispose
	|-List.Enumerator<WeakReference<EtwSession>>.Dispose
	|-List.Enumerator<RangePositionInfo>.Dispose
	|-List.Enumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Dispose
	|-List.Enumerator<XmlReflectionMember>.Dispose
	|-List.Enumerator<XmlQualifiedName>.Dispose
	|-List.Enumerator<TechTreeData.NodeInstance>.Dispose
	|-List.Enumerator<TechTreeLine>.Dispose
	|-List.Enumerator<TextTable.Row>.Dispose
	|-List.Enumerator<TickInterpolator.Segment>.Dispose
	|-List.Enumerator<TraceInfo>.Dispose
	|-List.Enumerator<TrainCar.TrainCarSnapshot>.Dispose
	|-List.Enumerator<TriggerBase>.Dispose
	|-List.Enumerator<TriggerSafeZone>.Dispose
	|-List.Enumerator<UIMapVendingMachineMarker>.Dispose
	|-List.Enumerator<Underwear>.Dispose
	|-List.Enumerator<NavMeshBuildMarkup>.Dispose
	|-List.Enumerator<NavMeshBuildSource>.Dispose
	|-List.Enumerator<NavMeshLink>.Dispose
	|-List.Enumerator<NavMeshModifier>.Dispose
	|-List.Enumerator<NavMeshModifierVolume>.Dispose
	|-List.Enumerator<AudioSource>.Dispose
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>.Dispose
	|-List.Enumerator<CharacterJoint>.Dispose
	|-List.Enumerator<Collider>.Dispose
	|-List.Enumerator<Color32>.Dispose
	|-List.Enumerator<Color>.Dispose
	|-List.Enumerator<Component>.Dispose
	|-List.Enumerator<ConfigurableJoint>.Dispose
	|-List.Enumerator<DDraw.BaseObject>.Dispose
	|-List.Enumerator<RaycastResult>.Dispose
	|-List.Enumerator<PersistentCall>.Dispose
	|-List.Enumerator<GUILayoutEntry>.Dispose
	|-List.Enumerator<GameObject>.Dispose
	|-List.Enumerator<ISubsystem>.Dispose
	|-List.Enumerator<ISubsystemDescriptor>.Dispose
	|-List.Enumerator<ISubsystemDescriptorImpl>.Dispose
	|-List.Enumerator<Joint>.Dispose
	|-List.Enumerator<KeyCode>.Dispose
	|-List.Enumerator<LODGroup>.Dispose
	|-List.Enumerator<Material>.Dispose
	|-List.Enumerator<MeshCollider>.Dispose
	|-List.Enumerator<MeshRenderer>.Dispose
	|-List.Enumerator<ParticleSystem>.Dispose
	|-List.Enumerator<PhysicMaterial>.Dispose
	|-List.Enumerator<RaycastHit2D>.Dispose
	|-List.Enumerator<RaycastHit>.Dispose
	|-List.Enumerator<Rect>.Dispose
	|-List.Enumerator<RenderTexture>.Dispose
	|-List.Enumerator<Renderer>.Dispose
	|-List.Enumerator<CommandBuffer>.Dispose
	|-List.Enumerator<PostProcessBundle>.Dispose
	|-List.Enumerator<PostProcessEffectSettings>.Dispose
	|-List.Enumerator<PostProcessLayer.SerializedBundleRef>.Dispose
	|-List.Enumerator<PostProcessVolume>.Dispose
	|-List.Enumerator<RenderTargetIdentifier>.Dispose
	|-List.Enumerator<Resolution>.Dispose
	|-List.Enumerator<Rigidbody>.Dispose
	|-List.Enumerator<SkinnedMeshRenderer>.Dispose
	|-List.Enumerator<Terrain>.Dispose
	|-List.Enumerator<GlyphRect>.Dispose
	|-List.Enumerator<Texture2D>.Dispose
	|-List.Enumerator<Texture>.Dispose
	|-List.Enumerator<TrailRenderer>.Dispose
	|-List.Enumerator<Transform>.Dispose
	|-List.Enumerator<TreeInstance>.Dispose
	|-List.Enumerator<MaskableGraphic>.Dispose
	|-List.Enumerator<UICharInfo>.Dispose
	|-List.Enumerator<EventCallbackFunctorBase>.Dispose
	|-List.Enumerator<FocusController.FocusedElement>.Dispose
	|-List.Enumerator<IEventDispatchingStrategy>.Dispose
	|-List.Enumerator<Panel>.Dispose
	|-List.Enumerator<VisualElement>.Dispose
	|-List.Enumerator<UILineInfo>.Dispose
	|-List.Enumerator<UIVertex>.Dispose
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>.Dispose
	|-List.Enumerator<Vector2>.Dispose
	|-List.Enumerator<Vector2[]>.Dispose
	|-List.Enumerator<Vector3>.Dispose
	|-List.Enumerator<Vector4>.Dispose
	|-List.Enumerator<Vector2i>.Dispose
	|-List.Enumerator<ViewModelDrawEvent>.Dispose
	|-List.Enumerator<ViewShake.ShakeParameters>.Dispose
	|-List.Enumerator<VirtualItemIcon>.Dispose
	|-List.Enumerator<VoiceProcessor>.Dispose
	|-List.Enumerator<VoicemailEntry>.Dispose
	|-List.Enumerator<WaterRuntime>.Dispose
	|-List.Enumerator<WearableHairCap>.Dispose
	|-List.Enumerator<WeightedAudioClip>.Dispose
	|-List.Enumerator<WindZoneExManager.CurrentZoneEntry>.Dispose
	|-List.Enumerator<WorldSplineData.LUTEntry.LUTPoint>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CB80 Offset: 0x11BF80 VA: 0x18011CB80
	|-List.Enumerator<AIMovePoint>.MoveNext
	|-List.Enumerator<BaseAIEvent>.MoveNext
	|-List.Enumerator<BaseBulb>.MoveNext
	|-List.Enumerator<BaseCollision>.MoveNext
	|-List.Enumerator<BaseEntity>.MoveNext
	|-List.Enumerator<BaseMeshPaintable>.MoveNext
	|-List.Enumerator<BaseMission.MissionInstance>.MoveNext
	|-List.Enumerator<BaseNetworkable>.MoveNext
	|-List.Enumerator<BaseNpc>.MoveNext
	|-List.Enumerator<BasePathNode>.MoveNext
	|-List.Enumerator<BasePlayer>.MoveNext
	|-List.Enumerator<BaseVehicle.MountPointInfo>.MoveNext
	|-List.Enumerator<BaseVehicle>.MoveNext
	|-List.Enumerator<BaseVehicleModule>.MoveNext
	|-List.Enumerator<BaseViewModel>.MoveNext
	|-List.Enumerator<BlendedSoundLoops.Loop>.MoveNext
	|-List.Enumerator<BoneRetarget>.MoveNext
	|-List.Enumerator<BuildingBlock>.MoveNext
	|-List.Enumerator<CH47DropZone>.MoveNext
	|-List.Enumerator<CH47LandingZone>.MoveNext
	|-List.Enumerator<CinematicEntity>.MoveNext
	|-List.Enumerator<ClientIOLine>.MoveNext
	|-List.Enumerator<CoalingTower>.MoveNext
	|-List.Enumerator<ComponentInfo>.MoveNext
	|-List.Enumerator<ConnectedSpeaker>.MoveNext
	|-List.Enumerator<ConvarComponent.ConvarEvent>.MoveNext
	|-List.Enumerator<CoverageQueries.Query>.MoveNext
	|-List.Enumerator<DecalRecycle>.MoveNext
	|-List.Enumerator<DecorSpawn>.MoveNext
	|-List.Enumerator<DeferredMeshDecal.InstanceData>.MoveNext
	|-List.Enumerator<DemoShotEntry>.MoveNext
	|-List.Enumerator<DemoShotListFolderWidget>.MoveNext
	|-List.Enumerator<DroppedItem>.MoveNext
	|-List.Enumerator<DungeonBaseInfo>.MoveNext
	|-List.Enumerator<DungeonBaseLink>.MoveNext
	|-List.Enumerator<DungeonBaseSocket>.MoveNext
	|-List.Enumerator<DungeonGridCell>.MoveNext
	|-List.Enumerator<DungeonGridInfo>.MoveNext
	|-List.Enumerator<DungeonVolume>.MoveNext
	|-List.Enumerator<ERDecal>.MoveNext
	|-List.Enumerator<ERLaneConnector>.MoveNext
	|-List.Enumerator<ERLocalGrid>.MoveNext
	|-List.Enumerator<ERMarkerExt>.MoveNext
	|-List.Enumerator<ERMesh>.MoveNext
	|-List.Enumerator<ERModularRoad>.MoveNext
	|-List.Enumerator<ERSOMarkerExt>.MoveNext
	|-List.Enumerator<ERSORoadExt>.MoveNext
	|-List.Enumerator<ERSideWalk>.MoveNext
	|-List.Enumerator<ERTerrainData>.MoveNext
	|-List.Enumerator<ERTreeInstance>.MoveNext
	|-List.Enumerator<OQQCCQCDQQ>.MoveNext
	|-List.Enumerator<QDOODOQQDQODD>.MoveNext
	|-List.Enumerator<QDQDOOQQDQODD>.MoveNext
	|-List.Enumerator<SideObject>.MoveNext
	|-List.Enumerator<tPoint>.MoveNext
	|-List.Enumerator<BurstCloth>.MoveNext
	|-List.Enumerator<Input.Button>.MoveNext
	|-List.Enumerator<RCon.RConClient>.MoveNext
	|-List.Enumerator<SkeletonSkin>.MoveNext
	|-List.Enumerator<FavouriteRadioStation>.MoveNext
	|-List.Enumerator<FruitScale>.MoveNext
	|-List.Enumerator<ICommandCenterListener>.MoveNext
	|-List.Enumerator<JSONNode>.MoveNext
	|-List.Enumerator<GenerateDungeonBase.DungeonSegment>.MoveNext
	|-List.Enumerator<GenerateDungeonGrid.PathLink>.MoveNext
	|-List.Enumerator<GenerateDungeonGrid.PathLinkSegment>.MoveNext
	|-List.Enumerator<GenerateDungeonGrid.PathSegment>.MoveNext
	|-List.Enumerator<GeneratePowerlineLayout.PathSegment>.MoveNext
	|-List.Enumerator<GenerateRailRing.RingNode>.MoveNext
	|-List.Enumerator<GenerateRoadLayout.PathNode>.MoveNext
	|-List.Enumerator<GenerateRoadLayout.PathSegment>.MoveNext
	|-List.Enumerator<GenerateRoadRing.RingNode>.MoveNext
	|-List.Enumerator<Gib>.MoveNext
	|-List.Enumerator<GlassPane>.MoveNext
	|-List.Enumerator<GraveyardFence>.MoveNext
	|-List.Enumerator<HitboxDefinition>.MoveNext
	|-List.Enumerator<HitboxSystem.HitboxShape>.MoveNext
	|-List.Enumerator<IClientComponentEx>.MoveNext
	|-List.Enumerator<IEffect>.MoveNext
	|-List.Enumerator<IItemSetup>.MoveNext
	|-List.Enumerator<IItemUpdate>.MoveNext
	|-List.Enumerator<IPlayerItemDefinition>.MoveNext
	|-List.Enumerator<IPrefabPostProcess>.MoveNext
	|-List.Enumerator<IPrefabPreProcess>.MoveNext
	|-List.Enumerator<IRagdollInhert>.MoveNext
	|-List.Enumerator<IServerComponentEx>.MoveNext
	|-List.Enumerator<IconSkin>.MoveNext
	|-List.Enumerator<ImageEffectLayer>.MoveNext
	|-List.Enumerator<InstrumentKeyController>.MoveNext
	|-List.Enumerator<Item>.MoveNext
	|-List.Enumerator<ItemAmount>.MoveNext
	|-List.Enumerator<ItemBlueprint>.MoveNext
	|-List.Enumerator<ItemContainer>.MoveNext
	|-List.Enumerator<ItemDefinition>.MoveNext
	|-List.Enumerator<ItemIcon>.MoveNext
	|-List.Enumerator<ItemModConsumable.ConsumableEffect>.MoveNext
	|-List.Enumerator<ItemPickupNotice>.MoveNext
	|-List.Enumerator<Value>.MoveNext
	|-List.Enumerator<KeyframeWidget>.MoveNext
	|-List.Enumerator<LODComponent>.MoveNext
	|-List.Enumerator<LandmarkInfo>.MoveNext
	|-List.Enumerator<LifeScale>.MoveNext
	|-List.Enumerator<LoadAssetsResult>.MoveNext
	|-List.Enumerator<MapMarker>.MoveNext
	|-List.Enumerator<MaterialReplacement>.MoveNext
	|-List.Enumerator<ValueChange<TimeSignature>>.MoveNext
	|-List.Enumerator<MissionMapMarker>.MoveNext
	|-List.Enumerator<Modifier>.MoveNext
	|-List.Enumerator<ModifierDefintion>.MoveNext
	|-List.Enumerator<SqliteFunctionAttribute>.MoveNext
	|-List.Enumerator<SqliteParameter>.MoveNext
	|-List.Enumerator<MonumentInfo>.MoveNext
	|-List.Enumerator<MonumentMarker>.MoveNext
	|-List.Enumerator<MorphCache>.MoveNext
	|-List.Enumerator<Connection>.MoveNext
	|-List.Enumerator<IXmlNode>.MoveNext
	|-List.Enumerator<JsonSerializerInternalReader.CreatorPropertyContext>.MoveNext
	|-List.Enumerator<SerializationCallback>.MoveNext
	|-List.Enumerator<OutlineObject>.MoveNext
	|-List.Enumerator<PaintableItem>.MoveNext
	|-List.Enumerator<PathFinder.Node>.MoveNext
	|-List.Enumerator<PathList.MeshObject>.MoveNext
	|-List.Enumerator<PathList>.MoveNext
	|-List.Enumerator<PatternFireworkStar>.MoveNext
	|-List.Enumerator<PlayerModel>.MoveNext
	|-List.Enumerator<PlayerModelSkin>.MoveNext
	|-List.Enumerator<PowerlineNode>.MoveNext
	|-List.Enumerator<Projectile>.MoveNext
	|-List.Enumerator<AIEventData>.MoveNext
	|-List.Enumerator<AIStateContainer>.MoveNext
	|-List.Enumerator<ArcadeGame.arcadeEnt>.MoveNext
	|-List.Enumerator<CardTable.WinnerBreakdown.Winner>.MoveNext
	|-List.Enumerator<DemoShot>.MoveNext
	|-List.Enumerator<EggHunt.EggHunter>.MoveNext
	|-List.Enumerator<FileStorageCacheData>.MoveNext
	|-List.Enumerator<GameMode.PlayerScore>.MoveNext
	|-List.Enumerator<GameMode.ScoreColumn>.MoveNext
	|-List.Enumerator<GameMode.TeamInfo>.MoveNext
	|-List.Enumerator<InstrumentMidiBinding>.MoveNext
	|-List.Enumerator<InstrumentRecordingNote>.MoveNext
	|-List.Enumerator<Item>.MoveNext
	|-List.Enumerator<ItemContainer>.MoveNext
	|-List.Enumerator<LightString.StringPoint>.MoveNext
	|-List.Enumerator<LinePoint>.MoveNext
	|-List.Enumerator<MapNote>.MoveNext
	|-List.Enumerator<MarketTerminal.PendingOrder>.MoveNext
	|-List.Enumerator<MissionInstance>.MoveNext
	|-List.Enumerator<Modifier>.MoveNext
	|-List.Enumerator<NeonSign.Lights>.MoveNext
	|-List.Enumerator<PatternFirework.Star>.MoveNext
	|-List.Enumerator<PhoneDirectory.DirectoryEntry>.MoveNext
	|-List.Enumerator<PlayerLifeStory.GenericStat>.MoveNext
	|-List.Enumerator<PlayerLifeStory.WeaponStats>.MoveNext
	|-List.Enumerator<PlayerTeam.TeamMember>.MoveNext
	|-List.Enumerator<RelationshipManager.PlayerRelationshipInfo>.MoveNext
	|-List.Enumerator<RespawnInformation.SpawnOptions>.MoveNext
	|-List.Enumerator<Tree>.MoveNext
	|-List.Enumerator<VendingMachine.SellOrder>.MoveNext
	|-List.Enumerator<VoicemailEntry>.MoveNext
	|-List.Enumerator<RainSurfaceAmbience.SurfaceSound>.MoveNext
	|-List.Enumerator<Recipe>.MoveNext
	|-List.Enumerator<RelationshipManager.PlayerRelationshipInfo>.MoveNext
	|-List.Enumerator<DamageTypeEntry>.MoveNext
	|-List.Enumerator<ConditionalObject>.MoveNext
	|-List.Enumerator<RustButton>.MoveNext
	|-List.Enumerator<ServerAdminPlayerEntry>.MoveNext
	|-List.Enumerator<ServerAdminUGCEntry>.MoveNext
	|-List.Enumerator<ServerAdminUGCEntryPattern>.MoveNext
	|-List.Enumerator<TimelineMarker>.MoveNext
	|-List.Enumerator<SellOrderEntry>.MoveNext
	|-List.Enumerator<ShoutcastStream>.MoveNext
	|-List.Enumerator<ShoutcastStreamer>.MoveNext
	|-List.Enumerator<SleepingBag>.MoveNext
	|-List.Enumerator<SleepingBagClusterMapMarker>.MoveNext
	|-List.Enumerator<SleepingBagMapMarker>.MoveNext
	|-List.Enumerator<SlotMachinePayoutWidget>.MoveNext
	|-List.Enumerator<SmokeGrenade>.MoveNext
	|-List.Enumerator<Socket_Base>.MoveNext
	|-List.Enumerator<Sound>.MoveNext
	|-List.Enumerator<SoundDefinition.DistanceAudioClipList>.MoveNext
	|-List.Enumerator<SteamClass>.MoveNext
	|-List.Enumerator<Action>.MoveNext
	|-List.Enumerator<Action<IntPtr>>.MoveNext
	|-List.Enumerator<List<int>>.MoveNext
	|-List.Enumerator<DataColumn>.MoveNext
	|-List.Enumerator<DataRelation>.MoveNext
	|-List.Enumerator<DataRow>.MoveNext
	|-List.Enumerator<DataTable>.MoveNext
	|-List.Enumerator<Index>.MoveNext
	|-List.Enumerator<EtwSession>.MoveNext
	|-List.Enumerator<FieldMetadata>.MoveNext
	|-List.Enumerator<CultureInfo>.MoveNext
	|-List.Enumerator<ModifierSpec>.MoveNext
	|-List.Enumerator<NameValueHeaderValue>.MoveNext
	|-List.Enumerator<RangeItemHeaderValue>.MoveNext
	|-List.Enumerator<IPAddress>.MoveNext
	|-List.Enumerator<MonoChunkStream.Chunk>.MoveNext
	|-List.Enumerator<WebConnection>.MoveNext
	|-List.Enumerator<WebConnectionGroup>.MoveNext
	|-List.Enumerator<object>.MoveNext
	|-List.Enumerator<FieldInfo>.MoveNext
	|-List.Enumerator<MemberInfo>.MoveNext
	|-List.Enumerator<MethodInfo>.MoveNext
	|-List.Enumerator<ExceptionDispatchInfo>.MoveNext
	|-List.Enumerator<IContextProperty>.MoveNext
	|-List.Enumerator<X509CertificateImpl>.MoveNext
	|-List.Enumerator<string>.MoveNext
	|-List.Enumerator<IAsyncLocal>.MoveNext
	|-List.Enumerator<Task>.MoveNext
	|-List.Enumerator<Thread>.MoveNext
	|-List.Enumerator<IEnlistmentNotification>.MoveNext
	|-List.Enumerator<Tuple<EventProvider.SessionInfo, bool>>.MoveNext
	|-List.Enumerator<Type>.MoveNext
	|-List.Enumerator<TypeIdentifier>.MoveNext
	|-List.Enumerator<WeakReference>.MoveNext
	|-List.Enumerator<WeakReference<EtwSession>>.MoveNext
	|-List.Enumerator<XmlReflectionMember>.MoveNext
	|-List.Enumerator<XmlQualifiedName>.MoveNext
	|-List.Enumerator<TechTreeData.NodeInstance>.MoveNext
	|-List.Enumerator<TechTreeLine>.MoveNext
	|-List.Enumerator<TextTable.Row>.MoveNext
	|-List.Enumerator<TriggerBase>.MoveNext
	|-List.Enumerator<TriggerSafeZone>.MoveNext
	|-List.Enumerator<UIMapVendingMachineMarker>.MoveNext
	|-List.Enumerator<Underwear>.MoveNext
	|-List.Enumerator<NavMeshLink>.MoveNext
	|-List.Enumerator<NavMeshModifier>.MoveNext
	|-List.Enumerator<NavMeshModifierVolume>.MoveNext
	|-List.Enumerator<AudioSource>.MoveNext
	|-List.Enumerator<CharacterJoint>.MoveNext
	|-List.Enumerator<Collider>.MoveNext
	|-List.Enumerator<Component>.MoveNext
	|-List.Enumerator<ConfigurableJoint>.MoveNext
	|-List.Enumerator<DDraw.BaseObject>.MoveNext
	|-List.Enumerator<PersistentCall>.MoveNext
	|-List.Enumerator<GUILayoutEntry>.MoveNext
	|-List.Enumerator<GameObject>.MoveNext
	|-List.Enumerator<ISubsystem>.MoveNext
	|-List.Enumerator<ISubsystemDescriptor>.MoveNext
	|-List.Enumerator<ISubsystemDescriptorImpl>.MoveNext
	|-List.Enumerator<Joint>.MoveNext
	|-List.Enumerator<LODGroup>.MoveNext
	|-List.Enumerator<Material>.MoveNext
	|-List.Enumerator<MeshCollider>.MoveNext
	|-List.Enumerator<MeshRenderer>.MoveNext
	|-List.Enumerator<ParticleSystem>.MoveNext
	|-List.Enumerator<PhysicMaterial>.MoveNext
	|-List.Enumerator<RenderTexture>.MoveNext
	|-List.Enumerator<Renderer>.MoveNext
	|-List.Enumerator<CommandBuffer>.MoveNext
	|-List.Enumerator<PostProcessBundle>.MoveNext
	|-List.Enumerator<PostProcessEffectSettings>.MoveNext
	|-List.Enumerator<PostProcessLayer.SerializedBundleRef>.MoveNext
	|-List.Enumerator<PostProcessVolume>.MoveNext
	|-List.Enumerator<Rigidbody>.MoveNext
	|-List.Enumerator<SkinnedMeshRenderer>.MoveNext
	|-List.Enumerator<Terrain>.MoveNext
	|-List.Enumerator<Texture2D>.MoveNext
	|-List.Enumerator<Texture>.MoveNext
	|-List.Enumerator<TrailRenderer>.MoveNext
	|-List.Enumerator<Transform>.MoveNext
	|-List.Enumerator<MaskableGraphic>.MoveNext
	|-List.Enumerator<EventCallbackFunctorBase>.MoveNext
	|-List.Enumerator<IEventDispatchingStrategy>.MoveNext
	|-List.Enumerator<Panel>.MoveNext
	|-List.Enumerator<VisualElement>.MoveNext
	|-List.Enumerator<Vector2[]>.MoveNext
	|-List.Enumerator<ViewShake.ShakeParameters>.MoveNext
	|-List.Enumerator<VirtualItemIcon>.MoveNext
	|-List.Enumerator<VoiceProcessor>.MoveNext
	|-List.Enumerator<VoicemailEntry>.MoveNext
	|-List.Enumerator<WaterRuntime>.MoveNext
	|-List.Enumerator<WearableHairCap>.MoveNext
	|-List.Enumerator<WeightedAudioClip>.MoveNext
	|
	|-RVA: 0x11C780 Offset: 0x11BB80 VA: 0x18011C780
	|-List.Enumerator<AIState>.MoveNext
	|-List.Enumerator<ItemSlot>.MoveNext
	|-List.Enumerator<InventoryDefId>.MoveNext
	|-List.Enumerator<int>.MoveNext
	|-List.Enumerator<Int32Enum>.MoveNext
	|-List.Enumerator<float>.MoveNext
	|-List.Enumerator<uint>.MoveNext
	|-List.Enumerator<Color32>.MoveNext
	|-List.Enumerator<KeyCode>.MoveNext
	|
	|-RVA: 0x11D540 Offset: 0x11C940 VA: 0x18011D540
	|-List.Enumerator<AdvancedChristmasLights.pointEntry>.MoveNext
	|-List.Enumerator<AlignedLineDrawer.LinePoint>.MoveNext
	|-List.Enumerator<ERChildsSO>.MoveNext
	|-List.Enumerator<TickRenderer.Tick>.MoveNext
	|
	|-RVA: 0x11C920 Offset: 0x11BD20 VA: 0x18011C920
	|-List.Enumerator<AtmosphereVolumeRenderer.CurrentVolumeEntry>.MoveNext
	|-List.Enumerator<DamageRenderer.DamageShowingRenderer>.MoveNext
	|-List.Enumerator<DeferredExtensionMesh.MaterialLink>.MoveNext
	|-List.Enumerator<DeferredMeshDecal.MaterialLink>.MoveNext
	|-List.Enumerator<CombineClass>.MoveNext
	|-List.Enumerator<EntityRef<LootContainer>>.MoveNext
	|-List.Enumerator<EntityRef<object>>.MoveNext
	|-List.Enumerator<TabbedPanel.Tab>.MoveNext
	|-List.Enumerator<RCon.BannedAddresses>.MoveNext
	|-List.Enumerator<GameStat.Stat>.MoveNext
	|-List.Enumerator<ImageStorageEntity.ImageRequest>.MoveNext
	|-List.Enumerator<ParticleSystemContainer.ParticleSystemGroup>.MoveNext
	|-List.Enumerator<PlayerItemRecipe>.MoveNext
	|-List.Enumerator<ReflectionProbeEx.RenderListEntry>.MoveNext
	|-List.Enumerator<MatchMakingKeyValuePair>.MoveNext
	|-List.Enumerator<Dispatch.Callback>.MoveNext
	|-List.Enumerator<DictionaryEntry>.MoveNext
	|-List.Enumerator<KeyValuePair<object, object>>.MoveNext
	|-List.Enumerator<KeyValuePair<object, float>>.MoveNext
	|-List.Enumerator<ValueTuple<object, object>>.MoveNext
	|-List.Enumerator<ValueTuple<string, AssetBundleRequest>>.MoveNext
	|-List.Enumerator<RangePositionInfo>.MoveNext
	|-List.Enumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>.MoveNext
	|-List.Enumerator<FocusController.FocusedElement>.MoveNext
	|-List.Enumerator<WindZoneExManager.CurrentZoneEntry>.MoveNext
	|
	|-RVA: 0x1483B0 Offset: 0x1477B0 VA: 0x1801483B0
	|-List.Enumerator<BaseEntity.ServerFileRequest>.MoveNext
	|
	|-RVA: 0x11D370 Offset: 0x11C770 VA: 0x18011D370
	|-List.Enumerator<CardTableUI.KeycodeWithAction>.MoveNext
	|-List.Enumerator<ItemSkinDirectory.Skin>.MoveNext
	|-List.Enumerator<KeyframeView.UIKeyframeValue>.MoveNext
	|-List.Enumerator<MidiConvar.KnobBinding>.MoveNext
	|-List.Enumerator<MidiConvar.NoteBinding>.MoveNext
	|-List.Enumerator<Option>.MoveNext
	|
	|-RVA: 0x11C4A0 Offset: 0x11B8A0 VA: 0x18011C4A0
	|-List.Enumerator<Cassette.LoadRequest>.MoveNext
	|-List.Enumerator<Admin.ServerConvarInfo>.MoveNext
	|-List.Enumerator<ExpandedLifeStats.GenericStatDisplay>.MoveNext
	|-List.Enumerator<MapView.MapMarkerCluster>.MoveNext
	|-List.Enumerator<MapView.SleepingBagCluster>.MoveNext
	|-List.Enumerator<TimelineEvent>.MoveNext
	|-List.Enumerator<InventoryRecipe>.MoveNext
	|-List.Enumerator<KeyValuePair<object, Color>>.MoveNext
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>.MoveNext
	|
	|-RVA: 0x11DA10 Offset: 0x11CE10 VA: 0x18011DA10
	|-List.Enumerator<Admin.PlayerInfo>.MoveNext
	|-List.Enumerator<PlaceMonuments.SpawnInfo>.MoveNext
	|
	|-RVA: 0x1488D0 Offset: 0x147CD0 VA: 0x1801488D0
	|-List.Enumerator<Admin.ServerUGCInfo>.MoveNext
	|
	|-RVA: 0x11C9E0 Offset: 0x11BDE0 VA: 0x18011C9E0
	|-List.Enumerator<Chat.MuteEntry>.MoveNext
	|-List.Enumerator<JsonPosition>.MoveNext
	|-List.Enumerator<InventoryRecipe.Ingredient>.MoveNext
	|-List.Enumerator<KeyValuePair<ulong, Dispatch.ResultCallback>>.MoveNext
	|
	|-RVA: 0x11C3C0 Offset: 0x11B7C0 VA: 0x18011C3C0
	|-List.Enumerator<Demos.DemoInfo>.MoveNext
	|-List.Enumerator<Output.Entry>.MoveNext
	|-List.Enumerator<IconSkinPicker.SkinButtonSetup>.MoveNext
	|-List.Enumerator<InvokeAction>.MoveNext
	|-List.Enumerator<WaypointSet.Waypoint>.MoveNext
	|-List.Enumerator<SkinnedMultiMesh.Part>.MoveNext
	|-List.Enumerator<SpecialPurposeCamera.RenderEntry>.MoveNext
	|
	|-RVA: 0x11BF80 Offset: 0x11B380 VA: 0x18011BF80
	|-List.Enumerator<CRedge>.MoveNext
	|-List.Enumerator<ProjectileWeaponMod.Modifier>.MoveNext
	|-List.Enumerator<VectorData>.MoveNext
	|-List.Enumerator<TrainCar.TrainCarSnapshot>.MoveNext
	|-List.Enumerator<Resolution>.MoveNext
	|-List.Enumerator<UICharInfo>.MoveNext
	|-List.Enumerator<Vector3>.MoveNext
	|
	|-RVA: 0x11CAC0 Offset: 0x11BEC0 VA: 0x18011CAC0
	|-List.Enumerator<ERCell>.MoveNext
	|-List.Enumerator<ERConnectionGUIStatus>.MoveNext
	|-List.Enumerator<ERTerrainChange>.MoveNext
	|-List.Enumerator<NormalPairs>.MoveNext
	|-List.Enumerator<PathFinder.Point>.MoveNext
	|-List.Enumerator<PlayerItemRecipe.Ingredient>.MoveNext
	|-List.Enumerator<Friend>.MoveNext
	|-List.Enumerator<DateTime>.MoveNext
	|-List.Enumerator<EventProvider.SessionInfo>.MoveNext
	|-List.Enumerator<double>.MoveNext
	|-List.Enumerator<long>.MoveNext
	|-List.Enumerator<TimeSpan>.MoveNext
	|-List.Enumerator<ulong>.MoveNext
	|-List.Enumerator<Vector2i>.MoveNext
	|
	|-RVA: 0x11C050 Offset: 0x11B450 VA: 0x18011C050
	|-List.Enumerator<ERLane>.MoveNext
	|-List.Enumerator<MagnetCrane.MagnetCraneSnapshot>.MoveNext
	|-List.Enumerator<DemoShotVectorKeyframe>.MoveNext
	|-List.Enumerator<DateTimeOffset>.MoveNext
	|-List.Enumerator<Decimal>.MoveNext
	|-List.Enumerator<Guid>.MoveNext
	|-List.Enumerator<TickInterpolator.Segment>.MoveNext
	|-List.Enumerator<NavMeshBuildMarkup>.MoveNext
	|-List.Enumerator<Color>.MoveNext
	|-List.Enumerator<Rect>.MoveNext
	|-List.Enumerator<GlyphRect>.MoveNext
	|-List.Enumerator<UILineInfo>.MoveNext
	|-List.Enumerator<Vector4>.MoveNext
	|-List.Enumerator<WorldSplineData.LUTEntry.LUTPoint>.MoveNext
	|
	|-RVA: 0x148090 Offset: 0x147490 VA: 0x180148090
	|-List.Enumerator<ERMeshCombineUtility.MeshInstance>.MoveNext
	|-List.Enumerator<Option>.MoveNext
	|
	|-RVA: 0x148C20 Offset: 0x148020 VA: 0x180148C20
	|-List.Enumerator<ERSOSection>.MoveNext
	|
	|-RVA: 0x1487D0 Offset: 0x147BD0 VA: 0x1801487D0
	|-List.Enumerator<ERSplatmap>.MoveNext
	|
	|-RVA: 0x1486E0 Offset: 0x147AE0 VA: 0x1801486E0
	|-List.Enumerator<ERVSData>.MoveNext
	|
	|-RVA: 0x11DDD0 Offset: 0x11D1D0 VA: 0x18011DDD0
	|-List.Enumerator<EngineDamageOverTime.RecentDamage>.MoveNext
	|-List.Enumerator<DemoShotFloatKeyframe>.MoveNext
	|-List.Enumerator<Vector2>.MoveNext
	|
	|-RVA: 0x11C1D0 Offset: 0x11B5D0 VA: 0x18011C1D0
	|-List.Enumerator<BurstCloth.Chain>.MoveNext
	|-List.Enumerator<MeshRendererLookup.LookupEntry>.MoveNext
	|-List.Enumerator<Achievement>.MoveNext
	|
	|-RVA: 0x11DBD0 Offset: 0x11CFD0 VA: 0x18011DBD0
	|-List.Enumerator<CapsuleParams>.MoveNext
	|-List.Enumerator<SteamNewsSource.Story>.MoveNext
	|-List.Enumerator<ViewModelDrawEvent>.MoveNext
	|
	|-RVA: 0x1482B0 Offset: 0x1476B0 VA: 0x1801482B0
	|-List.Enumerator<BoneData>.MoveNext
	|
	|-RVA: 0x1485F0 Offset: 0x1479F0 VA: 0x1801485F0
	|-List.Enumerator<SkeletonDefinition.Bone>.MoveNext
	|
	|-RVA: 0x11C830 Offset: 0x11BC30 VA: 0x18011C830
	|-List.Enumerator<Tick.Entry>.MoveNext
	|-List.Enumerator<PlaceMonumentsOffshore.SpawnInfo>.MoveNext
	|-List.Enumerator<PlaceMonumentsRailside.SpawnInfo>.MoveNext
	|-List.Enumerator<PlaceMonumentsRoadside.SpawnInfo>.MoveNext
	|
	|-RVA: 0x1481A0 Offset: 0x1475A0 VA: 0x1801481A0
	|-List.Enumerator<RenderInfo.RendererInstance>.MoveNext
	|
	|-RVA: 0x11CFD0 Offset: 0x11C3D0 VA: 0x18011CFD0
	|-List.Enumerator<WeightedStringList.Container>.MoveNext
	|-List.Enumerator<DemoShotParentKeyframe>.MoveNext
	|-List.Enumerator<KeyValuePair<HairCapMask, Renderer>>.MoveNext
	|-List.Enumerator<KeyValuePair<DateTime, object>>.MoveNext
	|-List.Enumerator<KeyValuePair<int, object>>.MoveNext
	|-List.Enumerator<KeyValuePair<Int32Enum, object>>.MoveNext
	|-List.Enumerator<KeyValuePair<uint, object>>.MoveNext
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>.MoveNext
	|
	|-RVA: 0x148B20 Offset: 0x147F20 VA: 0x180148B20
	|-List.Enumerator<FoliageGridMeshData.FoliageVertex>.MoveNext
	|
	|-RVA: 0x148D60 Offset: 0x148160 VA: 0x180148D60
	|-List.Enumerator<Gibbable.OverrideMesh>.MoveNext
	|
	|-RVA: 0x11D610 Offset: 0x11CA10 VA: 0x18011D610
	|-List.Enumerator<LocalClock.TimedEvent>.MoveNext
	|-List.Enumerator<SynchronizedClock.TimedEvent>.MoveNext
	|
	|-RVA: 0x11CD40 Offset: 0x11C140 VA: 0x18011CD40
	|-List.Enumerator<SevenBitNumber>.MoveNext
	|-List.Enumerator<bool>.MoveNext
	|-List.Enumerator<byte>.MoveNext
	|-List.Enumerator<sbyte>.MoveNext
	|
	|-RVA: 0x11C580 Offset: 0x11B980 VA: 0x18011C580
	|-List.Enumerator<MeshColliderInstance>.MoveNext
	|
	|-RVA: 0x11C290 Offset: 0x11B690 VA: 0x18011C290
	|-List.Enumerator<MeshColliderLookup.LookupEntry>.MoveNext
	|
	|-RVA: 0x11D450 Offset: 0x11C850 VA: 0x18011D450
	|-List.Enumerator<MeshInstance>.MoveNext
	|-List.Enumerator<SubsurfaceProfileTexture.SubsurfaceProfileEntry>.MoveNext
	|
	|-RVA: 0x11D8F0 Offset: 0x11CCF0 VA: 0x18011D8F0
	|-List.Enumerator<MeshRendererInstance>.MoveNext
	|
	|-RVA: 0x11CC40 Offset: 0x11C040 VA: 0x18011CC40
	|-List.Enumerator<SqliteKeyReader.KeyInfo>.MoveNext
	|
	|-RVA: 0x11CEE0 Offset: 0x11C2E0 VA: 0x18011CEE0
	|-List.Enumerator<PetCommandList.PetCommandDesc>.MoveNext
	|
	|-RVA: 0x11DB00 Offset: 0x11CF00 VA: 0x18011DB00
	|-List.Enumerator<DemoShotQuaternionKeyframe>.MoveNext
	|
	|-RVA: 0x11CE00 Offset: 0x11C200 VA: 0x18011CE00
	|-List.Enumerator<ReflectionProbeEx.CubemapSkyboxVertex>.MoveNext
	|-List.Enumerator<RenderTargetIdentifier>.MoveNext
	|-List.Enumerator<TreeInstance>.MoveNext
	|
	|-RVA: 0x11C6A0 Offset: 0x11BAA0 VA: 0x18011C6A0
	|-List.Enumerator<TransformSnapshot>.MoveNext
	|-List.Enumerator<SubmarineSonar.SonarBlip>.MoveNext
	|-List.Enumerator<SpawnIndividual>.MoveNext
	|
	|-RVA: 0x11D0A0 Offset: 0x11C4A0 VA: 0x18011D0A0
	|-List.Enumerator<ServerInfo>.MoveNext
	|
	|-RVA: 0x11D7F0 Offset: 0x11CBF0 VA: 0x18011D7F0
	|-List.Enumerator<ServerInfo>.MoveNext
	|
	|-RVA: 0x11D280 Offset: 0x11C680 VA: 0x18011D280
	|-List.Enumerator<InventoryItem.Amount>.MoveNext
	|
	|-RVA: 0x11D1A0 Offset: 0x11C5A0 VA: 0x18011D1A0
	|-List.Enumerator<InventoryItem>.MoveNext
	|
	|-RVA: 0x11C110 Offset: 0x11B510 VA: 0x18011C110
	|-List.Enumerator<char>.MoveNext
	|-List.Enumerator<short>.MoveNext
	|-List.Enumerator<ushort>.MoveNext
	|
	|-RVA: 0x11D6F0 Offset: 0x11CAF0 VA: 0x18011D6F0
	|-List.Enumerator<TraceInfo>.MoveNext
	|
	|-RVA: 0x11DCC0 Offset: 0x11D0C0 VA: 0x18011DCC0
	|-List.Enumerator<NavMeshBuildSource>.MoveNext
	|
	|-RVA: 0x220CD0 Offset: 0x2200D0 VA: 0x180220CD0
	|-List.Enumerator<RaycastResult>.MoveNext
	|
	|-RVA: 0x220DE0 Offset: 0x2201E0 VA: 0x180220DE0
	|-List.Enumerator<RaycastHit2D>.MoveNext
	|
	|-RVA: 0x220BE0 Offset: 0x21FFE0 VA: 0x180220BE0
	|-List.Enumerator<RaycastHit>.MoveNext
	|
	|-RVA: 0x220EC0 Offset: 0x2202C0 VA: 0x180220EC0
	|-List.Enumerator<UIVertex>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private bool MoveNextRare() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BAA0 Offset: 0x11AEA0 VA: 0x18011BAA0
	|-List.Enumerator<AdvancedChristmasLights.pointEntry>.MoveNextRare
	|-List.Enumerator<AlignedLineDrawer.LinePoint>.MoveNextRare
	|-List.Enumerator<Cassette.LoadRequest>.MoveNextRare
	|-List.Enumerator<Admin.ServerConvarInfo>.MoveNextRare
	|-List.Enumerator<Chat.MuteEntry>.MoveNextRare
	|-List.Enumerator<ERChildsSO>.MoveNextRare
	|-List.Enumerator<ExpandedLifeStats.GenericStatDisplay>.MoveNextRare
	|-List.Enumerator<LocalClock.TimedEvent>.MoveNextRare
	|-List.Enumerator<MapView.MapMarkerCluster>.MoveNextRare
	|-List.Enumerator<MapView.SleepingBagCluster>.MoveNextRare
	|-List.Enumerator<JsonPosition>.MoveNextRare
	|-List.Enumerator<TimelineEvent>.MoveNextRare
	|-List.Enumerator<TickRenderer.Tick>.MoveNextRare
	|-List.Enumerator<InventoryRecipe.Ingredient>.MoveNextRare
	|-List.Enumerator<InventoryRecipe>.MoveNextRare
	|-List.Enumerator<SynchronizedClock.TimedEvent>.MoveNextRare
	|-List.Enumerator<KeyValuePair<object, Color>>.MoveNextRare
	|-List.Enumerator<KeyValuePair<ulong, Dispatch.ResultCallback>>.MoveNextRare
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>.MoveNextRare
	|
	|-RVA: 0x11BAF0 Offset: 0x11AEF0 VA: 0x18011BAF0
	|-List.Enumerator<AtmosphereVolumeRenderer.CurrentVolumeEntry>.MoveNextRare
	|-List.Enumerator<DamageRenderer.DamageShowingRenderer>.MoveNextRare
	|-List.Enumerator<DeferredExtensionMesh.MaterialLink>.MoveNextRare
	|-List.Enumerator<DeferredMeshDecal.MaterialLink>.MoveNextRare
	|-List.Enumerator<CombineClass>.MoveNextRare
	|-List.Enumerator<ERLane>.MoveNextRare
	|-List.Enumerator<EntityRef<object>>.MoveNextRare
	|-List.Enumerator<TabbedPanel.Tab>.MoveNextRare
	|-List.Enumerator<RCon.BannedAddresses>.MoveNextRare
	|-List.Enumerator<WeightedStringList.Container>.MoveNextRare
	|-List.Enumerator<GameStat.Stat>.MoveNextRare
	|-List.Enumerator<ImageStorageEntity.ImageRequest>.MoveNextRare
	|-List.Enumerator<MagnetCrane.MagnetCraneSnapshot>.MoveNextRare
	|-List.Enumerator<ParticleSystemContainer.ParticleSystemGroup>.MoveNextRare
	|-List.Enumerator<PlayerItemRecipe>.MoveNextRare
	|-List.Enumerator<DemoShotParentKeyframe>.MoveNextRare
	|-List.Enumerator<DemoShotVectorKeyframe>.MoveNextRare
	|-List.Enumerator<ReflectionProbeEx.RenderListEntry>.MoveNextRare
	|-List.Enumerator<MatchMakingKeyValuePair>.MoveNextRare
	|-List.Enumerator<Dispatch.Callback>.MoveNextRare
	|-List.Enumerator<DictionaryEntry>.MoveNextRare
	|-List.Enumerator<KeyValuePair<DateTime, object>>.MoveNextRare
	|-List.Enumerator<KeyValuePair<int, object>>.MoveNextRare
	|-List.Enumerator<KeyValuePair<Int32Enum, object>>.MoveNextRare
	|-List.Enumerator<KeyValuePair<object, object>>.MoveNextRare
	|-List.Enumerator<KeyValuePair<object, float>>.MoveNextRare
	|-List.Enumerator<KeyValuePair<uint, object>>.MoveNextRare
	|-List.Enumerator<DateTimeOffset>.MoveNextRare
	|-List.Enumerator<Decimal>.MoveNextRare
	|-List.Enumerator<Guid>.MoveNextRare
	|-List.Enumerator<ValueTuple<object, object>>.MoveNextRare
	|-List.Enumerator<RangePositionInfo>.MoveNextRare
	|-List.Enumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>.MoveNextRare
	|-List.Enumerator<TickInterpolator.Segment>.MoveNextRare
	|-List.Enumerator<NavMeshBuildMarkup>.MoveNextRare
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>.MoveNextRare
	|-List.Enumerator<Color>.MoveNextRare
	|-List.Enumerator<Rect>.MoveNextRare
	|-List.Enumerator<GlyphRect>.MoveNextRare
	|-List.Enumerator<FocusController.FocusedElement>.MoveNextRare
	|-List.Enumerator<UILineInfo>.MoveNextRare
	|-List.Enumerator<Vector4>.MoveNextRare
	|-List.Enumerator<WindZoneExManager.CurrentZoneEntry>.MoveNextRare
	|-List.Enumerator<WorldSplineData.LUTEntry.LUTPoint>.MoveNextRare
	|
	|-RVA: 0x11B9B0 Offset: 0x11ADB0 VA: 0x18011B9B0
	|-List.Enumerator<BaseEntity.ServerFileRequest>.MoveNextRare
	|-List.Enumerator<CardTableUI.KeycodeWithAction>.MoveNextRare
	|-List.Enumerator<Demos.DemoInfo>.MoveNextRare
	|-List.Enumerator<Output.Entry>.MoveNextRare
	|-List.Enumerator<IconSkinPicker.SkinButtonSetup>.MoveNextRare
	|-List.Enumerator<InvokeAction>.MoveNextRare
	|-List.Enumerator<ItemSkinDirectory.Skin>.MoveNextRare
	|-List.Enumerator<KeyframeView.UIKeyframeValue>.MoveNextRare
	|-List.Enumerator<MidiConvar.KnobBinding>.MoveNextRare
	|-List.Enumerator<MidiConvar.NoteBinding>.MoveNextRare
	|-List.Enumerator<WaypointSet.Waypoint>.MoveNextRare
	|-List.Enumerator<TransformSnapshot>.MoveNextRare
	|-List.Enumerator<Option>.MoveNextRare
	|-List.Enumerator<SkinnedMultiMesh.Part>.MoveNextRare
	|-List.Enumerator<SubmarineSonar.SonarBlip>.MoveNextRare
	|-List.Enumerator<SpawnIndividual>.MoveNextRare
	|-List.Enumerator<SpecialPurposeCamera.RenderEntry>.MoveNextRare
	|-List.Enumerator<InventoryItem>.MoveNextRare
	|
	|-RVA: 0x11BEB0 Offset: 0x11B2B0 VA: 0x18011BEB0
	|-List.Enumerator<Admin.PlayerInfo>.MoveNextRare
	|-List.Enumerator<PlaceMonuments.SpawnInfo>.MoveNextRare
	|
	|-RVA: 0x11BB40 Offset: 0x11AF40 VA: 0x18011BB40
	|-List.Enumerator<Admin.ServerUGCInfo>.MoveNextRare
	|-List.Enumerator<CapsuleParams>.MoveNextRare
	|-List.Enumerator<SkeletonDefinition.Bone>.MoveNextRare
	|-List.Enumerator<ReflectionProbeEx.CubemapSkyboxVertex>.MoveNextRare
	|-List.Enumerator<SteamNewsSource.Story>.MoveNextRare
	|-List.Enumerator<InventoryItem.Amount>.MoveNextRare
	|-List.Enumerator<RenderTargetIdentifier>.MoveNextRare
	|-List.Enumerator<TreeInstance>.MoveNextRare
	|-List.Enumerator<ViewModelDrawEvent>.MoveNextRare
	|
	|-RVA: 0x11BC60 Offset: 0x11B060 VA: 0x18011BC60
	|-List.Enumerator<CRedge>.MoveNextRare
	|-List.Enumerator<ProjectileWeaponMod.Modifier>.MoveNextRare
	|-List.Enumerator<VectorData>.MoveNextRare
	|-List.Enumerator<TrainCar.TrainCarSnapshot>.MoveNextRare
	|-List.Enumerator<Resolution>.MoveNextRare
	|-List.Enumerator<UICharInfo>.MoveNextRare
	|-List.Enumerator<Vector3>.MoveNextRare
	|
	|-RVA: 0x11BA50 Offset: 0x11AE50 VA: 0x18011BA50
	|-List.Enumerator<ERCell>.MoveNextRare
	|-List.Enumerator<ERConnectionGUIStatus>.MoveNextRare
	|-List.Enumerator<ERTerrainChange>.MoveNextRare
	|-List.Enumerator<NormalPairs>.MoveNextRare
	|-List.Enumerator<EngineDamageOverTime.RecentDamage>.MoveNextRare
	|-List.Enumerator<BurstCloth.Chain>.MoveNextRare
	|-List.Enumerator<MeshRendererLookup.LookupEntry>.MoveNextRare
	|-List.Enumerator<PathFinder.Point>.MoveNextRare
	|-List.Enumerator<PlayerItemRecipe.Ingredient>.MoveNextRare
	|-List.Enumerator<DemoShotFloatKeyframe>.MoveNextRare
	|-List.Enumerator<Achievement>.MoveNextRare
	|-List.Enumerator<Friend>.MoveNextRare
	|-List.Enumerator<DateTime>.MoveNextRare
	|-List.Enumerator<EventProvider.SessionInfo>.MoveNextRare
	|-List.Enumerator<double>.MoveNextRare
	|-List.Enumerator<long>.MoveNextRare
	|-List.Enumerator<object>.MoveNextRare
	|-List.Enumerator<TimeSpan>.MoveNextRare
	|-List.Enumerator<ulong>.MoveNextRare
	|-List.Enumerator<Vector2>.MoveNextRare
	|-List.Enumerator<Vector2i>.MoveNextRare
	|
	|-RVA: 0x147D40 Offset: 0x147140 VA: 0x180147D40
	|-List.Enumerator<ERMeshCombineUtility.MeshInstance>.MoveNextRare
	|-List.Enumerator<RenderInfo.RendererInstance>.MoveNextRare
	|-List.Enumerator<Option>.MoveNextRare
	|
	|-RVA: 0x147ED0 Offset: 0x1472D0 VA: 0x180147ED0
	|-List.Enumerator<ERSOSection>.MoveNextRare
	|
	|-RVA: 0x147DA0 Offset: 0x1471A0 VA: 0x180147DA0
	|-List.Enumerator<ERSplatmap>.MoveNextRare
	|
	|-RVA: 0x11BDE0 Offset: 0x11B1E0 VA: 0x18011BDE0
	|-List.Enumerator<ERVSData>.MoveNextRare
	|-List.Enumerator<SqliteKeyReader.KeyInfo>.MoveNextRare
	|
	|-RVA: 0x147E60 Offset: 0x147260 VA: 0x180147E60
	|-List.Enumerator<BoneData>.MoveNextRare
	|
	|-RVA: 0x11BBA0 Offset: 0x11AFA0 VA: 0x18011BBA0
	|-List.Enumerator<Tick.Entry>.MoveNextRare
	|-List.Enumerator<Gibbable.OverrideMesh>.MoveNextRare
	|-List.Enumerator<MeshInstance>.MoveNextRare
	|-List.Enumerator<PetCommandList.PetCommandDesc>.MoveNextRare
	|-List.Enumerator<PlaceMonumentsOffshore.SpawnInfo>.MoveNextRare
	|-List.Enumerator<PlaceMonumentsRailside.SpawnInfo>.MoveNextRare
	|-List.Enumerator<PlaceMonumentsRoadside.SpawnInfo>.MoveNextRare
	|-List.Enumerator<SubsurfaceProfileTexture.SubsurfaceProfileEntry>.MoveNextRare
	|
	|-RVA: 0x147E00 Offset: 0x147200 VA: 0x180147E00
	|-List.Enumerator<FoliageGridMeshData.FoliageVertex>.MoveNextRare
	|
	|-RVA: 0x11B960 Offset: 0x11AD60 VA: 0x18011B960
	|-List.Enumerator<SevenBitNumber>.MoveNextRare
	|-List.Enumerator<bool>.MoveNextRare
	|-List.Enumerator<byte>.MoveNextRare
	|-List.Enumerator<sbyte>.MoveNextRare
	|
	|-RVA: 0x11BDD0 Offset: 0x11B1D0 VA: 0x18011BDD0
	|-List.Enumerator<MeshColliderInstance>.MoveNextRare
	|
	|-RVA: 0x11BF10 Offset: 0x11B310 VA: 0x18011BF10
	|-List.Enumerator<MeshColliderLookup.LookupEntry>.MoveNextRare
	|
	|-RVA: 0x11BD70 Offset: 0x11B170 VA: 0x18011BD70
	|-List.Enumerator<MeshRendererInstance>.MoveNextRare
	|
	|-RVA: 0x11BD80 Offset: 0x11B180 VA: 0x18011BD80
	|-List.Enumerator<DemoShotQuaternionKeyframe>.MoveNextRare
	|
	|-RVA: 0x11BD00 Offset: 0x11B100 VA: 0x18011BD00
	|-List.Enumerator<ServerInfo>.MoveNextRare
	|-List.Enumerator<ServerInfo>.MoveNextRare
	|
	|-RVA: 0x11BA00 Offset: 0x11AE00 VA: 0x18011BA00
	|-List.Enumerator<InventoryDefId>.MoveNextRare
	|-List.Enumerator<int>.MoveNextRare
	|-List.Enumerator<Int32Enum>.MoveNextRare
	|-List.Enumerator<float>.MoveNextRare
	|-List.Enumerator<uint>.MoveNextRare
	|-List.Enumerator<Color32>.MoveNextRare
	|
	|-RVA: 0x11BCB0 Offset: 0x11B0B0 VA: 0x18011BCB0
	|-List.Enumerator<char>.MoveNextRare
	|-List.Enumerator<short>.MoveNextRare
	|-List.Enumerator<ushort>.MoveNextRare
	|
	|-RVA: 0x11BC00 Offset: 0x11B000 VA: 0x18011BC00
	|-List.Enumerator<TraceInfo>.MoveNextRare
	|-List.Enumerator<RaycastResult>.MoveNextRare
	|
	|-RVA: 0x11BE40 Offset: 0x11B240 VA: 0x18011BE40
	|-List.Enumerator<NavMeshBuildSource>.MoveNextRare
	|
	|-RVA: 0x220B80 Offset: 0x21FF80 VA: 0x180220B80
	|-List.Enumerator<RaycastHit2D>.MoveNextRare
	|
	|-RVA: 0x220B20 Offset: 0x21FF20 VA: 0x180220B20
	|-List.Enumerator<RaycastHit>.MoveNextRare
	|
	|-RVA: 0x220AC0 Offset: 0x21FEC0 VA: 0x180220AC0
	|-List.Enumerator<UIVertex>.MoveNextRare
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3F60 Offset: 0xF3360 VA: 0x1800F3F60
	|-List.Enumerator<AIMovePoint>.get_Current
	|-List.Enumerator<BaseAIEvent>.get_Current
	|-List.Enumerator<BaseBulb>.get_Current
	|-List.Enumerator<BaseCollision>.get_Current
	|-List.Enumerator<BaseEntity>.get_Current
	|-List.Enumerator<BaseMeshPaintable>.get_Current
	|-List.Enumerator<BaseMission.MissionInstance>.get_Current
	|-List.Enumerator<BaseNetworkable>.get_Current
	|-List.Enumerator<BaseNpc>.get_Current
	|-List.Enumerator<BasePathNode>.get_Current
	|-List.Enumerator<BasePlayer>.get_Current
	|-List.Enumerator<BaseVehicle.MountPointInfo>.get_Current
	|-List.Enumerator<BaseVehicle>.get_Current
	|-List.Enumerator<BaseVehicleModule>.get_Current
	|-List.Enumerator<BaseViewModel>.get_Current
	|-List.Enumerator<BlendedSoundLoops.Loop>.get_Current
	|-List.Enumerator<BoneRetarget>.get_Current
	|-List.Enumerator<BuildingBlock>.get_Current
	|-List.Enumerator<CH47DropZone>.get_Current
	|-List.Enumerator<CH47LandingZone>.get_Current
	|-List.Enumerator<CinematicEntity>.get_Current
	|-List.Enumerator<ClientIOLine>.get_Current
	|-List.Enumerator<CoalingTower>.get_Current
	|-List.Enumerator<ComponentInfo>.get_Current
	|-List.Enumerator<ConnectedSpeaker>.get_Current
	|-List.Enumerator<ConvarComponent.ConvarEvent>.get_Current
	|-List.Enumerator<CoverageQueries.Query>.get_Current
	|-List.Enumerator<DecalRecycle>.get_Current
	|-List.Enumerator<DecorSpawn>.get_Current
	|-List.Enumerator<DeferredMeshDecal.InstanceData>.get_Current
	|-List.Enumerator<DemoShotEntry>.get_Current
	|-List.Enumerator<DemoShotListFolderWidget>.get_Current
	|-List.Enumerator<DroppedItem>.get_Current
	|-List.Enumerator<DungeonBaseInfo>.get_Current
	|-List.Enumerator<DungeonBaseLink>.get_Current
	|-List.Enumerator<DungeonBaseSocket>.get_Current
	|-List.Enumerator<DungeonGridCell>.get_Current
	|-List.Enumerator<DungeonGridInfo>.get_Current
	|-List.Enumerator<DungeonVolume>.get_Current
	|-List.Enumerator<ERDecal>.get_Current
	|-List.Enumerator<ERLaneConnector>.get_Current
	|-List.Enumerator<ERLocalGrid>.get_Current
	|-List.Enumerator<ERMarkerExt>.get_Current
	|-List.Enumerator<ERMesh>.get_Current
	|-List.Enumerator<ERModularRoad>.get_Current
	|-List.Enumerator<ERSOMarkerExt>.get_Current
	|-List.Enumerator<ERSORoadExt>.get_Current
	|-List.Enumerator<ERSideWalk>.get_Current
	|-List.Enumerator<ERTerrainData>.get_Current
	|-List.Enumerator<ERTreeInstance>.get_Current
	|-List.Enumerator<OQQCCQCDQQ>.get_Current
	|-List.Enumerator<QDOODOQQDQODD>.get_Current
	|-List.Enumerator<QDQDOOQQDQODD>.get_Current
	|-List.Enumerator<SideObject>.get_Current
	|-List.Enumerator<tPoint>.get_Current
	|-List.Enumerator<BurstCloth.Chain>.get_Current
	|-List.Enumerator<BurstCloth>.get_Current
	|-List.Enumerator<Input.Button>.get_Current
	|-List.Enumerator<RCon.RConClient>.get_Current
	|-List.Enumerator<SkeletonSkin>.get_Current
	|-List.Enumerator<FavouriteRadioStation>.get_Current
	|-List.Enumerator<FruitScale>.get_Current
	|-List.Enumerator<ICommandCenterListener>.get_Current
	|-List.Enumerator<JSONNode>.get_Current
	|-List.Enumerator<GenerateDungeonBase.DungeonSegment>.get_Current
	|-List.Enumerator<GenerateDungeonGrid.PathLink>.get_Current
	|-List.Enumerator<GenerateDungeonGrid.PathLinkSegment>.get_Current
	|-List.Enumerator<GenerateDungeonGrid.PathSegment>.get_Current
	|-List.Enumerator<GeneratePowerlineLayout.PathSegment>.get_Current
	|-List.Enumerator<GenerateRailRing.RingNode>.get_Current
	|-List.Enumerator<GenerateRoadLayout.PathNode>.get_Current
	|-List.Enumerator<GenerateRoadLayout.PathSegment>.get_Current
	|-List.Enumerator<GenerateRoadRing.RingNode>.get_Current
	|-List.Enumerator<Gib>.get_Current
	|-List.Enumerator<GlassPane>.get_Current
	|-List.Enumerator<GraveyardFence>.get_Current
	|-List.Enumerator<HitboxDefinition>.get_Current
	|-List.Enumerator<HitboxSystem.HitboxShape>.get_Current
	|-List.Enumerator<IClientComponentEx>.get_Current
	|-List.Enumerator<IEffect>.get_Current
	|-List.Enumerator<IItemSetup>.get_Current
	|-List.Enumerator<IItemUpdate>.get_Current
	|-List.Enumerator<IPlayerItemDefinition>.get_Current
	|-List.Enumerator<IPrefabPostProcess>.get_Current
	|-List.Enumerator<IPrefabPreProcess>.get_Current
	|-List.Enumerator<IRagdollInhert>.get_Current
	|-List.Enumerator<IServerComponentEx>.get_Current
	|-List.Enumerator<IconSkin>.get_Current
	|-List.Enumerator<ImageEffectLayer>.get_Current
	|-List.Enumerator<InstrumentKeyController>.get_Current
	|-List.Enumerator<Item>.get_Current
	|-List.Enumerator<ItemAmount>.get_Current
	|-List.Enumerator<ItemBlueprint>.get_Current
	|-List.Enumerator<ItemContainer>.get_Current
	|-List.Enumerator<ItemDefinition>.get_Current
	|-List.Enumerator<ItemIcon>.get_Current
	|-List.Enumerator<ItemModConsumable.ConsumableEffect>.get_Current
	|-List.Enumerator<ItemPickupNotice>.get_Current
	|-List.Enumerator<Value>.get_Current
	|-List.Enumerator<KeyframeWidget>.get_Current
	|-List.Enumerator<LODComponent>.get_Current
	|-List.Enumerator<LandmarkInfo>.get_Current
	|-List.Enumerator<LifeScale>.get_Current
	|-List.Enumerator<LoadAssetsResult>.get_Current
	|-List.Enumerator<MapMarker>.get_Current
	|-List.Enumerator<MaterialReplacement>.get_Current
	|-List.Enumerator<ValueChange<TimeSignature>>.get_Current
	|-List.Enumerator<MissionMapMarker>.get_Current
	|-List.Enumerator<Modifier>.get_Current
	|-List.Enumerator<ModifierDefintion>.get_Current
	|-List.Enumerator<SqliteFunctionAttribute>.get_Current
	|-List.Enumerator<SqliteParameter>.get_Current
	|-List.Enumerator<MonumentInfo>.get_Current
	|-List.Enumerator<MonumentMarker>.get_Current
	|-List.Enumerator<MorphCache>.get_Current
	|-List.Enumerator<Connection>.get_Current
	|-List.Enumerator<IXmlNode>.get_Current
	|-List.Enumerator<JsonSerializerInternalReader.CreatorPropertyContext>.get_Current
	|-List.Enumerator<SerializationCallback>.get_Current
	|-List.Enumerator<OutlineObject>.get_Current
	|-List.Enumerator<PaintableItem>.get_Current
	|-List.Enumerator<PathFinder.Node>.get_Current
	|-List.Enumerator<PathFinder.Point>.get_Current
	|-List.Enumerator<PathList.MeshObject>.get_Current
	|-List.Enumerator<PathList>.get_Current
	|-List.Enumerator<PatternFireworkStar>.get_Current
	|-List.Enumerator<PlayerModel>.get_Current
	|-List.Enumerator<PlayerModelSkin>.get_Current
	|-List.Enumerator<PowerlineNode>.get_Current
	|-List.Enumerator<Projectile>.get_Current
	|-List.Enumerator<AIEventData>.get_Current
	|-List.Enumerator<AIStateContainer>.get_Current
	|-List.Enumerator<ArcadeGame.arcadeEnt>.get_Current
	|-List.Enumerator<CardTable.WinnerBreakdown.Winner>.get_Current
	|-List.Enumerator<DemoShot>.get_Current
	|-List.Enumerator<EggHunt.EggHunter>.get_Current
	|-List.Enumerator<FileStorageCacheData>.get_Current
	|-List.Enumerator<GameMode.PlayerScore>.get_Current
	|-List.Enumerator<GameMode.ScoreColumn>.get_Current
	|-List.Enumerator<GameMode.TeamInfo>.get_Current
	|-List.Enumerator<InstrumentMidiBinding>.get_Current
	|-List.Enumerator<InstrumentRecordingNote>.get_Current
	|-List.Enumerator<Item>.get_Current
	|-List.Enumerator<ItemContainer>.get_Current
	|-List.Enumerator<LightString.StringPoint>.get_Current
	|-List.Enumerator<LinePoint>.get_Current
	|-List.Enumerator<MapNote>.get_Current
	|-List.Enumerator<MarketTerminal.PendingOrder>.get_Current
	|-List.Enumerator<MissionInstance>.get_Current
	|-List.Enumerator<Modifier>.get_Current
	|-List.Enumerator<NeonSign.Lights>.get_Current
	|-List.Enumerator<PatternFirework.Star>.get_Current
	|-List.Enumerator<PhoneDirectory.DirectoryEntry>.get_Current
	|-List.Enumerator<PlayerLifeStory.GenericStat>.get_Current
	|-List.Enumerator<PlayerLifeStory.WeaponStats>.get_Current
	|-List.Enumerator<PlayerTeam.TeamMember>.get_Current
	|-List.Enumerator<RelationshipManager.PlayerRelationshipInfo>.get_Current
	|-List.Enumerator<RespawnInformation.SpawnOptions>.get_Current
	|-List.Enumerator<Tree>.get_Current
	|-List.Enumerator<VendingMachine.SellOrder>.get_Current
	|-List.Enumerator<VoicemailEntry>.get_Current
	|-List.Enumerator<RainSurfaceAmbience.SurfaceSound>.get_Current
	|-List.Enumerator<Recipe>.get_Current
	|-List.Enumerator<RelationshipManager.PlayerRelationshipInfo>.get_Current
	|-List.Enumerator<DamageTypeEntry>.get_Current
	|-List.Enumerator<ConditionalObject>.get_Current
	|-List.Enumerator<RustButton>.get_Current
	|-List.Enumerator<ServerAdminPlayerEntry>.get_Current
	|-List.Enumerator<ServerAdminUGCEntry>.get_Current
	|-List.Enumerator<ServerAdminUGCEntryPattern>.get_Current
	|-List.Enumerator<TimelineMarker>.get_Current
	|-List.Enumerator<SellOrderEntry>.get_Current
	|-List.Enumerator<ShoutcastStream>.get_Current
	|-List.Enumerator<ShoutcastStreamer>.get_Current
	|-List.Enumerator<SleepingBag>.get_Current
	|-List.Enumerator<SleepingBagClusterMapMarker>.get_Current
	|-List.Enumerator<SleepingBagMapMarker>.get_Current
	|-List.Enumerator<SlotMachinePayoutWidget>.get_Current
	|-List.Enumerator<SmokeGrenade>.get_Current
	|-List.Enumerator<Socket_Base>.get_Current
	|-List.Enumerator<Sound>.get_Current
	|-List.Enumerator<SoundDefinition.DistanceAudioClipList>.get_Current
	|-List.Enumerator<SteamClass>.get_Current
	|-List.Enumerator<Action>.get_Current
	|-List.Enumerator<Action<IntPtr>>.get_Current
	|-List.Enumerator<List<int>>.get_Current
	|-List.Enumerator<DataColumn>.get_Current
	|-List.Enumerator<DataRelation>.get_Current
	|-List.Enumerator<DataRow>.get_Current
	|-List.Enumerator<DataTable>.get_Current
	|-List.Enumerator<Index>.get_Current
	|-List.Enumerator<NameValueHeaderValue>.get_Current
	|-List.Enumerator<RangeItemHeaderValue>.get_Current
	|-List.Enumerator<IPAddress>.get_Current
	|-List.Enumerator<MonoChunkStream.Chunk>.get_Current
	|-List.Enumerator<WebConnection>.get_Current
	|-List.Enumerator<WebConnectionGroup>.get_Current
	|-List.Enumerator<FieldInfo>.get_Current
	|-List.Enumerator<MemberInfo>.get_Current
	|-List.Enumerator<X509CertificateImpl>.get_Current
	|-List.Enumerator<Thread>.get_Current
	|-List.Enumerator<IEnlistmentNotification>.get_Current
	|-List.Enumerator<Type>.get_Current
	|-List.Enumerator<XmlReflectionMember>.get_Current
	|-List.Enumerator<XmlQualifiedName>.get_Current
	|-List.Enumerator<TechTreeData.NodeInstance>.get_Current
	|-List.Enumerator<TechTreeLine>.get_Current
	|-List.Enumerator<TextTable.Row>.get_Current
	|-List.Enumerator<TriggerBase>.get_Current
	|-List.Enumerator<TriggerSafeZone>.get_Current
	|-List.Enumerator<UIMapVendingMachineMarker>.get_Current
	|-List.Enumerator<Underwear>.get_Current
	|-List.Enumerator<NavMeshLink>.get_Current
	|-List.Enumerator<NavMeshModifier>.get_Current
	|-List.Enumerator<NavMeshModifierVolume>.get_Current
	|-List.Enumerator<AudioSource>.get_Current
	|-List.Enumerator<CharacterJoint>.get_Current
	|-List.Enumerator<Collider>.get_Current
	|-List.Enumerator<Component>.get_Current
	|-List.Enumerator<ConfigurableJoint>.get_Current
	|-List.Enumerator<DDraw.BaseObject>.get_Current
	|-List.Enumerator<PersistentCall>.get_Current
	|-List.Enumerator<GUILayoutEntry>.get_Current
	|-List.Enumerator<GameObject>.get_Current
	|-List.Enumerator<ISubsystem>.get_Current
	|-List.Enumerator<ISubsystemDescriptor>.get_Current
	|-List.Enumerator<ISubsystemDescriptorImpl>.get_Current
	|-List.Enumerator<Joint>.get_Current
	|-List.Enumerator<LODGroup>.get_Current
	|-List.Enumerator<Material>.get_Current
	|-List.Enumerator<MeshCollider>.get_Current
	|-List.Enumerator<MeshRenderer>.get_Current
	|-List.Enumerator<ParticleSystem>.get_Current
	|-List.Enumerator<PhysicMaterial>.get_Current
	|-List.Enumerator<RenderTexture>.get_Current
	|-List.Enumerator<Renderer>.get_Current
	|-List.Enumerator<CommandBuffer>.get_Current
	|-List.Enumerator<PostProcessBundle>.get_Current
	|-List.Enumerator<PostProcessEffectSettings>.get_Current
	|-List.Enumerator<PostProcessLayer.SerializedBundleRef>.get_Current
	|-List.Enumerator<PostProcessVolume>.get_Current
	|-List.Enumerator<Rigidbody>.get_Current
	|-List.Enumerator<SkinnedMeshRenderer>.get_Current
	|-List.Enumerator<Terrain>.get_Current
	|-List.Enumerator<Texture2D>.get_Current
	|-List.Enumerator<Texture>.get_Current
	|-List.Enumerator<TrailRenderer>.get_Current
	|-List.Enumerator<Transform>.get_Current
	|-List.Enumerator<MaskableGraphic>.get_Current
	|-List.Enumerator<EventCallbackFunctorBase>.get_Current
	|-List.Enumerator<IEventDispatchingStrategy>.get_Current
	|-List.Enumerator<Panel>.get_Current
	|-List.Enumerator<VisualElement>.get_Current
	|-List.Enumerator<Vector2[]>.get_Current
	|-List.Enumerator<Vector2i>.get_Current
	|-List.Enumerator<ViewShake.ShakeParameters>.get_Current
	|-List.Enumerator<VirtualItemIcon>.get_Current
	|-List.Enumerator<VoiceProcessor>.get_Current
	|-List.Enumerator<VoicemailEntry>.get_Current
	|-List.Enumerator<WaterRuntime>.get_Current
	|-List.Enumerator<WearableHairCap>.get_Current
	|-List.Enumerator<WeightedAudioClip>.get_Current
	|-List.Enumerator<ERCell>.get_Current
	|-List.Enumerator<ERConnectionGUIStatus>.get_Current
	|-List.Enumerator<ERTerrainChange>.get_Current
	|-List.Enumerator<NormalPairs>.get_Current
	|-List.Enumerator<MeshRendererLookup.LookupEntry>.get_Current
	|-List.Enumerator<PlayerItemRecipe.Ingredient>.get_Current
	|-List.Enumerator<Achievement>.get_Current
	|-List.Enumerator<Friend>.get_Current
	|-List.Enumerator<DateTime>.get_Current
	|-List.Enumerator<EtwSession>.get_Current
	|-List.Enumerator<EventProvider.SessionInfo>.get_Current
	|-List.Enumerator<FieldMetadata>.get_Current
	|-List.Enumerator<CultureInfo>.get_Current
	|-List.Enumerator<long>.get_Current
	|-List.Enumerator<ModifierSpec>.get_Current
	|-List.Enumerator<object>.get_Current
	|-List.Enumerator<MethodInfo>.get_Current
	|-List.Enumerator<ExceptionDispatchInfo>.get_Current
	|-List.Enumerator<IContextProperty>.get_Current
	|-List.Enumerator<string>.get_Current
	|-List.Enumerator<IAsyncLocal>.get_Current
	|-List.Enumerator<Task>.get_Current
	|-List.Enumerator<TimeSpan>.get_Current
	|-List.Enumerator<Tuple<EventProvider.SessionInfo, bool>>.get_Current
	|-List.Enumerator<TypeIdentifier>.get_Current
	|-List.Enumerator<ulong>.get_Current
	|-List.Enumerator<WeakReference>.get_Current
	|-List.Enumerator<WeakReference<EtwSession>>.get_Current
	|
	|-RVA: 0xF3F30 Offset: 0xF3330 VA: 0x1800F3F30
	|-List.Enumerator<AIState>.get_Current
	|-List.Enumerator<ItemSlot>.get_Current
	|-List.Enumerator<uint>.get_Current
	|-List.Enumerator<KeyCode>.get_Current
	|-List.Enumerator<InventoryDefId>.get_Current
	|-List.Enumerator<int>.get_Current
	|-List.Enumerator<Int32Enum>.get_Current
	|-List.Enumerator<Color32>.get_Current
	|
	|-RVA: 0x116B30 Offset: 0x115F30 VA: 0x180116B30
	|-List.Enumerator<AlignedLineDrawer.LinePoint>.get_Current
	|-List.Enumerator<Chat.MuteEntry>.get_Current
	|-List.Enumerator<ExpandedLifeStats.GenericStatDisplay>.get_Current
	|-List.Enumerator<MapView.MapMarkerCluster>.get_Current
	|-List.Enumerator<MapView.SleepingBagCluster>.get_Current
	|-List.Enumerator<JsonPosition>.get_Current
	|-List.Enumerator<TickRenderer.Tick>.get_Current
	|-List.Enumerator<AdvancedChristmasLights.pointEntry>.get_Current
	|-List.Enumerator<Cassette.LoadRequest>.get_Current
	|-List.Enumerator<Admin.ServerConvarInfo>.get_Current
	|-List.Enumerator<ERChildsSO>.get_Current
	|-List.Enumerator<LocalClock.TimedEvent>.get_Current
	|-List.Enumerator<TimelineEvent>.get_Current
	|-List.Enumerator<InventoryRecipe.Ingredient>.get_Current
	|-List.Enumerator<InventoryRecipe>.get_Current
	|-List.Enumerator<SynchronizedClock.TimedEvent>.get_Current
	|-List.Enumerator<KeyValuePair<object, Color>>.get_Current
	|-List.Enumerator<KeyValuePair<ulong, Dispatch.ResultCallback>>.get_Current
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>.get_Current
	|
	|-RVA: 0x116AF0 Offset: 0x115EF0 VA: 0x180116AF0
	|-List.Enumerator<CardTableUI.KeycodeWithAction>.get_Current
	|-List.Enumerator<IconSkinPicker.SkinButtonSetup>.get_Current
	|-List.Enumerator<InvokeAction>.get_Current
	|-List.Enumerator<KeyframeView.UIKeyframeValue>.get_Current
	|-List.Enumerator<MidiConvar.KnobBinding>.get_Current
	|-List.Enumerator<MidiConvar.NoteBinding>.get_Current
	|-List.Enumerator<TransformSnapshot>.get_Current
	|-List.Enumerator<SkinnedMultiMesh.Part>.get_Current
	|-List.Enumerator<BaseEntity.ServerFileRequest>.get_Current
	|-List.Enumerator<Demos.DemoInfo>.get_Current
	|-List.Enumerator<Output.Entry>.get_Current
	|-List.Enumerator<ItemSkinDirectory.Skin>.get_Current
	|-List.Enumerator<WaypointSet.Waypoint>.get_Current
	|-List.Enumerator<Option>.get_Current
	|-List.Enumerator<SubmarineSonar.SonarBlip>.get_Current
	|-List.Enumerator<SpawnIndividual>.get_Current
	|-List.Enumerator<SpecialPurposeCamera.RenderEntry>.get_Current
	|-List.Enumerator<InventoryItem>.get_Current
	|
	|-RVA: 0x116B50 Offset: 0x115F50 VA: 0x180116B50
	|-List.Enumerator<Admin.ServerUGCInfo>.get_Current
	|-List.Enumerator<CapsuleParams>.get_Current
	|-List.Enumerator<ViewModelDrawEvent>.get_Current
	|-List.Enumerator<SkeletonDefinition.Bone>.get_Current
	|-List.Enumerator<ReflectionProbeEx.CubemapSkyboxVertex>.get_Current
	|-List.Enumerator<SteamNewsSource.Story>.get_Current
	|-List.Enumerator<InventoryItem.Amount>.get_Current
	|-List.Enumerator<RenderTargetIdentifier>.get_Current
	|-List.Enumerator<TreeInstance>.get_Current
	|
	|-RVA: 0x10ABB0 Offset: 0x109FB0 VA: 0x18010ABB0
	|-List.Enumerator<DamageRenderer.DamageShowingRenderer>.get_Current
	|-List.Enumerator<DeferredMeshDecal.MaterialLink>.get_Current
	|-List.Enumerator<CombineClass>.get_Current
	|-List.Enumerator<ERLane>.get_Current
	|-List.Enumerator<EntityRef<LootContainer>>.get_Current
	|-List.Enumerator<ImageStorageEntity.ImageRequest>.get_Current
	|-List.Enumerator<DemoShotVectorKeyframe>.get_Current
	|-List.Enumerator<ReflectionProbeEx.RenderListEntry>.get_Current
	|-List.Enumerator<Dispatch.Callback>.get_Current
	|-List.Enumerator<KeyValuePair<HairCapMask, Renderer>>.get_Current
	|-List.Enumerator<ValueTuple<string, AssetBundleRequest>>.get_Current
	|-List.Enumerator<Rect>.get_Current
	|-List.Enumerator<AtmosphereVolumeRenderer.CurrentVolumeEntry>.get_Current
	|-List.Enumerator<DeferredExtensionMesh.MaterialLink>.get_Current
	|-List.Enumerator<EntityRef<object>>.get_Current
	|-List.Enumerator<TabbedPanel.Tab>.get_Current
	|-List.Enumerator<RCon.BannedAddresses>.get_Current
	|-List.Enumerator<WeightedStringList.Container>.get_Current
	|-List.Enumerator<GameStat.Stat>.get_Current
	|-List.Enumerator<MagnetCrane.MagnetCraneSnapshot>.get_Current
	|-List.Enumerator<ParticleSystemContainer.ParticleSystemGroup>.get_Current
	|-List.Enumerator<PlayerItemRecipe>.get_Current
	|-List.Enumerator<DemoShotParentKeyframe>.get_Current
	|-List.Enumerator<MatchMakingKeyValuePair>.get_Current
	|-List.Enumerator<DictionaryEntry>.get_Current
	|-List.Enumerator<KeyValuePair<DateTime, object>>.get_Current
	|-List.Enumerator<KeyValuePair<int, object>>.get_Current
	|-List.Enumerator<KeyValuePair<Int32Enum, object>>.get_Current
	|-List.Enumerator<KeyValuePair<object, object>>.get_Current
	|-List.Enumerator<KeyValuePair<object, float>>.get_Current
	|-List.Enumerator<KeyValuePair<uint, object>>.get_Current
	|-List.Enumerator<DateTimeOffset>.get_Current
	|-List.Enumerator<Decimal>.get_Current
	|-List.Enumerator<Guid>.get_Current
	|-List.Enumerator<ValueTuple<object, object>>.get_Current
	|-List.Enumerator<RangePositionInfo>.get_Current
	|-List.Enumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>.get_Current
	|-List.Enumerator<TickInterpolator.Segment>.get_Current
	|-List.Enumerator<NavMeshBuildMarkup>.get_Current
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>.get_Current
	|-List.Enumerator<Color>.get_Current
	|-List.Enumerator<GlyphRect>.get_Current
	|-List.Enumerator<FocusController.FocusedElement>.get_Current
	|-List.Enumerator<UILineInfo>.get_Current
	|-List.Enumerator<Vector4>.get_Current
	|-List.Enumerator<WindZoneExManager.CurrentZoneEntry>.get_Current
	|-List.Enumerator<WorldSplineData.LUTEntry.LUTPoint>.get_Current
	|
	|-RVA: 0x149EB0 Offset: 0x1492B0 VA: 0x180149EB0
	|-List.Enumerator<ERSplatmap>.get_Current
	|
	|-RVA: 0x149EE0 Offset: 0x1492E0 VA: 0x180149EE0
	|-List.Enumerator<BoneData>.get_Current
	|
	|-RVA: 0x149E70 Offset: 0x149270 VA: 0x180149E70
	|-List.Enumerator<Option>.get_Current
	|-List.Enumerator<ERMeshCombineUtility.MeshInstance>.get_Current
	|-List.Enumerator<RenderInfo.RendererInstance>.get_Current
	|
	|-RVA: 0x11FD20 Offset: 0x11F120 VA: 0x18011FD20
	|-List.Enumerator<PetCommandList.PetCommandDesc>.get_Current
	|-List.Enumerator<PlaceMonumentsOffshore.SpawnInfo>.get_Current
	|-List.Enumerator<PlaceMonumentsRailside.SpawnInfo>.get_Current
	|-List.Enumerator<PlaceMonumentsRoadside.SpawnInfo>.get_Current
	|-List.Enumerator<Tick.Entry>.get_Current
	|-List.Enumerator<Gibbable.OverrideMesh>.get_Current
	|-List.Enumerator<MeshInstance>.get_Current
	|-List.Enumerator<SubsurfaceProfileTexture.SubsurfaceProfileEntry>.get_Current
	|
	|-RVA: 0x11FCF0 Offset: 0x11F0F0 VA: 0x18011FCF0
	|-List.Enumerator<PlaceMonuments.SpawnInfo>.get_Current
	|-List.Enumerator<Admin.PlayerInfo>.get_Current
	|
	|-RVA: 0x11FDD0 Offset: 0x11F1D0 VA: 0x18011FDD0
	|-List.Enumerator<DemoShotFloatKeyframe>.get_Current
	|-List.Enumerator<Vector2>.get_Current
	|-List.Enumerator<EngineDamageOverTime.RecentDamage>.get_Current
	|
	|-RVA: 0x11FD70 Offset: 0x11F170 VA: 0x18011FD70
	|-List.Enumerator<DemoShotQuaternionKeyframe>.get_Current
	|
	|-RVA: 0x116B10 Offset: 0x115F10 VA: 0x180116B10
	|-List.Enumerator<VectorData>.get_Current
	|-List.Enumerator<Resolution>.get_Current
	|-List.Enumerator<Vector3>.get_Current
	|-List.Enumerator<CRedge>.get_Current
	|-List.Enumerator<ProjectileWeaponMod.Modifier>.get_Current
	|-List.Enumerator<TrainCar.TrainCarSnapshot>.get_Current
	|-List.Enumerator<UICharInfo>.get_Current
	|
	|-RVA: 0x11FEC0 Offset: 0x11F2C0 VA: 0x18011FEC0
	|-List.Enumerator<ServerInfo>.get_Current
	|-List.Enumerator<ServerInfo>.get_Current
	|
	|-RVA: 0x10ABD0 Offset: 0x109FD0 VA: 0x18010ABD0
	|-List.Enumerator<bool>.get_Current
	|-List.Enumerator<SevenBitNumber>.get_Current
	|-List.Enumerator<byte>.get_Current
	|-List.Enumerator<sbyte>.get_Current
	|
	|-RVA: 0x11FD90 Offset: 0x11F190 VA: 0x18011FD90
	|-List.Enumerator<NavMeshBuildSource>.get_Current
	|
	|-RVA: 0x11FF50 Offset: 0x11F350 VA: 0x18011FF50
	|-List.Enumerator<RaycastResult>.get_Current
	|-List.Enumerator<TraceInfo>.get_Current
	|
	|-RVA: 0x2214C0 Offset: 0x2208C0 VA: 0x1802214C0
	|-List.Enumerator<RaycastHit>.get_Current
	|
	|-RVA: 0x149DD0 Offset: 0x1491D0 VA: 0x180149DD0
	|-List.Enumerator<ERSOSection>.get_Current
	|
	|-RVA: 0x11FD40 Offset: 0x11F140 VA: 0x18011FD40
	|-List.Enumerator<ERVSData>.get_Current
	|-List.Enumerator<SqliteKeyReader.KeyInfo>.get_Current
	|
	|-RVA: 0x149E40 Offset: 0x149240 VA: 0x180149E40
	|-List.Enumerator<FoliageGridMeshData.FoliageVertex>.get_Current
	|
	|-RVA: 0x11FDF0 Offset: 0x11F1F0 VA: 0x18011FDF0
	|-List.Enumerator<MeshColliderInstance>.get_Current
	|
	|-RVA: 0x11FF10 Offset: 0x11F310 VA: 0x18011FF10
	|-List.Enumerator<MeshColliderLookup.LookupEntry>.get_Current
	|
	|-RVA: 0x11FE60 Offset: 0x11F260 VA: 0x18011FE60
	|-List.Enumerator<MeshRendererInstance>.get_Current
	|
	|-RVA: 0x10ABA0 Offset: 0x109FA0 VA: 0x18010ABA0
	|-List.Enumerator<char>.get_Current
	|-List.Enumerator<short>.get_Current
	|-List.Enumerator<ushort>.get_Current
	|
	|-RVA: 0x10ABC0 Offset: 0x109FC0 VA: 0x18010ABC0
	|-List.Enumerator<double>.get_Current
	|
	|-RVA: 0x116AE0 Offset: 0x115EE0 VA: 0x180116AE0
	|-List.Enumerator<float>.get_Current
	|
	|-RVA: 0x2214A0 Offset: 0x2208A0 VA: 0x1802214A0
	|-List.Enumerator<RaycastHit2D>.get_Current
	|
	|-RVA: 0x221460 Offset: 0x220860 VA: 0x180221460
	|-List.Enumerator<UIVertex>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E780 Offset: 0x11DB80 VA: 0x18011E780
	|-List.Enumerator<AdvancedChristmasLights.pointEntry>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<AlignedLineDrawer.LinePoint>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Cassette.LoadRequest>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Admin.ServerConvarInfo>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Chat.MuteEntry>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<ERChildsSO>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<ExpandedLifeStats.GenericStatDisplay>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<LocalClock.TimedEvent>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<MapView.MapMarkerCluster>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<MapView.SleepingBagCluster>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<JsonPosition>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<TimelineEvent>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<TickRenderer.Tick>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<InventoryRecipe.Ingredient>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<InventoryRecipe>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<SynchronizedClock.TimedEvent>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<KeyValuePair<object, Color>>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<KeyValuePair<ulong, Dispatch.ResultCallback>>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11E6D0 Offset: 0x11DAD0 VA: 0x18011E6D0
	|-List.Enumerator<AtmosphereVolumeRenderer.CurrentVolumeEntry>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<DamageRenderer.DamageShowingRenderer>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<DeferredExtensionMesh.MaterialLink>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<DeferredMeshDecal.MaterialLink>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<CombineClass>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<ERLane>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<EntityRef<object>>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<TabbedPanel.Tab>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<RCon.BannedAddresses>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<WeightedStringList.Container>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<GameStat.Stat>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<ImageStorageEntity.ImageRequest>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<MagnetCrane.MagnetCraneSnapshot>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<ParticleSystemContainer.ParticleSystemGroup>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<PlayerItemRecipe>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<DemoShotParentKeyframe>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<DemoShotVectorKeyframe>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<ReflectionProbeEx.RenderListEntry>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<MatchMakingKeyValuePair>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Dispatch.Callback>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<DictionaryEntry>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<KeyValuePair<DateTime, object>>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<KeyValuePair<int, object>>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<KeyValuePair<Int32Enum, object>>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<KeyValuePair<object, float>>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<KeyValuePair<uint, object>>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<DateTimeOffset>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Decimal>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Guid>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<ValueTuple<object, object>>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<RangePositionInfo>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<TickInterpolator.Segment>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<NavMeshBuildMarkup>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Color>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Rect>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<GlyphRect>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<FocusController.FocusedElement>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<UILineInfo>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Vector4>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<WindZoneExManager.CurrentZoneEntry>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<WorldSplineData.LUTEntry.LUTPoint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11E4A0 Offset: 0x11D8A0 VA: 0x18011E4A0
	|-List.Enumerator<BaseEntity.ServerFileRequest>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<CardTableUI.KeycodeWithAction>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Demos.DemoInfo>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Output.Entry>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<IconSkinPicker.SkinButtonSetup>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<InvokeAction>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<ItemSkinDirectory.Skin>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<KeyframeView.UIKeyframeValue>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<MidiConvar.KnobBinding>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<MidiConvar.NoteBinding>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<WaypointSet.Waypoint>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<TransformSnapshot>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Option>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<SkinnedMultiMesh.Part>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<SubmarineSonar.SonarBlip>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<SpawnIndividual>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<SpecialPurposeCamera.RenderEntry>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<InventoryItem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11ECE0 Offset: 0x11E0E0 VA: 0x18011ECE0
	|-List.Enumerator<Admin.PlayerInfo>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<PlaceMonuments.SpawnInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11EC10 Offset: 0x11E010 VA: 0x18011EC10
	|-List.Enumerator<Admin.ServerUGCInfo>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<CapsuleParams>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<SkeletonDefinition.Bone>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<ReflectionProbeEx.CubemapSkyboxVertex>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<SteamNewsSource.Story>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<InventoryItem.Amount>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<RenderTargetIdentifier>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<TreeInstance>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<ViewModelDrawEvent>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11E560 Offset: 0x11D960 VA: 0x18011E560
	|-List.Enumerator<CRedge>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<ProjectileWeaponMod.Modifier>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<VectorData>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<TrainCar.TrainCarSnapshot>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Resolution>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<UICharInfo>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Vector3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11E8F0 Offset: 0x11DCF0 VA: 0x18011E8F0
	|-List.Enumerator<ERCell>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<ERConnectionGUIStatus>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<ERTerrainChange>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<NormalPairs>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<BurstCloth.Chain>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<MeshRendererLookup.LookupEntry>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<PathFinder.Point>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<PlayerItemRecipe.Ingredient>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Achievement>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Friend>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<DateTime>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<EventProvider.SessionInfo>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<long>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<TimeSpan>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<ulong>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Vector2i>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1494F0 Offset: 0x1488F0 VA: 0x1801494F0
	|-List.Enumerator<ERMeshCombineUtility.MeshInstance>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<RenderInfo.RendererInstance>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Option>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1493D0 Offset: 0x1487D0 VA: 0x1801493D0
	|-List.Enumerator<ERSOSection>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1491E0 Offset: 0x1485E0 VA: 0x1801491E0
	|-List.Enumerator<ERSplatmap>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11F490 Offset: 0x11E890 VA: 0x18011F490
	|-List.Enumerator<ERVSData>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<SqliteKeyReader.KeyInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11E620 Offset: 0x11DA20 VA: 0x18011E620
	|-List.Enumerator<EngineDamageOverTime.RecentDamage>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<DemoShotFloatKeyframe>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<double>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Vector2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1492C0 Offset: 0x1486C0 VA: 0x1801492C0
	|-List.Enumerator<BoneData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11E9A0 Offset: 0x11DDA0 VA: 0x18011E9A0
	|-List.Enumerator<Tick.Entry>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Gibbable.OverrideMesh>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<MeshInstance>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<PetCommandList.PetCommandDesc>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<PlaceMonumentsOffshore.SpawnInfo>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<PlaceMonumentsRailside.SpawnInfo>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<PlaceMonumentsRoadside.SpawnInfo>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<SubsurfaceProfileTexture.SubsurfaceProfileEntry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1495E0 Offset: 0x1489E0 VA: 0x1801495E0
	|-List.Enumerator<FoliageGridMeshData.FoliageVertex>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11EFE0 Offset: 0x11E3E0 VA: 0x18011EFE0
	|-List.Enumerator<SevenBitNumber>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<bool>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<byte>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<sbyte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11F090 Offset: 0x11E490 VA: 0x18011F090
	|-List.Enumerator<MeshColliderInstance>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11EA60 Offset: 0x11DE60 VA: 0x18011EA60
	|-List.Enumerator<MeshColliderLookup.LookupEntry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11EDB0 Offset: 0x11E1B0 VA: 0x18011EDB0
	|-List.Enumerator<MeshRendererInstance>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11F3D0 Offset: 0x11E7D0 VA: 0x18011F3D0
	|-List.Enumerator<DemoShotQuaternionKeyframe>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11F1C0 Offset: 0x11E5C0 VA: 0x18011F1C0
	|-List.Enumerator<ServerInfo>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<ServerInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11E840 Offset: 0x11DC40 VA: 0x18011E840
	|-List.Enumerator<InventoryDefId>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Int32Enum>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<uint>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Color32>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11EB60 Offset: 0x11DF60 VA: 0x18011EB60
	|-List.Enumerator<char>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<short>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<ushort>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11EF80 Offset: 0x11E380 VA: 0x18011EF80
	|-List.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11EED0 Offset: 0x11E2D0 VA: 0x18011EED0
	|-List.Enumerator<float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11F560 Offset: 0x11E960 VA: 0x18011F560
	|-List.Enumerator<TraceInfo>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<RaycastResult>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11F2D0 Offset: 0x11E6D0 VA: 0x18011F2D0
	|-List.Enumerator<NavMeshBuildSource>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x221290 Offset: 0x220690 VA: 0x180221290
	|-List.Enumerator<RaycastHit2D>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2211C0 Offset: 0x2205C0 VA: 0x1802211C0
	|-List.Enumerator<RaycastHit>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2210D0 Offset: 0x2204D0 VA: 0x1802210D0
	|-List.Enumerator<UIVertex>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11DEE0 Offset: 0x11D2E0 VA: 0x18011DEE0
	|-List.Enumerator<AdvancedChristmasLights.pointEntry>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<AlignedLineDrawer.LinePoint>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Cassette.LoadRequest>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Admin.ServerConvarInfo>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Chat.MuteEntry>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<ERChildsSO>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<ExpandedLifeStats.GenericStatDisplay>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<LocalClock.TimedEvent>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<MapView.MapMarkerCluster>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<MapView.SleepingBagCluster>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<JsonPosition>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<TimelineEvent>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<TickRenderer.Tick>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<InventoryRecipe.Ingredient>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<InventoryRecipe>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<SynchronizedClock.TimedEvent>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<KeyValuePair<object, Color>>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<KeyValuePair<ulong, Dispatch.ResultCallback>>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11E020 Offset: 0x11D420 VA: 0x18011E020
	|-List.Enumerator<AtmosphereVolumeRenderer.CurrentVolumeEntry>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<DamageRenderer.DamageShowingRenderer>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<DeferredExtensionMesh.MaterialLink>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<DeferredMeshDecal.MaterialLink>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<CombineClass>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<ERLane>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<EntityRef<object>>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<TabbedPanel.Tab>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<RCon.BannedAddresses>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<WeightedStringList.Container>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<GameStat.Stat>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<ImageStorageEntity.ImageRequest>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<MagnetCrane.MagnetCraneSnapshot>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<ParticleSystemContainer.ParticleSystemGroup>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<PlayerItemRecipe>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<DemoShotParentKeyframe>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<DemoShotVectorKeyframe>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<ReflectionProbeEx.RenderListEntry>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<MatchMakingKeyValuePair>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Dispatch.Callback>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<DictionaryEntry>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<KeyValuePair<DateTime, object>>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<KeyValuePair<int, object>>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<KeyValuePair<Int32Enum, object>>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<KeyValuePair<object, float>>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<KeyValuePair<uint, object>>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<DateTimeOffset>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Decimal>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Guid>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<ValueTuple<object, object>>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<RangePositionInfo>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<TickInterpolator.Segment>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<NavMeshBuildMarkup>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Color>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Rect>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<GlyphRect>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<FocusController.FocusedElement>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<UILineInfo>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Vector4>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<WindZoneExManager.CurrentZoneEntry>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<WorldSplineData.LUTEntry.LUTPoint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11E130 Offset: 0x11D530 VA: 0x18011E130
	|-List.Enumerator<BaseEntity.ServerFileRequest>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<CardTableUI.KeycodeWithAction>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Demos.DemoInfo>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Output.Entry>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<IconSkinPicker.SkinButtonSetup>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<InvokeAction>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<ItemSkinDirectory.Skin>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<KeyframeView.UIKeyframeValue>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<MidiConvar.KnobBinding>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<MidiConvar.NoteBinding>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<WaypointSet.Waypoint>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<TransformSnapshot>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Option>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<SkinnedMultiMesh.Part>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<SubmarineSonar.SonarBlip>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<SpawnIndividual>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<SpecialPurposeCamera.RenderEntry>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<InventoryItem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11DE90 Offset: 0x11D290 VA: 0x18011DE90
	|-List.Enumerator<Admin.PlayerInfo>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<PlaceMonuments.SpawnInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11E060 Offset: 0x11D460 VA: 0x18011E060
	|-List.Enumerator<Admin.ServerUGCInfo>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<CapsuleParams>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<SkeletonDefinition.Bone>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<ReflectionProbeEx.CubemapSkyboxVertex>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<SteamNewsSource.Story>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<InventoryItem.Amount>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<RenderTargetIdentifier>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<TreeInstance>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<ViewModelDrawEvent>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11E180 Offset: 0x11D580 VA: 0x18011E180
	|-List.Enumerator<CRedge>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<ProjectileWeaponMod.Modifier>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<VectorData>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<TrainCar.TrainCarSnapshot>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Resolution>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<UICharInfo>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Vector3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11DF70 Offset: 0x11D370 VA: 0x18011DF70
	|-List.Enumerator<ERCell>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<ERConnectionGUIStatus>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<ERTerrainChange>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<NormalPairs>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<EngineDamageOverTime.RecentDamage>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<BurstCloth.Chain>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<MeshRendererLookup.LookupEntry>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<PathFinder.Point>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<PlayerItemRecipe.Ingredient>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<DemoShotFloatKeyframe>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Achievement>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Friend>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<DateTime>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<EventProvider.SessionInfo>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<double>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<long>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<object>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<TimeSpan>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<ulong>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Vector2>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Vector2i>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x148F50 Offset: 0x148350 VA: 0x180148F50
	|-List.Enumerator<ERMeshCombineUtility.MeshInstance>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<RenderInfo.RendererInstance>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Option>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x148FB0 Offset: 0x1483B0 VA: 0x180148FB0
	|-List.Enumerator<ERSOSection>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x149000 Offset: 0x148400 VA: 0x180149000
	|-List.Enumerator<ERSplatmap>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11E280 Offset: 0x11D680 VA: 0x18011E280
	|-List.Enumerator<ERVSData>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<SqliteKeyReader.KeyInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x148EE0 Offset: 0x1482E0 VA: 0x180148EE0
	|-List.Enumerator<BoneData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11E1C0 Offset: 0x11D5C0 VA: 0x18011E1C0
	|-List.Enumerator<Tick.Entry>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Gibbable.OverrideMesh>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<MeshInstance>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<PetCommandList.PetCommandDesc>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<PlaceMonumentsOffshore.SpawnInfo>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<PlaceMonumentsRailside.SpawnInfo>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<PlaceMonumentsRoadside.SpawnInfo>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<SubsurfaceProfileTexture.SubsurfaceProfileEntry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x149050 Offset: 0x148450 VA: 0x180149050
	|-List.Enumerator<FoliageGridMeshData.FoliageVertex>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11E0B0 Offset: 0x11D4B0 VA: 0x18011E0B0
	|-List.Enumerator<SevenBitNumber>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<bool>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<byte>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<sbyte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11E320 Offset: 0x11D720 VA: 0x18011E320
	|-List.Enumerator<MeshColliderInstance>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11E3E0 Offset: 0x11D7E0 VA: 0x18011E3E0
	|-List.Enumerator<MeshColliderLookup.LookupEntry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11E210 Offset: 0x11D610 VA: 0x18011E210
	|-List.Enumerator<MeshRendererInstance>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11E2D0 Offset: 0x11D6D0 VA: 0x18011E2D0
	|-List.Enumerator<DemoShotQuaternionKeyframe>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11DFB0 Offset: 0x11D3B0 VA: 0x18011DFB0
	|-List.Enumerator<ServerInfo>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<ServerInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11DF30 Offset: 0x11D330 VA: 0x18011DF30
	|-List.Enumerator<InventoryDefId>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<int>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Int32Enum>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<float>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<uint>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Color32>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11E0F0 Offset: 0x11D4F0 VA: 0x18011E0F0
	|-List.Enumerator<char>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<short>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<ushort>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11E390 Offset: 0x11D790 VA: 0x18011E390
	|-List.Enumerator<TraceInfo>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<RaycastResult>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11E440 Offset: 0x11D840 VA: 0x18011E440
	|-List.Enumerator<NavMeshBuildSource>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x220FD0 Offset: 0x2203D0 VA: 0x180220FD0
	|-List.Enumerator<RaycastHit2D>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x221080 Offset: 0x220480 VA: 0x180221080
	|-List.Enumerator<RaycastHit>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x221020 Offset: 0x220420 VA: 0x180221020
	|-List.Enumerator<UIVertex>.System.Collections.IEnumerator.Reset
	*/

}

public static class List // TypeDefIndex: 4843
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public static void Compare<T, TListA, TListB>(TListA a, TListB b, List<T> added, List<T> removed, List<T> remained) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1573E20 Offset: 0x1572420 VA: 0x181573E20
	|-List.Compare<Connection, List<Connection>, List<Connection>>
	|-List.Compare<Group, ListHashSet<Group>, List<Group>>
	|-List.Compare<object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public static void Compare<TListA, TListB, TItemA, TItemB, TKey>(TListA a, TListB b, HashSet<TKey> added, HashSet<TKey> removed, HashSet<TKey> remained, Func<TItemA, TKey> selectorA, Func<TItemB, TKey> selectorB) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1574180 Offset: 0x1572780 VA: 0x181574180
	|-List.Compare<Dictionary.KeyCollection<ulong, RelationshipManager.PlayerRelationshipInfo>, List<RelationshipManager.PlayerRelationshipInfo>, ulong, RelationshipManager.PlayerRelationshipInfo, ulong>
	|-List.Compare<object, object, ulong, object, ulong>
	|
	|-RVA: 0x1573820 Offset: 0x1571E20 VA: 0x181573820
	|-List.Compare<object, object, object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public static TItem FindWith<TItem, TKey>(IReadOnlyCollection<TItem> items, Func<TItem, TKey> selector, TKey search, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B92F0 Offset: 0x15B78F0 VA: 0x1815B92F0
	|-List.FindWith<Manifest.NewsInfo.BlogInfo, string>
	|-List.FindWith<object, object>
	|
	|-RVA: 0x15B9570 Offset: 0x15B7B70 VA: 0x1815B9570
	|-List.FindWith<MarketTerminal.PendingOrder, uint>
	|-List.FindWith<object, uint>
	|
	|-RVA: 0x15B97F0 Offset: 0x15B7DF0 VA: 0x1815B97F0
	|-List.FindWith<PlayerTeam.TeamMember, ulong>
	|-List.FindWith<object, ulong>
	*/

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public static Nullable<TItem> TryFindWith<TItem, TKey>(IReadOnlyCollection<TItem> items, Func<TItem, TKey> selector, TKey search, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED4990 Offset: 0xED2F90 VA: 0x180ED4990
	|-List.TryFindWith<ImageStorageEntity.ImageRequest, IImageReceiver>
	|-List.TryFindWith<ImageStorageEntity.ImageRequest, object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public static int FindIndexWith<TItem, TKey>(IReadOnlyList<TItem> items, Func<TItem, TKey> selector, TKey search) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11791B0 Offset: 0x11777B0 VA: 0x1811791B0
	|-List.FindIndexWith<object, object>
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	internal static void <Compare>g__InitializeWith|1_0<TListA, TListB, TItemA, TItemB, TKey>(HashSet<TKey> set, HashSet<TKey> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15747E0 Offset: 0x1572DE0 VA: 0x1815747E0
	|-List.<Compare>g__InitializeWith|1_0<object, object, object, object, object>
	|
	|-RVA: 0x15749D0 Offset: 0x1572FD0 VA: 0x1815749D0
	|-List.<Compare>g__InitializeWith|1_0<object, object, ulong, object, ulong>
	*/

}
