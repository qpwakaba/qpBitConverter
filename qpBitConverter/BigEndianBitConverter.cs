using System;
using System.Collections.Generic;
using System.Text;

namespace qpwakaba
{
    public class BigEndianBitConverter : IBitConverter
    {
        private static readonly BigEndianBitConverter Instance = new BigEndianBitConverter();
        private BigEndianBitConverter() { }
        public static BigEndianBitConverter GetInstance() => Instance;

        public byte[] GetBytes(long value)
        {
            byte[] bytes = new byte[sizeof(long)];
            for (int i = sizeof(long) - 1; i >= 0; --i)
            {
                bytes[sizeof(long) - i - 1] = (byte) (value >> (i * 8));
            }
            return bytes;
        }
        public byte[] GetBytes(int value)
        {
            byte[] bytes = new byte[sizeof(int)];
            for (int i = sizeof(int) - 1; i >= 0; --i)
            {
                bytes[sizeof(int) - i - 1] = (byte) (value >> (i * 8));
            }
            return bytes;
        }
        public byte[] GetBytes(short value)
        {
            byte[] bytes = new byte[sizeof(short)];
            for (int i = sizeof(short) - 1; i >= 0; --i)
            {
                bytes[sizeof(short) - i - 1] = (byte) (value >> (i * 8));
            }
            return bytes;
        }
        public byte[] GetBytes(ulong value)
        {
            byte[] bytes = new byte[sizeof(ulong)];
            for (int i = sizeof(ulong) - 1; i >= 0; --i)
            {
                bytes[sizeof(ulong) - i - 1] = (byte) (value >> (i * 8));
            }
            return bytes;
        }
        public byte[] GetBytes(uint value)
        {
            byte[] bytes = new byte[sizeof(uint)];
            for (int i = sizeof(uint) - 1; i >= 0; --i)
            {
                bytes[sizeof(uint) - i - 1] = (byte) (value >> (i * 8));
            }
            return bytes;
        }
        public byte[] GetBytes(ushort value)
        {
            byte[] bytes = new byte[sizeof(ushort)];
            for (int i = sizeof(ushort) - 1; i >= 0; --i)
            {
                bytes[sizeof(ushort) - i - 1] = (byte) (value >> (i * 8));
            }
            return bytes;
        }
        public byte[] GetBytes(double value)
        {
            unsafe
            {
                var ptr = (long*) &value;
                return GetBytes(*ptr);
            }
        }
        public byte[] GetBytes(float value)
        {
            unsafe
            {
                var ptr = (int*) &value;
                return GetBytes(*ptr);
            }
        }
        public byte[] GetBytes(char value)
        {
            byte[] bytes = new byte[sizeof(char)];
            for (int i = sizeof(char) - 1; i >= 0; --i)
            {
                bytes[sizeof(char) - i - 1] = (byte) (value >> (i * 8));
            }
            return bytes;
        }
        public byte[] GetBytes(bool value)
        {
            byte[] bytes = new byte[1];
            bytes[0] = (byte) (value ? 1 : 0);
            return bytes;
        }
        public void WriteBytes(long value, byte[] to, int offset)
        {
            for (int i = sizeof(long) - 1; i >= 0; --i)
            {
                to[sizeof(long) - i - 1 + offset] = (byte) (value >> (i * 8));
            }
        }
        public void WriteBytes(int value, byte[] to, int offset)
        {
            for (int i = sizeof(int) - 1; i >= 0; --i)
            {
                to[sizeof(int) - i - 1 + offset] = (byte) (value >> (i * 8));
            }
        }
        public void WriteBytes(short value, byte[] to, int offset)
        {
            for (int i = sizeof(short) - 1; i >= 0; --i)
            {
                to[sizeof(short) - i - 1 + offset] = (byte) (value >> (i * 8));
            }
        }
        public void WriteBytes(ulong value, byte[] to, int offset)
        {
            for (int i = sizeof(ulong) - 1; i >= 0; --i)
            {
                to[sizeof(ulong) - i - 1 + offset] = (byte) (value >> (i * 8));
            }
        }
        public void WriteBytes(uint value, byte[] to, int offset)
        {
            for (int i = sizeof(uint) - 1; i >= 0; --i)
            {
                to[sizeof(uint) - i - 1 + offset] = (byte) (value >> (i * 8));
            }
        }
        public void WriteBytes(ushort value, byte[] to, int offset)
        {
            for (int i = sizeof(ushort) - 1; i >= 0; --i)
            {
                to[sizeof(ushort) - i - 1 + offset] = (byte) (value >> (i * 8));
            }
        }
        public void WriteBytes(double value, byte[] to, int offset)
        {
            unsafe
            {
                var ptr = (long*) &value;
                WriteBytes(*ptr, to, offset);
            }
        }
        public void WriteBytes(float value, byte[] to, int offset)
        {
            unsafe
            {
                var ptr = (int*) &value;
                WriteBytes(*ptr, to, offset);
            }
        }
        public void WriteBytes(char value, byte[] to, int offset)
        {
            for (int i = sizeof(char) - 1; i >= 0; --i)
            {
                to[sizeof(char) - i - 1 + offset] = (byte) (value >> (i * 8));
            }
        }
        public void WriteBytes(bool value, byte[] to, int offset)
        {
            to[offset] = (byte) (value ? 1 : 0);
        }
        public bool ToBoolean(byte[] bytes, int offset)
        {
            return bytes[0 + offset] != 0 ? true : false;
        }

