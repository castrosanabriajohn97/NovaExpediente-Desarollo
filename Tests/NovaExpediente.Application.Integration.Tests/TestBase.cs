// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaExpediente.Application.Integration.Tests
{
    using static Testing;

    public class TestBase
    {
        [SetUp]
        public async Task SetUp()
        {
            await ResetState();
        }
    }
}
