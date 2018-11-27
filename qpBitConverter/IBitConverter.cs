using System;

namespace qpwakaba
{
    public interface IBitConverter
    {
        byte[] GetBytes(long l);
        byte[] GetBytes(int i);
        byte[] GetBytes(short s);
        byte[] GetBytes(ulong l);
        byte[] GetBytes(uint i);
        byte[] GetBytes(ushort s);
        byte[] GetBytes(double d);
        byte[] GetBytes(float f);
        byte[] GetBytes(char c);
        byte[] GetBytes(bool b);
        void WriteBytes(long l, byte[] to, int offset);
        void WriteBytes(int i, byte[] to, int offset);
        void WriteBytes(short s, byte[] to, int offset);
        void WriteBytes(ulong l, byte[] to, int offset);
        void WriteBytes(uint i, byte[] to, int offset);
        void WriteBytes(ushort s, byte[] to, int offset);
        void WriteBytes(double d, byte[] to, int offset);
        void WriteBytes(float f, byte[] to, int offset);
        void WriteBytes(char c, byte[] to, int offset);
        void WriteBytes(bool b, byte[] to, int offset);
#if SPAN_USABLE
        void WriteBytes(long l, Span<byte> to);
        void WriteBytes(int i, Span<byte> to);
        void WriteBytes(short s, Span<byte> to);
        void WriteBytes(ulong l, Span<byte> to);
        void WriteBytes(uint i, Span<byte> to);
        void WriteBytes(ushort s, Span<byte> to);
        void WriteBytes(double d, Span<byte> to);
        void WriteBytes(float f, Span<byte> to);
        void WriteBytes(char c, Span<byte> to);
        void WriteBytes(bool b, Span<byte> to);

        long ToInt64(Span<byte> b);
        int ToInt32(Span<byte> b);
        short ToInt16(Span<byte> b);
        ulong ToUInt64(Span<byte> b);
        uint ToUInt32(Span<byte> b);
        ushort ToUInt16(Span<byte> b);
        double ToDouble(Span<byte> b);
        float ToFloat(Span<byte> b);
        char ToChar(Span<byte> b);
        bool ToBoolean(Span<byte> b);
#endif
        long ToInt64(byte[] b);
        long ToInt64(byte[] b, int offset);
        int ToInt32(byte[] b);
        int ToInt32(byte[] b, int offset);
        short ToInt16(byte[] b);
        short ToInt16(byte[] b, int offset);
        ulong ToUInt64(byte[] b);
        ulong ToUInt64(byte[] b, int offset);
        uint ToUInt32(byte[] b);
        uint ToUInt32(byte[] b, int offset);
        ushort ToUInt16(byte[] b);
        ushort ToUInt16(byte[] b, int offset);
        double ToDouble(byte[] b);
        double ToDouble(byte[] b, int offset);
        float ToFloat(byte[] b);
        float ToFloat(byte[] b, int offset);
        char ToChar(byte[] b);
        char ToChar(byte[] b, int offset);
        bool ToBoolean(byte[] b);
        bool ToBoolean(byte[] b, int offset);
    }
}
