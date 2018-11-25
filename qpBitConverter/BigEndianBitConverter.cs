using System;
using System.Collections.Generic;
using System.Text;

namespace qpwakaba
{
    public class BigEndianBitConverter : IBitConverter
    {
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
        public bool ToBoolean(byte[] bytes)
        {
            return bytes[0] != 0 ? true : false;
        }
        public char ToChar(byte[] bytes)
        {
            char value = (char) 0;
            for (int i = sizeof(char) - 1; i >= 0; --i)
            {
                value |= (char) (bytes[sizeof(char) - i - 1] << (i * 8));
            }
            return value;
        }
        public double ToDouble(byte[] bytes)
        {
            unsafe
            {
                long l = ToInt64(bytes);
                return *(double*) &l;
            }
        }
        public float ToFloat(byte[] bytes)
        {
            unsafe
            {
                int i = ToInt32(bytes);
                return *(float*) &i;
            }
        }
        public short ToInt16(byte[] bytes)
        {
            short value = 0;
            for (int i = sizeof(short) - 1; i >= 0; --i)
            {
                value |= (short) (bytes[sizeof(short) - i - 1] << (i * 8));
            }
            return value;
        }
        public int ToInt32(byte[] bytes)
        {
            int value = 0;
            for (int i = sizeof(int) - 1; i >= 0; --i)
            {
                value |= (int) bytes[sizeof(int) - i - 1] << (i * 8);
            }
            return value;
        }
        public long ToInt64(byte[] bytes)
        {
            long value = 0;
            for (int i = sizeof(long) - 1; i >= 0; --i)
            {
                value |= ((long) bytes[sizeof(long) - i - 1]) << (i * 8);
            }
            return value;
        }
        public ushort ToUInt16(byte[] bytes)
        {
            ushort value = 0;
            for (int i = sizeof(ushort) - 1; i >= 0; --i)
            {
                value |= (ushort) (bytes[sizeof(ushort) - i - 1] << (i * 8));
            }
            return value;
        }
        public uint ToUInt32(byte[] bytes)
        {
            uint value = 0;
            for (int i = sizeof(uint) - 1; i >= 0; --i)
            {
                value |= (uint) bytes[sizeof(uint) - i - 1] << (i * 8);
            }
            return value;
        }
        public ulong ToUInt64(byte[] bytes)
        {
            ulong value = 0;
            for (int i = sizeof(ulong) - 1; i >= 0; --i)
            {
                value |= ((ulong) bytes[sizeof(ulong) - i - 1]) << (i * 8);
            }
            return value;
        }
    }
}
