using Microsoft.AspNetCore.Mvc;

[Route("api/claims/claim")]
 public class ClaimsController : Controller
 {
      // POST api/claims/claim
    [HttpPost]
    public IActionResult Post([FromBody]string value)
    {
        return Created("", value);
    }

    // GET api/claims/claim/5
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        return Ok("The id is: " + id);
    }

     // PUT api/claims/claim/id
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody]string value)
    {
        return NoContent();
    }
    
    // DELETE api/claims/claim/id
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        return Delete(id);
    }
 }