        public bool ToBoolean(byte[] b) => ToBoolean(b, 0);

        public char ToChar(byte[] bytes, int offset)
        {
            char value = (char) 0;
            for (int i = sizeof(char) - 1; i >= 0; --i)
            {
                value |= (char) (bytes[sizeof(char) - i - 1 + offset] << (i * 8));
            }
            return value;
        }

        public char ToChar(byte[] b) => ToChar(b, 0);

        public double ToDouble(byte[] bytes, int offset)
        {
            unsafe
            {
                long l = ToInt64(bytes, offset);
                return *(double*) &l;
            }
        }

        public double ToDouble(byte[] b) => ToDouble(b, 0);

        public float ToFloat(byte[] bytes, int offset)
        {
            unsafe
            {
                int i = ToInt32(bytes, offset);
                return *(float*) &i;
            }
        }

        public float ToFloat(byte[] b) => ToFloat(b, 0);

        public short ToInt16(byte[] bytes, int offset)
        {
            short value = 0;
            for (int i = sizeof(short) - 1; i >= 0; --i)
            {
                value |= (short) (bytes[sizeof(short) - i - 1 + offset] << (i * 8));
            }
            return value;
        }

        public short ToInt16(byte[] b) => ToInt16(b, 0);

        public int ToInt32(byte[] bytes, int offset)
        {
            int value = 0;
            for (int i = sizeof(int) - 1; i >= 0; --i)
            {
                value |= (int) bytes[sizeof(int) - i - 1 + offset] << (i * 8);
            }
            return value;
        }

        public int ToInt32(byte[] b) => ToInt32(b, 0);

        public long ToInt64(byte[] bytes, int offset)
        {
            long value = 0;
            for (int i = sizeof(long) - 1; i >= 0; --i)
            {
                value |= ((long) bytes[sizeof(long) - i - 1 + offset]) << (i * 8);
            }
            return value;
        }

        public long ToInt64(byte[] b) => ToInt64(b, 0);

        public ushort ToUInt16(byte[] bytes, int offset)
        {
            ushort value = 0;
            for (int i = sizeof(ushort) - 1; i >= 0; --i)
            {
                value |= (ushort) (bytes[sizeof(ushort) - i - 1 + offset] << (i * 8));
            }
            return value;
        }

        public ushort ToUInt16(byte[] b) => ToUInt16(b, 0);

        public uint ToUInt32(byte[] bytes, int offset)
        {
            uint value = 0;
            for (int i = sizeof(uint) - 1; i >= 0; --i)
            {
                value |= (uint) bytes[sizeof(uint) - i - 1 + offset] << (i * 8);
            }
            return value;
        }

        public uint ToUInt32(byte[] b) => ToUInt32(b, 0);

        public ulong ToUInt64(byte[] bytes, int offset)
        {
            ulong value = 0;
            for (int i = sizeof(ulong) - 1; i >= 0; --i)
            {
                value |= ((ulong) bytes[sizeof(ulong) - i - 1 + offset]) << (i * 8);
            }
            return value;
        }

