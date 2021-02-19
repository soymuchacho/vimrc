/*
 * resourced
 *
 * This is a sample Petstore server.  You can find out more about Swagger at [http://swagger.io](http://swagger.io) or on [irc.freenode.net, #swagger](http://swagger.io/irc/). 
 *
 * OpenAPI spec version: v1.0.0.1
 * Contact: vespergu@tvunetworks.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;

using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class ExportApiController : ControllerBase
    { 
        /// <summary>
        /// export media for user
        /// </summary>
        /// <param name="body">Export object</param>
        /// <response code="200">OK</response>
        /// <response code="405">Invalid input</response>
        [HttpPost]
        [Route("/TVU_For_Test/resourced_test/v1.0.0.1/export")]
        [ValidateModelState]
        [SwaggerOperation("Export")]
        [SwaggerResponse(statusCode: 200, type: typeof(ApiResponse), description: "OK")]
        public virtual IActionResult Export([FromBody]Exportparam body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ApiResponse));

            //TODO: Uncomment the next line to return response 405 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(405);
            string exampleJson = null;
            exampleJson = "{\n  \"ErrorCode\" : 200,\n  \"ErrorMessage\" : \"ok\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ApiResponse>(exampleJson)
                        : default(ApiResponse);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
