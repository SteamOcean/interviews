import { QueryClient, QueryClientProvider } from '@tanstack/react-query'
import { BookList } from './containers/BookList'
const queryClient = new QueryClient()

function App() {

  return (
    <QueryClientProvider client={queryClient}>
      <BookList />
    </QueryClientProvider>
  )
}

export default App
