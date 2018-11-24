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
        int ToInt32(byte[] b);
        short ToInt16(byte[] b);
        ulong ToUInt64(byte[] b);
        uint ToUInt32(byte[] b);
        ushort ToUInt16(byte[] b);
        double ToDouble(byte[] b);
        float ToFloat(byte[] b);
        char ToChar(byte[] b);
        bool ToBoolean(byte[] b);
    }
}
