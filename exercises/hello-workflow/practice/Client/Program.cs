﻿// This file is designated to run the Workflow
using Temporalio.Client;
using TemporalioHelloWorld.Practice.Workflow;

// Create a client to localhost on "default" namespace
var client = await TemporalClient.ConnectAsync(new("localhost:7233"));

// Run workflow
var result = await client.ExecuteWorkflowAsync(
    (SayHelloWorkflow wf) => wf.RunAsync("World"),
    new(id: "my-workflow-id", taskQueue: "greeting-tasks"));

Console.WriteLine($"Workflow result: {result}");

// TODO PART B: modify the statement above to specify the Task Queue name (i.e - change the Task Queue to greeting-tasks)