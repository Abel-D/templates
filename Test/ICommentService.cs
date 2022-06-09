
namespace {
  
public interface ICommentService
{

 Task<Comment> AddComment();
 IEnumerable<Comment> GetComments();

}
}
