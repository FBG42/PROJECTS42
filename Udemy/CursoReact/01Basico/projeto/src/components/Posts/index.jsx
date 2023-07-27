import { PostCard } from "../PostCard";

export const Posts = ({posts}) => (
    <div className="posts">
        {posts.map((post, index) => (
        <PostCard
            key={index}
            title={post.title}
            body={post.body}
            cover={post.cover}
        // post={post}
        />
        ))}
    </div>
)