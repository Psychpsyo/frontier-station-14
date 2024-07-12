using Robust.Shared.Configuration;

namespace Content.Shared.NF14.CCVar;

[CVarDefs]
public sealed class NF14CVars
{
    /// <summary>
    /// Whether or not respawning is enabled.
    /// </summary>
    public static readonly CVarDef<bool> RespawnEnabled =
        CVarDef.Create("nf14.respawn.enabled", true, CVar.SERVER | CVar.REPLICATED);

    /// <summary>
    /// Respawn time, how long the player has to wait in seconds after death.
    /// </summary>
    public static readonly CVarDef<float> RespawnTime =
        CVarDef.Create("nf14.respawn.time", 1200.0f, CVar.SERVER | CVar.REPLICATED);

    /// <summary>
    /// Whether or not returning from cryosleep is enabled.
    /// </summary>
    public static readonly CVarDef<bool> CryoReturnEnabled =
        CVarDef.Create("nf14.uncryo.enabled", true, CVar.SERVER | CVar.REPLICATED);

    /// <summary>
    /// The time in seconds after which a cryosleeping body is considered expired and can be deleted from the storage map.
    /// </summary>
    public static readonly CVarDef<float> CryoExpirationTime =
        CVarDef.Create("nf14.uncryo.maxtime", 180 * 60f, CVar.SERVER | CVar.REPLICATED);

    /*
     *  Public Transit
     */
    /// <summary>
    /// Whether public transit is enabled.
    /// </summary>
    public static readonly CVarDef<bool> PublicTransit =
        CVarDef.Create("nf14.publictransit.enabled", true, CVar.SERVERONLY);

    /// <summary>
    /// The map to use for the public bus.
    /// </summary>
    public static readonly CVarDef<string> PublicTransitBusMap =
        CVarDef.Create("nf14.publictransit.bus_map", "/Maps/_NF/Shuttles/Bus/publicts.yml", CVar.SERVERONLY);

    /// <summary>
    /// The amount of time the bus waits at a station.
    /// </summary>
    public static readonly CVarDef<float> PublicTransitWaitTime =
        CVarDef.Create("nf14.publictransit.wait_time", 180f, CVar.SERVERONLY);

    /// <summary>
    /// The amount of time the flies through FTL space.
    /// </summary>
    public static readonly CVarDef<float> PublicTransitFlyTime =
        CVarDef.Create("nf14.publictransit.fly_time", 50f, CVar.SERVERONLY);

    /*
     *  World Gen
     */
    /// <summary>
    /// The number of Trade Stations to spawn in every round
    /// </summary>
    public static readonly CVarDef<int> MarketStations =
        CVarDef.Create("nf14.worldgen.market_stations", 1, CVar.SERVERONLY);

    /// <summary>
    /// The number of Cargo Depots to spawn in every round
    /// </summary>
    public static readonly CVarDef<int> CargoDepots =
        CVarDef.Create("nf14.worldgen.cargo_depots", 2, CVar.SERVERONLY);

    /// <summary>
    /// The number of Optional Points Of Interest to spawn in every round
    /// </summary>
    public static readonly CVarDef<int> OptionalPOIs =
        CVarDef.Create("nf14.worldgen.optional_pois", 8, CVar.SERVERONLY);

    /// <summary>
    /// The multiplier to add to distance spawning calculations
    /// </summary>
    public static readonly CVarDef<float> POIDistanceModifier =
        CVarDef.Create("nf14.worldgen.distance_modifier", 1f, CVar.SERVERONLY);
}