        public ulong ToUInt64(byte[] b) => ToUInt64(b, 0);

#if SPAN_USABLE
        public void WriteBytes(long value, Span<byte> to){
            for (int i = sizeof(long) - 1; i >= 0; --i)
            {
                to[sizeof(long) - i - 1] = (byte) (value >> (i * 8));
            }
        }
        public void WriteBytes(int value, Span<byte> to)
        {
            for (int i = sizeof(int) - 1; i >= 0; --i)
            {
                to[sizeof(int) - i - 1] = (byte) (value >> (i * 8));
            }
        }
        public void WriteBytes(short value, Span<byte> to)
        {
            for (int i = sizeof(short) - 1; i >= 0; --i)
            {
                to[sizeof(short) - i - 1] = (byte) (value >> (i * 8));
            }
        }
        public void WriteBytes(ulong value, Span<byte> to)
        {
            for (int i = sizeof(ulong) - 1; i >= 0; --i)
            {
                to[sizeof(ulong) - i - 1] = (byte) (value >> (i * 8));
            }
        }
        public void WriteBytes(uint value, Span<byte> to)
        {
            for (int i = sizeof(uint) - 1; i >= 0; --i)
            {
                to[sizeof(uint) - i - 1] = (byte) (value >> (i * 8));
            }
        }
        public void WriteBytes(ushort value, Span<byte> to)
        {
            for (int i = sizeof(ushort) - 1; i >= 0; --i)
            {
                to[sizeof(ushort) - i - 1] = (byte) (value >> (i * 8));
            }
        }
        public void WriteBytes(double value, Span<byte> to)
        {
            unsafe
            {
                var ptr = (long*) &value;
                WriteBytes(*ptr, to);
            }
        }
        public void WriteBytes(float value, Span<byte> to)
        {
            unsafe
            {
                var ptr = (int*) &value;
                WriteBytes(*ptr, to);
            }
        }
        public void WriteBytes(char value, Span<byte> to)
        {
            for (int i = sizeof(char) - 1; i >= 0; --i)
            {
                to[sizeof(char) - i - 1] = (byte) (value >> (i * 8));
            }
        }
        public void WriteBytes(bool value, Span<byte> to)
        {
            to[0] = (byte) (value ? 1 : 0);
        }
        public long ToInt64(Span<byte> bytes)
        {
            long value = 0;
            for (int i = sizeof(long) - 1; i >= 0; --i)
            {
                value |= ((long) bytes[sizeof(long) - i - 1]) << (i * 8);
            }
            return value;
        }
        public int ToInt32(Span<byte> bytes)
        {
            int value = 0;
            for (int i = sizeof(int) - 1; i >= 0; --i)
            {
                value |= (int) bytes[sizeof(int) - i - 1] << (i * 8);
            }
            return value;
        }
        public short ToInt16(Span<byte> bytes)
        {
            short value = 0;
            for (int i = sizeof(short) - 1; i >= 0; --i)
            {
                value |= (short) (bytes[sizeof(short) - i - 1] << (i * 8));
            }
            return value;
        }
        public ulong ToUInt64(Span<byte> bytes)
        {
            ulong value = 0;
            for (int i = sizeof(ulong) - 1; i >= 0; --i)
            {
                value |= ((ulong) bytes[sizeof(ulong) - i - 1]) << (i * 8);
            }
            return value;
        }
        public uint ToUInt32(Span<byte> bytes)
        {
            uint value = 0;
            for (int i = sizeof(uint) - 1; i >= 0; --i)
            {
                value |= (uint) bytes[sizeof(uint) - i - 1] << (i * 8);
            }
            return value;
        }
        public ushort ToUInt16(Span<byte> bytes)
        {
            ushort value = 0;
            for (int i = sizeof(ushort) - 1; i >= 0; --i)
            {
                value |= (ushort) (bytes[sizeof(ushort) - i - 1] << (i * 8));
            }
            return value;
        }
        public double ToDouble(Span<byte> bytes)
        {
            unsafe
            {
                long l = ToInt64(bytes);
                return *(double*) &l;
            }
        }
        public float ToFloat(Span<byte> bytes)
        {
            unsafe
            {
                int i = ToInt32(bytes);
                return *(float*) &i;
            }
        }
        public char ToChar(Span<byte> bytes)
        {
            char value = (char) 0;
            for (int i = sizeof(char) - 1; i >= 0; --i)
            {
                value |= (char) (bytes[sizeof(char) - i - 1] << (i * 8));
            }
            return value;
        }
        public bool ToBoolean(Span<byte> bytes)
        {
            return bytes[0] != 0 ? true : false;
        }
#endif
    }
}
