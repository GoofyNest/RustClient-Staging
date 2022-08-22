internal static class ThrowHelper // TypeDefIndex: 124
{	// Methods

	// RVA: 0x160EA40 Offset: 0x160D040 VA: 0x18160EA40
	internal static void ThrowArgumentNullException(ExceptionArgument argument) { }

	// RVA: 0x160E230 Offset: 0x160C830 VA: 0x18160E230
	private static Exception CreateArgumentNullException(ExceptionArgument argument) { }

	// RVA: 0x160EBD0 Offset: 0x160D1D0 VA: 0x18160EBD0
	internal static void ThrowArrayTypeMismatchException_ArrayTypeMustBeExactMatch(Type type) { }

	// RVA: 0x160E370 Offset: 0x160C970 VA: 0x18160E370
	private static Exception CreateArrayTypeMismatchException_ArrayTypeMustBeExactMatch(Type type) { }

	// RVA: 0x160E990 Offset: 0x160CF90 VA: 0x18160E990
	internal static void ThrowArgumentException_InvalidTypeWithPointersNotSupported(Type type) { }

	// RVA: 0x160E1C0 Offset: 0x160C7C0 VA: 0x18160E1C0
	private static Exception CreateArgumentException_InvalidTypeWithPointersNotSupported(Type type) { }

	// RVA: 0x160EC10 Offset: 0x160D210 VA: 0x18160EC10
	internal static void ThrowIndexOutOfRangeException() { }

	// RVA: 0x160E3E0 Offset: 0x160C9E0 VA: 0x18160E3E0
	private static Exception CreateIndexOutOfRangeException() { }

	// RVA: 0x160EB70 Offset: 0x160D170 VA: 0x18160EB70
	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument) { }

	// RVA: 0x160E2D0 Offset: 0x160C8D0 VA: 0x18160E2D0
	private static Exception CreateArgumentOutOfRangeException(ExceptionArgument argument) { }

	// RVA: 0x160EBB0 Offset: 0x160D1B0 VA: 0x18160EBB0
	internal static void ThrowArgumentOutOfRangeException() { }

	// RVA: 0x160ED80 Offset: 0x160D380 VA: 0x18160ED80
	internal static void ThrowWrongValueTypeArgumentException(object value, Type targetType) { }

	// RVA: 0x160ECC0 Offset: 0x160D2C0 VA: 0x18160ECC0
	internal static void ThrowKeyNotFoundException() { }

	// RVA: 0x160E9D0 Offset: 0x160CFD0 VA: 0x18160E9D0
	internal static void ThrowArgumentException(ExceptionResource resource) { }

	// RVA: 0x160EA80 Offset: 0x160D080 VA: 0x18160EA80
	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument, ExceptionResource resource) { }

	// RVA: 0x160EC50 Offset: 0x160D250 VA: 0x18160EC50
	internal static void ThrowInvalidOperationException(ExceptionResource resource) { }

	// RVA: 0x160ED10 Offset: 0x160D310 VA: 0x18160ED10
	internal static void ThrowNotSupportedException(ExceptionResource resource) { }

	// RVA: -1 Offset: -1
	internal static void IfNullAndNullsAreIllegalThenThrow<T>(object value, ExceptionArgument argName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D4470 Offset: 0x5D2A70 VA: 0x1805D4470
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

	// RVA: 0x160E430 Offset: 0x160CA30 VA: 0x18160E430
	internal static string GetArgumentName(ExceptionArgument argument) { }

	// RVA: 0x160E620 Offset: 0x160CC20 VA: 0x18160E620
	internal static string GetResourceName(ExceptionResource resource) { }

}

internal static class ThrowHelper // TypeDefIndex: 6726
{
// Namespace: System
internal static class ThrowHelper // TypeDefIndex: 6726
	// Methods

	// RVA: 0x231BAD0 Offset: 0x231A0D0 VA: 0x18231BAD0
	internal static void ThrowArrayTypeMismatchException() { }

	// RVA: 0x231B970 Offset: 0x2319F70 VA: 0x18231B970
	private static Exception CreateArrayTypeMismatchException() { }

	// RVA: 0x231BA50 Offset: 0x231A050 VA: 0x18231BA50
	internal static void ThrowArgumentException_InvalidTypeWithPointersNotSupported(Type type) { }

	// RVA: 0x231B6C0 Offset: 0x2319CC0 VA: 0x18231B6C0
	private static Exception CreateArgumentException_InvalidTypeWithPointersNotSupported(Type type) { }

	// RVA: 0x231BA10 Offset: 0x231A010 VA: 0x18231BA10
	internal static void ThrowArgumentException_DestinationTooShort() { }

	// RVA: 0x231B5F0 Offset: 0x2319BF0 VA: 0x18231B5F0
	private static Exception CreateArgumentException_DestinationTooShort() { }

	// RVA: 0x231BB10 Offset: 0x231A110 VA: 0x18231BB10
	internal static void ThrowIndexOutOfRangeException() { }

	// RVA: 0x231B9C0 Offset: 0x2319FC0 VA: 0x18231B9C0
	private static Exception CreateIndexOutOfRangeException() { }

	// RVA: 0x231BA90 Offset: 0x231A090 VA: 0x18231BA90
	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument) { }

	// RVA: 0x231B8D0 Offset: 0x2319ED0 VA: 0x18231B8D0
	private static Exception CreateArgumentOutOfRangeException(ExceptionArgument argument) { }

}

internal static class ThrowHelper // TypeDefIndex: 7083
{	// Methods

	// RVA: 0x23132B0 Offset: 0x23118B0 VA: 0x1823132B0
	internal static void ThrowArgumentNullException(ExceptionArgument argument) { }

	// RVA: 0x23132F0 Offset: 0x23118F0 VA: 0x1823132F0
	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument) { }

	// RVA: 0x23131F0 Offset: 0x23117F0 VA: 0x1823131F0
	private static ArgumentNullException GetArgumentNullException(ExceptionArgument argument) { }

	// RVA: 0x2313250 Offset: 0x2311850 VA: 0x182313250
	private static ArgumentOutOfRangeException GetArgumentOutOfRangeException(ExceptionArgument argument) { }

	// RVA: 0x2313170 Offset: 0x2311770 VA: 0x182313170
	private static string GetArgumentName(ExceptionArgument argument) { }

}

