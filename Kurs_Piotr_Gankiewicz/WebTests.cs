using FluentAssertions;
using Kurs.Models;
using Moq;
using NUnit.Framework;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Tests
{
    public class WebTests
    {
        public HttpClient HttpClient;
     
                                              
        [SetUp]
        public void Setup()
        {
            HttpClient = new HttpClient();

        }

        [Test]
        public async Task test_http_response_should_return_204()
        {
            //Act
            var response = await HttpClient.GetAsync("http://httpstat.us/204"); //Strona do testowania otrzymywanych błędów

            //Assert
            response.Should().NotBeNull();
            response.StatusCode.Equals(HttpStatusCode.NoContent);
        }
    }
}