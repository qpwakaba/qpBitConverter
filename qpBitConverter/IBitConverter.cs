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
