
using FisherInsuranceApi.Data;
using FisherInsuranceApi.Models;
using Microsoft.AspNetCore.Mvc;

[Route("api/claims/")]
 public class ClaimsController : Controller
 {
     private IMemoryStore db;
    public ClaimsController(IMemoryStore repo)
    {
        db = repo;
    } 

    [HttpGet]
    public IActionResult GetClaims()
    {
        return Ok(db.RetrieveAllClaims);
    } 

      // POST api/claims/claim
    [HttpPost]
    public IActionResult Post([FromBody] Claim claim)
    {
        return Ok(db.CreateClaim(claim));
    }

    // GET api/claims/claim/5
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        return Ok(db.RetrieveClaim(id));
    }

     // PUT api/claims/claim/id
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Claim claim)
    {
        return Ok(db.UpdateClaim(claim));
    }
    
    // DELETE api/claims/claim/id
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        db.DeleteClaim(id);
        return Ok();
    }
 }