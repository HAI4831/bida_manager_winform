using RestSharp;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace QuanLyBanBida
{
    public partial class ChatAi : Form
    {
        private readonly string _apiKey;
        private readonly RestClient _client;

        public ChatAi()
        {
            // Khởi tạo giá trị cho _apiKey
            _apiKey = "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"; // Thay YOUR_API_KEY bằng API key của bạn
                                                                             // Khởi tạo RestClient
            _client = new RestClient("https://api.openai.com/v1"); // Thay đổi URL nếu cần thiết
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Mở trình duyệt web mặc định với URL được cung cấp
            OpenWebPage("https://gg.com");
        }

        private void OpenWebPage(string url)
        {
            try
            {
                // Sử dụng lớp Process để mở trình duyệt web mặc định
                Process.Start(url);
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi xảy ra khi mở liên kết
                MessageBox.Show("Không thể mở liên kết: " + ex.Message);
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Hiển thị thông báo về việc thêm API chatGPT để làm chatbot đang tích hợp
            MessageBox.Show("Thêm API chatGPT để làm chatbot đang tích hợp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Mở trang web
            OpenWebPage("https://hoangboy.github.io/cv");
        }
    }
}
