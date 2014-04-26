using System;
using System.Net;
using Alchemy.Handlers.WebSocket;

namespace Alchemy.Classes
{
	public interface IUserContext
	{
		Header Header { get; }
		ulong MaxFrameSize { get; set; }
		EndPoint ClientAddress { get; set; }
		DataFrame DataFrame  { get; set; }

		Exception LatestException { get; set; }


		Protocol Protocol { get; set; }
		string RequestPath { get; set; }

		void OnConnect();
		void OnConnected();
		void OnDisconnect();
		void OnReceive();
		void OnSend();
		void Send(DataFrame dataFrame, bool raw = false, bool close = false);
		void Send(byte[] someBytes, bool raw = false, bool close = false);
		void Send(string aString, bool raw = false, bool close = false);
		void SetOnConnect(OnEventDelegate aDelegate);
		void SetOnConnected(OnEventDelegate aDelegate);
		void SetOnDisconnect(OnEventDelegate aDelegate);
		void SetOnReceive(OnEventDelegate aDelegate);
		void SetOnSend(OnEventDelegate aDelegate);
		Boolean Connected { get; }
		void Close();
	}
}
