using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;

namespace QuanLyBanBida
{
    public partial class ChatBot : Form
    {
        private readonly OpenAIClient _openaiClient;

        public ChatBot()
        {
            InitializeComponent();
            _openaiClient = new OpenAIClient("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"); // Thay YOUR_API_KEY bằng API key của bạn cho OpenAI
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            // Lấy tin nhắn từ TextBox
            string message = txtMessage.Text;

            // Thêm tin nhắn vào ListBox
            if (!string.IsNullOrEmpty(message))
            {
                listBoxMessages.Items.Add($"You: {message}");

                try
                {
                    // Gửi tin nhắn đến chatbot của OpenAI và nhận phản hồi
                    string responseOpenAI = await _openaiClient.Complete(message);
                    listBoxMessages.Items.Add($"OpenAI Bot: {responseOpenAI}");
                }
                catch (Exception ex)
                {
                    listBoxMessages.Items.Add($"Error: {ex.Message}");
                }

                txtMessage.Clear();
            }
        }
    }

    public class OpenAIClient
    {
        private readonly string _apiKey;
        private readonly HttpClient _client;

        public OpenAIClient(string apiKey)
        {
            _apiKey = apiKey;
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://api.openai.com/v1");
            _client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _apiKey);
        }

        public async Task<string> Complete(string prompt)
        {
            var requestBody = "{\"prompt\": \"" + prompt + "\"}";
            var content = new StringContent(requestBody, System.Text.Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("/completions", content);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new Exception($"Chat GPT hiện không thể phản hồi bạn: {response.ReasonPhrase}");
            }
        }
    }
}
