using System.Collections.Generic;

namespace B2BEcommerce.Models.Report
{
    public class DashboardListModel
    {
        public List<DashboardModel> TYPE1 { get; set; } //Aylık Ciro Gösterimi 

        public List<DashboardModel> TYPE2 { get; set; } //Finansal Durum

        public List<DashboardModel> TYPE3 { get; set; } //Günlük İşlemler

        public List<DashboardModel> TYPE4 { get; set; } //İlk 10 Müşteri Ciro

        public List<DashboardModel> TYPE5 { get; set; } //İlk 10 Marka Ciro

        public List<DashboardModel> TYPE6 { get; set; } //İlk 10 Malzeme Ciro

        public List<DashboardModel> TYPE7 { get; set; } //İlk 10 Şehir Ciro

        public List<DashboardModel> TYPE8 { get; set; } //Cari Hesap Bakiyeleri

        public List<DashboardModel> TYPE9 { get; set; } //Cari Bazlı Ciro Bekleyen Sipariş Bekleyen Teklif Onaylanan Sipariş.
    }
}
