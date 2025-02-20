import { useBooks } from "../queries/useBooks";

export const BookList = () => {
  const { data, isLoading, error } = useBooks();
return (data && data.map((b:{id:string,title:string,author:string}) => <p key={b.id}>{b.title} by {b.author}</p>))
};
