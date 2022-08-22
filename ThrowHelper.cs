internal static class ThrowHelper // TypeDefIndex: 124
{	// Methods

	// RVA: 0x15FBD60 Offset: 0x15FA360 VA: 0x1815FBD60
	internal static void ThrowArgumentNullException(ExceptionArgument argument) { }

	// RVA: 0x15FB550 Offset: 0x15F9B50 VA: 0x1815FB550
	private static Exception CreateArgumentNullException(ExceptionArgument argument) { }

	// RVA: 0x15FBEF0 Offset: 0x15FA4F0 VA: 0x1815FBEF0
	internal static void ThrowArrayTypeMismatchException_ArrayTypeMustBeExactMatch(Type type) { }

	// RVA: 0x15FB690 Offset: 0x15F9C90 VA: 0x1815FB690
	private static Exception CreateArrayTypeMismatchException_ArrayTypeMustBeExactMatch(Type type) { }

	// RVA: 0x15FBCB0 Offset: 0x15FA2B0 VA: 0x1815FBCB0
	internal static void ThrowArgumentException_InvalidTypeWithPointersNotSupported(Type type) { }

	// RVA: 0x15FB4E0 Offset: 0x15F9AE0 VA: 0x1815FB4E0
	private static Exception CreateArgumentException_InvalidTypeWithPointersNotSupported(Type type) { }

	// RVA: 0x15FBF30 Offset: 0x15FA530 VA: 0x1815FBF30
	internal static void ThrowIndexOutOfRangeException() { }

	// RVA: 0x15FB700 Offset: 0x15F9D00 VA: 0x1815FB700
	private static Exception CreateIndexOutOfRangeException() { }

	// RVA: 0x15FBE90 Offset: 0x15FA490 VA: 0x1815FBE90
	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument) { }

	// RVA: 0x15FB5F0 Offset: 0x15F9BF0 VA: 0x1815FB5F0
	private static Exception CreateArgumentOutOfRangeException(ExceptionArgument argument) { }

	// RVA: 0x15FBED0 Offset: 0x15FA4D0 VA: 0x1815FBED0
	internal static void ThrowArgumentOutOfRangeException() { }

	// RVA: 0x15FC0A0 Offset: 0x15FA6A0 VA: 0x1815FC0A0
	internal static void ThrowWrongValueTypeArgumentException(object value, Type targetType) { }

	// RVA: 0x15FBFE0 Offset: 0x15FA5E0 VA: 0x1815FBFE0
	internal static void ThrowKeyNotFoundException() { }

	// RVA: 0x15FBCF0 Offset: 0x15FA2F0 VA: 0x1815FBCF0
	internal static void ThrowArgumentException(ExceptionResource resource) { }

	// RVA: 0x15FBDA0 Offset: 0x15FA3A0 VA: 0x1815FBDA0
	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument, ExceptionResource resource) { }

	// RVA: 0x15FBF70 Offset: 0x15FA570 VA: 0x1815FBF70
	internal static void ThrowInvalidOperationException(ExceptionResource resource) { }

	// RVA: 0x15FC030 Offset: 0x15FA630 VA: 0x1815FC030
	internal static void ThrowNotSupportedException(ExceptionResource resource) { }

	// RVA: -1 Offset: -1
	internal static void IfNullAndNullsAreIllegalThenThrow<T>(object value, ExceptionArgument argName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D4400 Offset: 0x5D2A00 VA: 0x1805D4400
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<AdvancedChristmasLights.pointEntry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<AlignedLineDrawer.LinePoint>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<AtmosphereVolumeRenderer.CurrentVolumeEntry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<BaseEntity.ServerFileRequest>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<CardTableUI.KeycodeWithAction>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Cassette.LoadRequest>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Admin.PlayerInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Admin.ServerConvarInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Admin.ServerUGCInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Chat.MuteEntry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DamageRenderer.DamageShowingRenderer>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DeferredExtensionMesh.MaterialLink>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DeferredMeshDecal.MaterialLink>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Demos.DemoInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<CRedge>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<CombineClass>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ERCell>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ERChildsSO>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ERConnectionGUIStatus>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ERLane>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ERMeshCombineUtility.MeshInstance>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ERSOSection>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ERSplatmap>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ERTerrainChange>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ERVSData>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<NormalPairs>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<EngineDamageOverTime.RecentDamage>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<EntityRef<object>>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ExpandedLifeStats.GenericStatDisplay>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<BurstCloth.Chain>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<CapsuleParams>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<BoneData>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TabbedPanel.Tab>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Output.Entry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RCon.BannedAddresses>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SkeletonDefinition.Bone>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Tick.Entry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RenderInfo.RendererInstance>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<WeightedStringList.Container>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<FoliageGridMeshData.FoliageVertex>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Option>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<GameStat.Stat>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Gibbable.OverrideMesh>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<IconSkinPicker.SkinButtonSetup>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ImageStorageEntity.ImageRequest>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<InvokeAction>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ItemSkinDirectory.Skin>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyframeView.UIKeyframeValue>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<LocalClock.TimedEvent>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MagnetCrane.MagnetCraneSnapshot>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MapView.MapMarkerCluster>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MapView.SleepingBagCluster>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SevenBitNumber>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MeshColliderInstance>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MeshColliderLookup.LookupEntry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MeshInstance>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MeshRendererInstance>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MeshRendererLookup.LookupEntry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MidiConvar.KnobBinding>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MidiConvar.NoteBinding>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SqliteKeyReader.KeyInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<JsonPosition>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ParticleSystemContainer.ParticleSystemGroup>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<PathFinder.Point>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<PetCommandList.PetCommandDesc>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<PlaceMonuments.SpawnInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<PlaceMonumentsOffshore.SpawnInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<PlaceMonumentsRailside.SpawnInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<PlaceMonumentsRoadside.SpawnInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<PlayerItemRecipe.Ingredient>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<PlayerItemRecipe>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ProjectileWeaponMod.Modifier>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DemoShotFloatKeyframe>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DemoShotParentKeyframe>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DemoShotQuaternionKeyframe>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DemoShotVectorKeyframe>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<VectorData>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ReflectionProbeEx.CubemapSkyboxVertex>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ReflectionProbeEx.RenderListEntry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<WaypointSet.Waypoint>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TransformSnapshot>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TimelineEvent>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Option>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TickRenderer.Tick>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ServerInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SkinnedMultiMesh.Part>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SubmarineSonar.SonarBlip>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SpawnIndividual>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SpecialPurposeCamera.RenderEntry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SteamNewsSource.Story>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Achievement>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<InventoryDefId>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<MatchMakingKeyValuePair>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ServerInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Dispatch.Callback>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Friend>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<InventoryItem.Amount>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<InventoryItem>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<InventoryRecipe.Ingredient>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<InventoryRecipe>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SubsurfaceProfileTexture.SubsurfaceProfileEntry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<SynchronizedClock.TimedEvent>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<bool>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<byte>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<char>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DictionaryEntry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<DateTime, object>>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<int, object>>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<Int32Enum, object>>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<object, object>>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<object, float>>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<object, Color>>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<uint, object>>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<KeyValuePair<ulong, Dispatch.ResultCallback>>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DateTime>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<DateTimeOffset>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Decimal>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<EventProvider.SessionInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<double>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Guid>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<short>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<int>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Int32Enum>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<long>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<sbyte>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<float>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TimeSpan>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ushort>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<uint>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ulong>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ValueTuple<object, object>>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RangePositionInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TickInterpolator.Segment>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TraceInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TrainCar.TrainCarSnapshot>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<NavMeshBuildMarkup>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<NavMeshBuildSource>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<BeforeRenderHelper.OrderBlock>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Color32>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Color>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RaycastResult>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RaycastHit2D>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RaycastHit>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Rect>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<RenderTargetIdentifier>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Resolution>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<GlyphRect>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TreeInstance>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<UICharInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<FocusController.FocusedElement>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<UILineInfo>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<UIVertex>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<UnitySynchronizationContext.WorkRequest>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Vector2>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Vector3>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Vector4>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Vector2i>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<ViewModelDrawEvent>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<WindZoneExManager.CurrentZoneEntry>
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<WorldSplineData.LUTEntry.LUTPoint>
	|
	|-RVA: 0x48BD30 Offset: 0x48A330 VA: 0x18048BD30
	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<object>
	*/

	// RVA: 0x15FB750 Offset: 0x15F9D50 VA: 0x1815FB750
	internal static string GetArgumentName(ExceptionArgument argument) { }

	// RVA: 0x15FB940 Offset: 0x15F9F40 VA: 0x1815FB940
	internal static string GetResourceName(ExceptionResource resource) { }

}

