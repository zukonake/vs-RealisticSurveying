using Vintagestory.API.MathTools;
using ProtoBuf;

namespace RealisticSurveying;

[ProtoContract]
public struct Node
{
    [ProtoMember(1)] public Vec3f Pos;
    [ProtoMember(2)] public string? Label;
}

[ProtoContract]
public struct Edge
{
    // Indices into Nodes list
    [ProtoMember(1)] public int A;
    [ProtoMember(2)] public int B;
}

[ProtoContract]
public struct Face
{
    // Indices into Nodes list
    [ProtoMember(1)] public int A;
    [ProtoMember(2)] public int B;
    [ProtoMember(3)] public int C;
}

[ProtoContract]
public class Stroke
{
    [ProtoMember(1)] public int Color;
    [ProtoMember(2)] public float Width;
    [ProtoMember(3)] public List<Vec3f> Pts = [];
}

[ProtoContract]
public class MapData
{
    // Should be bumped on breaking changes, used to migrate old data
    [ProtoMember(1)] public int Version = 0;
    [ProtoMember(2)] public Vec3i? OriginPos;
    [ProtoMember(3)] public string? Name;
    [ProtoMember(4)] public List<Node> Nodes = [];
    [ProtoMember(5)] public List<Edge> Edges = [];
    [ProtoMember(6)] public List<Face> Faces = [];
    [ProtoMember(7)] public List<Stroke> Strokes = [];
}
