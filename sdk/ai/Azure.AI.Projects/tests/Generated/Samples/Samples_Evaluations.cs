// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.AI.Projects.Samples
{
    public partial class Samples_Evaluations
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Evaluation_GetEvaluation_EvaluationsGetMaximumSet()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Evaluations client = new AIProjectClient(endpoint, credential).GetEvaluationsClient(apiVersion: "2025-05-15-preview");

            Response response = client.GetEvaluation("so", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("data").GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("evaluators").GetProperty("<key>").GetProperty("id").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Evaluation_GetEvaluation_EvaluationsGetMaximumSet_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Evaluations client = new AIProjectClient(endpoint, credential).GetEvaluationsClient(apiVersion: "2025-05-15-preview");

            Response response = await client.GetEvaluationAsync("so", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("data").GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("evaluators").GetProperty("<key>").GetProperty("id").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Evaluation_GetEvaluation_EvaluationsGetMaximumSet_Convenience()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Evaluations client = new AIProjectClient(endpoint, credential).GetEvaluationsClient(apiVersion: "2025-05-15-preview");

            Response<Evaluation> response = client.GetEvaluation("so");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Evaluation_GetEvaluation_EvaluationsGetMaximumSet_Convenience_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Evaluations client = new AIProjectClient(endpoint, credential).GetEvaluationsClient(apiVersion: "2025-05-15-preview");

            Response<Evaluation> response = await client.GetEvaluationAsync("so");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Evaluations_Create_EvaluationsCreateMaximumSet()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Evaluations client = new AIProjectClient(endpoint, credential).GetEvaluationsClient(apiVersion: "2025-05-15-preview");

            using RequestContent content = RequestContent.Create(new
            {
                data = new
                {
                    type = "InputData",
                },
                displayName = "ymjxkodggqrhjnmusta",
                description = "cuviaxytqckkybxwc",
                tags = new
                {
                    key30 = "nqrdpedyhkjzgrbtqhxbmkdmlpdf",
                },
                properties = new
                {
                    key9192 = "e",
                },
                evaluators = new
                {
                    key2735 = new
                    {
                        id = "gujwtvhptykq",
                        initParams = new object(),
                        dataMapping = new
                        {
                            key7400 = "ijkjfvoswni",
                        },
                    },
                },
            });
            Response response = client.Create(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("data").GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("evaluators").GetProperty("<key>").GetProperty("id").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Evaluations_Create_EvaluationsCreateMaximumSet_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Evaluations client = new AIProjectClient(endpoint, credential).GetEvaluationsClient(apiVersion: "2025-05-15-preview");

            using RequestContent content = RequestContent.Create(new
            {
                data = new
                {
                    type = "InputData",
                },
                displayName = "ymjxkodggqrhjnmusta",
                description = "cuviaxytqckkybxwc",
                tags = new
                {
                    key30 = "nqrdpedyhkjzgrbtqhxbmkdmlpdf",
                },
                properties = new
                {
                    key9192 = "e",
                },
                evaluators = new
                {
                    key2735 = new
                    {
                        id = "gujwtvhptykq",
                        initParams = new object(),
                        dataMapping = new
                        {
                            key7400 = "ijkjfvoswni",
                        },
                    },
                },
            });
            Response response = await client.CreateAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("data").GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("evaluators").GetProperty("<key>").GetProperty("id").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Evaluations_Create_EvaluationsCreateMaximumSet_Convenience()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Evaluations client = new AIProjectClient(endpoint, credential).GetEvaluationsClient(apiVersion: "2025-05-15-preview");

            Evaluation evaluation = new Evaluation(default, new Dictionary<string, EvaluatorConfiguration>
            {
                ["key2735"] = new EvaluatorConfiguration("gujwtvhptykq")
                {
                    InitParams = { },
                    DataMapping =
{
["key7400"] = "ijkjfvoswni"
},
                }
            })
            {
                DisplayName = "ymjxkodggqrhjnmusta",
                Description = "cuviaxytqckkybxwc",
                Tags =
{
["key30"] = "nqrdpedyhkjzgrbtqhxbmkdmlpdf"
},
                Properties =
{
["key9192"] = "e"
},
            };
            Response<Evaluation> response = client.Create(evaluation);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Evaluations_Create_EvaluationsCreateMaximumSet_Convenience_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Evaluations client = new AIProjectClient(endpoint, credential).GetEvaluationsClient(apiVersion: "2025-05-15-preview");

            Evaluation evaluation = new Evaluation(default, new Dictionary<string, EvaluatorConfiguration>
            {
                ["key2735"] = new EvaluatorConfiguration("gujwtvhptykq")
                {
                    InitParams = { },
                    DataMapping =
{
["key7400"] = "ijkjfvoswni"
},
                }
            })
            {
                DisplayName = "ymjxkodggqrhjnmusta",
                Description = "cuviaxytqckkybxwc",
                Tags =
{
["key30"] = "nqrdpedyhkjzgrbtqhxbmkdmlpdf"
},
                Properties =
{
["key9192"] = "e"
},
            };
            Response<Evaluation> response = await client.CreateAsync(evaluation);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Evaluations_Create_EvaluationsCreateMinimumSet()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Evaluations client = new AIProjectClient(endpoint, credential).GetEvaluationsClient(apiVersion: "2025-05-15-preview");

            using RequestContent content = RequestContent.Create(new
            {
                data = new
                {
                    type = "InputData",
                },
                evaluators = new object(),
            });
            Response response = client.Create(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("data").GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("evaluators").GetProperty("<key>").GetProperty("id").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Evaluations_Create_EvaluationsCreateMinimumSet_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Evaluations client = new AIProjectClient(endpoint, credential).GetEvaluationsClient(apiVersion: "2025-05-15-preview");

            using RequestContent content = RequestContent.Create(new
            {
                data = new
                {
                    type = "InputData",
                },
                evaluators = new object(),
            });
            Response response = await client.CreateAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("data").GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("evaluators").GetProperty("<key>").GetProperty("id").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Evaluations_Create_EvaluationsCreateMinimumSet_Convenience()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Evaluations client = new AIProjectClient(endpoint, credential).GetEvaluationsClient(apiVersion: "2025-05-15-preview");

            Evaluation evaluation = new Evaluation(default, new Dictionary<string, EvaluatorConfiguration>());
            Response<Evaluation> response = client.Create(evaluation);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Evaluations_Create_EvaluationsCreateMinimumSet_Convenience_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Evaluations client = new AIProjectClient(endpoint, credential).GetEvaluationsClient(apiVersion: "2025-05-15-preview");

            Evaluation evaluation = new Evaluation(default, new Dictionary<string, EvaluatorConfiguration>());
            Response<Evaluation> response = await client.CreateAsync(evaluation);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Evaluations_CreateAgentEvaluation_EvaluationsCreateAgentEvaluationMaximumSet()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Evaluations client = new AIProjectClient(endpoint, credential).GetEvaluationsClient(apiVersion: "2025-05-15-preview");

            using RequestContent content = RequestContent.Create(new
            {
                runId = "ecfcffqsrdhpecocrufffiqz",
                threadId = "cxjjsyhkeezgnaqqyerrdrbbth",
                evaluators = new
                {
                    key2653 = new
                    {
                        id = "gujwtvhptykq",
                        initParams = new object(),
                        dataMapping = new
                        {
                            key7400 = "ijkjfvoswni",
                        },
                    },
                },
                samplingConfiguration = new
                {
                    name = "tj",
                    samplingPercent = 7F,
                    maxRequestRate = 8F,
                },
                redactionConfiguration = new
                {
                    redactScoreProperties = true,
                },
                appInsightsConnectionString = "dvcnrcwar",
            });
            Response response = client.CreateAgentEvaluation(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Evaluations_CreateAgentEvaluation_EvaluationsCreateAgentEvaluationMaximumSet_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Evaluations client = new AIProjectClient(endpoint, credential).GetEvaluationsClient(apiVersion: "2025-05-15-preview");

            using RequestContent content = RequestContent.Create(new
            {
                runId = "ecfcffqsrdhpecocrufffiqz",
                threadId = "cxjjsyhkeezgnaqqyerrdrbbth",
                evaluators = new
                {
                    key2653 = new
                    {
                        id = "gujwtvhptykq",
                        initParams = new object(),
                        dataMapping = new
                        {
                            key7400 = "ijkjfvoswni",
                        },
                    },
                },
                samplingConfiguration = new
                {
                    name = "tj",
                    samplingPercent = 7F,
                    maxRequestRate = 8F,
                },
                redactionConfiguration = new
                {
                    redactScoreProperties = true,
                },
                appInsightsConnectionString = "dvcnrcwar",
            });
            Response response = await client.CreateAgentEvaluationAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Evaluations_CreateAgentEvaluation_EvaluationsCreateAgentEvaluationMaximumSet_Convenience()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Evaluations client = new AIProjectClient(endpoint, credential).GetEvaluationsClient(apiVersion: "2025-05-15-preview");

            AgentEvaluationRequest evaluation = new AgentEvaluationRequest("ecfcffqsrdhpecocrufffiqz", new Dictionary<string, EvaluatorConfiguration>
            {
                ["key2653"] = new EvaluatorConfiguration("gujwtvhptykq")
                {
                    InitParams = { },
                    DataMapping =
{
["key7400"] = "ijkjfvoswni"
},
                }
            }, "dvcnrcwar")
            {
                ThreadId = "cxjjsyhkeezgnaqqyerrdrbbth",
                SamplingConfiguration = new AgentEvaluationSamplingConfiguration("tj", 7F, 8F),
                RedactionConfiguration = new AgentEvaluationRedactionConfiguration
                {
                    RedactScoreProperties = true,
                },
            };
            Response<AgentEvaluation> response = client.CreateAgentEvaluation(evaluation);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Evaluations_CreateAgentEvaluation_EvaluationsCreateAgentEvaluationMaximumSet_Convenience_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Evaluations client = new AIProjectClient(endpoint, credential).GetEvaluationsClient(apiVersion: "2025-05-15-preview");

            AgentEvaluationRequest evaluation = new AgentEvaluationRequest("ecfcffqsrdhpecocrufffiqz", new Dictionary<string, EvaluatorConfiguration>
            {
                ["key2653"] = new EvaluatorConfiguration("gujwtvhptykq")
                {
                    InitParams = { },
                    DataMapping =
{
["key7400"] = "ijkjfvoswni"
},
                }
            }, "dvcnrcwar")
            {
                ThreadId = "cxjjsyhkeezgnaqqyerrdrbbth",
                SamplingConfiguration = new AgentEvaluationSamplingConfiguration("tj", 7F, 8F),
                RedactionConfiguration = new AgentEvaluationRedactionConfiguration
                {
                    RedactScoreProperties = true,
                },
            };
            Response<AgentEvaluation> response = await client.CreateAgentEvaluationAsync(evaluation);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Evaluations_CreateAgentEvaluation_EvaluationsCreateAgentEvaluationMinimumSet()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Evaluations client = new AIProjectClient(endpoint, credential).GetEvaluationsClient(apiVersion: "2025-05-15-preview");

            using RequestContent content = RequestContent.Create(new
            {
                runId = "ecfcffqsrdhpecocrufffiqz",
                evaluators = new object(),
                appInsightsConnectionString = "dvcnrcwar",
            });
            Response response = client.CreateAgentEvaluation(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Evaluations_CreateAgentEvaluation_EvaluationsCreateAgentEvaluationMinimumSet_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Evaluations client = new AIProjectClient(endpoint, credential).GetEvaluationsClient(apiVersion: "2025-05-15-preview");

            using RequestContent content = RequestContent.Create(new
            {
                runId = "ecfcffqsrdhpecocrufffiqz",
                evaluators = new object(),
                appInsightsConnectionString = "dvcnrcwar",
            });
            Response response = await client.CreateAgentEvaluationAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Evaluations_CreateAgentEvaluation_EvaluationsCreateAgentEvaluationMinimumSet_Convenience()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Evaluations client = new AIProjectClient(endpoint, credential).GetEvaluationsClient(apiVersion: "2025-05-15-preview");

            AgentEvaluationRequest evaluation = new AgentEvaluationRequest("ecfcffqsrdhpecocrufffiqz", new Dictionary<string, EvaluatorConfiguration>(), "dvcnrcwar");
            Response<AgentEvaluation> response = client.CreateAgentEvaluation(evaluation);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Evaluations_CreateAgentEvaluation_EvaluationsCreateAgentEvaluationMinimumSet_Convenience_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Evaluations client = new AIProjectClient(endpoint, credential).GetEvaluationsClient(apiVersion: "2025-05-15-preview");

            AgentEvaluationRequest evaluation = new AgentEvaluationRequest("ecfcffqsrdhpecocrufffiqz", new Dictionary<string, EvaluatorConfiguration>(), "dvcnrcwar");
            Response<AgentEvaluation> response = await client.CreateAgentEvaluationAsync(evaluation);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Evaluation_GetEvaluations_EvaluationsListMaximumSet()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Evaluations client = new AIProjectClient(endpoint, credential).GetEvaluationsClient(apiVersion: "2025-05-15-preview");

            foreach (BinaryData item in client.GetEvaluations(null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("data").GetProperty("type").ToString());
                Console.WriteLine(result.GetProperty("evaluators").GetProperty("<key>").GetProperty("id").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Evaluation_GetEvaluations_EvaluationsListMaximumSet_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Evaluations client = new AIProjectClient(endpoint, credential).GetEvaluationsClient(apiVersion: "2025-05-15-preview");

            await foreach (BinaryData item in client.GetEvaluationsAsync(null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("data").GetProperty("type").ToString());
                Console.WriteLine(result.GetProperty("evaluators").GetProperty("<key>").GetProperty("id").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Evaluation_GetEvaluations_EvaluationsListMaximumSet_Convenience()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Evaluations client = new AIProjectClient(endpoint, credential).GetEvaluationsClient(apiVersion: "2025-05-15-preview");

            foreach (Evaluation item in client.GetEvaluations())
            {
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Evaluation_GetEvaluations_EvaluationsListMaximumSet_Convenience_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Evaluations client = new AIProjectClient(endpoint, credential).GetEvaluationsClient(apiVersion: "2025-05-15-preview");

            await foreach (Evaluation item in client.GetEvaluationsAsync())
            {
            }
        }
    }
}
