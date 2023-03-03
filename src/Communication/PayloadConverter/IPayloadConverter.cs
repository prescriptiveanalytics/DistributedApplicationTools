﻿namespace DAT.Communication {
  public interface IPayloadConverter {
    byte[] Serialize<T>(T payload);

    T Deserialize<T>(byte[] payload);

    object Deserialize(byte[] payload, Type type = null);

  }
}
