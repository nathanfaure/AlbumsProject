$(document).ready(function () {
    $(".add-comment-container").hide();
});

function showCommentContainer(sender) {
    var postId = $(sender.currentTarget).attr("postId");
    var showHideContainer = $(".add-comment-container[postid='" + postId + "']");
    showHideContainer.toggle(500);
}



function addCommentHandler(sender) {
    var postId = $(sender.target.parentNode.parentNode).attr("postId");
    var textarea = $(sender.target.parentNode).find(".comment-text");
    if (textarea.val().trim() === "" || textarea.val() == undefined) {
        alert("Type a comment.");
    }
    else {
        //"ControllerName/Method"
        $.post("/Comment/AddComment",
            $.param({ postId: postId, text: textarea.val() }),
            function () {
                $.get("/Post/Index",
                    function(getResult) {
                        $(".rendered-content").html(getResult);
                        $(".btn-add-comment").click(addCommentHandler);
                        $(".show-comment-container").click(showCommentContainer);
                        $(".add-comment-container").hide();
                    });
            }
        );
    }
}
$(".show-comment-container").click(showCommentContainer);
$(".btn-add-comment").click(addCommentHandler);