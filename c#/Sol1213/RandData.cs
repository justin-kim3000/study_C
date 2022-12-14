using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol1213
{
    internal class RandData
    {
        private string[] name = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
        private string[] tel = {"010-1234-5678", "010-4321-5678", "010-3478-1278",
                     "010-4523-1978", "010-7890-2134"};
        private string[] address = {"대구시 동구 신암4동", "서울시 동구 신암4동",
             "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동"};
        private string[] model = { "SM6", "쏘나타", "싼타페", "K7", "그랜져" };
        private string[] color = { "블랙", "은색", "흰색", "회색", "빨강" };
        private string[] year = { "2016", "2017", "2016", "2017", "2016" };
        private string[] company = { "삼성르노", "현대", "현대", "기아", "현대" };
        
        Random random = new Random();

        public string getName() { return name[random.Next(name.Length)]; }
        public string getTel() { return tel[random.Next(tel.Length)]; }
        public string getAddr() { return address[random.Next(address.Length)]; }
        public string getModel() { return model[random.Next(model.Length)]; }
        public string getColor() { return color[random.Next(color.Length)]; }
        public string getYear() { return year[random.Next(year.Length)]; }
        public string getCompany() { return name[random.Next(company.Length)]; }

    }
}