internal static class ThrowHelper // TypeDefIndex: 6726
{
// Namespace: System
internal static class ThrowHelper // TypeDefIndex: 6726
	// Methods

	// RVA: 0x231C2F0 Offset: 0x231A8F0 VA: 0x18231C2F0
	internal static void ThrowArrayTypeMismatchException() { }

	// RVA: 0x231C190 Offset: 0x231A790 VA: 0x18231C190
	private static Exception CreateArrayTypeMismatchException() { }

	// RVA: 0x231C270 Offset: 0x231A870 VA: 0x18231C270
	internal static void ThrowArgumentException_InvalidTypeWithPointersNotSupported(Type type) { }

	// RVA: 0x231BEE0 Offset: 0x231A4E0 VA: 0x18231BEE0
	private static Exception CreateArgumentException_InvalidTypeWithPointersNotSupported(Type type) { }

	// RVA: 0x231C230 Offset: 0x231A830 VA: 0x18231C230
	internal static void ThrowArgumentException_DestinationTooShort() { }

	// RVA: 0x231BE10 Offset: 0x231A410 VA: 0x18231BE10
	private static Exception CreateArgumentException_DestinationTooShort() { }

	// RVA: 0x231C330 Offset: 0x231A930 VA: 0x18231C330
	internal static void ThrowIndexOutOfRangeException() { }

	// RVA: 0x231C1E0 Offset: 0x231A7E0 VA: 0x18231C1E0
	private static Exception CreateIndexOutOfRangeException() { }

	// RVA: 0x231C2B0 Offset: 0x231A8B0 VA: 0x18231C2B0
	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument) { }

	// RVA: 0x231C0F0 Offset: 0x231A6F0 VA: 0x18231C0F0
	private static Exception CreateArgumentOutOfRangeException(ExceptionArgument argument) { }

}

internal static class ThrowHelper // TypeDefIndex: 7083
{	// Methods

	// RVA: 0x2313AD0 Offset: 0x23120D0 VA: 0x182313AD0
	internal static void ThrowArgumentNullException(ExceptionArgument argument) { }

	// RVA: 0x2313B10 Offset: 0x2312110 VA: 0x182313B10
	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument) { }

	// RVA: 0x2313A10 Offset: 0x2312010 VA: 0x182313A10
	private static ArgumentNullException GetArgumentNullException(ExceptionArgument argument) { }

	// RVA: 0x2313A70 Offset: 0x2312070 VA: 0x182313A70
	private static ArgumentOutOfRangeException GetArgumentOutOfRangeException(ExceptionArgument argument) { }

	// RVA: 0x2313990 Offset: 0x2311F90 VA: 0x182313990
	private static string GetArgumentName(ExceptionArgument argument) { }

}

