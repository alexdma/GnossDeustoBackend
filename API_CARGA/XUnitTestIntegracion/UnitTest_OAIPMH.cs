using API_CARGA.Models;
using API_CARGA.Models.Services;
using API_CARGA.Models.Transport;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestIntegracion
{
    public class UnitTest_OAIPMH
    {
        [Fact]
        public void TestListIdentifier()
        {
            ConfigUrlService urlService = new ConfigUrlService();
            urlService.Url = "http://herc-as-front-desa.atica.um.es/carga/";
            OaiPublishRDFService oaiPublish = new OaiPublishRDFService(urlService, null);
            var lista = oaiPublish.CallListIdentifier(new Guid("5efac0ad-ec4e-467d-bbf5-ce3f64edb46a"));
            Assert.True(lista.Count > 0);
        }

        [Fact]
        public void TestGetRecord()
        {
            ConfigUrlService urlService = new ConfigUrlService();
            urlService.Url = "http://herc-as-front-desa.atica.um.es/carga/";
            OaiPublishRDFService oaiPublish = new OaiPublishRDFService(urlService, null);
            string rdf = oaiPublish.CallGetRecord(new Guid("5efac0ad-ec4e-467d-bbf5-ce3f64edb46a"), "1");
            Assert.True(!string.IsNullOrEmpty(rdf));
        }
    }
}
