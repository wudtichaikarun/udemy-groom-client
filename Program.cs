using Grpc.Net.Client;
using gRoom.gRPC.Messages;

// groomserver project PORT
using var channel = GrpcChannel.ForAddress("http://localhost:5000");
var client = new Groom.GroomClient(channel);
Console.Write("Enter room name to gegister: ");
var roomName = Console.ReadLine();
var resp = client.RegisterToRoom(new RoomRegistrationRequest { RoomName = roomName });
Console.WriteLine($"Room ID: {resp.RoomId}");
Console.Read();